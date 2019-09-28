using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHTMDocsV3
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
            while (counter <= totalNumber)
            {
                // generate a document with incremented values
                Document htmPage = new Document { fileName = $"{courseName}-p{counter}.htm", path = $"..//..//..//Files//{courseName}-p{counter}.htm", fileNumber = counter, lines = TextRepository.BaseLines.ToList() };
                // write the document to a new file
                htmPage.InitializeLines(htmPage, courseName, courseTitle, counter);
                Document.GeneratePage(htmPage);
                counter++;
            }
            Document pageOne = GeneratePagesOneAndTwo.MakePageOne(courseName, courseTitle);
            Document.GeneratePage(pageOne);
            Console.WriteLine("The program has completed. Please verify your files.");
            Console.ReadLine();
        }
    }
}
