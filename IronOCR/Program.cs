using IronOcr;
using System;

namespace IronOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Frelancing\ConsoleApp\OCR_Apps\IronOCR\Files\";
            var ocr = new IronTesseract();
            using (var input = new OcrInput(path + "Resume.jpg"))
            {
                var result = ocr.Read(input);
                Console.WriteLine(result.Text);
                Console.ReadKey();
            }
        }
    }
}
