using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;

namespace POC
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listEdiFiles = new List<Tuple<string, string,string,string>>();
            listEdiFiles.Add(Tuple.Create(@"C:\Users\Dell\Desktop\EdiWork\ListLoad850.txt", @"C:\Users\Dell\Desktop\EdiWork\Packing_ORIGINAL_850.xml", @"C:\Users\Dell\Desktop\EdiWork\XpathLoad850.html", @"C:\Users\Dell\Desktop\EdiWork\XpathLoad850Updated.html"));
            listEdiFiles.Add(Tuple.Create(@"C:\Users\Dell\Desktop\EdiWork\ListLoad856.txt", @"C:\Users\Dell\Desktop\EdiWork\Packing_ORIGINAL_856.xml", @"C:\Users\Dell\Desktop\EdiWork\XpathLoad856.html", @"C:\Users\Dell\Desktop\EdiWork\XpathLoad856Updated.html"));
            XPathHelper.XPathMapper(listEdiFiles);
        }
        
    }
    
}
