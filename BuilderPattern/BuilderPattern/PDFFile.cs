using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class PDFFile : FileBuilder
    {
        public override void SetFileContent()
        {
            file.FileContent = "PDF Content";
        }

        public override void SetFileFooter()
        {
            file.FileFooter = "PDF Footer";
        }

        public override void SetFileHeader()
        {
            file.FileHeader = "PDF Header";
        }

        public override void SetFileType()
        {
            file.FileType = "PDF";
        }
    }
}
