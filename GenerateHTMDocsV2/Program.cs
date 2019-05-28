using System;
using GenerateHTMDocs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHTMDocsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will create HTM documents to facilitate course creation for AnytimeCE.");
            uint totalNumber;
            Console.WriteLine("What is the Course Name?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What should the Course Title be?");
            string courseTitle = Console.ReadLine();
            Console.WriteLine("How many documents would you like? (Must be below 1000)");
            while (!uint.TryParse(Console.ReadLine(), out totalNumber))
            {
                Console.WriteLine("Please type a positive number.");
                // note: the program won't work correctly if the user types a number larger than 999
            }

            int counter = 2;
            Document readDocument = new Document { fileName = $"{courseName}-p{counter}.htm", path = $"..//..//..//Files//{courseName}-p{counter}.htm", fileNumber = counter, lines = TextRepository.BaseLines };
            readDocument.lines[3] += $"{courseTitle}</title>";
            readDocument.lines[8] += $"{courseName}-p{counter}.jpg\" border = \"0\" usemap = \"#Map\" >";
            readDocument.lines[10] += $"{courseName}-p{counter - 1}.htm\">";
            readDocument.lines[11] += $"{courseName}-p{counter + 1}.htm\">";
            GeneratePagesOneAndTwo.GeneratePage(readDocument);
            var brokenLines = Helper.splitLines(readDocument, courseName);
            while (counter < totalNumber)
            {
                var generateFile = new GenerateFile();
                Document newFile = generateFile.MakeFile(readDocument, brokenLines, courseName);
                // here I swap the old file for the new, so the properties within the document increment
                readDocument = newFile;
                counter++;
            }
            Document pageOne = GeneratePagesOneAndTwo.MakePageOne(courseName);
            GeneratePagesOneAndTwo.GeneratePage(pageOne);
            Console.WriteLine("The program has completed. Please verify your files.");
            Console.ReadLine();
        }
    }
}
