using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenCaptureMagic.Util
{
    class WebBrowser : System.Windows.Forms.WebBrowser
    {
        protected override void OnNewWindow(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            //base.OnNewWindow(e);
        }
    }
}
