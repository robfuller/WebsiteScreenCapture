using System;
using System.Text;
using System.IO;

namespace ScreenCaptureMagic
{
    class GenerateReport
    {
        
        public static void createReport(Models.SiteInfo site)
        {
            StreamWriter fs = new StreamWriter("report.htm", false);
            fs.WriteLine("<html>" + Environment.NewLine + "  <head>" + Environment.NewLine);
            fs.WriteLine("   <title>Report for " + site.Starting_URL + " on " + DateTime.Now.Date + "</title>");
            fs.WriteLine("   <style>");
            fs.WriteLine("      body { font-size: 10pt; font-family: arial, serif; }" + Environment.NewLine +
	                     "      ul.narrowcol { float: left; width: 500px; font-size: 8pt; }" + Environment.NewLine + 
                         "      h1 { font-size: 11pt; }" + Environment.NewLine +
                         "      h3 { font-size: 9pt}");

            fs.WriteLine("   </style>");
            fs.WriteLine("  </head");
            fs.WriteLine("<body>");
            fs.WriteLine("<h1>Report for " + site.Starting_URL + " on " + DateTime.Now.Date + "</h1>");
            
            ReportAllUrlsFollowed(fs, site);

            ReportBadURLS(fs, site);

            foreach (Models.PageAssets page in site.Pages)
            {
                ReportOnPage(fs, page);
            }
            fs.Close();
            fs.Dispose();
        }
        private static void ReportAllUrlsFollowed(StreamWriter fs, Models.SiteInfo site)
        {
            fs.WriteLine("Total URLS Followed: " + site.URIs.Count + "<br>");

            fs.WriteLine("<ul class='allurls'>");
            foreach (Uri uri in site.URIs)
            {
                fs.WriteLine("  <li>" + uri.ToString() + "</li>");
            }
            fs.WriteLine("</ul> <br>");
            
        }
        private static void ReportBadURLS(StreamWriter fs, Models.SiteInfo site)
        {
            if (site.Bad_URLs.Count > 0)
            {
                fs.WriteLine("Errors on URLs Found:");
                fs.WriteLine("<ul class='badurls narrowcol'>");
                foreach (Models.BadUrl badurl in site.Bad_URLs)
                {
                    fs.WriteLine("  <li>" + badurl.Url + " found on " + badurl.FoundOnUrl + " error message: " + badurl.Message + "</li>");
                }
                fs.WriteLine("</ul>");
            }
       
        }

        private static void ReportOnPage(StreamWriter fs, Models.PageAssets page)
        {
            fs.WriteLine("<h2>" + page.Page_URL + "</h2>");
            fs.WriteLine("<h3>Page has " + page.All_links.Count + " links and " + page.All_images.Count + " images");
            fs.WriteLine("<h3>Links:</h3>");
            fs.WriteLine("<ul class='links narrowcol'>");
            foreach (string u in page.All_links)
            {
                fs.WriteLine("  <li>" + u + "</li>");
            }
            fs.WriteLine("</ul>");
            fs.WriteLine("<h3>Images</h3> <ul class='images narrowcol'>");
            foreach (string u in page.All_images)
            {
                fs.WriteLine("  <li >" + u + "</li>");
            }
            fs.WriteLine("</ul>");
            fs.WriteLine("<h3> Meta Data</h3> <ul class='meta'narrowcol>");
            foreach (string u in page.Meta)
            {
                fs.WriteLine("   <li>" + u + "</li>");
            }
            fs.WriteLine("</ul><br/>");
            fs.WriteLine("<img class='screenshot' src='" + page.BitmapFilename + "'>");
        }
    }
}
