using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class FileDirector
    {
        public File MakeFile(FileBuilder fileBuilder)
        {
            fileBuilder.CreateNewFile();
            fileBuilder.SetFileType();
            fileBuilder.SetFileHeader();
            fileBuilder.SetFileContent();
            fileBuilder.SetFileFooter();

            return fileBuilder.GetFile();
        }
    }
}
