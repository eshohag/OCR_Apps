using IronOcr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IronOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading files...");
            var path = @"C:\Frelancing\ConsoleApp\OCR_Apps\IronOCR\Files\";
            List<string> paths = Directory.EnumerateFiles(path, "*.pdf").ToList();

            var searchableKeyCv = new List<string>();

            foreach (string filePath in paths)
            {
                Console.WriteLine("Read File- " + filePath);
                Console.WriteLine("Start-" + DateTime.Now);
                var ocr = new IronTesseract();
                using (var input = new OcrInput(filePath))
                {
                    var result = ocr.Read(input);
                    var text = result.Text;
                    if (text.Contains("React"))
                        searchableKeyCv.Add("React");
                    //if (text.Contains("ETL"))
                    //    searchableKeyCv.Add("ETL");
                    Console.WriteLine("End-" + DateTime.Now);
                }
            }
            Console.WriteLine("Searchable Key Result-");
            foreach (var item in searchableKeyCv)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
