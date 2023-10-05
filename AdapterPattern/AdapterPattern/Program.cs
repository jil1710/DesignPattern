namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xml = @"<Invoice>
                            <Timestamp>1/1/2017 00:01</Timestamp>
                            <CusNumber>12345</CusNumber>
                            <AccNumber>54321</AccNumber>
                        </Invoice>";
            IXMLData xMLData = new XMLData(xml);

            IJsonData jsonData = new XMLToJsonAdapter(xMLData);

            var json = jsonData.GetJsonData();

            Console.WriteLine(json);    

            Console.ReadKey();
        }
    }
}