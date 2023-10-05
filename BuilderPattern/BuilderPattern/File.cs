using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class File
    {
        public string FileType { get; set; }
        public string FileHeader { get; set; }
        public string FileFooter { get; set; }
        public string FileContent { get; set; }

        public void DisplayFile()
        {
            Console.WriteLine("File Type :" + FileType);
            Console.WriteLine("File Header :" + FileHeader);
            Console.WriteLine("File Content :" + FileFooter);
            Console.WriteLine("File Footer :" + FileContent);
        }
    }
}
