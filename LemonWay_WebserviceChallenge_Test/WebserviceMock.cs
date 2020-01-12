using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LemonWay_WebserviceChallenge_Test
{
    class WebserviceMock
    {
        public static int Fibonacci(int n)
        {
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
        public static string XmlToJson(string xml)
        {
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
