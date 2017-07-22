using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml;

namespace jsonDotNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = @"<?xml version=""1.0"" standalone=""no""?>
<root>
  <person id=""1"">
  <name>Alan</name>
  <url>http://www.google.com</url>
  </person>
  <person id=""2"">
  <name>Louis</name>
  <url>http://www.yahoo.com</url>
  </person>
</root>";

            XmlDocument doc = new XmlDocument(); //创建xml document 实例
            doc.LoadXml(xml);//转换string为xml

            string jsonText = JsonConvert.SerializeXmlNode(doc);//转换xml为json
            Console.WriteLine(jsonText);
        }
    }
}
