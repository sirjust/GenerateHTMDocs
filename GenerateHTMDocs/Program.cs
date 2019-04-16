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
            Document mainDocument = new Document { path = @"../../../Files/Page2.htm", fileName = "Page2", fileNumber = 2 };
            mainDocument.ExtractFile(mainDocument.path);
            Console.ReadLine();
        }
    }
}
