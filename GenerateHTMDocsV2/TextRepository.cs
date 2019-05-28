using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHTMDocsV2
{
    static class TextRepository
    {
        public static List<string> BaseLines = new List<string> {
            "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\">",
            "<html>",
            "<head>",
            "<title>",
            "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=iso-8859-1\">",
            "</head>",
            "",
            "<body>",
            "<img src=\"",
            "<map name=\"Map\">",
            "  <area shape=\"rect\" coords=\"586,551,676,584\" href=\"",
            "  <area shape=\"rect\" coords=\"688,551,778,584\" href=\"",
            "</map>",
            "</body>",
            "</html>"
        };
    }
}
