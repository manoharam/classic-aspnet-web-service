<%@ WebService Language="C#" Class="frameworkaspxservice.MyService" %>
using System;
using System.Web;
using System.Web.Services;

namespace frameworkaspxservice
{
   [WebService(Namespace="http://pivotal.io")]
	public class MyService: WebService
	{
        public MyService() {}
        
        [WebMethod]
        public string SayHi() {
        
            //get machine name
            string machineName = Environment.MachineName;
        
            //add system console writeline
            System.Console.WriteLine(string.Format("Being polite and saying hi from {0}!", machineName));

            //add read of environment variable
            string greeting = Environment.GetEnvironmentVariable("greeting");
        
            return string.Format("{0}, everyone!", greeting);
        }
        
        [WebMethod]
        public void CrashMe() {
            
            System.Threading.Thread.CurrentThread.Abort();
        
        }
	}
}
