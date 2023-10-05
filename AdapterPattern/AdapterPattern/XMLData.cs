using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class XMLData : IXMLData
    {
        private string xml;

        public XMLData(string xmldata)
        {
            xml = xmldata;
        }

        public string GetXmlData()
        {
            return xml;
        }
    }
}
