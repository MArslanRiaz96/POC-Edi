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
            var listEdiXPathValues = new List<Tuple<string, string>>();
            foreach (var ediFile in listEdiFiles)
            {
                var listEdiXpathFile = File.ReadAllLines(ediFile.Item1);
                var listEdiXpaths = new List<string>(listEdiXpathFile);

                //Create the XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.Load(ediFile.Item2);

                //Display all the book titles.
                foreach (var listEdiXpath in listEdiXpaths)
                {
                    var SlipedXpath = listEdiXpath.Trim('{','}').Split(@"/");
                    var trmipedXpath = SlipedXpath[1].Replace("}}", string.Empty).Replace(" ", string.Empty);
                    if (trmipedXpath.Contains("-"))
                    {
                        var slipttrmipedXpathForNode = trmipedXpath.Split('-');
                        var elemListById = doc.SelectSingleNode("//"+ slipttrmipedXpathForNode[0] + "[@ID='"+ slipttrmipedXpathForNode[1]+ "']");
                        if (!listEdiXPathValues.Any(z => z.Item2 == elemListById.InnerXml && z.Item1 == listEdiXpath))
                        {
                            listEdiXPathValues.Add(Tuple.Create(listEdiXpath, elemListById.InnerXml));
                        }
                        Console.WriteLine(elemListById.InnerXml);
                    }
                    else
                    {
                        XmlNodeList elemList = doc.GetElementsByTagName(trmipedXpath);
                        for (int i = 0; i < elemList.Count; i++)
                        {
                            Console.WriteLine(elemList[i].InnerXml);
                            if (!listEdiXPathValues.Any(z => z.Item2 == elemList[i].InnerXml && z.Item1 == listEdiXpath))
                            {
                                listEdiXPathValues.Add(Tuple.Create(listEdiXpath, elemList[i].InnerXml));
                            }

                        }
                    }
                }
                WebClient webClient = new WebClient();
                string html = webClient.DownloadString(ediFile.Item3).ToString();
                foreach (var listEdiXPathValue in listEdiXPathValues)
                {
                    html = Regex.Replace(html, listEdiXPathValue.Item1, listEdiXPathValue.Item2);
                }
                if (!File.Exists(ediFile.Item4))
                {
                    File.Create(ediFile.Item4);
                    using (var tw = new StreamWriter(ediFile.Item4, false))
                    {
                        tw.WriteLine(html);
                    }
                }
                else if (File.Exists(ediFile.Item4))
                {
                    using (var tw = new StreamWriter(ediFile.Item4, false))
                    {
                        tw.WriteLine(html);
                    }
                }
                var p = new Process();
                var p2 = new Process();
                p.StartInfo = new ProcessStartInfo(ediFile.Item3)
                {
                    UseShellExecute = true
                };
                p.Start();
                p2.StartInfo = new ProcessStartInfo(ediFile.Item4)
                {
                    UseShellExecute = true
                };
                p2.Start();

                var doc2 = new HtmlDocument();
                doc2.LoadHtml(html);


            }
            
        }
        
    }
    
}
