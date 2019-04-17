using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHTMDocs
{
    class GenerateFile
    {
        public GenerateFile(Document baseFile)
        {
            Document newPage = new Document();
            newPage.fileNumber = baseFile.fileNumber + 1;
            newPage.fileName = "Page" + newPage.fileNumber;
            newPage.path = baseFile.path.Remove(baseFile.path.Length - 5) + newPage.fileNumber + ".htm";
            newPage.lines = new List<string>();
            foreach(string line in baseFile.lines)
            {
                newPage.lines.Add(line);
            }
            // change image reference
            newPage.lines[8] = newPage.lines[8].Substring(0,37) + "3" + newPage.lines[8].Substring(38);

            //change forward and backward links
            newPage.lines[10] = newPage.lines[10].Remove(newPage.lines[10].Length - 7) + (newPage.fileNumber - 1) + ".htm" + '\u0022' +">";
            newPage.lines[11] = newPage.lines[11].Remove(newPage.lines[11].Length - 7) + (newPage.fileNumber + 1) + ".htm" + '\u0022' + ">";

            StreamWriter sw = new StreamWriter(newPage.path);
            for(int i = 0; i< newPage.lines.Count; i++)
            {
                sw.WriteLine(newPage.lines[i]);
            }
            sw.Close();
        }
    }
}
