
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Ubiety.Dns.Core;

namespace datacenter.Url_helper
{
  public  class UrlHelpClass 
    {
        public HttpResponse responses;
        private UrlHelpClass()
        {

        }
         private UrlHelpClass(HttpResponse response)
        {
            responses = response;
        }

        private static UrlHelpClass UrlHelpClasss = null;

        public static UrlHelpClass Instance
        {
            get
            {
                if(UrlHelpClasss == null)
                {
                    return UrlHelpClasss = new UrlHelpClass();
                }
                return UrlHelpClasss;
            }
        }

        public void UrlCustom(string route , string name , ref string url)
        {
             url = AppDomain.CurrentDomain.BaseDirectory +  route + @"\" + name;
        }
        
        public void UrlRedirect(string route , string name , ref string url)
        {
             url = AppDomain.CurrentDomain.BaseDirectory +  route + @"\" + name;
            responses.Redirect(url);
        }
    }
}
