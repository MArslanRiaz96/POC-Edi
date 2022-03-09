﻿using System;
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
        public static void XPathMapper(HumanReadableConfiguration humanReadableConfiguration)
        {
            var listEdiXPathValues = new List<Tuple<string, string>>();
            
                XmlDocument doc = new XmlDocument();
                doc.Load(humanReadableConfiguration.PackingPath);

                foreach (var listEdiXpath in humanReadableConfiguration.configurations)
                {
                if (listEdiXpath.LineLevel != null)
                {
                    XmlNodeList baseNodes = doc.SelectNodes(listEdiXpath.LineLevel.LineLevelXPath);
                    int i = 0;
                    foreach (XmlNode baseNode in baseNodes)
                    {
                        var htmltemplate = listEdiXpath.LineLevel.HTML;
                        foreach (var XPathConnfig in listEdiXpath.LineLevel.XPathConnfigs)
                        {

                            var elemList = baseNode.SelectNodes(XPathConnfig.XPath);

                            if (elemList.Count != 0 || !string.IsNullOrEmpty(elemList[i].InnerXml))
                            {
                                Console.WriteLine(elemList[i].InnerXml);
                                htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, elemList[i].InnerXml);
                               
                            }
                            else if (elemList.Count == 0)
                            {
                                htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, XPathConnfig.DefaultValue);
                            }

                        }
                        htmlArray = htmlArray + htmltemplate;
                        i++;
                    }

                        listEdiXPathValues.Add(Tuple.Create(listEdiXpath.LineLevel.PlaceHolder, htmlArray));
                        htmlArray = "";
                } 
                else if (listEdiXpath.XPathConnfig != null)
                {
                    XmlNodeList elemList = doc.SelectNodes(listEdiXpath.XPathConnfig.XPath);
                    for (int i = 0; i < elemList.Count; i++)
                    {
                        Console.WriteLine(elemList[i].InnerXml);
                        if (!listEdiXPathValues.Any(z => z.Item2 == elemList[i].InnerXml && z.Item1 == listEdiXpath.XPathConnfig.PlaceHolder))
                        {
                            listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, elemList[i].InnerXml));
                        }

                    }
                    if (elemList.Count == 0)
                    {
                        if (!listEdiXPathValues.Any(z => z.Item2 == "" && z.Item1 == listEdiXpath.XPathConnfig.PlaceHolder))
                        {
                            listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, listEdiXpath.XPathConnfig.DefaultValue));
                        }
                    }
                }
            }
                WebClient webClient = new WebClient();
            
            string html = webClient.DownloadString(humanReadableConfiguration.TemplatePath).ToString();
                foreach (var listEdiXPathValue in listEdiXPathValues)
                {
                    html = Regex.Replace(html, listEdiXPathValue.Item1, listEdiXPathValue.Item2,RegexOptions.None);
                }
                if (!File.Exists(humanReadableConfiguration.TemplatePathUpdatedTemp))
                {
                    File.Create(humanReadableConfiguration.TemplatePathUpdatedTemp).Dispose();
                    using (var tw = new StreamWriter(humanReadableConfiguration.TemplatePathUpdatedTemp, false))
                    {
                        tw.WriteLine(html);
                    }
                }
                else if (File.Exists(humanReadableConfiguration.TemplatePathUpdatedTemp))
                {
                    using (var tw = new StreamWriter(humanReadableConfiguration.TemplatePathUpdatedTemp, false))
                    {
                        tw.WriteLine(html);
                    }
                }
                
                var p = new Process();
                var p2 = new Process();
                p.StartInfo = new ProcessStartInfo(humanReadableConfiguration.TemplatePath)
                {
                    UseShellExecute = true
                };
                p.Start();
                p2.StartInfo = new ProcessStartInfo(humanReadableConfiguration.TemplatePathUpdatedTemp)
                {
                    UseShellExecute = true
                };
                p2.Start();
            
        }
    }
}
