using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace POC
{
    public static class XPathHelper
    {
        public static string htmlArray = "";
        public static void XPathMapper(List<Tuple<string, string, string, string>> tuples)
        {
            var listEdiXPathValues = new List<Tuple<string, string>>();
            foreach (var ediFile in tuples)
            {
                var listEdiXpathFile = File.ReadAllLines(ediFile.Item1);
                var listEdiXpaths = new List<string>(listEdiXpathFile);

                //Create the XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.Load(ediFile.Item2);

                foreach (var listEdiXpath in listEdiXpaths)
                {
                    if (listEdiXpath.Contains("<tr>"))
                    {
                        XmlNodeList baseNodes = doc.SelectNodes("//PO1Loop1/PO1");
                        foreach (XmlNode baseNode in baseNodes)
                        {
                            var htmltemplate = listEdiXpath;
                            foreach (XmlNode childNode in baseNode)
                            {
                                var makeXPath = "{{"+ baseNode.Name + "/"+ childNode.Name + "}}";
                                htmltemplate = Regex.Replace(htmltemplate, makeXPath, childNode.InnerXml);
                                
                            }
                            htmlArray = htmlArray + htmltemplate;
                        }
                    }
                    else
                    {
                        var SlipedXpath = listEdiXpath.Trim('{', '}').Split(@"/");
                        var trmipedXpath = SlipedXpath[1].Replace("}}", string.Empty).Replace(" ", string.Empty);
                        if (trmipedXpath.Contains("-"))
                        {
                            var slipttrmipedXpathForNode = trmipedXpath.Split('-');
                            var elemListById = doc.SelectSingleNode("//" + slipttrmipedXpathForNode[0] + "[@ID='" + slipttrmipedXpathForNode[1] + "']");
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
                }
                WebClient webClient = new WebClient();
                string html = webClient.DownloadString(ediFile.Item3).ToString();
                foreach (var listEdiXPathValue in listEdiXPathValues)
                {
                    html = Regex.Replace(html, listEdiXPathValue.Item1, listEdiXPathValue.Item2);
                }
                html = Regex.Replace(html, "{{LinesHtml}}", htmlArray);
                if (!File.Exists(ediFile.Item4))
                {
                    File.Create(ediFile.Item4).Dispose();
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
            }
        }
    }
}
