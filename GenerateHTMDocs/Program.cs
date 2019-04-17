using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHTMDocs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will take in a simple HTM document and create\nfollow-on documents to facilitate course creation for AnytimeCE.");
            Console.WriteLine("How many documents would you like?");
            int.TryParse(Console.ReadLine(), out int totalNumber);
            Document readDocument = new Document { path = @"../../../Files/Page2.htm", fileName = "Page2", fileNumber = 2 };
            readDocument.lines = readDocument.ExtractFile(readDocument.path);
            int counter = 2;
            while (counter < totalNumber){
                var generateFile = new GenerateFile();
                Document newFile = generateFile.MakeFile(readDocument);
                readDocument = newFile;
                counter++;
            }
            Console.ReadLine();
        }
    }
}
