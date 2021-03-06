﻿using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHTMDocsV3
{
    public static class GeneratePagesOneAndTwo
    {

        public static Document MakePageOne(string courseName, string courseTitle)
        {
            Document pageOne = new Document { fileName = $"{courseName}-p1.htm", path = $"..//..//..//Files//{courseName}-p1.htm", fileNumber = 1, lines = TextRepository.BaseLines };
            pageOne.lines[3] += $"{courseTitle}</title>";
            pageOne.lines[8] = $"<img src=\"{ courseName}-p1.jpg\" border = \"0\" usemap = \"#Map\" >";
            pageOne.lines[10] = $"  <area shape=\"rect\" coords=\"586,551,676,584\" href=\"Blank0.htm\">";
            pageOne.lines[11] = $"  <area shape=\"rect\" coords=\"688,551,778,584\" href=\"{courseName}-p2.htm\">";
            return pageOne;
        }
    }
}
