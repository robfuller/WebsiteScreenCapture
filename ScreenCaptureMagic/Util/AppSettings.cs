using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenCaptureMagic.Util
{
    class AppSettings
    {
        int _pageTimeoutInSeconds = 10;
        int _flashLoadAllowanceInMilliseconds = 3000;
        int _maxDepthToSpider = 0;
        int _minBrowserHeight = 760;
        int _defaultBrowserWidth = 1024;

        string[] _excludeFileExtentions = { "#", ".jpg", ".jpeg", ".gif", ".zip", ".exe", ".ppt", ".pptx", ".docx", ".doc", ".xls", ".xlsx", ".pdf/", ".pdf", ".js", ".swf", ".css", ".mp3", ".wav", ".mov", ".mpeg", ".avi", ".png" };
        string _fileLocation = "";
        string _base_url;


        bool _constrainToChildUrls = true;
        bool _followJavascriptLinks = true;
        bool _ignoreQueryStrings = true;
        bool _takeScreenShots = true;


        public int PageTimeoutInSeconds
        {
            get { return _pageTimeoutInSeconds; }
            set { _pageTimeoutInSeconds = value; }
        }


        public int FlashLoadAllowanceInSeconds
        {
            get { return _flashLoadAllowanceInMilliseconds / 1000; }
            set { _flashLoadAllowanceInMilliseconds = value * 1000; }
        }

        public int FlashLoadAllowanceInMilliseconds
        {
            get { return _flashLoadAllowanceInMilliseconds; }
            set { _flashLoadAllowanceInMilliseconds = value; }
        }


        public int MaxDepthToSpider
        {
            get { return _maxDepthToSpider; }
            set { _maxDepthToSpider = value; }
        }


        public string[] ExcludeFileExtentions
        {
            get { return _excludeFileExtentions; }
            set { _excludeFileExtentions = value; }
        }

        public string FileLocation
        {
            get { return _fileLocation; }
            set { _fileLocation = value; }
        }

        
        public int MinBrowserHeight
        {
            get { return _minBrowserHeight; }
            set { _minBrowserHeight = value; }
        }


        public int DefaultBrowserWidth
        {
            get { return _defaultBrowserWidth; }
            set { _defaultBrowserWidth = value; }
        }


        public bool ConstrainToDeeperUrls
        {
            get { return _constrainToChildUrls; }
            set { _constrainToChildUrls = value; }
        }


        public bool FollowJavascriptLinks
        {
            get { return _followJavascriptLinks; }
            set { _followJavascriptLinks = value; }
        }



        public bool IgnoreQueryStrings
        {
            get { return _ignoreQueryStrings; }
            set { _ignoreQueryStrings = value; }
        }


        public string Base_url
        {
            get { return _base_url; }
            set { _base_url = value; }
        }

        
        public bool TakeScreenShots
        {
            get { return _takeScreenShots; }
            set { _takeScreenShots = value; }
        }

    }
}
