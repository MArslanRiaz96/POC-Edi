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
            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad850.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad850Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_850.xml"),
            //TemplateSetCode = 850,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG03", PlaceHolder = "{{BEG/BEG03}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG05", PlaceHolder = "{{BEG/BEG05}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//REF/REF02", PlaceHolder = "{{REF/REF02}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '064']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '064'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '063']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '063'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1/N104", PlaceHolder = "{{N1/N104}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //        HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO101}}</td>  <td width=\"50%\"><br> <b>Vendor's (Seller's) Item Number</b>: {{PO1/PO107}}<br> </td>  <td VALIGN=\"TOP\" width=\"10%\"><br>{{PO1/PO102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO103}}</td> <td VALIGN=\"TOP\" width=\"12%\"><br>{{PO1/PO104}}</td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{PO1/PO105}}</td>  <td VALIGN=\"TOP\" width=\"15%\"><br>{{PO1/PO106}}</td> </tr>",
            //        LineLevelXPath = "//PO1Loop1/PO1",
            //        PlaceHolder = "{{LinesHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1/PO101",
            //            PlaceHolder="{{PO1/PO101}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1/PO107",
            //            PlaceHolder="{{PO1/PO107}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1/PO102",
            //            PlaceHolder="{{PO1/PO102}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1/PO103",
            //            PlaceHolder="{{PO1/PO103}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1/PO104",
            //            PlaceHolder="{{PO1/PO104}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1/PO105",
            //            PlaceHolder="{{PO1/PO105}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1/PO106",
            //            PlaceHolder="{{PO1/PO106}}",
            //            DefaultValue="",
            //        }

            //        }
            //    }
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT01", PlaceHolder = "{{CTT/CTT01}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT02", PlaceHolder = "{{CTT/CTT02}}", DefaultValue = "" },
            //    LineLevel = null
            //    }

            //}
            //}
            //,new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad990.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad990Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_990.xml"),
            //TemplateSetCode = 850,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B1/B101", PlaceHolder = "{{B1/B101}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B1/B102", PlaceHolder = "{{B1/B102}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B1/B103", PlaceHolder = "{{B1/B103}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B1/B104", PlaceHolder = "{{B1/B104}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9/N901", PlaceHolder = "{{N9/N901}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9/N902", PlaceHolder = "{{N9/N902}}", DefaultValue = "" },
            //    LineLevel = null
            //    }

            //}
            //}
            //,
            new HumanReadableConfiguration()
            {
            TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad810.html"),
            TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad810Updated.html"),
            PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_810.xml"),
            TemplateSetCode = 850,
            KDIVersion = "",
            configurations = new List<Configuration>() {
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG01", PlaceHolder = "{{BIG/BIG01}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG02", PlaceHolder = "{{BIG/BIG02}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG03", PlaceHolder = "{{BIG/BIG03}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG04", PlaceHolder = "{{BIG/BIG04}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'DP']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'DP'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'IA']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'IA'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = null,
                LineLevel = new LineLevel()
                {
                   HTML = "<tr> <td border=\"0\" width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (Assigned by Buyer or Buyer's Agent: {{N1/N103}})</td> </tr>",
                    LineLevelXPath = "//N1Loop1/N1",
                    PlaceHolder = "{{ShipHtml}}",
                    XPathConnfigs = new List<XPathConnfig>() {
                    new XPathConnfig()
                    {
                        XPath="//N1/N103",
                        PlaceHolder="{{N1/N103}}",
                        DefaultValue="",
                    }
                    }
                },
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD01", PlaceHolder = "{{ITD/ITD01}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD02", PlaceHolder = "{{ITD/ITD02}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD03", PlaceHolder = "{{ITD/ITD03}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD04", PlaceHolder = "{{ITD/ITD04}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = null,
                LineLevel = new LineLevel()
                {
                   HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br>1</td> <td width=\"50%\"><br> <b>U.P.C. Consumer Package Code (1-5-5-1)</b>: {{IT1/IT106}}<br> </td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{IT1/IT102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{IT1/IT103}}</td> <td VALIGN=\"TOP\" width=\"12%\"><br>{{IT1/IT104}}</td> <td VALIGN=\"TOP\" width=\"15%\"><br>{{IT1/IT105}}</td> </tr> <tr> <td width=\"15\"></td> <td width=\"55%\" colspan=\"5\"> </td> </tr>",
                    LineLevelXPath = "//IT1Loop1/IT1",
                    PlaceHolder = "{{LinesHtml}}",
                    XPathConnfigs = new List<XPathConnfig>() {
                    new XPathConnfig()
                    {
                        XPath="//IT1/IT102",
                        PlaceHolder="{{IT1/IT102}}",
                        DefaultValue="",
                    },
                    new XPathConnfig()
                    {
                        XPath="//IT1/IT103",
                        PlaceHolder="{{IT1/IT103}}",
                        DefaultValue="",
                    },
                    new XPathConnfig()
                    {
                        XPath="//IT1/IT104",
                        PlaceHolder="{{IT1/IT104}}",
                        DefaultValue="",
                    },
                    new XPathConnfig()
                    {
                        XPath="//IT1/IT105",
                        PlaceHolder="{{IT1/IT105}}",
                        DefaultValue="",
                    },
                    new XPathConnfig()
                    {
                        XPath="//IT1/IT106",
                        PlaceHolder="{{IT1/IT106}}",
                        DefaultValue="",
                    }
                    }
                },
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//TDS/TDS01", PlaceHolder = "{{TDS/TDS01}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//CAD/CAD01", PlaceHolder = "{{CAD/CAD01}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//CAD/CAD02", PlaceHolder = "{{CAD/CAD02}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//CAD/CAD03", PlaceHolder = "{{CAD/CAD03}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT01", PlaceHolder = "{{CTT/CTT01}}", DefaultValue = "" },
                LineLevel = null
                }

            }
            }
        };
    }
}
