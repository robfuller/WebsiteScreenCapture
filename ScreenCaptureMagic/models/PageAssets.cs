using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenCaptureMagic.Models
{
    class PageAssets
    {
        string _page_url;

        public string Page_URL
        {
            get { return _page_url; }
            set { _page_url = value; }
        }

        List<string> _all_links = new List<string>();

        public List<string> All_links
        {
            get { return _all_links; }
            set { _all_links = value; }
        }
        
        List<string> _meta = new List<string>();

        public List<string> Meta
        {
          get { return _meta; }
          set { _meta = value; }
        }

        List<string> _all_images = new List<string>();

        public List<string> All_images
        {
            get { return _all_images; }
            set { _all_images = value; }
        }

        List<string> _all_stylesheets = new List<string>();

        public List<string> All_stylesheets
        {
            get { return _all_stylesheets; }
            set { _all_stylesheets = value; }
        }
        
        string _bitmap;

        public string BitmapFilename
        {
            get { return _bitmap; }
            set { _bitmap = value; }
        }

        bool _has_flash = false;

        public bool Has_flash
        {
            get { return _has_flash; }
            set { _has_flash = value; }
        }

        public PageAssets(string url)
        {
            _page_url = url;
        }



    }
}
