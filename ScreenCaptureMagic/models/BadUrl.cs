using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenCaptureMagic.Models
{
    class BadUrl
    {
        string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        string _foundOnUrl;

        public string FoundOnUrl
        {
            get { return _foundOnUrl; }
            set { _foundOnUrl = value; }
        }
        public BadUrl(string url, string message, string foundOnUrl) {
            Url = url;
            Message = message;
            FoundOnUrl = foundOnUrl;
        }
    }
}
