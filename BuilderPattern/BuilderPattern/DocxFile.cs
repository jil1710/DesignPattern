using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class DocxFile : FileBuilder
    {
        public override void SetFileContent()
        {
            file.FileContent = "Docx Content";
        }

        public override void SetFileFooter()
        {
            file.FileFooter = "Docx Footer";
        }

        public override void SetFileHeader()
        {
            file.FileHeader = "Docx Header";
        }

        public override void SetFileType()
        {
            file.FileType = "Docx";
        }
    }
}
