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
            var listPlaceHolderForCalculation = new List<Tuple<string, double>>();
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

                            var elemList = baseNode.SelectNodes(XPathConnfig.XPath)[i];

                            if (elemList != null || XPathConnfig.MutiplcationUsingXPath != null)
                            {
                                if (XPathConnfig.MappingRequired == false && XPathConnfig.DateFormat == null && XPathConnfig.TimeFormat == null && XPathConnfig.MutiplcationUsingXPath == null)
                                {
                                    Console.WriteLine(elemList.InnerXml);
                                    htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, elemList.InnerXml);
                                }
                                else
                                {
                                    if (XPathConnfig.MappingRequired == true)
                                    {
                                        htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, "db");
                                    }
                                    else if (XPathConnfig.DateFormat != null)
                                    {
                                        try
                                        {
                                            var parsedDate = DateTime.ParseExact(elemList.InnerXml, XPathConnfig.DateFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(XPathConnfig.DateFormat.TargetFormat);
                                            htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, parsedDate);
                                        }
                                        catch (Exception ex)
                                        {
                                            htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, elemList.InnerXml);
                                        }
                                        
                                    }
                                    else if (XPathConnfig.TimeFormat != null)
                                    {
                                        try
                                        {
                                            var parsedTime = DateTime.ParseExact(elemList.InnerXml, XPathConnfig.TimeFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(XPathConnfig.TimeFormat.TargetFormat);
                                            htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, parsedTime);
                                        }
                                        catch (Exception ex)
                                        {
                                            htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, elemList.InnerXml);
                                        }
                                    }
                                    else if (XPathConnfig.MutiplcationUsingXPath != null)
                                    {
                                        List<double> XpathValues = new List<double>();
                                        foreach (var Xpath in XPathConnfig.MutiplcationUsingXPath)
                                        {
                                            try
                                            {
                                                var elemListForMutiplication = baseNode.SelectNodes(Xpath)[i];
                                                XpathValues.Add(Convert.ToDouble(elemListForMutiplication.InnerXml));
                                                
                                            }
                                            catch (Exception ex)
                                            {

                                            }
                                            
                                        }
                                        htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, XpathValues.Aggregate((a, x) => a * x).ToString("0.00"));
                                        listPlaceHolderForCalculation.Add(Tuple.Create(XPathConnfig.PlaceHolder, Convert.ToDouble(XpathValues.Aggregate((a, x) => a * x).ToString("0.00"))));
                                    }
                                        
                                }
                                
                               
                            }
                            else if (elemList == null)
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
                else if (listEdiXpath.XPathConnfig != null && listEdiXpath.XPathConnfig.AdditionUsingPlaceHolders == null)
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
                                    try
                                    {
                                        var parsedDate = DateTime.ParseExact(elemList[i].InnerXml, listEdiXpath.XPathConnfig.DateFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(listEdiXpath.XPathConnfig.DateFormat.TargetFormat);
                                        listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, parsedDate));
                                    }
                                    catch (Exception ex)
                                    {

                                        listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, elemList[i].InnerXml));
                                    }
                                    
                                }
                                else if (listEdiXpath.XPathConnfig.TimeFormat != null)
                                {
                                    try
                                    {
                                        var parsedTime = DateTime.ParseExact(elemList[i].InnerXml, listEdiXpath.XPathConnfig.TimeFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(listEdiXpath.XPathConnfig.TimeFormat.TargetFormat);
                                        listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, parsedTime));
                                    }
                                    catch (Exception ex)
                                    {

                                        listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, elemList[i].InnerXml));
                                    }
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
                else if(listEdiXpath.XPathConnfig != null && listEdiXpath.XPathConnfig.AdditionUsingPlaceHolders != null && listEdiXpath.XPathConnfig.AdditionUsingPlaceHolders.Any())
                {
                    double sum = 0;
                    foreach (var placeHolder in listEdiXpath.XPathConnfig.AdditionUsingPlaceHolders)
                    {
                        var placeHolderSum = listPlaceHolderForCalculation.Where(x=>x.Item1 == placeHolder).Select(x=>x.Item2).Sum();
                        sum = sum + placeHolderSum;
                    }
                    listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, sum.ToString()));
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
