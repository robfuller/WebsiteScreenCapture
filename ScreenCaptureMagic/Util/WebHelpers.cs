using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;

namespace ScreenCaptureMagic.Util
{
    class WebHelpers
    {

        public static string determineFilename(string url)
        {
            Uri uri = new Uri(url);
            int x = uri.Segments.Length;
            string filename;
            if (x >= 2)
            {
                if (uri.Segments[x - 1].EndsWith("/")) filename = uri.Segments[x - 1].Replace("/", "_index.jpg");
                else filename = uri.Segments[x - 2].Replace("/", "_") + uri.Segments[x - 1] + ".jpg";
            }
            else
            {
                filename = "index.jpg";
            }
            return filename;
        }

        public static string makeRelativePathAbsolute(string absoluteDomainPath, string url)
        {
            if (url.StartsWith("/"))
                url = url.Substring(1, url.Length - 1);
            if (absoluteDomainPath.EndsWith("/"))
                url = absoluteDomainPath + url;
            else url = absoluteDomainPath + "/" + url;

            return url;
        }
        public static bool hasExtension(Uri uri)
        {
            string path = uri.AbsolutePath;
            if (path.Contains(".") &&
                ( path.Length - path.LastIndexOf(".") <= 5)) return true; //4 for the extention "html" + 1 for the "."
            return false;
        }
        public static bool isExtentionValid(string[] invalidExtensions, Uri uri)
        {
            int len = uri.Segments.Length - 1;
            foreach (string extension in invalidExtensions)
            {
                //if last characters of the url ARE (true) in the exclude list the it is invalid
                if (uri.Segments[len].ToLower().EndsWith(extension)) return false;
            }
            return true;

        }

        public static bool checkForFlash(ScreenCaptureMagic.Util.WebBrowser wb)
        {
            string page_text = wb.DocumentText.ToLower();

            if ( (page_text.Contains("object") &&
                    page_text.Contains("param name=\"movie\""))  ||
                 (page_text.Contains("swfobject(")) )
            {

                return true;
            }
            return false;
        }
        
        public static List<string> scrapeMeta(ScreenCaptureMagic.Util.WebBrowser wb)
        {
            List<string> meta = new List<string>();

            Regex metaregex =
                new Regex(@"<meta\s*(?:(?:\b(\w|-)+\b\s*(?:=\s*(?:""[^""]*""|'" +
                          @"[^']*'|[^""'<> ]+)\s*)?)*)/?\s*>",
                          RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);

            foreach (Match metamatch in metaregex.Matches(wb.DocumentText))
            {
                string val = metamatch.Value.Replace("<", "");
                val = val.Replace(">", "");
                meta.Add(val);    
            }
                        
            return meta;
        }

        // determine if current url is a child of base_url
        public static bool IsDeeperUrl(Uri base_uri, Uri current_uri)
        {
            if (base_uri.Segments.Length > current_uri.Segments.Length) return false;

            int segments = base_uri.Segments.Length;
            if (WebHelpers.hasExtension(current_uri)) segments--;
            for (int i = 0; i < segments; i++)
            {
                if ( (base_uri.Segments[i] != current_uri.Segments[i] ) ) return false;
            }
            return true;
        }
    }
}
