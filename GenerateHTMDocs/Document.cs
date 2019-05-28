using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHTMDocs
{
    public class Document
    {
        public string path { get; set; }
        public string fileName { get; set; }
        public int fileNumber { get; set; }
        public List<string> lines { get; set; }
        public string title { get; set; }

        public List<string> ExtractFile(string path)
        {
            // foreach line of text, add it to the file lines
            // do this only for the second file
            string[] lines = File.ReadAllLines(path);
            var returnLines = new List<string>();
            foreach(string line in lines)
            {
                returnLines.Add(line);
            }
            return returnLines;
        }

    }
}
