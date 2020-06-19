using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Security.Cryptography;

namespace Proy1_Diseno_InvestSys.Controller
{
    class XMLLogger : Logger {
        public void log(string data) {
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load("Log.xml");
            }
            catch (System.IO.FileNotFoundException)
            {
                doc.LoadXml(
                    "<?xml version=\"1.0\"?> \n" +
                    "<Investments> \n" +
                    "</Investments> \n"
                );
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            string[] nodes = data.Split(',');
            string[] names = new string[nodes.Length];
            string[] values = new string[nodes.Length];
            for (int i = 0; i < nodes.Length; i++) {
                string[] temp = nodes[i].Split(':');
                names[i] = temp[0];
                values[i] = temp[1];
            }

            XmlNode inv = doc.CreateElement("Investment");
            for (int i = 0; i < nodes.Length; i++)
            {
                XmlNode node = doc.CreateElement(names[i]);
                node.InnerText = values[i];
                inv.AppendChild(node);
            }

            doc.DocumentElement.AppendChild(inv);
            try
            {
                doc.Save("Log.xml");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
