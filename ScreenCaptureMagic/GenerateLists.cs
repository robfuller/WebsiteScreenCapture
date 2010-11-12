using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ScreenCaptureMagic
{
    class GenerateLists
    {
        public static void CreateReport(Models.SiteInfo siteinfo)
        {
            createReportList_Urls(siteinfo.URIs);
            createReportList_BadUrls(siteinfo.Bad_URLs);
            createReportList_images(siteinfo.Pages);
            createReportList_urlsByPage(siteinfo.Pages);
        }

        private static void createReportList_urlsByPage(List<Models.PageAssets> pages)
        {
            try
            {
                StreamWriter fs = new StreamWriter("links_by_page.csv", false);
                fs.WriteLine("Page, URL");
                foreach (Models.PageAssets page in pages)
                {
                    foreach (string url in page.All_links)
                    {
                        fs.WriteLine(page.Page_URL + ", " + url);
                    }
                }
                fs.Close();
                fs.Dispose();
            }
            catch
            {
                throw;
            }
            
        }

        private static void createReportList_Urls(List<Uri> urls)
        {
            try
            {
                StreamWriter fs = new StreamWriter("urls.csv", false);
                fs.WriteLine( "URL");
                foreach (Uri url in urls)
                {
                    fs.WriteLine(url.ToString());
                }
                fs.Close();
                fs.Dispose();
            }
            catch 
            { 
                throw; 
            }
        }

        private static void createReportList_BadUrls(List<Models.BadUrl> badurls)
        {
            try
            {
                StreamWriter fs = new StreamWriter("bad_urls.csv", false);
                fs.WriteLine("Found on URL, Bad Url, Message");
                foreach (Models.BadUrl  badurl in badurls)
                {
                    fs.WriteLine(badurl.FoundOnUrl + ", " + badurl.Url + ", " + badurl.Message);
                }
                fs.Close();
                fs.Dispose();
            }
            catch
            {
                throw;
            }
        }

        private static void createReportList_images(List<Models.PageAssets> pages)
        {
         try
            {
                StreamWriter fs = new StreamWriter("images_by_page.csv", false);
                fs.WriteLine("Found on URL, image URL");
                foreach (Models.PageAssets page in pages)
                {
                    foreach (string img in page.All_images)
                    {
                        fs.WriteLine(page.Page_URL + ", " + img);
                    }
              
                }
                fs.Close();
                fs.Dispose();
            }
            catch
            {
                throw;
            }
        
        }

    }
}
