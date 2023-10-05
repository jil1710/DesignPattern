using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterPattern
{
    public class XMLToJsonAdapter : IJsonData
    {
        private IXMLData _data;

        public XMLToJsonAdapter(IXMLData xMLData)
        {
            _data = xMLData;
        }

        public string GetJsonData()
        {
            var xmlData = _data.GetXmlData();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlData);
            var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);

            return json;
        }
    }
}
