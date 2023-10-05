using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class FileBuilder
    {
        protected File file;

        public abstract void SetFileType();
        public abstract void SetFileHeader();
        public abstract void SetFileContent();
        public abstract void SetFileFooter();

        public void CreateNewFile()
        {
            file = new File();
        }

        public File GetFile()
        {
            return file;
        }
    }
}
