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
        //    new HumanReadableConfiguration()
        //    {
        //    TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad850.html"),
        //    TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad850Updated.html"),
        //    PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_850.xml"),
        //    TemplateSetCode = 850,
        //    KDIVersion = "",
        //    configurations = new List<Configuration>() {
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG03", PlaceHolder = "{{BEG/BEG03}}", DefaultValue = "" },
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG05", PlaceHolder = "{{BEG/BEG05}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG02", PlaceHolder = "{{BEG/BEG02}}", DefaultValue = "", MappingRequired = true},
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG01", PlaceHolder = "{{BEG/BEG01}}", DefaultValue = "", MappingRequired= true},
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//REF/REF02", PlaceHolder = "{{REF/REF02}}", DefaultValue = "" },
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//CSH/CSH01", PlaceHolder = "{{CSH/CSH01}}", DefaultValue = "" , MappingRequired= true},
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '064']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '064'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '063']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '063'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'ST'}}", DefaultValue = "" , MappingRequired= true},
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'ST'}}", DefaultValue = "" },
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT01", PlaceHolder = "{{CTT/CTT01}}", DefaultValue = "" },
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT02", PlaceHolder = "{{CTT/CTT02}}", DefaultValue = "" },
        //        LineLevel = null
        //        },
        //        new Configuration()
        //        {
        //        XPathConnfig = null,
        //        LineLevel = new LineLevel()
        //        {
        //            HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO101}}</td>  <td width=\"50%\"><br> <b>Vendor's (Seller's) Item Number</b>: {{PO1/PO107}}<br> </td>  <td VALIGN=\"TOP\" width=\"10%\"><br>{{PO1/PO102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO103}}</td> <td VALIGN=\"TOP\" width=\"12%\"><br>{{PO1/PO104}}</td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{PO1/PO105}}</td>  <td VALIGN=\"TOP\" width=\"15%\"><br>{{PO1/PO106}}</td> </tr>",
        //            LineLevelXPath = "//PO1Loop1/PO1",
        //            PlaceHolder = "{{LinesHtml}}",
        //            XPathConnfigs = new List<XPathConnfig>() {
        //            new XPathConnfig()
        //            {
        //                XPath="//PO1/PO101",
        //                PlaceHolder="{{PO1/PO101}}",
        //                DefaultValue="",
        //            },
        //            new XPathConnfig()
        //            {
        //                XPath="//PO1/PO107",
        //                PlaceHolder="{{PO1/PO107}}",
        //                DefaultValue="",
        //            },
        //            new XPathConnfig()
        //            {
        //                XPath="//PO1/PO102",
        //                PlaceHolder="{{PO1/PO102}}",
        //                DefaultValue="",
        //            },
        //            new XPathConnfig()
        //            {
        //                XPath="//PO1/PO103",
        //                PlaceHolder="{{PO1/PO103}}",
        //                DefaultValue="",
        //            },
        //            new XPathConnfig()
        //            {
        //                XPath="//PO1/PO104",
        //                PlaceHolder="{{PO1/PO104}}",
        //                DefaultValue="",
        //            },
        //            new XPathConnfig()
        //            {
        //                XPath="//PO1/PO105",
        //                PlaceHolder="{{PO1/PO105}}",
        //                DefaultValue="",
        //                MappingRequired= true
        //            },
        //            new XPathConnfig()
        //            {
        //                XPath="//PO1/PO106",
        //                PlaceHolder="{{PO1/PO106}}",
        //                DefaultValue="",
        //                MutiplcationUsingXPath = new List<string>()
        //                {
        //                    "//PO1Loop1/PO1/PO102",
        //                    "//PO1Loop1/PO1/PO104"
        //                }
        //            }

        //            }
        //        }
        //        }
        //    }
        //},
           // new HumanReadableConfiguration()
           //{
           // TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad990.html"),
           // TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad990Updated.html"),
           // PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_990.xml"),
           // TemplateSetCode = 990,
           // KDIVersion = "",
           // configurations = new List<Configuration>() {
           //     new Configuration()
           //     {
           //     XPathConnfig = new XPathConnfig() { XPath = "//B1/B101", PlaceHolder = "{{B1/B101}}", DefaultValue = "" },
           //     LineLevel = null
           //     },
           //     new Configuration()
           //     {
           //     XPathConnfig = new XPathConnfig() { XPath = "//B1/B102", PlaceHolder = "{{B1/B102}}", DefaultValue = "" },
           //     LineLevel = null
           //     },
           //     new Configuration()
           //     {
           //     XPathConnfig = new XPathConnfig() { XPath = "//B1/B103", PlaceHolder = "{{B1/B103}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
           //     LineLevel = null
           //     },
           //     new Configuration()
           //     {
           //     XPathConnfig = new XPathConnfig() { XPath = "//B1/B104", PlaceHolder = "{{B1/B104}}", DefaultValue = "" ,  MappingRequired= true},
           //     LineLevel = null
           //     },
           //     new Configuration()
           //     {
           //     XPathConnfig = new XPathConnfig() { XPath = "//N9/N901", PlaceHolder = "{{N9/N901}}", DefaultValue = "", MappingRequired = true },
           //     LineLevel = null
           //     },
           //     new Configuration()
           //     {
           //     XPathConnfig = new XPathConnfig() { XPath = "//N9/N902", PlaceHolder = "{{N9/N902}}", DefaultValue = "" },
           //     LineLevel = null
           //     }

           // }
           // }
           // ,
            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad810.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad810Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_810.xml"),
            //TemplateSetCode = 810,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG01", PlaceHolder = "{{BIG/BIG01}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG02", PlaceHolder = "{{BIG/BIG02}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG03", PlaceHolder = "{{BIG/BIG03}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG04", PlaceHolder = "{{BIG/BIG04}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'DP']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'DP'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'IA']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'IA'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<tr> <td border=\"0\" width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ({{N1/N103}}: {{N1/N104}})</td> </tr>",
            //        LineLevelXPath = "//N1Loop1/N1",
            //        PlaceHolder = "{{ShipHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//N1/N103",
            //            PlaceHolder="{{N1/N103}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//N1/N104",
            //            PlaceHolder="{{N1/N104}}",
            //            DefaultValue="",
            //        }
            //        }
            //    },
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD01", PlaceHolder = "{{ITD/ITD01}}", DefaultValue = "" , MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD02", PlaceHolder = "{{ITD/ITD02}}", DefaultValue = "" , MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD05", PlaceHolder = "{{ITD/ITD05}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD07", PlaceHolder = "{{ITD/ITD07}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br>{{IT1/IT101}}</td> <td width=\"50%\"><br> <b>U.P.C. Consumer Package Code (1-5-5-1)</b>: {{IT1/IT107}}<br> </td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{IT1/IT102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{IT1/IT103}}</td> <td VALIGN=\"TOP\" width=\"12%\"><br>{{IT1/IT104}}</td> <td VALIGN=\"TOP\" width=\"15%\"><br>{{IT1/IT105}}</td> </tr> <tr> <td width=\"15\"></td> <td width=\"55%\" colspan=\"5\"> </td> </tr>",
            //        LineLevelXPath = "//IT1Loop1/IT1",
            //        PlaceHolder = "{{LinesHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//IT1/IT101",
            //            PlaceHolder="{{IT1/IT101}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//IT1/IT102",
            //            PlaceHolder="{{IT1/IT102}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//IT1/IT103",
            //            PlaceHolder="{{IT1/IT103}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//IT1/IT104",
            //            PlaceHolder="{{IT1/IT104}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//IT1/IT105",
            //            PlaceHolder="{{IT1/IT105}}",
            //            DefaultValue="",
            //            MutiplcationUsingXPath= new List<string>()
            //            {
            //                "//IT1/IT102",
            //                "//IT1/IT104"
            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//IT1/IT107",
            //            PlaceHolder="{{IT1/IT107}}",
            //            DefaultValue="",
            //        }
            //        }
            //    },
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { PlaceHolder = "{{TDS/TDS01}}", DefaultValue = "" , AdditionUsingPlaceHolders =  new List<string>() { "{{IT1/IT105}}" } } ,
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CAD/CAD05", PlaceHolder = "{{CAD/CAD05}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CAD/CAD07", PlaceHolder = "{{CAD/CAD07}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CAD/CAD08", PlaceHolder = "{{CAD/CAD08}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT01", PlaceHolder = "{{CTT/CTT01}}", DefaultValue = "" },
            //    LineLevel = null
            //    }

            //}
            //}
            //,
            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad856.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad856Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_856.xml"),
            //TemplateSetCode = 856,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BSN/BSN01", PlaceHolder = "{{BSN/BSN01}}", DefaultValue = "" , MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BSN/BSN02", PlaceHolder = "{{BSN/BSN02}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BSN/BSN03", PlaceHolder = "{{BSN/BSN03}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BSN/BSN04", PlaceHolder = "{{BSN/BSN04}}", DefaultValue = "" , TimeFormat= new TimeFormat() { SourceFormat = "HHmmss",TargetFormat = "hh:mm:ss tt"}},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BSN/BSN05", PlaceHolder = "{{BSN/BSN05}}", DefaultValue = "" , MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[TD1[HL03 = 'S']]/TD1/TD102", PlaceHolder = "{{TD1/TD101-HL03 = 'S'}}", DefaultValue = "" , MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/TD1/TD102", PlaceHolder = "{{TD1/TD102-HL03 = 'S'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/TD1/TD106", PlaceHolder = "{{TD1/TD106-HL03 = 'S'}}", DefaultValue = "" , MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/TD1/TD107", PlaceHolder = "{{TD1/TD107-HL03 = 'S'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "/HLLoop1[HL[HL03 = 'S']]/TD1/TD108", PlaceHolder = "{{TD1/TD108-HL03 = 'S'}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/TD5/TD502", PlaceHolder = "{{TD5/TD502-HL03 = 'S'}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/TD5/TD503", PlaceHolder = "{{TD5/TD503-HL03 = 'S'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/TD5/TD504", PlaceHolder = "{{TD5/TD504-HL03 = 'S'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/REF[REF01 = 'CN']/REF/REF02", PlaceHolder = "{{REF/REF02-HL03 = 'S'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/REF[REF01 = 'BM']/REF/REF02", PlaceHolder = "{{REF/REF02-HL03 = 'S'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/DTM[DTM01 = '011']/DTM/DTM02", PlaceHolder = "{{DTM/DTM02-HL03 = 'S'}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'SH']]/N1/N102", PlaceHolder = "{{N1/N102-HL03 = 'S'-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'SH']]/N3/N301", PlaceHolder = "{{N3/N301-HL03 = 'S'-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'SH']]/N4/N401", PlaceHolder = "{{N4/N401-HL03 = 'S'-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'SH']]/N4/N402", PlaceHolder = "{{N4/N402-HL03 = 'S'-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'SH']]/N4/N403", PlaceHolder = "{{N4/N403-HL03 = 'S'-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'OB']]/N1/N102", PlaceHolder = "{{N1/N102-HL03 = 'S'-N101 = 'OB'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'OB']]/N3/N301", PlaceHolder = "{{N3/N301-HL03 = 'S'-N101 = 'OB'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'OB']]/N4/N401", PlaceHolder = "{{N4/N401-HL03 = 'S'-N101 = 'OB'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'OB']]/N4/N402", PlaceHolder = "{{N4/N402-HL03 = 'S'-N101 = 'OB'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'OB']]/N4/N403", PlaceHolder = "{{N4/N403-HL03 = 'S'-N101 = 'OB'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'OB']]/N4/N405", PlaceHolder = "{{N4/N405-HL03 = 'S'-N101 = 'OB'}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'OB']]/N4/N406", PlaceHolder = "{{N4/N406-HL03 = 'S'-N101 = 'OB'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'SF']]/N1/N102", PlaceHolder = "{{N1/N102-HL03 = 'S'-N101 = 'SF'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'SF']]/N4/N401", PlaceHolder = "{{N3/N301-HL03 = 'S'-N101 = 'SF'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'SF']]/N4/N401", PlaceHolder = "{{N4/N401-HL03 = 'S'-N101 = 'SF'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'SF']]/N4/N402", PlaceHolder = "{{N4/N402-HL03 = 'S'-N101 = 'SF'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'S']]/N1Loop1[N1[N101 = 'SF']]/N4/N403", PlaceHolder = "{{N4/N403-HL03 = 'S'-N101 = 'SF'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'O']]/PRF/PRF01", PlaceHolder = "{{PRF/PRF01}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1[HL[HL03 = 'O']]/PRF/PRF04", PlaceHolder = "{{PRF/PRF04}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table cellpadding=\"0\" border=\"0\" width=\"100%\"> <tr> <td width=\"638\" valign=\"top\" class=\"sectiontitle\" style=\"border: 2px; border-style: solid; border-color: DarkGray; background-color:LightGrey; padding: 2pt; color: Black\">Item Level Information</td> </tr> </table> </center></div> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td> <b>Part Numbers</b> </td></tr></table> <table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\"   background=\"res://VistaRes.Dll/legalpad.gif\"> <TR><TD WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vendor's (Seller's) Part Number</TD><TD BGCOLOR=\"#FFFFFF\">{{LIN/LIN03}}</TD></TR> <TR><TD WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;UCC - 12</TD><TD BGCOLOR=\"#FFFFFF\">{{LIN/LIN05}}</TD></TR> </TR> </table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Item Detail (Shipment): </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assigned Identification : {{SN1/SN101}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Number of Units Shipped : {{SN1/SN102}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code : {{SN1/SN103}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Item Physical Details: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pack : {{PO4/PO401}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Size : {{PO4/PO402}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code : {{PO4/PO403}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\"> <tr> <td width=\"1%\" valign=\"top\"> </td> <td width = \"99%\"><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Product/Item Description: </b></td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> </b>{{PID/PID05}}<br>    </td></tr> </table></td></tr></table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table>",
            //        LineLevelXPath = "//HLLoop1[PO4]",
            //        PlaceHolder = "{{ItemLevelHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//HLLoop1[PO4]//LIN/LIN03",
            //            PlaceHolder="{{LIN/LIN03}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//HLLoop1[PO4]//LIN/LIN05",
            //            PlaceHolder="{{LIN/LIN05}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//HLLoop1[PO4]//SN1/SN101",
            //            PlaceHolder="{{SN1/SN101}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//HLLoop1[PO4]//SN1/SN102",
            //            PlaceHolder="{{SN1/SN102}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//HLLoop1[PO4]//SN1/SN103",
            //            PlaceHolder="{{SN1/SN103}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//HLLoop1[PO4]//PO4/PO401",
            //            PlaceHolder="{{PO4/PO401}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//HLLoop1[PO4]//PO4/PO402",
            //            PlaceHolder="{{PO4/PO402}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//HLLoop1[PO4]//PO4/PO403",
            //            PlaceHolder="{{PO4/PO403}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//HLLoop1[PO4]//PID/PID05",
            //            PlaceHolder="{{PID/PID05}}",
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
            //,
            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad214.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad214Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_214.xml"),
            //TemplateSetCode = 214,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B10/B1001", PlaceHolder = "{{B10/B1001}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B10/B1002", PlaceHolder = "{{B10/B1002}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B10/B1003", PlaceHolder = "{{B10/B1003}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1[N101 = 'SH']/N102", PlaceHolder = "{{N1/N102-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1[N101 = 'SH']/N104", PlaceHolder = "{{N1/N104-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N3/N302", PlaceHolder = "{{N3/N302-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N4/N404", PlaceHolder = "{{N4/N404-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1[N101 = 'CN']/N102", PlaceHolder = "{{N1/N102-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1[N101 = 'CN']/N104", PlaceHolder = "{{N1/N104-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1[N101 = 'CN']/N104", PlaceHolder = "{{N1/N104-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N3/N302", PlaceHolder = "{{N3/N302-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N4/N404", PlaceHolder = "{{N4/N404-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Shipment Status Details: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Shipment Status Code : {{AT7/AT701}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Shipment Status or Appointment Reason Code : {{AT7/AT702}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Date : {{AT7/AT705}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Time : {{AT7/AT706}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Time Code : {{AT7/AT707}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Equipment, Shipment, or Real Property Location: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;City Name : {{MS1/MS101}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;State or Province Code : {{MS1/MS102}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Country Code : {{MS1/MS103}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Equipment or Container Owner and Type: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Standard Carrier Alpha Code : {{MS2/MS201}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Equipment Number : {{MS2/MS202}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Business Instructions and Reference Number: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification : {{L11/L1101}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification Qualifier : {{L11/L1102}} </td></tr> </table><br>",
            //        LineLevelXPath = "//AT7Loop1[AT7]",
            //        PlaceHolder = "{{ShipmentDetailHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//AT7/AT701",
            //            PlaceHolder="{{AT7/AT701}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//AT7/AT702",
            //            PlaceHolder="{{AT7/AT702}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//AT7/AT705",
            //            PlaceHolder="{{AT7/AT705}}",
            //            DefaultValue="",
            //            DateFormat = new DateFormat()
            //            {
            //                 SourceFormat = "yyyyMMdd",
            //                 TargetFormat = "MM/dd/yyyy"
            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//AT7/AT706",
            //            PlaceHolder="{{AT7/AT706}}",
            //            DefaultValue="",
            //            TimeFormat = new TimeFormat()
            //            {
            //                 SourceFormat = "HHmm",
            //                 TargetFormat = "hh:mm tt"
            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//AT7/AT707",
            //            PlaceHolder="{{AT7/AT707}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//MS1/MS101",
            //            PlaceHolder="{{MS1/MS101}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//MS1/MS102",
            //            PlaceHolder="{{MS1/MS102}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//MS1/MS103",
            //            PlaceHolder="{{MS1/MS103}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//MS2/MS201",
            //            PlaceHolder="{{MS2/MS201}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//MS2/MS202",
            //            PlaceHolder="{{MS2/MS202}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//..//L11/L1101",
            //            PlaceHolder="{{L11/L1101}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//AT7Loop1[AT7]//..//L11/L1102",
            //            PlaceHolder="{{L11/L1102}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        }
            //        }
            //    }
            //    }
            //}

            //},

            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad855.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad855Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_855.xml"),
            //TemplateSetCode = 855,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BAK/BAK01", PlaceHolder = "{{BAK/BAK01}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BAK/BAK02", PlaceHolder = "{{BAK/BAK02}}", DefaultValue = "", MappingRequired = true  },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BAK/BAK03", PlaceHolder = "{{BAK/BAK03}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BAK/BAK04", PlaceHolder = "{{BAK/BAK04}}", DefaultValue = "" , DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD505", PlaceHolder = "{{TD5/TD505}}", DefaultValue = "", MappingRequired = true  },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'ST'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'ST'}}", DefaultValue = "" , MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'ST'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SF']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'SF'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SF']]/N4/N401", PlaceHolder = "{{N4/N401-N401 = 'SF'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SF']]/N4/N402", PlaceHolder = "{{N4/N402-N401 = 'SF'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SF']]/N4/N403", PlaceHolder = "{{N4/N403-N401 = 'SF'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br></td> <td width=\"50%\"><br> <b>U.P.C./EAN Shipping Container Code (1-2-5-5-1)</b>: {{PO1/PO107}}<br> </td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{PO1/PO102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO103}}</td> <td VALIGN=\"TOP\" width=\"12%\"><br>{{PO1/PO104}}</td> <td VALIGN=\"TOP\" width=\"15%\"><br>{{PO1/PO105}}</td> </tr> <tr> <td width=\"15\"></td> <td width=\"55%\" colspan=\"5\"> <br><b>Line Item Description</b> <table border=\"0\" width=\"100%\" background=\"res://VistaRes.Dll/legalpad.gif\" cellspacing=\"1\" cellpadding=\"0\"  doDocumentonClick()> <tr> <td></td> <td align=\"left\" width=\"90%\"> </b> {{PID/PID05}}<br> </td> </tr> </table> </div> </td> </tr>",
            //        LineLevelXPath = "//PO1Loop1[PID]",
            //        PlaceHolder = "{{LineItemHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1Loop1[PID]/PO1/PO107",
            //            PlaceHolder="{{PO1/PO107}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1Loop1[PID]/PO1/PO102",
            //            PlaceHolder="{{PO1/PO102}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1Loop1[PID]/PO1/PO103",
            //            PlaceHolder="{{PO1/PO103}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1Loop1[PID]/PO1/PO104",
            //            PlaceHolder="{{PO1/PO104}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1Loop1[PID]/PO1/PO105",
            //            PlaceHolder="{{PO1/PO105}}",
            //            DefaultValue="",
            //            MutiplcationUsingXPath = new List<string>()
            //            {
            //                "//PO1Loop1[PID]/PO1/PO102",
            //                "//PO1Loop1[PID]/PO1/PO104"
            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1Loop1[PID]/PID/PID05",
            //            PlaceHolder="{{PID/PID05}}",
            //            DefaultValue=""
            //            }
            //        }

            //    }
            //    }
            //}

            //},

            new HumanReadableConfiguration()
            {
            TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad860.html"),
            TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad860Updated.html"),
            PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_860.xml"),
            TemplateSetCode = 860,
            KDIVersion = "",
            configurations = new List<Configuration>() {
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH03", PlaceHolder = "{{BCH/BCH03}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH06", PlaceHolder = "{{BCH/BCH06}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH11", PlaceHolder = "{{BCH/BCH11}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH01", PlaceHolder = "{{BCH/BCH01}}", DefaultValue = "", MappingRequired = true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH02", PlaceHolder = "{{BCH/BCH02}}", DefaultValue = "", MappingRequired = true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'IA']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'IA'}}", DefaultValue = ""},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//FOB/FOB01", PlaceHolder = "{{FOB/FOB01}}", DefaultValue = "", MappingRequired = true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//FOB/FOB02", PlaceHolder = "{{FOB/FOB02}}", DefaultValue = "", MappingRequired = true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//FOB/FOB06", PlaceHolder = "{{FOB/FOB06}}", DefaultValue = "", MappingRequired = true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//FOB/FOB07", PlaceHolder = "{{FOB/FOB07}}", DefaultValue = ""},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD03", PlaceHolder = "{{ITD/ITD03}}", DefaultValue = ""},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD05", PlaceHolder = "{{ITD/ITD05}}", DefaultValue = ""},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD12", PlaceHolder = "{{ITD/ITD12}}", DefaultValue = ""},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '037']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '037'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '038']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '038'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '064']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '064'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD502", PlaceHolder = "{{TD5/TD502}}", DefaultValue = "", MappingRequired = true},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD503", PlaceHolder = "{{TD5/TD503}}", DefaultValue = ""},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD505", PlaceHolder = "{{TD5/TD505}}", DefaultValue = ""},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N9Loop1[N9[N901 = 'PO']]/N9/N901", PlaceHolder = "{{N9/N901-N901 = 'PO'}}", DefaultValue = "" , MappingRequired = true  },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N9Loop1[N9[N901 = 'PO']]/N9/N902", PlaceHolder = "{{N9/N902-N901 = 'PO'}}", DefaultValue = ""},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N9Loop1[N9[N901 = 'PO']]/MSG/MSG01", PlaceHolder = "{{MSG/MSG01-N901 = 'PO'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'ST'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'ST'}}", DefaultValue = "", MappingRequired = true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'ST'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'ST'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'ST'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'ST'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'ST'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//CUR/CUR02", PlaceHolder = "{{CUR/CUR02}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD01", PlaceHolder = "{{ITD/ITD01}}", DefaultValue = "", MappingRequired= true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD02", PlaceHolder = "{{ITD/ITD02}}", DefaultValue = "", MappingRequired= true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD07", PlaceHolder = "{{ITD/ITD07}}", DefaultValue = ""},
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'DP']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'DP'}}", DefaultValue = "", MappingRequired= true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = null,
                LineLevel = new LineLevel()
                {
                   HTML = "<table border=\"0\" WIDTH=\"70%\" CELLPADDING=\"0\" CELLSPACING=\"0\" HEIGHT=\"1\"> <tr> <td width=\"5%\"><b>Line</b></td> <td width=\"43%\"><b>Description</b></td> <td width=\"10%\"><b>Quan Ord</b></td> <td width=\"10%\"><b>Quan to Rec</b></td> <td width=\"3%\"><b>UI</b></td> <td width=\"11%\"><b>Price Basis</b></td> <td width=\"10%\"><b>Price($)</b></td> </tr> <tr> <td VALIGN=\"TOP\" width=\"5%\">{{POC/POC01}}</td> <td width=\"48%\"> <b>Vendor's Style Number</b>: {{POC/POC09}} <br> <b>U.P.C. Consumer Package Code (1-5-5-1)</b>: {{POC/POC10}} <br> <b>GTIN</b>:{{POC/POC12}} <br> <b>Buyer's Item Number</b>:{{POC/POC13}} <br> <b>Buyer Part </b>:{{POC/POC14}} <br> <b>VENDOR PART </b>: <br> <b>Pack </b>: {{PO4/PO401}} <br> <b>Size </b>: {{PO4/PO402}} <br> <b>Product Size </b>: {{POC/POC18}} <br> <b>Message Text </b>: {{MSG/MSG01}} <br> <b>Unit or Basis for Measurement Code </b>: {{PO4/PO403}} <br> <b>Change Type</b>: {{POC/POC02}} <br> </td> <td VALIGN=\"TOP\" width=\"10%\">{{POC/POC03}}</td> <td VALIGN=\"TOP\" width=\"10%\">{{POC/POC04}}</td> <td VALIGN=\"TOP\" width=\"3%\">{{POC/POC05}}</td> <td VALIGN=\"TOP\" width=\"6%\"></td> <td VALIGN=\"TOP\" width=\"10%\">{{POC/POC07}}</td> </tr> <tr> <td width=\"15\"></td> <td width=\"55%\" colspan=\"5\"> <br><b>     Line Item Description (Source: Product)</b> <table border=\"0\" width=\"100%\" background=\"res://VistaRes.Dll/legalpad.gif\" cellspacing=\"1\" cellpadding=\"0\" doDocumentonClick()> <tr> <td></td> <td align=\"left\" width=\"90%\"> </b>{{PID/PID05-PID01 = '75'}} <br> </td> </tr> <tr> <td></td> <td align=\"left\" width=\"90%\"> </b>{{PID/PID05-PID01 = '08'}} <br> </td> </tr> </table> </div> </td> </tr>",
                    LineLevelXPath = "//POCLoop1[POC]",
                    PlaceHolder = "{{LinedItemHtml}}",
                    XPathConnfigs = new List<XPathConnfig>() {
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC01",
                        PlaceHolder="{{POC/POC01}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC09",
                        PlaceHolder="{{POC/POC09}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC10",
                        PlaceHolder="{{POC/POC10}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC12",
                        PlaceHolder="{{POC/POC12}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC13",
                        PlaceHolder="{{POC/POC13}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC14",
                        PlaceHolder="{{POC/POC14}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC02",
                        PlaceHolder="{{POC/POC02}}",
                        DefaultValue="",
                        MappingRequired = true
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC03",
                        PlaceHolder="{{POC/POC03}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC04",
                        PlaceHolder="{{POC/POC04}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC05",
                        PlaceHolder="{{POC/POC05}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="EA",
                        PlaceHolder="{{POC/POC07}}",
                        DefaultValue="",
                        GetXPathUsingIdentifier = true
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/PIDLoop1[PID_2]/PID_2[PID02 = '75']/PID05",
                        PlaceHolder="{{PID/PID05-PID01 = '75'}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/PIDLoop1[PID_2]/PID_2[PID02 = '08']/PID05",
                        PlaceHolder="{{PID/PID05-PID01 = '08'}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/PO4/PO401",
                        PlaceHolder="{{PO4/PO401}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/PO4/PO402",
                        PlaceHolder="{{PO4/PO402}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/PO4/PO403",
                        PlaceHolder="{{PO4/PO403}}",
                        DefaultValue="",
                        MappingRequired = true
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/POC/POC18",
                        PlaceHolder="{{POC/POC18}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//POCLoop1[POC]/MSG/MSG01",
                        PlaceHolder="{{MSG/MSG01}}",
                        DefaultValue="",
                        ConcatinationUsingSameXPath = true
                    }

                }
                }
            }

            }
            }

            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad210.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad210Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_210.xml"),
            //TemplateSetCode = 210,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B3/B302", PlaceHolder = "{{B3/B302}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B3/B303", PlaceHolder = "{{B3/B303}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B3/B304", PlaceHolder = "{{B3/B304}}", DefaultValue = "", MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B3/B305", PlaceHolder = "{{B3/B305}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B3/B306", PlaceHolder = "{{B3/B306}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B3/B307", PlaceHolder = "{{B3/B307}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B3/B309", PlaceHolder = "{{B3/B309}}", DefaultValue = "",  DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B3/B310", PlaceHolder = "{{B3/B310}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B3/B311", PlaceHolder = "{{B3/B311}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B3/B312", PlaceHolder = "{{B3/B312}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//C3/C301", PlaceHolder = "{{C3/C301}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'BM']/N901", PlaceHolder = "{{N9/N901-N901 = 'BM'}}", DefaultValue = "", MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'BM']/N902", PlaceHolder = "{{N9/N902-N901 = 'BM'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'SH'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'SH'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'SH'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'SH'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'SH'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SH']]/N4/N404", PlaceHolder = "{{N4/N404-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'CN']]/N4/N404", PlaceHolder = "{{N4/N404-N101 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Rate and Charges: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Lading Line Item Number : {{L1/L101}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Freight Rate : {{L1/L102}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Rate/Value Qualifier : {{L1/L103}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Charge : {{L1/L104}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Special Charge or Allowance Code : {{L1/L108}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Special Charge Description : {{L1/L112}} </td></tr> </table><br>",
            //        LineLevelXPath = "//LXLoop1[LX]",
            //        PlaceHolder = "{{LinesHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/L1/L101",
            //            PlaceHolder="{{L1/L101}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/L1/L102",
            //            PlaceHolder="{{L1/L102}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/L1/L103",
            //            PlaceHolder="{{L1/L103}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/L1/L104",
            //            PlaceHolder="{{L1/L104}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/L1/L108",
            //            PlaceHolder="{{L1/L108}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/L1/L112",
            //            PlaceHolder="{{L1/L112}}",
            //            DefaultValue=""
            //        }

            //    }
            //    }
            //}

            //}
            //},

            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad940.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad940Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_940.xml"),
            //TemplateSetCode = 940,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W05[W0501 = 'N']/W0501", PlaceHolder = "{{W05/W0501-W0501 = 'N'}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W05[W0501 = 'N']/W0502", PlaceHolder = "{{W05/W0502-W0501 = 'N'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W05[W0501 = 'N']/W0504", PlaceHolder = "{{W05/W0504-W0501 = 'N'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W05[W0501 = 'N']/W0505", PlaceHolder = "{{W05/W0505-W0501 = 'N'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N102", PlaceHolder = "{{N1/N102-N101= 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N103", PlaceHolder = "{{N1/N103-N101= 'ST'}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N104", PlaceHolder = "{{N1/N104-N101= 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'DE']]/N1/N102", PlaceHolder = "{{N1/N102-N101= 'DE'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'DE']]/N1/N103", PlaceHolder = "{{N1/N103-N101= 'DE'}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'DE']]/N1/N104", PlaceHolder = "{{N1/N104-N101= 'DE'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'DE']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'DE'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'DE']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'DE'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'DE']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'DE'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'DE']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'DE'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'WH']]/N1/N102", PlaceHolder = "{{N1/N102-N101= 'WH'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'WH']]/N1/N103", PlaceHolder = "{{N1/N103-N101= 'WH'}}", DefaultValue = "",MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'WH']]/N1/N104", PlaceHolder = "{{N1/N104-N101= 'WH'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'WH']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'WH'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'WH']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'WH'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'WH']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'WH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'BR']/N901", PlaceHolder = "{{N9/N901-N901 = 'BR'}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'BR']/N902", PlaceHolder = "{{N9/N902-N901 = 'BR'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//NTE[NTE01 = 'WHI']/NTE02", PlaceHolder = "{{NTE/NTE02-NTE01 = 'WHI'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W66[W6601 = 'PP']/W6601", PlaceHolder = "{{W66/W6601-W6601 = 'PP'}}", DefaultValue = "" , MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W66[W6601 = 'PP']/W6602", PlaceHolder = "{{W66/W6602-W6601 = 'PP'}}", DefaultValue = "" , MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W66[W6601 = 'PP']/W6605", PlaceHolder = "{{W66/W6605-W6601 = 'PP'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W76/W7601", PlaceHolder = "{{W76/W7601}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W76/W7602", PlaceHolder = "{{W76/W7602}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W76/W7603", PlaceHolder = "{{W76/W7603}}", DefaultValue = "" , MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W76/W7604", PlaceHolder = "{{W76/W7604}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W76/W7605", PlaceHolder = "{{W76/W7605}}", DefaultValue = "" , MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Line Item Detail - Warehouse: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quantity Ordered : {{W01/W0101}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code : {{W01/W0102}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;U.P.C. Case Code : {{W01/W0103}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID Qualifier : {{W01/W0104}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID : {{W01/W0105}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID Qualifier : {{W01/W0106}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID : {{W01/W0107}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Warehouse Lot Number : {{W01/W0113}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Line Item Detail - Description: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Free-form Description : {{G69/G6901}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Reference Identification: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification Qualifier : {{N9/N901}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification : {{N9/N902}} </td></tr> </table><br>",
            //        LineLevelXPath = "//LXLoop1[LX]",
            //        PlaceHolder = "{{LinesItemHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W01Loop1/W01/W0101",
            //            PlaceHolder="{{W01/W0101}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W01Loop1/W01/W0102",
            //            PlaceHolder="{{W01/W0102}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W01Loop1/W01/W0103",
            //            PlaceHolder="{{W01/W0103}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W01Loop1/W01/W0104",
            //            PlaceHolder="{{W01/W0104}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W01Loop1/W01/W0105",
            //            PlaceHolder="{{W01/W0105}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W01Loop1/W01/W0106",
            //            PlaceHolder="{{W01/W0106}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W01Loop1/W01/W0107",
            //            PlaceHolder="{{W01/W0107}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W01Loop1/W01/W0113",
            //            PlaceHolder="{{W01/W0113}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W01Loop1/G69/G6901",
            //            PlaceHolder="{{G69/G6901}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/N9/N901",
            //            PlaceHolder="{{N9/N901}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/N9/N902",
            //            PlaceHolder="{{N9/N902}}",
            //            DefaultValue=""
            //        }

            //    }
            //    }
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Date/Time: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Date Qualifier : {{G62/G6201}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Date : {{G62/G6202}} </td></tr> </table><br>",
            //        LineLevelXPath = "//G62",
            //        PlaceHolder = "{{DateTimeHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//G62/G6201",
            //            PlaceHolder="{{G62/G6201}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//G62/G6202",
            //            PlaceHolder="{{G62/G6202}}",
            //            DefaultValue="",
            //            DateFormat = new DateFormat()
            //            {
            //                 SourceFormat = "yyyyMMdd",
            //                 TargetFormat = "MM/dd/yyyy"
            //            }

            //        }

            //    }
            //    }
            //}

            //}
            //},

            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad204.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad204Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_204.xml"),
            //TemplateSetCode = 204,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B2/B202", PlaceHolder = "{{B2/B202}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B2/B204", PlaceHolder = "{{B2/B204}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B2/B206", PlaceHolder = "{{B2/B206}}", DefaultValue = "", MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B2/B207", PlaceHolder = "{{B2/B207}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B2A/B2A01", PlaceHolder = "{{B2A/B2A01}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//B2A/B2A02", PlaceHolder = "{{B2A/B2A02}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//L11/L1101", PlaceHolder = "{{L11/L1101}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//L11/L1102", PlaceHolder = "{{L11/L1102}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G62/G6201", PlaceHolder = "{{G62/G6201}}", DefaultValue = "", MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G62/G6202", PlaceHolder = "{{G62/G6202}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G62/G6203", PlaceHolder = "{{G62/G6203}}", DefaultValue = "", MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G62/G6204", PlaceHolder = "{{G62/G6204}}", DefaultValue = "",TimeFormat= new TimeFormat() { SourceFormat = "HHmmss",TargetFormat = "hh:mm:ss tt"}},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G62/G6205", PlaceHolder = "{{G62/G6205}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//AT5/AT501", PlaceHolder = "{{AT5/AT501}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//NTE[NTE01 = 'CBH']/NTE02", PlaceHolder = "{{NTE/NTE02-NTE01 = 'CBH'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//NTE[NTE01 = 'RPT']/NTE02", PlaceHolder = "{{NTE/NTE02-NTE01 = 'RPT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N1/N102", PlaceHolder = "{{N1/N102-N101= 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N1/N103", PlaceHolder = "{{N1/N103-N101= 'BT'}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N1/N104", PlaceHolder = "{{N1/N104-N101= 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N4/N404", PlaceHolder = "{{N4/N404-N101 = 'BT'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N7Loop1/N7/N702", PlaceHolder = "{{N7/N702}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N7Loop1/N7/N711", PlaceHolder = "{{N7/N711}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N7Loop1/M7/M701", PlaceHolder = "{{M7/M701}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/S5/S501", PlaceHolder = "{{S5/S501-S501 = '1'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/S5/S502", PlaceHolder = "{{S5/S502-S501 = '1'}}", DefaultValue = "" , MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/S5/S503", PlaceHolder = "{{S5/S503-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/S5/S504", PlaceHolder = "{{S5/S504-S501 = '1'}}", DefaultValue = "",MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/S5/S505", PlaceHolder = "{{S5/S505-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/S5/S506", PlaceHolder = "{{S5/S506-S501 = '1'}}", DefaultValue = "" , MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/S5/S507", PlaceHolder = "{{S5/S507-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/S5/S508", PlaceHolder = "{{S5/S508-S501 = '1'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/N1/N102", PlaceHolder = "{{N1/N102-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/N1/N103", PlaceHolder = "{{N1/N103-S501 = '1'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/N1/N104", PlaceHolder = "{{N1/N104-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/N3/N301", PlaceHolder = "{{N3/N301-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/N4/N401", PlaceHolder = "{{N4/N401-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/N4/N402", PlaceHolder = "{{N4/N402-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/N4/N403", PlaceHolder = "{{N4/N403-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/N4/N404", PlaceHolder = "{{N4/N404-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/G61/G6101", PlaceHolder = "{{G61/G6101-S501 = '1'}}", DefaultValue = "",MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/G61/G6102", PlaceHolder = "{{G61/G6102-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/G61/G6103", PlaceHolder = "{{G61/G6103-S501 = '1'}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/N1Loop2/G61/G6104", PlaceHolder = "{{G61/G6104-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/OID/OID01", PlaceHolder = "{{OID/OID01-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/LAD/LAD01", PlaceHolder = "{{LAD/LAD01-S501 = '1'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/LAD/LAD02", PlaceHolder = "{{LAD/LAD02-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/L5/L503", PlaceHolder = "{{L5/L503-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/L5/L504", PlaceHolder = "{{L5/L504-S501 = '1'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/AT8/AT801", PlaceHolder = "{{AT8/AT801-S501 = '1'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/AT8/AT802", PlaceHolder = "{{AT8/AT802-S501 = '1'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/AT8/AT803", PlaceHolder = "{{AT8/AT803-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/AT8/AT804", PlaceHolder = "{{AT8/AT804-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/AT8/AT805", PlaceHolder = "{{AT8/AT805-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/AT8/AT806", PlaceHolder = "{{AT8/AT806-S501 = '1'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/AT8/AT807", PlaceHolder = "{{AT8/AT807-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/G61Loop2/G61/G6101", PlaceHolder = "{{G61/G6101-S501 = '1'}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/G61Loop2/G61/G6102", PlaceHolder = "{{G61/G6102-S501 = '1'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/S5/S501", PlaceHolder = "{{S5/S501-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/S5/S502", PlaceHolder = "{{S5/S502-S501 = '2'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/S5/S503", PlaceHolder = "{{S5/S503-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/S5/S504", PlaceHolder = "{{S5/S504-S501 = '2'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/S5/S505", PlaceHolder = "{{S5/S505-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/S5/S506", PlaceHolder = "{{S5/S506-S501 = '2'}}", DefaultValue = "" , MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/S5/S507", PlaceHolder = "{{S5/S507-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/S5/S508", PlaceHolder = "{{S5/S508-S501 = '2'}}", DefaultValue = "", MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/NTE/NTE02", PlaceHolder = "{{NTE/NTE02-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/N1/N102", PlaceHolder = "{{N1/N102-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/N1/N103", PlaceHolder = "{{N1/N103-S501 = '2'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/N1/N104", PlaceHolder = "{{N1/N104-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/N3/N301", PlaceHolder = "{{N3/N301-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/N4/N401", PlaceHolder = "{{N4/N401-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/N4/N402", PlaceHolder = "{{N4/N402-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/N4/N403", PlaceHolder = "{{N4/N403-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/N4/N404", PlaceHolder = "{{N4/N404-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/G61/G6101", PlaceHolder = "{{G61/G6101-S501 = '2'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/G61/G6102", PlaceHolder = "{{G61/G6102-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/G61/G6103", PlaceHolder = "{{G61/G6103-S501 = '2'}}", DefaultValue = "",MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/N1Loop2/G61/G6104", PlaceHolder = "{{G61/G6104-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/OID/OID01", PlaceHolder = "{{OID/OID01-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/LAD/LAD01", PlaceHolder = "{{LAD/LAD01-S501 = '2'}}", DefaultValue = "" , MappingRequired=true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/LAD/LAD02", PlaceHolder = "{{LAD/LAD02-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/L5/L503", PlaceHolder = "{{L5/L503-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/L5/L504", PlaceHolder = "{{L5/L504-S501 = '2'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/AT8/AT801", PlaceHolder = "{{AT8/AT801-S501 = '2'}}", DefaultValue = "" , MappingRequired=true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/AT8/AT802", PlaceHolder = "{{AT8/AT802-S501 = '2'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/AT8/AT803", PlaceHolder = "{{AT8/AT803-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/AT8/AT804", PlaceHolder = "{{AT8/AT804-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/AT8/AT805", PlaceHolder = "{{AT8/AT805-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/AT8/AT806", PlaceHolder = "{{AT8/AT806-S501 = '2'}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/AT8/AT807", PlaceHolder = "{{AT8/AT807-S501 = '2'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/G61Loop2/G61/G6101", PlaceHolder = "{{G61/G6101-S501 = '2' 2nd}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/G61Loop2/G61/G6102", PlaceHolder = "{{G61/G6102-S501 = '2' 2nd}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//L3/L301", PlaceHolder = "{{L3/L301}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//L3/L302", PlaceHolder = "{{L3/L302}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//L3/L309", PlaceHolder = "{{L3/L309}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//L3/L310", PlaceHolder = "{{L3/L310}}", DefaultValue = "" , MappingRequired=true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//L3/L311", PlaceHolder = "{{L3/L311}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//L3/L312", PlaceHolder = "{{L3/L312}}", DefaultValue = "", MappingRequired=true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Date/Time: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Date Qualifier : {{G62/G6201}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Date : {{G62/G6202}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Time Qualifier : {{G62/G6203}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Time : {{G62/G6204}} </td></tr> </table><br>",
            //        LineLevelXPath = "//S5Loop1[S5[S501 = '1']]/G62",
            //        PlaceHolder = "{{DateTimeHtml1}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '1']]/G62/G6201",
            //            PlaceHolder="{{G62/G6201}}",
            //            DefaultValue="",
            //            MappingRequired=true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '1']]/G62/G6202",
            //            PlaceHolder="{{G62/G6202}}",
            //            DefaultValue="",
            //            DateFormat= new DateFormat()
            //            {
            //                SourceFormat="yyyyMMdd",
            //                TargetFormat="MM/dd/yyyy"
            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '1']]/G62/G6203",
            //            PlaceHolder="{{G62/G6203}}",
            //            DefaultValue="",
            //            MappingRequired=true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '1']]/G62/G6204",
            //            PlaceHolder="{{G62/G6204}}",
            //            DefaultValue="",
            //            TimeFormat= new TimeFormat()
            //            {
            //                SourceFormat="HHmmss",
            //                TargetFormat="hh:mm:ss tt"
            //            }
            //        }

            //    }
            //    }
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Date/Time: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Date Qualifier : {{G62/G6201}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Date : {{G62/G6202}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Time Qualifier : {{G62/G6203}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Time : {{G62/G6204}} </td></tr> </table><br>",
            //        LineLevelXPath = "//S5Loop1[S5[S501 = '2']]/G62",
            //        PlaceHolder = "{{DateTimeHtml2}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '2']]/G62/G6201",
            //            PlaceHolder="{{G62/G6201}}",
            //            DefaultValue="",
            //            MappingRequired=true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '2']]/G62/G6202",
            //            PlaceHolder="{{G62/G6202}}",
            //            DefaultValue="",
            //            DateFormat= new DateFormat()
            //            {
            //                SourceFormat="yyyyMMdd",
            //                TargetFormat="MM/dd/yyyy"
            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '2']]/G62/G6203",
            //            PlaceHolder="{{G62/G6203}}",
            //            DefaultValue="",
            //            MappingRequired=true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '2']]/G62/G6204",
            //            PlaceHolder="{{G62/G6204}}",
            //            DefaultValue="",
            //            TimeFormat= new TimeFormat()
            //            {
            //                SourceFormat="HHmmss",
            //                TargetFormat="hh:mm:ss tt"
            //            }
            //        }

            //    }
            //    }
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Business Instructions and Reference Number: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification : {{L11/L1101}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification Qualifier : {{L11/L1102}} </td></tr> </table><br>",
            //        LineLevelXPath = "//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/G61Loop2/L11",
            //        PlaceHolder = "{{BussinessHtml1}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/G61Loop2/L11/L1101",
            //            PlaceHolder="{{L11/L1101}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '1']]/OIDLoop1/L5Loop2/G61Loop2/L11/L1102",
            //            PlaceHolder="{{L11/L1102}}",
            //            DefaultValue="",
            //            MappingRequired= true

            //        }

            //    }
            //    }
            //},
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Business Instructions and Reference Number: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification : {{L11/L1101}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification Qualifier : {{L11/L1102}} </td></tr> </table><br>",
            //        LineLevelXPath = "//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/G61Loop2/L11",
            //        PlaceHolder = "{{BussinessHtml2}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/G61Loop2/L11/L1101",
            //            PlaceHolder="{{L11/L1101}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//S5Loop1[S5[S501 = '2']]/OIDLoop1/L5Loop2/G61Loop2/L11/L1102",
            //            PlaceHolder="{{L11/L1102}}",
            //            DefaultValue="",
            //            MappingRequired= true

            //        }

            //    }
            //    }
            //}

            //}
            //}
            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad945.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad945Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_945.xml"),
            //TemplateSetCode = 945,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W06/W0601", PlaceHolder = "{{W06/W0601}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W06/W0602", PlaceHolder = "{{W06/W0602}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W06/W0603", PlaceHolder = "{{W06/W0603}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W06/W0604", PlaceHolder = "{{W06/W0604}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N4/N404", PlaceHolder = "{{N4/N404-N101 = 'BT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SF']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'SF'}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SF']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'SF'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N404", PlaceHolder = "{{N4/N404-N101 = 'ST'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G62/G6201", PlaceHolder = "{{G62/G6201}}", DefaultValue = "" , MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G62/G6202", PlaceHolder = "{{G62/G6202}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G62/G6203", PlaceHolder = "{{G62/G6203}}", DefaultValue = "" , MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G62/G6204", PlaceHolder = "{{G62/G6204}}", DefaultValue = "" , TimeFormat= new TimeFormat() { SourceFormat = "hhmm",TargetFormat = "hh:mm tt"} },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W27/W2701", PlaceHolder = "{{W27/W2701}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//W27/W2702", PlaceHolder = "{{W27/W2702}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Warehouse Item Detail: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Shipment/Order Status Code : {{W12/W1201}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Number of Units Shipped : {{W12/W1203}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code : {{W12/W1205}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID Qualifier : {{W12/W1207}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID : {{W12/W1208}} </td></tr> </table><br>",
            //        LineLevelXPath = "//LXLoop1[LX]",
            //        PlaceHolder = "{{WarehousDetailsHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W12Loop1/W12/W1201",
            //            PlaceHolder="{{W12/W1201}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W12Loop1/W12/W1203",
            //            PlaceHolder="{{W12/W1203}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W12Loop1/W12/W1205",
            //            PlaceHolder="{{W12/W1205}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W12Loop1/W12/W1207",
            //            PlaceHolder="{{W12/W1207}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//LXLoop1[LX]/W12Loop1/W12/W1208",
            //            PlaceHolder="{{W12/W1208}}",
            //            DefaultValue=""
            //        }

            //    }
            //    }
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Reference Identification: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification Qualifier : {{N9/N901}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification : {{N9/N902}} </td></tr> </table><br>",
            //        LineLevelXPath = "//N9",
            //        PlaceHolder = "{{ReferenceHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//N9/N901",
            //            PlaceHolder="{{N9/N901}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//N9/N902",
            //            PlaceHolder="{{N9/N902}}",
            //            DefaultValue=""
            //        }

            //    }
            //    }
            //}

            //}
            //}

        };
    }
}
