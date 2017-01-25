using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WcfServer
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            using (var receiveStream = HttpContext.Current.Request.InputStream)
            {
                receiveStream.Position = 0;
                using (var ms = new MemoryStream())
                {
                    receiveStream.CopyTo(ms);
                    ms.Position = 0;
                    using (var sr = new StreamReader(ms, Encoding.UTF8))
                    {
                        string requestText = sr.ReadToEnd();
                    }
                }
                receiveStream.Position = 0;
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}