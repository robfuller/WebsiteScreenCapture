using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using ScreenCaptureMagic.Util;

namespace ScreenCaptureMagic
{
    class SpiderAndCapture
    {
        private ScreenCaptureMagic.Util.WebBrowser _wb;
        private string _starting_url;
        private Models.SiteInfo _site_info = new Models.SiteInfo();
        private Util.AppSettings _settings = new AppSettings();
        private int _currentDepth = 0;

        public Models.SiteInfo Site_info
        {
            get { return _site_info; }
            set { _site_info = value; }
        }
       
        
        
        
        public SpiderAndCapture(string startingUrl)
        {
            ExecuteProgram(startingUrl, new Util.AppSettings());
           
        }

        public SpiderAndCapture(string startingUrl, Util.AppSettings settings)
        {
            ExecuteProgram(startingUrl, settings);
        }

        private void ExecuteProgram(string startingUrl, Util.AppSettings settings) 
        {
            _settings = settings;
            _starting_url = startingUrl;
            
            if (_settings.Base_url == null) _settings.Base_url = startingUrl;
            _site_info.Starting_URL = _starting_url;
            processUrl(_starting_url);

        }
        
        private void processUrl(string url)
        {
            try {
                processUrl(new Uri(url));
            }
            catch {
            }
        }
        private void processUrl(Uri uri)
        {
            try
            {
                
                if (_settings.IgnoreQueryStrings && uri.Query.Length > 0) 
                {
                    uri = new Uri(uri.ToString().Replace(uri.Query, ""));
                }
                _site_info.URIs.Add(uri);
                setupBrowser(uri);

                Models.PageAssets page = processPage(uri, _wb.Document.Links, _wb.Document.Images);
                page.BitmapFilename = takeScreenshot();
                _site_info.Pages.Add(page);
                _wb.Dispose();

                foreach (string link in page.All_links)
                {
                    string localurl = link;
                    if(link.Contains("#")) localurl = link.Remove(link.IndexOf("#"));
                    localurl = Uri.EscapeUriString(localurl).Trim();

                    Uri localUri;
                    if (Uri.TryCreate(uri, localurl, out localUri))
                    {
                        
                     //   Uri link_clean = WebHelpers.scrubUrl(localUri, _settings.AllowQueryStringToDifferentiateUrls);

                        if (ShouldFollowURL(localUri, uri) &&
                                (_settings.MaxDepthToSpider == 0 || _currentDepth <= _settings.MaxDepthToSpider))
                        {
                            processUrl(localUri);
                            _currentDepth++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Exception uhoh = new Exception("Exception while processing " + uri.ToString() + "\n " + ex.Message, ex);
                throw uhoh;
            }

        }
        
        private Models.PageAssets processPage(Uri uri, HtmlElementCollection links, HtmlElementCollection images)
        {
            

            Models.PageAssets page = new Models.PageAssets(uri.ToString());
            page.Has_flash = WebHelpers.checkForFlash(_wb);
            if (page.Has_flash)
            {
                AppHelpers.statusMessage("Think I found flash on this page.  Delaying to allow it to load.");
                System.Threading.Thread.Sleep(_settings.FlashLoadAllowanceInMilliseconds); // seconds to try to let flash catch up
            }

            page.Meta = Util.WebHelpers.scrapeMeta(_wb);

            foreach (HtmlElement e in images)
            {
                page.All_images.Add(e.GetAttribute("src"));
            }
            foreach (HtmlElement e in links)
            {
                string u = e.GetAttribute("href");
                page.All_links.Add(u);
            }          

            return page;
        }

        private void setupBrowser(Uri uri)
        {
            AppHelpers.statusMessage("Navigating to " + uri.ToString());
            _wb = new ScreenCaptureMagic.Util.WebBrowser();
            _wb.ScrollBarsEnabled = false;
            _wb.ScriptErrorsSuppressed = true;
            _wb.AllowNavigation = true;
            _wb.Navigate(uri);
            DateTime startTime = DateTime.Now;
            while (_wb.ReadyState != WebBrowserReadyState.Complete) { 
                Application.DoEvents(); 
            
                if (DateTime.Now.Subtract(startTime).Seconds > _settings.PageTimeoutInSeconds)  break; //page time out
            }
            _wb.Height = _wb.Document.Body.ScrollRectangle.Height;
            _wb.Width = _settings.DefaultBrowserWidth;

        }

        private string takeScreenshot()
        {
            try
            {
                if (_wb.Height == 0) _wb.Height = _settings.MinBrowserHeight;
                if (!System.IO.Directory.Exists("screen_caps")) System.IO.Directory.CreateDirectory("screen_caps");

                string filename = "screen_caps\\" +  WebHelpers.determineFilename(_wb.Url.ToString());

                Bitmap bitmap = new Bitmap(_wb.Width, _wb.Height);
                _wb.DrawToBitmap(bitmap, new Rectangle(0, 0, _wb.Width, _wb.Height));
                
                ImageHelpers.saveBitmapToJpg(bitmap, filename);
                return filename;
            }
            catch (Exception ex)
            {
                AppHelpers.statusMessage("Error taking screen shot for: " + _wb.Url);
                throw ex;
            }
        }

        private bool ShouldFollowURL(Uri followUri, Uri originatingPage)
        {
            try
            {
                string url = followUri.ToString();
                if (_settings.IgnoreQueryStrings && followUri.Query.Length > 0)            
                    url = url.Replace(followUri.Query, "");
                
               
                if(_site_info.URIs.Contains(new Uri(url))) return false; //by far the most common case - having followed the url before                
               
                if (!(followUri.Scheme == Uri.UriSchemeHttp || followUri.Scheme == Uri.UriSchemeHttps)) return false;
                if (followUri.Host != _site_info.Domain) return false;
                if (WebHelpers.hasExtension(followUri) && 
                        !WebHelpers.isExtentionValid(_settings.ExcludeFileExtentions, followUri)) return false;
                if (_settings.ConstrainToDeeperUrls) return WebHelpers.IsDeeperUrl(_site_info.Starting_Uri , followUri);

                return true;
            }
            catch (System.UriFormatException ex)
            {

                Models.BadUrl badurl = new Models.BadUrl(followUri.ToString(), ex.Message, originatingPage.ToString());
                _site_info.Bad_URLs.Add(badurl);
                return false;
                //swallow error, skip url and proceed
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
