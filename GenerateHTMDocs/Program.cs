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
            Console.WriteLine("This program will take in a simple HTM document and create follow-on documents to facilitate course creation for AnytimeCE.");
            uint totalNumber;
            Console.WriteLine("How many documents would you like?");
            while(!uint.TryParse(Console.ReadLine(), out totalNumber))
            {
                Console.WriteLine("Please type a positive number.");
                // note: the program won't work correctly if the user types a number larger than 999
            }
            Document readDocument = new Document { path = @"../../../Files/W2017_NEC_440_ACREF_EQ_SC-p2.htm", fileName = "W2017_NEC_440_ACREF_EQ_SC-p2.htm", fileNumber = 2 };
            readDocument.lines = readDocument.ExtractFile(readDocument.path);
            var brokenLines = Helper.splitLines(readDocument);
            int counter = 2;
            while (counter < totalNumber){
                var generateFile = new GenerateFile();
                Document newFile = generateFile.MakeFile(readDocument, brokenLines);
                // here I swap the old file for the new, so the properties within the document increment
                readDocument = newFile;
                counter++;
            }
            Console.WriteLine("The program has completed. Please verify your files.");
            Console.ReadLine();
        }
    }
}
