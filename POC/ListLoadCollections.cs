using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC
{
    public static class ListLoadCollections
    {
        public static List<HumanReadableConfiguration> humanReadableConfigurations = new List<HumanReadableConfiguration>()
        {
            new HumanReadableConfiguration()
            {
            TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad850.html"),
            TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad850Updated.html"),
            PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_850.xml"),
            TemplateSetCode = 850,
            KDIVersion = "",
            configurations = new List<Configuration>() {
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG03", PlaceHolder = "{{BEG/BEG03}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG05", PlaceHolder = "{{BEG/BEG05}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//REF/REF02", PlaceHolder = "{{REF/REF02}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '064']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '064'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '063']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '063'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1/N104", PlaceHolder = "{{N1/N104}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = null,
                LineLevel = new LineLevel()
                {
                    HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO101}}</td>  <td width=\"50%\"><br> <b>Vendor's (Seller's) Item Number</b>: {{PO1/PO107}}<br> </td>  <td VALIGN=\"TOP\" width=\"10%\"><br>{{PO1/PO102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO103}}</td> <td VALIGN=\"TOP\" width=\"12%\"><br>{{PO1/PO104}}</td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{PO1/PO105}}</td>  <td VALIGN=\"TOP\" width=\"15%\"><br>{{PO1/PO106}}</td> </tr>",
                    LineLevelXPath = "//PO1Loop1/PO1",
                    PlaceHolder = "{{LinesHtml}}",
                    XPathConnfigs = new List<XPathConnfig>() {
                    new XPathConnfig()
                    {
                        XPath="//PO1/PO101",
                        PlaceHolder="{{PO1/PO101}}",
                        DefaultValue="",
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1/PO107",
                        PlaceHolder="{{PO1/PO107}}",
                        DefaultValue="",
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1/PO102",
                        PlaceHolder="{{PO1/PO102}}",
                        DefaultValue="",
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1/PO103",
                        PlaceHolder="{{PO1/PO103}}",
                        DefaultValue="",
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1/PO104",
                        PlaceHolder="{{PO1/PO104}}",
                        DefaultValue="",
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1/PO105",
                        PlaceHolder="{{PO1/PO105}}",
                        DefaultValue="",
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1/PO106",
                        PlaceHolder="{{PO1/PO106}}",
                        DefaultValue="",
                    }

                    }
                }
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT01", PlaceHolder = "{{CTT/CTT01}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT02", PlaceHolder = "{{CTT/CTT02}}", DefaultValue = "" },
                LineLevel = null
                }

            }
            }
        };
    }
}
