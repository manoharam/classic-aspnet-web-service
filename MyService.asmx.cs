using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace framework_aspnet_service
{
    /// <summary>
    /// Summary description for MyService
    /// </summary>
    [WebService(Namespace = "http://pivotal.io")]
    // [System.Web.Script.Services.ScriptService]
    public class MyService : System.Web.Services.WebService
    {

        [WebMethod]
        public string SayHi()
        {
            //get machine name
            string machineName = Environment.MachineName;

            //add system console writeline
            System.Console.WriteLine(string.Format("Being polite and saying hi from {0}!", machineName));

            //add read of environment variable
            string greeting = Environment.GetEnvironmentVariable("greeting");

            return string.Format("{0}, everyone!", greeting);
        }

        [WebMethod]
        public void CrashMe()
        {

            System.Threading.Thread.CurrentThread.Abort();

        }
    }
}
