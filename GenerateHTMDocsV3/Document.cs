using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHTMDocsV3
{
    public class Document
    {
        public string path { get; set; }
        public string fileName { get; set; }
        public int fileNumber { get; set; }
        public List<string> lines { get; set; }
        public string title { get; set; }

        public static void GeneratePage(Document htmPage)
        {
            StreamWriter sw = new StreamWriter(htmPage.path);
            for (int i = 0; i < htmPage.lines.Count; i++)
            {
                sw.WriteLine(htmPage.lines[i]);
            }
            sw.Close();
        }

        public void InitializeLines(Document htmlPage, string courseName, string courseTitle, int counter)
        {
            htmlPage.lines[3] += $"{courseTitle}</title>";
            htmlPage.lines[8] += $"{courseName}-p{counter}.jpg\" border = \"0\" usemap = \"#Map\" >";
            htmlPage.lines[10] += $"{courseName}-p{counter - 1}.htm\">";
            htmlPage.lines[11] += $"{courseName}-p{counter + 1}.htm\">";
        }
    }
}
