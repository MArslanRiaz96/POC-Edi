using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;

namespace POC
{
    public static class XPathHelper
    {
        public static string htmlArray = "";
        public static void XPathMapper(HumanReadableConfiguration humanReadableConfiguration, List<HumanReadableConfigurationMapping> mappings)
        {
            var listEdiXPathValues = new List<Tuple<string, string>>();
            var childEdiXPathValues = new List<Tuple<string, string>>();
            var listPlaceHolderForCalculation = new List<Tuple<string, double>>();
            XmlDocument doc = new XmlDocument();
            doc.Load(humanReadableConfiguration.PackingPath);

            foreach (var listEdiXpath in humanReadableConfiguration.configurations)
            {
                if (listEdiXpath.LineLevel != null)
                {
                    XmlNodeList baseNodes = doc.SelectNodes(listEdiXpath.LineLevel.LineLevelXPath);
                    int i = 0;
                    int n = 0;

                    //// Check if the XPath is "//HLLoop1[position()>1]"
                    //if (listEdiXpath.LineLevel.LineLevelXPath == "//HLLoop1[position()>1]")
                    //{
                    //    i++; // Increment i by 1 for each iteration
                    //}

                    //if (listEdiXpath.LineLevel.LineLevelXPath == "//HLLoop1/HL[HL03 = '36']")
                    //{
                    //    // You may want to use a node-specific logic here.
                    //    // Increment i based on a condition or just increment after each iteration
                    //    i++;
                    //}
                    //int index = 0;
                    
                    foreach (XmlNode baseNode in baseNodes)
                    {
                        //int currentIndex = 0;
                        //bool isDetermined = false;
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

                            ////var elemList = baseNode.SelectNodes(XPathConnfig.XPath)[!string.IsNullOrEmpty(node) ? Convert.ToInt32(node) : i];
                            //XmlNode elemList = null;
                            //var allNodes = baseNode.SelectNodes(XPathConnfig.XPath);
                            //if (!isDetermined)
                            //{
                            //    for (int z = index; z < baseNodes.Count; z++)
                            //    {
                            //        var element = baseNode.SelectNodes(XPathConnfig.XPath)[z];
                            //        XmlNode hl03Node = element;
                            //        if (hl03Node != null && hl03Node.InnerText == "35")
                            //        {
                            //            currentIndex = z;
                            //            isDetermined = true;
                            //            break;
                            //        }
                            //    }
                            //}


                            //var selectedNodes = baseNode.SelectNodes(XPathConnfig.XPath)[currentIndex];

                            ////if (selectedNodes != null && selectedNodes.Count > index) // Ensure there are more than 3 nodes
                            //if (selectedNodes != null) // Ensure there are more than 3 nodes
                            //{
                            //    XmlNode hl03Node = selectedNodes;
                            //    elemList = (XmlElement)selectedNodes;
                            //    htmltemplate = htmltemplate.Replace(XPathConnfig.PlaceHolder, elemList.InnerText);
                            //    //bool found = false;
                            //    //for (int idx = index; idx < selectedNodes.Count; idx++) // Start from index 3 (4th node)
                            //    //{
                            //    //    XmlNode item = selectedNodes[idx];

                            //    //    // Check if the HL03 element has the required value "35"
                            //    //    //XmlNode hl03Node = baseNode.SelectSingleNode("HL03");
                            //    //    XmlNode hl03Node = selectedNodes;
                            //    //    if (hl03Node != null && hl03Node.InnerText == "35")
                            //    //    {
                            //    //        elemList = (XmlElement)item;
                            //    //        found = true;
                            //    //        // Process the element that meets the condition
                            //    //        htmltemplate = htmltemplate.Replace(XPathConnfig.PlaceHolder, item.InnerText);
                            //    //        break; // Exit the loop once the condition is met
                            //    //    }
                            //    //    //index++;

                            //    //}

                            //}
                            //else
                            //{
                            //    // Use relative XPath, scoped to the current baseNode
                            //    var scopedXPath = "." + XPathConnfig.XPath;

                            //    // Get all matching nodes within the current baseNode context
                            //    var scopeSelectedNodes = baseNode.SelectNodes(scopedXPath);

                            //    // Check if the XPath exists and nodes are returned
                            //    if (scopeSelectedNodes != null && scopeSelectedNodes.Count > 0)
                            //    {
                            //        elemList = scopeSelectedNodes[0];
                            //    }
                            //    else
                            //    {
                            //        // If no nodes are found, replace the placeholder with an empty string
                            //        htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, string.Empty);
                            //        continue;
                            //    }
                            //}

                            //// Further processing of elemList, replacing placeholders in the template
                            //if (elemList != null)
                            //{
                            //    htmltemplate = htmltemplate.Replace(XPathConnfig.PlaceHolder, elemList.InnerText);
                            //}

                            //var elemList = baseNode.SelectNodes(XPathConnfig.XPath)[!string.IsNullOrEmpty(node) ? Convert.ToInt32(node) : i];

                            XmlNode elemList = null;
                            if (humanReadableConfiguration.TemplateSetCode == 816)
                            {
                                // Scope the XPath to the current baseNode context
                                var scopedXPath = "." + XPathConnfig.XPath; // Use relative XPath, starting with '.'

                                // Get all matching nodes for the current baseNode only
                                var selectedNodes = baseNode.SelectNodes(scopedXPath);

                                // Check if the XPath exists and nodes are returned
                                if (selectedNodes != null && selectedNodes.Count > 0)
                                {
                                    elemList = selectedNodes[0];
                                }
                                else
                                {
                                    // If no nodes are found, handle it (skip this baseNode or insert a placeholder)
                                    htmltemplate = Regex.Replace(htmltemplate, XPathConnfig.PlaceHolder, string.Empty);
                                    continue;
                                }
                            }
                            else
                            {
                                elemList = baseNode.SelectNodes(XPathConnfig.XPath)[!string.IsNullOrEmpty(node) ? Convert.ToInt32(node) : i];
                            }

                            if (elemList == null && XPathConnfig.AllowNodeSameRepetation)
                            {
                                elemList = baseNode.SelectNodes(XPathConnfig.XPath)[0];
                            }

                            if ((XPathConnfig.ShowInLastLineItem == true && baseNodes.Count == i + 1) || (XPathConnfig.ShowInLastLineItem == false && elemList != null) || (XPathConnfig.ShowInLastLineItem == false && XPathConnfig.MutiplcationUsingXPath != null) || (XPathConnfig.ShowInLastLineItem == false && !string.IsNullOrEmpty(XPathConnfig.GetXPathUsingIdentifier) || (XPathConnfig.ShowInLastLineItem == false && XPathConnfig.ConcatinationUsingDifferentXPath != null)))
                            {
                                if (XPathConnfig.IsIdentityMarker && listEdiXpath.LineLevel.IsChildLineLevel)
                                {
                                    htmltemplate = Regex.Replace(htmltemplate, listEdiXpath.LineLevel.ChildLineLevel.PlaceHolder, $"{listEdiXpath.LineLevel.ChildLineLevel.PlaceHolder}-{elemList.InnerXml}");
                                }
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
                                                var elemListForMultiplication = baseNode.SelectNodes(Xpath)[i];
                                                XpathValues.Add(Convert.ToDouble(elemListForMultiplication.InnerXml));

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

                        if (listEdiXpath.LineLevel.IsChildLineLevel)
                        {
                            var childHtmlTemplate = listEdiXpath.LineLevel?.ChildLineLevel.HTML;
                            var childTemplateTemp = listEdiXpath.LineLevel?.ChildLineLevel.HTML;
                            //var baseChildNodes = baseNode.SelectNodes(listEdiXpath.LineLevel.SecondLineLevel.LineLevelXPath);
                            var baseChildNodes = baseNode.ChildNodes;
                            string childRows = "";
                            var marker = listEdiXpath.LineLevel.XPathConnfigs.Where(x => x.IsIdentityMarker == true).FirstOrDefault();
                            var lineNode = baseNode.SelectNodes(marker.XPath)[i];
                            foreach (XmlNode childNode in baseChildNodes)
                            {
                                if (childNode.Name.Contains(listEdiXpath.LineLevel.ChildLineLevel.LineLevelXPath.Replace("//", "")))
                                {
                                    foreach (var childConfig in listEdiXpath.LineLevel.ChildLineLevel.XPathConnfigs)
                                    {
                                        var elemList = childNode.SelectNodes(childConfig.XPath)[n];
                                        if (childConfig.MappingRequired == false && childConfig.DateFormat == null
                                            && childConfig.TimeFormat == null && childConfig.MutiplcationUsingXPath == null
                                            && childConfig.ConcatinationUsingSameXPath == false && string.IsNullOrEmpty(childConfig.GetXPathUsingIdentifier))
                                        {
                                            Console.WriteLine(elemList.InnerXml);
                                            childTemplateTemp = Regex.Replace(childTemplateTemp, childConfig.PlaceHolder, elemList.InnerXml);
                                        }
                                        else
                                        {
                                            if (childConfig.MappingRequired == true)
                                            {
                                                childTemplateTemp = Regex.Replace(childTemplateTemp, childConfig.PlaceHolder,"db");
                                            }
                                            else if (childConfig.DateFormat != null)
                                            {
                                                try
                                                {
                                                    var parsedDate = DateTime.ParseExact(elemList.InnerXml, childConfig.DateFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(childConfig.DateFormat.TargetFormat);
                                                    childTemplateTemp = Regex.Replace(childTemplateTemp, childConfig.PlaceHolder, parsedDate);
                                                }
                                                catch (Exception ex)
                                                {
                                                    childTemplateTemp = Regex.Replace(childTemplateTemp, childConfig.PlaceHolder, elemList.InnerXml);
                                                }

                                            }
                                            else if (childConfig.TimeFormat != null)
                                            {
                                                try
                                                {
                                                    var parsedTime = DateTime.ParseExact(elemList.InnerXml, childConfig.TimeFormat.SourceFormat, CultureInfo.InvariantCulture).ToString(childConfig.TimeFormat.TargetFormat);
                                                    childTemplateTemp = Regex.Replace(childTemplateTemp, childConfig.PlaceHolder, parsedTime);
                                                }
                                                catch (Exception ex)
                                                {
                                                    childTemplateTemp = Regex.Replace(childTemplateTemp, childConfig.PlaceHolder, elemList.InnerXml);
                                                }
                                            }
                                        }

                                    }
                                    childRows = childRows + childTemplateTemp;
                                    childTemplateTemp = childHtmlTemplate;
                                    n++;
                                }
                            }
                            childEdiXPathValues.Add(Tuple.Create($"{listEdiXpath.LineLevel.ChildLineLevel.PlaceHolder}-{lineNode.InnerXml}", childRows));
                            childRows = string.Empty;
                        }
                        {
                            int childTable = 0;

                        }
                        htmlArray = htmlArray + htmltemplate;
                        i++;
                        //index++;
                    }

                    listEdiXPathValues.Add(Tuple.Create(listEdiXpath.LineLevel.PlaceHolder, htmlArray));
                    listEdiXPathValues.AddRange(childEdiXPathValues);
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
                else if (listEdiXpath.XPathConnfig != null && listEdiXpath.XPathConnfig.AdditionUsingPlaceHolders != null && listEdiXpath.XPathConnfig.AdditionUsingPlaceHolders.Any())
                {
                    double sum = 0;
                    foreach (var placeHolder in listEdiXpath.XPathConnfig.AdditionUsingPlaceHolders)
                    {
                        var placeHolderSum = listPlaceHolderForCalculation.Where(x => x.Item1 == placeHolder).Select(x => x.Item2).Sum();
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

            //
            html = HtmlCleanupHelper.ExecuteCleanup(html);
            //

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

        private static void ImplementationForSecondLineLevel()
        {

        }
    }
}
