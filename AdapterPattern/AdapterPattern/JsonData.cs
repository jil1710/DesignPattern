using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class JsonData : IJsonData
    {
        private string json;

        public JsonData(string jsondata)
        {
            json = jsondata;
        }

        public string GetJsonData()
        {
            return json;
        }
    }
}
