using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace InsuranceAppWebUI
{
    public class TestBase
    {
        // private static string _serverAddress = "http://www.eaa.org";
        //private static string _serverAddress = "http://dev.eaa.org";
        private static string _serverAddress = "http://qa.eaa.org";
        public string TestImage()
        {
            return @"C:\Users\tzirbel\Pictures\Sky2.jpg";
        }

        public IE BrowseTo(string url)
        {
            return new IE(string.Format("{0}{1}", _serverAddress, url));
        }
    }
}
