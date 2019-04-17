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
            string newFileName = baseFile.fileName + "new";
            StreamWriter sw = new StreamWriter(baseFile.path.Remove(baseFile.path.Length-5) + "3.htm");
            for(int i = 0; i< baseFile.lines.Count; i++)
            {
                sw.WriteLine(baseFile.lines[i]);
            }
            sw.Close();
        }
    }
}
