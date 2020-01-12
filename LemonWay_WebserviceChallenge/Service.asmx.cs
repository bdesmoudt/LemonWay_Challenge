using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace LemonWay_WebserviceChallenge
{
    /// <summary>
    /// Description résumée de Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod]
        public int Fibonacci(int n)
        {
            Log.Info("Starting Fibonacci...");
            Log.Debug("Request Recieved - Method : " + HttpContext.Current.Request.HttpMethod);
            Log.Debug("Request Recieved - Header : " + HttpContext.Current.Request.Headers.ToString());
            Log.Debug("Request Recieved - User IP : " + HttpContext.Current.Request.UserHostAddress);
            Thread.Sleep(3000);
            if (n < 1 || n > 100)
            {
                return -1;
            }

            else
            {
                int a = 0;
                int b = 1;
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                return a;
            }
        }


        [WebMethod]
        public string XmlToJson(string xml)
        {
            Log.Info("Starting XmlToJson...");
            Log.Debug("Request Recieved - Method : " + HttpContext.Current.Request.HttpMethod);
            Log.Debug("Request Recieved - Header : " + HttpContext.Current.Request.Headers.ToString());
            Log.Debug("Request Recieved - User IP : " + HttpContext.Current.Request.UserHostAddress);
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);

                string json = JsonConvert.SerializeXmlNode(doc);
                return json;
            }
            catch
            {
                return "Bad Xml format";
            }
        }
    }
}
