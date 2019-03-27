using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_config1
{
    class selenium_config_cls
    {
        public void TestMethod1()
        {
            Console.WriteLine(System.Configuration.ConfigurationManager.AppSettings.Get("Browser"));
            Console.WriteLine(System.Configuration.ConfigurationManager.AppSettings.Get("Username"));
            Console.WriteLine(System.Configuration.ConfigurationManager.AppSettings.Get("Password"));

        }
    }
}
