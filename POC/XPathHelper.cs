using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
                                if (XPathConnfig.MappingRequired == false && XPathConnfig.DateFormat == null && XPathConnfig.TimeFormat == null)
                                {
                                    Console.WriteLine(elemList[i].InnerXml);
                                    htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, elemList[i].InnerXml);
                                }
                                else
                                {
                                    if (XPathConnfig.MappingRequired == true)
                                    {
                                        htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, "db");
                                    }
                                    else if (XPathConnfig.DateFormat != null)
                                    {
                                        var parsedDate = DateTime.ParseExact(elemList[i].InnerXml, XPathConnfig.DateFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(XPathConnfig.DateFormat.TargetFormat);
                                        htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, parsedDate);
                                    }
                                    else if (XPathConnfig.TimeFormat != null)
                                    {
                                        var parsedTime = DateTime.ParseExact(elemList[i].InnerXml, XPathConnfig.TimeFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(XPathConnfig.TimeFormat.TargetFormat);
                                        htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, parsedTime);
                                    }
                                        
                                }
                                
                               
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
                            if (listEdiXpath.XPathConnfig.MappingRequired == false && listEdiXpath.XPathConnfig.DateFormat == null && listEdiXpath.XPathConnfig.TimeFormat == null)
                            {
                                listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, elemList[i].InnerXml));
                            }
                            else
                            {
                                if (listEdiXpath.XPathConnfig.MappingRequired == true)
                                {
                                    listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, "db"));
                                }
                                else if (listEdiXpath.XPathConnfig.DateFormat != null)
                                {
                                    var parsedDate = DateTime.ParseExact(elemList[i].InnerXml, listEdiXpath.XPathConnfig.DateFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(listEdiXpath.XPathConnfig.DateFormat.TargetFormat);
                                    listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, parsedDate));
                                }
                                else if (listEdiXpath.XPathConnfig.TimeFormat != null)
                                {
                                    var parsedTime = DateTime.ParseExact(elemList[i].InnerXml, listEdiXpath.XPathConnfig.TimeFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(listEdiXpath.XPathConnfig.TimeFormat.TargetFormat);
                                    listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, parsedTime));
                                }
                            }

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
                html = Regex.Replace(html, listEdiXPathValue.Item1, listEdiXPathValue.Item2, RegexOptions.None);
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
