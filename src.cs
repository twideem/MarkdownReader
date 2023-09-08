using System.Diagnostics;
using System.IO;

class _
{
    static void Main(string[] x)
    {
        var a = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\res.html";
        File.WriteAllText(a, "<!DOCTYPE html><title>" + Path.GetFileName(x[0]) + "</title><meta charset='UTF-8'><script src='lib/showdown.min.js'></script><script src='lib/highlight.min.js'></script><link rel='stylesheet' id='HighlightTheme'><p>\n" + File.ReadAllText(x[0]) + "\n</p><script src='conf.js'></script><script>let a=document.getElementsByTagName('p')[0];let b=new showdown.Converter();a.innerHTML=b.makeHtml(a.innerHTML).replace(/&amp;/g,'&');hljs.initHighlightingOnLoad()</script>");
        Process.Start(a);
    }
}