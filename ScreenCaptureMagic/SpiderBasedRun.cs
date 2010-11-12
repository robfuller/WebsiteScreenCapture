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
    class SpiderBasedRun
    {
        private string _starting_url;
        private Models.SiteInfo _site_info = new Models.SiteInfo();
        private Util.AppSettings _settings = new AppSettings();
        private int _currentDepth = 0;
        private Util.WebHelpers _wbh;

        public Models.SiteInfo Site_info
        {
            get { return _site_info; }
            set { _site_info = value; }
        }
          
        public SpiderBasedRun(string startingUrl)
        {
            ExecuteProgram(startingUrl, new Util.AppSettings());
           
        }

        public SpiderBasedRun(string startingUrl, Util.AppSettings settings)
        {
            ExecuteProgram(startingUrl, settings);
        }

        private void ExecuteProgram(string startingUrl, Util.AppSettings settings) 
        {
            _settings = settings;
            _wbh = new Util.WebHelpers(settings);
            _starting_url = startingUrl;
            
            if (_settings.Base_url == null) _settings.Base_url = startingUrl;
            _site_info.Starting_URL = _starting_url;
            processUrl(_starting_url);
            _wbh.Dispose();
                
        }
        
        private void processUrl(string url)
        {
            try {
                processUrl(new Uri(url));
            }
            catch {
                throw;
            }
        }
        private void processUrl(Uri uri)
        {
            Models.PageAssets page;

            try
            {
             
                _site_info.URIs.Add(uri);

                
                page = _wbh.processPage(uri);
          
                if (_settings.TakeScreenShots)
                {
                    page.BitmapFilename = _wbh.takeScreenshot();
                }

                _site_info.Pages.Add(page);
                // this next block should be refactored out into its own method.
                
                foreach (string link in page.All_links)
                {
                    string localurl = link;
                    if (link.Contains("#")) localurl = link.Remove(link.IndexOf("#"));
                    localurl = Uri.EscapeUriString(localurl).Trim();

                    Uri localUri;
                    if (Uri.TryCreate(uri, localurl, out localUri))
                    {
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
        
   

        private bool ShouldFollowURL(Uri followUri, Uri originatingPage)
        {
            try
            {
                
                if (_settings.IgnoreQueryStrings) 
                    followUri = StaticWebHelpers.IgnoreQueryString(followUri);
                
                if(_site_info.URIs.Contains(followUri)) 
                    return false; //by far the most common case - having followed the url before                
                                
                if (_settings.FollowJavascriptLinks && followUri.Scheme.StartsWith("javascript")) 
                    return true;
 
                if (!(followUri.Scheme == Uri.UriSchemeHttp || followUri.Scheme == Uri.UriSchemeHttps)) 
                    return false;

                if (followUri.Host != _site_info.Domain) 
                    return false;

                if (StaticWebHelpers.hasExtension(followUri) && 
                        !StaticWebHelpers.isExtentionValid(_settings.ExcludeFileExtentions, followUri)) 
                    return false;

                if (_settings.ConstrainToDeeperUrls) 
                    return StaticWebHelpers.IsDeeperUrl(_site_info.Starting_Uri , followUri);

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
