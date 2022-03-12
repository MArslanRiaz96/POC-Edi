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
            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad810.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad810Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_810.xml"),
            //TemplateSetCode = 850,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG01", PlaceHolder = "{{BIG/BIG01}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG02", PlaceHolder = "{{BIG/BIG02}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BIG/BIG03", PlaceHolder = "{{BIG/BIG03}}", DefaultValue = "" },
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
            //       HTML = "<tr> <td border=\"0\" width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (Assigned by Buyer or Buyer's Agent: {{N1/N103}})</td> </tr>",
            //        LineLevelXPath = "//N1Loop1/N1",
            //        PlaceHolder = "{{ShipHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//N1/N103",
            //            PlaceHolder="{{N1/N103}}",
            //            DefaultValue="",
            //        }
            //        }
            //    },
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD01", PlaceHolder = "{{ITD/ITD01}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD02", PlaceHolder = "{{ITD/ITD02}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD03", PlaceHolder = "{{ITD/ITD03}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD04", PlaceHolder = "{{ITD/ITD04}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br>1</td> <td width=\"50%\"><br> <b>U.P.C. Consumer Package Code (1-5-5-1)</b>: {{IT1/IT106}}<br> </td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{IT1/IT102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{IT1/IT103}}</td> <td VALIGN=\"TOP\" width=\"12%\"><br>{{IT1/IT104}}</td> <td VALIGN=\"TOP\" width=\"15%\"><br>{{IT1/IT105}}</td> </tr> <tr> <td width=\"15\"></td> <td width=\"55%\" colspan=\"5\"> </td> </tr>",
            //        LineLevelXPath = "//IT1Loop1/IT1",
            //        PlaceHolder = "{{LinesHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
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
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//IT1/IT106",
            //            PlaceHolder="{{IT1/IT106}}",
            //            DefaultValue="",
            //        }
            //        }
            //    },
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TDS/TDS01", PlaceHolder = "{{TDS/TDS01}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CAD/CAD01", PlaceHolder = "{{CAD/CAD01}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CAD/CAD02", PlaceHolder = "{{CAD/CAD02}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CAD/CAD03", PlaceHolder = "{{CAD/CAD03}}", DefaultValue = "" },
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
            //TemplateSetCode = 850,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BSN/BSN02", PlaceHolder = "{{BSN/BSN02}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BSN/BSN03", PlaceHolder = "{{BSN/BSN03}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BSN/BSN04", PlaceHolder = "{{BSN/BSN04}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD1[TD101 = 'Pieces']/TD101", PlaceHolder = "{{TD1/TD101-TD101 = 'Pieces'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD1[TD101 = 'Pieces']/TD102", PlaceHolder = "{{TD1/TD102-TD101 = 'Pieces'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD1[TD101 = 'Pieces']/TD103", PlaceHolder = "{{TD1/TD103-TD101 = 'Pieces'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD1[TD101 = 'Pieces']/TD104", PlaceHolder = "{{TD1/TD104-TD101 = 'Pieces'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD1[TD101 = 'Pieces']/TD105", PlaceHolder = "{{TD1/TD105-TD101 = 'Pieces'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD501", PlaceHolder = "{{TD5/TD501}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD502", PlaceHolder = "{{TD5/TD502}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD503", PlaceHolder = "{{TD5/TD503}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'CN']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'CN'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'BM']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'BM'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '011']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '011'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1[N101 = 'SH']/N102", PlaceHolder = "{{N1/N102-N101 = 'SH'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N3[N301 = '31875 SOLON RD']/N301", PlaceHolder = "{{N3/N301-N301 = '31875 SOLON RD'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N4[N401 = 'SOLON']/N403", PlaceHolder = "{{N4/N403-N401 = 'SOLON'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1[N101 = 'OB']/N102", PlaceHolder = "{{N1/N102-N101 = 'OB'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N3[N301 = 'P O BOX 9999999']/N301", PlaceHolder = "{{N3/N301-N301 = 'P O BOX 9999999'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N4[N401 = 'ATLANTA']/N403", PlaceHolder = "{{N4/N403-N401 = 'ATLANTA'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N4[N401 = 'ATLANTA']/N405", PlaceHolder = "{{N4/N405-N401 = 'ATLANTA'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1[N101 = 'SF']/N102", PlaceHolder = "{{N1/N102-N101 = 'SF'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N3[N301 = '31875 SOLON ROAD']/N301", PlaceHolder = "{{N3/N301-N301 = '31875 SOLON ROAD'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N4[N401 = 'SOLON']/N403", PlaceHolder = "{{N4/N403-N401 = 'SOLON'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//PRF/PRF01", PlaceHolder = "{{PRF/PRF01}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//PRF/PRF02", PlaceHolder = "{{PRF/PRF02}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table cellpadding=\"0\" border=\"0\" width=\"100%\"> <tr> <td width=\"638\" valign=\"top\" class=\"sectiontitle\" style=\"border: 2px; border-style: solid; border-color: DarkGray; background-color:LightGrey; padding: 2pt; color: Black\">Item Level Information</td> </tr> </table> </center></div> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td> <b>Part Numbers</b> </td></tr></table> <table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\"   background=\"res://VistaRes.Dll/legalpad.gif\"> <TR><TD WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vendor's (Seller's) Part Number</TD><TD BGCOLOR=\"#FFFFFF\">{{LIN/LIN03}}</TD></TR> <TR><TD WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;UCC - 12</TD><TD BGCOLOR=\"#FFFFFF\">{{LIN/LIN05}}</TD></TR> </TR> </table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Item Detail (Shipment): </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assigned Identification : {{SN1/SN101}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Number of Units Shipped : {{SN1/SN102}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code : {{SN1/SN103}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Item Physical Details: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pack : {{PO4/PO401}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Size : {{PO4/PO402}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code : {{PO4/PO403}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\"> <tr> <td width=\"1%\" valign=\"top\"> </td> <td width = \"99%\"><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Product/Item Description: </b></td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> </b>{{PID/PID03}}<br>    </td></tr> </table></td></tr></table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table>",
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
            //            XPath="//HLLoop1[PO4]//PID/PID03",
            //            PlaceHolder="{{PID/PID03}}",
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
            //                 SourceFormat = "hhmm",
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
            
            new HumanReadableConfiguration()
            {
            TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad855.html"),
            TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad855Updated.html"),
            PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_855.xml"),
            TemplateSetCode = 855,
            KDIVersion = "",
            configurations = new List<Configuration>() {
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BAK/BAK01", PlaceHolder = "{{BAK/BAK01}}", DefaultValue = "", MappingRequired = true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BAK/BAK02", PlaceHolder = "{{BAK/BAK02}}", DefaultValue = "", MappingRequired = true  },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BAK/BAK03", PlaceHolder = "{{BAK/BAK03}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//BAK/BAK04", PlaceHolder = "{{BAK/BAK04}}", DefaultValue = "" , DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD505", PlaceHolder = "{{TD5/TD505}}", DefaultValue = "", MappingRequired = true  },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'ST'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'ST'}}", DefaultValue = "" , MappingRequired = true },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'ST'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SF']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'SF'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SF']]/N4/N401", PlaceHolder = "{{N4/N401-N401 = 'SF'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SF']]/N4/N402", PlaceHolder = "{{N4/N402-N401 = 'SF'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SF']]/N4/N403", PlaceHolder = "{{N4/N403-N401 = 'SF'}}", DefaultValue = "" },
                LineLevel = null
                },
                new Configuration()
                {
                XPathConnfig = null,
                LineLevel = new LineLevel()
                {
                   HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br></td> <td width=\"50%\"><br> <b>U.P.C./EAN Shipping Container Code (1-2-5-5-1)</b>: {{PO1/PO107}}<br> </td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{PO1/PO102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO103}}</td> <td VALIGN=\"TOP\" width=\"12%\"><br>{{PO1/PO104}}</td> <td VALIGN=\"TOP\" width=\"15%\"><br>{{PO1/PO105}}</td> </tr> <tr> <td width=\"15\"></td> <td width=\"55%\" colspan=\"5\"> <br><b>Line Item Description</b> <table border=\"0\" width=\"100%\" background=\"res://VistaRes.Dll/legalpad.gif\" cellspacing=\"1\" cellpadding=\"0\"  doDocumentonClick()> <tr> <td></td> <td align=\"left\" width=\"90%\"> </b> {{PID/PID05}}<br> </td> </tr> </table> </div> </td> </tr>",
                    LineLevelXPath = "//PO1Loop1[PID]",
                    PlaceHolder = "{{LineItemHtml}}",
                    XPathConnfigs = new List<XPathConnfig>() {
                    new XPathConnfig()
                    {
                        XPath="//PO1Loop1[PID]/PO1/PO107",
                        PlaceHolder="{{PO1/PO107}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1Loop1[PID]/PO1/PO102",
                        PlaceHolder="{{PO1/PO102}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1Loop1[PID]/PO1/PO103",
                        PlaceHolder="{{PO1/PO103}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1Loop1[PID]/PO1/PO104",
                        PlaceHolder="{{PO1/PO104}}",
                        DefaultValue=""
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1Loop1[PID]/PO1/PO105",
                        PlaceHolder="{{PO1/PO105}}",
                        DefaultValue="",
                        MutiplcationUsingXPath = new List<string>()
                        {
                            "//PO1Loop1[PID]/PO1/PO102",
                            "//PO1Loop1[PID]/PO1/PO104"
                        }
                    },
                    new XPathConnfig()
                    {
                        XPath="//PO1Loop1[PID]/PID/PID05",
                        PlaceHolder="{{PID/PID05}}",
                        DefaultValue=""
                        }
                    }
                    
                }
                }
            }

            }
        };
    }
}
