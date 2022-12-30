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
                            string node = "";
                            bool identifierOneStepHead = XPathConnfig.GetXPathUsingIdentifierOneStepHead;
                            if (XPathConnfig.PreferedXpaths != null)
                            {
                                foreach (var preferedXpath in XPathConnfig.PreferedXpaths)
                                {
                                    if (string.IsNullOrEmpty(preferedXpath.Identifier))
                                    {
                                        var elemListXpathValidator = baseNode.SelectNodes(preferedXpath.XPath)[i];
                                        if (elemListXpathValidator != null)
                                        {
                                            XPathConnfig.XPath = preferedXpath.XPath;
                                            XPathConnfig.GetXPathUsingIdentifier = "";
                                            node = !string.IsNullOrEmpty(preferedXpath.TotalNodes) && !string.IsNullOrEmpty(preferedXpath.SelectedNode) ? (Convert.ToInt32(preferedXpath.TotalNodes) * (i + 1) - Convert.ToInt32(preferedXpath.SelectedNode)).ToString() : "";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        var elemListXpathValidator = baseNode.SelectNodes(preferedXpath.XPath)[i];
                                        if (elemListXpathValidator != null && elemListXpathValidator.InnerText.Contains(preferedXpath.Identifier))
                                        {
                                            XPathConnfig.XPath = preferedXpath.XPath;
                                            XPathConnfig.GetXPathUsingIdentifier = preferedXpath.Identifier;
                                            node = !string.IsNullOrEmpty(preferedXpath.TotalNodes) && !string.IsNullOrEmpty(preferedXpath.SelectedNode) ? (Convert.ToInt32(preferedXpath.TotalNodes) * (i + 1) - Convert.ToInt32(preferedXpath.SelectedNode)).ToString() : "";
                                            break;
                                        }
                                    }
                                }
                            }

                            var elemList = baseNode.SelectNodes(XPathConnfig.XPath)[ !string.IsNullOrEmpty(node) ? Convert.ToInt32(node) : i];
                            if ( (XPathConnfig.ShowInLastLineItem == true && baseNodes.Count == i + 1) || (XPathConnfig.ShowInLastLineItem == false && elemList != null) || (XPathConnfig.ShowInLastLineItem == false && XPathConnfig.MutiplcationUsingXPath != null ) || (XPathConnfig.ShowInLastLineItem == false && !string.IsNullOrEmpty(XPathConnfig.GetXPathUsingIdentifier) || (XPathConnfig.ShowInLastLineItem == false && XPathConnfig.ConcatinationUsingDifferentXPath != null)))
                            {
                                if (XPathConnfig.MappingRequired == false && XPathConnfig.DateFormat == null && XPathConnfig.TimeFormat == null && XPathConnfig.MutiplcationUsingXPath == null && XPathConnfig.ConcatinationUsingSameXPath == false && string.IsNullOrEmpty(XPathConnfig.GetXPathUsingIdentifier))
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
                                    else if (XPathConnfig.ConcatinationUsingSameXPath == true)
                                    {
                                        var elemListForconcatinationlist = baseNode.SelectNodes(XPathConnfig.XPath);
                                        string ConcatinationUsingSameXPath = "";
                                        for (int j = 0; j < elemListForconcatinationlist.Count; j++)
                                        {
                                            Console.WriteLine(elemListForconcatinationlist[j].InnerXml);
                                            ConcatinationUsingSameXPath = ConcatinationUsingSameXPath + " " + elemListForconcatinationlist[j].InnerXml;
                                        }
                                        htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, ConcatinationUsingSameXPath);
                                    }
                                    else if (XPathConnfig?.ConcatinationUsingDifferentXPath?.Count() > 0)
                                    {
                                        string ConcatinationUsingDifferentXPath = "";
                                        foreach (string XPathConfig in XPathConnfig?.ConcatinationUsingDifferentXPath)
                                        {
                                            var elemListForconcatinationlist = baseNode.SelectNodes(XPathConfig);

                                            for (int j = 0; j < elemListForconcatinationlist.Count; j++)
                                            {
                                                Console.WriteLine(elemListForconcatinationlist[j].InnerXml);
                                                ConcatinationUsingDifferentXPath = ConcatinationUsingDifferentXPath + " " + elemListForconcatinationlist[j].InnerXml;
                                            }
                                        }
                                        
                                        htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, ConcatinationUsingDifferentXPath);
                                    }
                                    else if (!string.IsNullOrEmpty(XPathConnfig.GetXPathUsingIdentifier))
                                    {
                                        bool validator = false;
                                        var elemListForconcatinationlist = elemList.ChildNodes;
                                        for (int j = 0; j < elemListForconcatinationlist.Count; j++)
                                        {
                                            if (validator == true)
                                            {
                                                if (identifierOneStepHead == false)
                                                {
                                                    htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, elemListForconcatinationlist[j]?.InnerXml == null ? "" : elemListForconcatinationlist[j]?.InnerXml);
                                                    Console.WriteLine(elemListForconcatinationlist[j]?.InnerXml);
                                                    break;
                                                }
                                                else if (identifierOneStepHead == true)
                                                {
                                                    identifierOneStepHead = false;
                                                }
                                                
                                            }
                                            if (elemListForconcatinationlist[j]?.InnerXml == XPathConnfig.GetXPathUsingIdentifier)
                                            {
                                                validator = true;
                                            }

                                        }
                                        if (!validator)
                                        {
                                            htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, XPathConnfig.DefaultValue);
                                        }
                                    }

                                }


                            }
                            else if (elemList == null || XPathConnfig.ShowInLastLineItem == true)
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

                        string node = "";
                        bool isPreferedXpath = false;
                        dynamic elemListXpathValidator = null;
                        if (listEdiXpath.XPathConnfig.PreferedXpaths != null)
                        {
                            foreach (var preferedXpath in listEdiXpath.XPathConnfig.PreferedXpaths)
                            {
                                if (string.IsNullOrEmpty(preferedXpath.Identifier))
                                {
                                     elemListXpathValidator = doc.SelectNodes(preferedXpath.XPath)[i];
                                    if (elemListXpathValidator != null)
                                    {
                                        listEdiXpath.XPathConnfig.XPath = preferedXpath.XPath;
                                        listEdiXpath.XPathConnfig.GetXPathUsingIdentifier = "";
                                        node = !string.IsNullOrEmpty(preferedXpath.TotalNodes) && !string.IsNullOrEmpty(preferedXpath.SelectedNode) ? (Convert.ToInt32(preferedXpath.TotalNodes) * (i + 1) - Convert.ToInt32(preferedXpath.SelectedNode)).ToString() : "";
                                        isPreferedXpath = true;
                                        break;
                                    }
                                }
                                else
                                {
                                     elemListXpathValidator = doc.SelectNodes(preferedXpath.XPath)[i];
                                    if (elemListXpathValidator != null && elemListXpathValidator.InnerText.Contains(preferedXpath.Identifier))
                                    {
                                        listEdiXpath.XPathConnfig.XPath = preferedXpath.XPath;
                                        listEdiXpath.XPathConnfig.GetXPathUsingIdentifier = preferedXpath.Identifier;
                                        node = !string.IsNullOrEmpty(preferedXpath.TotalNodes) && !string.IsNullOrEmpty(preferedXpath.SelectedNode) ? (Convert.ToInt32(preferedXpath.TotalNodes) * (i + 1) - Convert.ToInt32(preferedXpath.SelectedNode)).ToString() : "";
                                        isPreferedXpath = true;
                                        break;
                                    }
                                }
                            }
                        }

                        bool identifierOneStepHead = listEdiXpath.XPathConnfig.GetXPathUsingIdentifierOneStepHead;
                        Console.WriteLine(!string.IsNullOrEmpty(node) || elemListXpathValidator == null ? elemList[i].InnerXml : elemListXpathValidator?.InnerXml);
                        if (!listEdiXPathValues.Any(z => z.Item2 == (!string.IsNullOrEmpty(node) || elemListXpathValidator == null ? elemList[i].InnerXml : elemListXpathValidator?.InnerXml) && z.Item1 == listEdiXpath.XPathConnfig.PlaceHolder))
                        {
                            if (listEdiXpath.XPathConnfig.MappingRequired == false && listEdiXpath.XPathConnfig.DateFormat == null && listEdiXpath.XPathConnfig.TimeFormat == null && listEdiXpath.XPathConnfig.ConcatinationUsingSameXPath == false && string.IsNullOrEmpty(listEdiXpath.XPathConnfig.GetXPathUsingIdentifier) && listEdiXpath.XPathConnfig.ConcatinationUsingDifferentXPath == null)
                            {
                                listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, !string.IsNullOrEmpty(node) || elemListXpathValidator == null ? elemList[i].InnerXml : elemListXpathValidator?.InnerXml));
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
                                        var parsedDate = DateTime.ParseExact(!string.IsNullOrEmpty(node) || elemListXpathValidator == null ? elemList[i].InnerXml : elemListXpathValidator?.InnerXml, listEdiXpath.XPathConnfig.DateFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(listEdiXpath.XPathConnfig.DateFormat.TargetFormat);
                                        listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, parsedDate));
                                    }
                                    catch (Exception ex)
                                    {

                                        listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, !string.IsNullOrEmpty(node) || elemListXpathValidator == null ? elemList[i].InnerXml : elemListXpathValidator?.InnerXml));
                                    }
                                    
                                }
                                else if (listEdiXpath.XPathConnfig.TimeFormat != null)
                                {
                                    try
                                    {
                                        var parsedTime = DateTime.ParseExact(!string.IsNullOrEmpty(node) || elemListXpathValidator == null ? elemList[i].InnerXml : elemListXpathValidator?.InnerXml, listEdiXpath.XPathConnfig.TimeFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(listEdiXpath.XPathConnfig.TimeFormat.TargetFormat);
                                        listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, parsedTime));
                                    }
                                    catch (Exception ex)
                                    {

                                        listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, !string.IsNullOrEmpty(node) || elemListXpathValidator == null ? elemList[i].InnerXml : elemListXpathValidator?.InnerXml));
                                    }
                                }
                                else if (listEdiXpath.XPathConnfig.ConcatinationUsingSameXPath == true)
                                {
                                    var elemListForconcatinationlist = doc.SelectNodes(listEdiXpath.XPathConnfig.XPath);
                                    string ConcatinationUsingSameXPath = "";
                                    for (int j = 0; j < elemListForconcatinationlist.Count; j++)
                                    {
                                        Console.WriteLine(elemListForconcatinationlist[j].InnerXml);
                                        ConcatinationUsingSameXPath = ConcatinationUsingSameXPath + " " + elemListForconcatinationlist[j].InnerXml;
                                    }
                                    listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, ConcatinationUsingSameXPath));
                                }
                                else if (!string.IsNullOrEmpty(listEdiXpath.XPathConnfig.GetXPathUsingIdentifier))
                                {
                                    bool validator = false;
                                    var elemListForconcatinationlist = elemList[i].ChildNodes;
                                    for (int j = 0; j < elemListForconcatinationlist.Count; j++)
                                    {
                                        if (validator == true)
                                        {
                                            if (identifierOneStepHead == false)
                                            {
                                                listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, elemListForconcatinationlist[j]?.InnerXml == null ? "" : elemListForconcatinationlist[j]?.InnerXml));
                                                Console.WriteLine(elemListForconcatinationlist[j]?.InnerXml);
                                                break;
                                            }
                                            else if (identifierOneStepHead == true)
                                            {
                                                identifierOneStepHead = false;
                                            }

                                        }
                                        if (elemListForconcatinationlist[j]?.InnerXml == listEdiXpath.XPathConnfig.GetXPathUsingIdentifier)
                                        {
                                            validator = true;
                                        }

                                    }
                                    if (!validator)
                                    {
                                        listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, listEdiXpath.XPathConnfig.DefaultValue));
                                    }
                                }
                                else if (listEdiXpath.XPathConnfig != null && listEdiXpath.XPathConnfig.ConcatinationUsingDifferentXPath != null && listEdiXpath.XPathConnfig.ConcatinationUsingDifferentXPath.Any())
                                {
                                    string ConcatinationUsingDifferentXPath = "";
                                    foreach (string XPathConfigP in listEdiXpath?.XPathConnfig?.ConcatinationUsingDifferentXPath)
                                    {
                                        var elemListForconcatinationlist = doc.SelectNodes(XPathConfigP);

                                        for (int j = 0; j < elemListForconcatinationlist.Count; j++)
                                        {
                                            Console.WriteLine(elemListForconcatinationlist[j].InnerXml);
                                            ConcatinationUsingDifferentXPath = ConcatinationUsingDifferentXPath + " " + elemListForconcatinationlist[j].InnerXml;
                                        }
                                    }

                                    listEdiXPathValues.Add(Tuple.Create(listEdiXpath.XPathConnfig.PlaceHolder, ConcatinationUsingDifferentXPath));
                                }
                            }

                        }

                        if (isPreferedXpath = true)
                        {
                        break;
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
