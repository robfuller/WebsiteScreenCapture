using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenCaptureMagic.Util
{
    class AppSettings
    {
        int _pageTimeoutInSeconds = 10;

        public int PageTimeoutInSeconds
        {
            get { return _pageTimeoutInSeconds; }
            set { _pageTimeoutInSeconds = value; }
        }

        int _flashLoadAllowanceInMilliseconds = 3000;

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

        private int _maxDepthToSpider = 0;

        public int MaxDepthToSpider
        {
            get { return _maxDepthToSpider; }
            set { _maxDepthToSpider = value; }
        }

        string[] _excludeFileExtentions = { "#", ".jpg", ".jpeg", ".gif", ".zip", ".exe", ".ppt", ".pptx", ".docx", ".doc", ".xls", ".xlsx", ".pdf/", ".pdf", ".js", ".swf", ".css", ".mp3", ".wav", ".mov", ".mpeg", ".avi", ".png" };

        public string[] ExcludeFileExtentions
        {
            get { return _excludeFileExtentions; }
            set { _excludeFileExtentions = value; }
        }
        string _fileLocation = "";

        public string FileLocation
        {
            get { return _fileLocation; }
            set { _fileLocation = value; }
        }

        int _minBrowserHeight = 760;

        public int MinBrowserHeight
        {
            get { return _minBrowserHeight; }
            set { _minBrowserHeight = value; }
        }

        int _defaultBrowserWidth = 1024;

        public int DefaultBrowserWidth
        {
            get { return _defaultBrowserWidth; }
            set { _defaultBrowserWidth = value; }
        }

        bool _constrainToChildUrls = true;

        public bool ConstrainToDeeperUrls
        {
            get { return _constrainToChildUrls; }
            set { _constrainToChildUrls = value; }
        }

        bool _followJavascriptLinks = false;

        public bool FollowJavascriptLinks
        {
            get { return _followJavascriptLinks; }
            set { _followJavascriptLinks = value; }
        }


        bool _ignoreQueryStrings = true;

        public bool IgnoreQueryStrings
        {
            get { return _ignoreQueryStrings; }
            set { _ignoreQueryStrings = value; }
        }

        string _base_url;

        public string Base_url
        {
            get { return _base_url; }
            set { _base_url = value; }
        }

        private bool _takeScreenShots = true;

        public bool TakeScreenShots
        {
            get { return _takeScreenShots; }
            set { _takeScreenShots = value; }
        }

    }
}
