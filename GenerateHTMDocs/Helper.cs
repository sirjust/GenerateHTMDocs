using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHTMDocs
{
    static public class Helper
    {
        static public List<string[]> splitLines(Document readFile)
        {
            // I split each line into an array of three strings; this way I could insert a higher value into the middle of it (ie 10 and up)
            var lineEightSplit = new string[] { readFile.lines[8].Substring(0, 37), readFile.fileNumber.ToString(), readFile.lines[8].Substring(38) };

            var lineTenSplit = new string[] { readFile.lines[10].Substring(0, 79), (readFile.fileNumber -1).ToString(), readFile.lines[10].Substring(80) };

            var lineElevenSplit = new string[] { readFile.lines[11].Substring(0, 79), (readFile.fileNumber + 1).ToString(), readFile.lines[11].Substring(80) };
            return new List<string[]> { lineEightSplit, lineTenSplit, lineElevenSplit };
        }
    }
}
