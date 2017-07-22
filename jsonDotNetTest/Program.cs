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
  <name>Kobe</name>
  <url>https://nba.hupu.com/players/kobebryant-151.html</url>
  </person>
  <person id=""2"">
  <name>Jordan</name>
  <url>https://nba.hupu.com/players/michaeljordan-4087.html</url>
  </person>
</root>";

            XmlDocument doc = new XmlDocument(); //创建xml document 实例
            doc.LoadXml(xml);//转换string为xml

            string jsonText = JsonConvert.SerializeXmlNode(doc);//转换xml为json
            Console.WriteLine(jsonText);
        }
    }
}
