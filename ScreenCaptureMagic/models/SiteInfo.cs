using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenCaptureMagic.Models
{
    class SiteInfo
    {

        Uri _starting_uri;

        public Uri Starting_Uri
        {
            get { return _starting_uri; }
            set { _starting_uri = value; }
        }

        
        public string Starting_URL
        {
            get { return _starting_uri.ToString(); }
            set { 
                try
                {
                    Uri uri = new Uri(value);
                    _domain = uri.Host;
                    _domain_absolute = uri.AbsoluteUri;
                    _starting_uri = uri;
                } 
                catch (Exception ex)
                { 
                    throw ex;
                }
            }
        }
        string _domain;

        public string Domain
        {
            get { return _domain; }
            
        }
        string _domain_absolute;

        public string Domain_absolute
        {
            get { return _domain_absolute; }
            
        }
        List<Uri> _URLs = new List<Uri>();

        public List<Uri> URIs
        {
            get { return _URLs; }
            set { _URLs = value; }
        }



        List<PageAssets> _pages = new List<PageAssets>();

        public List<PageAssets> Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }
        List<BadUrl> _bad_urls = new List<BadUrl>();

        public List<BadUrl> Bad_URLs
        {
            get { return _bad_urls; }
            set { _bad_urls = value; }
        }
    }
}
