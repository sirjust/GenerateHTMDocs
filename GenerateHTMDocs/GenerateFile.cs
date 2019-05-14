using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHTMDocs
{
    public class GenerateFile
    {
        public Document MakeFile(Document baseFile, List<string[]> brokenLines, string courseName)
        {
            Document newPage = new Document();
            newPage.fileNumber = baseFile.fileNumber + 1;
            newPage.fileName = $"{courseName}p" + newPage.fileNumber;
            switch (newPage.fileNumber)
            {
                // here I can insert the new fileNumber into the path
                case var num when (newPage.fileNumber <10): newPage.path = baseFile.path.Remove(baseFile.path.Length - 5) + newPage.fileNumber + ".htm";
                    break;
                case var num when (newPage.fileNumber > 10 && newPage.fileNumber<= 100):
                    newPage.path = baseFile.path.Remove(baseFile.path.Length - 6) + newPage.fileNumber + ".htm";
                    break;
                case var num when (newPage.fileNumber > 100):
                    newPage.path = baseFile.path.Remove(baseFile.path.Length - 7) + newPage.fileNumber + ".htm";
                    break;
                default: newPage.path = baseFile.path.Remove(baseFile.path.Length - 5) + newPage.fileNumber + ".htm";
                    break; ;
            }
            
            newPage.lines = new List<string>();
            foreach(string line in baseFile.lines)
            {
                newPage.lines.Add(line);
            }
            // change image reference
            newPage.lines[8] = brokenLines[0][0] + newPage.fileNumber + brokenLines[0][2];

            // change forward and backward links
            newPage.lines[10] = brokenLines[1][0] + (newPage.fileNumber -1) + brokenLines[1][2];
            newPage.lines[11] = brokenLines[1][0] + (newPage.fileNumber +1) + brokenLines[1][2];

            StreamWriter sw = new StreamWriter(newPage.path);
            for(int i = 0; i< newPage.lines.Count; i++)
            {
                sw.WriteLine(newPage.lines[i]);
            }
            sw.Close();
            return newPage;
        }
    }
}
