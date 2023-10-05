namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PDFFile pdfFile = new PDFFile();

            FileDirector fileDirector = new FileDirector();

            File file = fileDirector.MakeFile(pdfFile);


            file.DisplayFile();

            Console.WriteLine("----------------------------------------------");

            DocxFile docxFile = new DocxFile();
            file = fileDirector.MakeFile(docxFile);
            file.DisplayFile();

            Console.ReadKey();
        }
    }
}