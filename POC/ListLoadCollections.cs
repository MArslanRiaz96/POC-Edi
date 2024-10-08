﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
                TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XPathLoadMAESA861.html"),// Placeholder file
                TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XPathLoadMAESA861Updated.html"),
                PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGNAL_MAESA861.xml"), // Packing file where xml path defined
                TemplateSetCode = 861,
                KDIVersion = "",
                configurations = new List<Configuration>() 
                {

                    #region Beginning Segment for Receiving Advice or Acceptance Certificate:
                    new Configuration()
                    {
                        XPathConnfig = new XPathConnfig() { XPath = "//BRA/BRA01", PlaceHolder = "{{BRA/BRA01}}", DefaultValue = ""},
                        LineLevel = null
                    },
                    new Configuration()
                    {
                        XPathConnfig = new XPathConnfig() { XPath = "//BRA/BRA02", PlaceHolder = "{{BRA/BRA02}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
                        LineLevel = null
                    },
                    new Configuration()
                    {
                        XPathConnfig = new XPathConnfig() { XPath = "//BRA/BRA03", PlaceHolder = "{{BRA/BRA03}}", DefaultValue = "",MappingRequired=true},
                        LineLevel = null
                    },
                    new Configuration()
                    {
                        XPathConnfig = new XPathConnfig() { XPath = "//BRA/BRA04", PlaceHolder = "{{BRA/BRA04}}", DefaultValue = "",MappingRequired=true},
                        LineLevel = null
                    },
                    new Configuration()
                    {
                        XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01='IA']/REF02", PlaceHolder = "{{REFREF01IAREF02}}", DefaultValue = ""},
                        LineLevel = null
                    },
                    new Configuration()
                    {
                        XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'IK']/REF02", PlaceHolder = "{{REFREF01REF02}}", DefaultValue = ""},
                        LineLevel = null
                    },
                        //
                    #endregion

                    #region Date/Time Reference
                    new Configuration()
                    {
                        //XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '809']/DTM02", PlaceHolder = "{{DTM/DTM02/809}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyMMdd", TargetFormat = "MM/dd/yyyy" }},
                        XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '809']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '809'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
                        LineLevel = null
                    },
                    new Configuration()
                    {
                        XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '003']/DTM02", PlaceHolder = "{{DTM/DTM02/003}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
                        LineLevel = null
                    }, 
                    #endregion
                    new Configuration()
                    {
                        XPathConnfig = new XPathConnfig() { XPath = "//PRF/PRF01", PlaceHolder = "{{PRF/PRF01}}", DefaultValue = ""},
                        LineLevel = null
                    },
                    new Configuration()
                    {
                        XPathConnfig = new XPathConnfig() { XPath = "//PRF/PRF04", PlaceHolder = "{{PRF/PRF04}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
                        LineLevel = null
                    },

                    new Configuration()
                    {
                        XPathConnfig = null,
                        LineLevel = new LineLevel()
                        {
                            HTML = "<table>\r\n<tr>\r\n<td width='50%'>\r\n<b>Warehouse</b><br/>\r\n<span class='tab1'>({{N1/N103}}: {{N1/N104}})</span></td><br/>\r\n</tr>\r\n</table>\r\n<br/>",
                            LineLevelXPath = "//N1Loop1",
                            PlaceHolder = "{{WarehouseInformationHtml}}",
                            XPathConnfigs = new List<XPathConnfig>()
                            {
                                new XPathConnfig(){
                                        XPath="//N1/N103",
                                        PlaceHolder="{{N1/N103}}",
                                        DefaultValue="",
                                        MappingRequired= true
                                },
                                new XPathConnfig(){
                                        XPath="//N1/N104",
                                        PlaceHolder="{{N1/N104}}",
                                        DefaultValue=""
                                },
                            }
                        }
                    },

                    new Configuration()
                    {
                        XPathConnfig = null,
                        LineLevel = new LineLevel()
                        {
                            HTML = "<b>Receiving Conditions</b><br/>\r\n   <span class='tab1'>Quantity Units Received or Accepted: {{RCD/RCD02}}</span><br/>\r\n   <span class='tab1'>Composite Unit of Measure: {{RCD/RCD03}}</span><br/>\r\n<br/>\r\n<b>Part Numbers</b>\r\n<table class='bordersSm'>\r\n  <tr>\r\n    <td width='35%' class='tab1'>{{LIN/LIN02}}</td>\r\n    <td>{{LIN/LIN03}}</td>\r\n  </tr>\r\n  <tr>\r\n    <td width='35%' class='tab1'>{{LIN/LIN04}}</td>\r\n    <td>{{LIN/LIN05}}</td>\r\n  </tr>\r\n</table>\r\n<br/>\r\n<b>Service, Promotion, Allowance, or Charge Information</b><br/>\r\n<span class='tab1'>Allowance or Charge Indicator: {{SAC/SAC01}}</span><br/>\r\n<span class='tab1'>Service, Promotion, Allowance, or Charge Code: {{SAC/SAC02}}</span><br/>\r\n<span class='tab1'>Amount: {{SAC/SAC05}}</span><br/>\r\n<span class='tab1'>Rate: {{SAC/SAC08}}</span><br/>\r\n<span class='tab1'>Unit or Basis for Measurement Code: {{SAC/SAC09}}</span><br/>\r\n<span class='tab1'>Quantity: {{SAC/SAC10}}</span><br/>\r\n<br/>",
                            LineLevelXPath = "//RCDLoop1",
                            PlaceHolder = "{{LoopInformationHtml}}",
                            XPathConnfigs = new List<XPathConnfig>()
                            {
                                new XPathConnfig(){
                                        XPath="//RCD/RCD02",
                                        PlaceHolder="{{RCD/RCD02}}",
                                        DefaultValue=""
                                },
                                new XPathConnfig(){
                                        XPath="//RCD/RCD03",
                                        PlaceHolder="{{RCD/RCD03}}",
                                        DefaultValue="",
                                        MappingRequired= true
                                },
                                new XPathConnfig(){
                                        XPath="//LIN/LIN02",
                                        PlaceHolder="{{LIN/LIN02}}",
                                        DefaultValue="",
                                        MappingRequired= true
                                },
                                new XPathConnfig(){
                                        XPath="//LIN/LIN03",
                                        PlaceHolder="{{LIN/LIN03}}",
                                        DefaultValue=""
                                },
                                new XPathConnfig(){
                                        XPath="//LIN/LIN04",
                                        PlaceHolder="{{LIN/LIN04}}",
                                        DefaultValue="",
                                        MappingRequired= true
                                },
                                new XPathConnfig(){
                                        XPath="//LIN/LIN05",
                                        PlaceHolder="{{LIN/LIN05}}",
                                        DefaultValue=""
                                },

                                new XPathConnfig(){
                                        XPath="//SAC/SAC01",
                                        PlaceHolder="{{SAC/SAC01}}",
                                        DefaultValue="",
                                        MappingRequired= true
                                },
                                new XPathConnfig(){
                                        XPath="//SAC/SAC02",
                                        PlaceHolder="{{SAC/SAC02}}",
                                        DefaultValue="",
                                        MappingRequired= true
                                },
                                new XPathConnfig(){
                                        XPath="//SAC/SAC05",
                                        PlaceHolder="{{SAC/SAC05}}",
                                        DefaultValue="",
                                        isDecimal=true,
                                },
                                new XPathConnfig(){
                                        XPath="//SAC/SAC08",
                                        PlaceHolder="{{SAC/SAC08}}",
                                        DefaultValue=""
                                },
                                new XPathConnfig(){
                                        XPath="//SAC/SAC09",
                                        PlaceHolder="{{SAC/SAC09}}",
                                        DefaultValue="",
                                        MappingRequired= true
                                },
                                new XPathConnfig(){
                                        XPath="//SAC/SAC10",
                                        PlaceHolder="{{SAC/SAC10}}",
                                        DefaultValue=""
                                },
                            }
                        },
                    },


                }
            }


            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad816.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad816Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_816.xml"),
            //TemplateSetCode = 816,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BHT/BHT01", PlaceHolder = "{{BHT/BHT01}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BHT/BHT02", PlaceHolder = "{{BHT/BHT02}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BHT/BHT03", PlaceHolder = "{{BHT/BHT03}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BHT/BHT04", PlaceHolder = "{{BHT/BHT04}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/N1/N102", PlaceHolder = "{{N1Loop1/N1/N102}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    //////////////////////////////////////////////////////


            //    //new Configuration()
            //    //{
            //    //XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1/N1Loop2/N1_2/N102", PlaceHolder = "{{N1Loop2/N1_2/N102}}", DefaultValue = ""},
            //    //LineLevel = null
            //    //},
            //    //new Configuration()
            //    //{
            //    //XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1/N1Loop2/N1_2/N103", PlaceHolder = "{{N1Loop2/N1_2/N103}}", DefaultValue = "", MappingRequired= true},
            //    //LineLevel = null
            //    //},
            //    //new Configuration()
            //    //{
            //    //XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1/N1Loop2/N1_2/N104", PlaceHolder = "{{N1Loop2/N1_2/N104}}", DefaultValue = ""},
            //    //LineLevel = null
            //    //},
            //    //new Configuration()
            //    //{
            //    //XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1/N1Loop2/N3_2/N301", PlaceHolder = "{{N1Loop2/N3_2/N301}}", DefaultValue = ""},
            //    //LineLevel = null
            //    //},

            //    //new Configuration()
            //    //{
            //    //XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1/N1Loop2/N4_2/N401", PlaceHolder = "{{N1Loop2/N4_2/N401}}", DefaultValue = ""},
            //    //LineLevel = null
            //    //},
            //    //new Configuration()
            //    //{
            //    //XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1/N1Loop2/N4_2/N402", PlaceHolder = "{{N1Loop2/N4_2/N402}}", DefaultValue = ""},
            //    //LineLevel = null
            //    //},
            //    //new Configuration()
            //    //{
            //    //XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1/N1Loop2/N4_2/N403", PlaceHolder = "{{N1Loop2/N4_2/N403}}", DefaultValue = ""},
            //    //LineLevel = null
            //    //},
            //    //new Configuration()
            //    //{
            //    //XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1/N1Loop2/N4_2/N404", PlaceHolder = "{{N1Loop2/N4_2/N404}}", DefaultValue = ""},
            //    //LineLevel = null
            //    //},

            //    //new Configuration()
            //    //{
            //    //XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1/N1Loop2/REF_3/REF01", PlaceHolder = "{{N1Loop2/REF_3/REF01}}", DefaultValue = "", MappingRequired= true},
            //    //LineLevel = null
            //    //},
            //    //new Configuration()
            //    //{
            //    //XPathConnfig = new XPathConnfig() { XPath = "//HLLoop1/N1Loop2/REF_3/REF02", PlaceHolder = "{{N1Loop2/REF_3/REF02}}", DefaultValue = ""},
            //    //LineLevel = null
            //    //},


            //    new Configuration()
            //    {
            //        XPathConnfig = null,
            //        LineLevel = new LineLevel()
            //        {
            //            HTML = "<div class='sectionTitle'>{{HL/HL03}}</div>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\">\r\n   <tr>\r\n      <td valign=\"top\" width=\"50%\">\r\n         <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\"><b>{{HeaderN1Loop2/N1_2/N101}}: </b></td>\r\n            </tr>\r\n         </table>\r\n         <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n            <tr>\r\n               <td border=\"0\" width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{HeaderN1Loop2/N1_2/N102}} ({{HeaderN1Loop2/N1_2/N103}}: {{N1Loop2/N1_2/N104}})</td>\r\n            </tr>\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{N1Loop2/N3_2/N301}}</td>\r\n            </tr>\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{Loop/N1Loop2/N4_2/N401}}, {{N1Loop2/N4_2/N402}} {{N1Loop2/N4_2/N403}} {{N1Loop2/N4_2/N404}}</td>\r\n            </tr>\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\"><b>Reference Information: </b></td>\r\n            </tr>\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{N1Loop2/REF_3/REF01-REF01 = 'DNS'}} : {{N1Loop2/REF_3/REF02-REF01 = 'DNS'}}</td>\r\n            </tr>\r\n          <br/>\r\n         </table>\r\n      </td>\r\n   </tr>\r\n   <tr></tr>\r\n</table>\r\n<br/>",
            //            LineLevelXPath = "//HLLoop1[position()=1]", //"//HLLoop1/HL[HL03 = '35']", //"//HLLoop1[position()=1]", //ns:HL[ns:HL03 = '35']
            //            PlaceHolder = "{{TransactionHeaderInformationHtml}}",
            //            XPathConnfigs = new List<XPathConnfig>()
            //            {
            //                new XPathConnfig(){
            //                        XPath="//HL/HL03",
            //                        PlaceHolder="{{HL/HL03}}",
            //                        DefaultValue="",
            //                        MappingRequired= true
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N1_2/N101",
            //                        PlaceHolder="{{HeaderN1Loop2/N1_2/N101}}",
            //                        DefaultValue="",
            //                        MappingRequired = true
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N1_2/N102",
            //                        PlaceHolder="{{HeaderN1Loop2/N1_2/N102}}",
            //                        DefaultValue="",
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N1_2/N103",
            //                        PlaceHolder="{{HeaderN1Loop2/N1_2/N103}}",
            //                        DefaultValue="",
            //                        MappingRequired= true
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N1_2/N104",
            //                        PlaceHolder="{{N1Loop2/N1_2/N104}}",
            //                        DefaultValue="",
            //                },

            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N3_2/N301",
            //                        PlaceHolder="{{N1Loop2/N3_2/N301}}",
            //                        DefaultValue="",
            //                },

            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N4_2/N401",
            //                        PlaceHolder="{{Loop/N1Loop2/N4_2/N401}}",
            //                        DefaultValue="",
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N4_2/N402",
            //                        PlaceHolder="{{N1Loop2/N4_2/N402}}",
            //                        DefaultValue="",
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N4_2/N403",
            //                        PlaceHolder="{{N1Loop2/N4_2/N403}}",
            //                        DefaultValue="",
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N4_2/N404",
            //                        PlaceHolder="{{N1Loop2/N4_2/N404}}",
            //                        DefaultValue="",
            //                },


            //                //Reference Information:
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/REF_3[REF01 = 'DNS']/REF01",
            //                        PlaceHolder="{{N1Loop2/REF_3/REF01-REF01 = 'DNS'}}",
            //                        DefaultValue="",
            //                        MappingRequired = true
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/REF_3[REF01 = 'DNS']/REF02",
            //                        PlaceHolder="{{N1Loop2/REF_3/REF02-REF01 = 'DNS'}}",
            //                        DefaultValue="",
            //                },
            //                //new XPathConnfig(){
            //                //        XPath="//N1Loop2/REF_3[REF01 = 'ST' or REF01 = 'AEM']/REF01",
            //                //        PlaceHolder="{{N1Loop2/REF_3/REF01-REF01 = 'ST' or REF01 = 'AEM'}}",
            //                //        DefaultValue="",
            //                //        MappingRequired=true
            //                //},
            //            }
            //        }
            //    },
            //    ///////////////////////////////////////////////////////////
            //    new Configuration()
            //    {
            //        XPathConnfig = null,
            //        LineLevel = new LineLevel()
            //        {
            //            HTML = "<div class='sectionTitle'>{{HL/HL03}}</div>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\">\r\n   <tr>\r\n      <td valign=\"top\" width=\"50%\">\r\n         <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\"><b>{{N1Loop2/N1_2/N101}}: </b></td>\r\n            </tr>\r\n         </table>\r\n         <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n            <tr>\r\n               <td border=\"0\" width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{N1Loop2/N1_2/N102}} ({{N1Loop2/N1_2/N103}}: {{N1Loop2/N1_2/N104}})</td>\r\n            </tr>\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{N1Loop2/N3_2/N301}}</td>\r\n            </tr>\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{Loop/N1Loop2/N4_2/N401}}, {{N1Loop2/N4_2/N402}} {{N1Loop2/N4_2/N403}} {{N1Loop2/N4_2/N404}}</td>\r\n            </tr>\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\">\r\n                  <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n                     <tr>\r\n                        <td width=\"100%\" valign=\"top\" align=\"left\"><b>Contact Information: </b></td>\r\n                     </tr>\r\n                  </table>\r\n                  <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n                     <tr>\r\n                        <td width=\"50%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Information Contact : {{N1Loop2/PER_2/PER02}}<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Telephone : {{Loop/N1Loop2/PER_2/PER04}}<br/></td>\r\n                     </tr>\r\n                  </table>\r\n                  <br/>\r\n               </td>\r\n            </tr>\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\"><b>Reference Information: </b></td>\r\n            </tr>\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{N1Loop2/REF_3/REF01-REF01 = 'DNS'}} : {{N1Loop2/REF_3/REF02-REF01 = 'DNS'}}</td>\r\n            </tr>\r\n            <tr>\r\n               <td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{N1Loop2/REF_3/REF01-REF01 = 'ST' or REF01 = 'AEM'}} : {{N1Loop2/REF_3/REF02-REF01 = 'ST'}} </td>\r\n            </tr>\r\n            <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n               <tr>\r\n                  <td width=\"100%\" valign=\"top\" align=\"left\"><b>Date/Time Reference</b></td>\r\n               </tr>\r\n            </table>\r\n            <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n               <tr>\r\n                  <td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Effective : {{N1Loop2/DTM_2/DTM02}} </td>\r\n               </tr>\r\n            </table>\r\n            <br/>\r\n            <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" >\r\n               <tr>\r\n                  <td width=\"100%\" valign=\"top\" align=\"left\"><b>Action or Status Indicator:</b></td>\r\n               </tr>\r\n            </table>\r\n            <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n               <tr>\r\n                  <td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Action Code : {{N1Loop2/ASI/ASI01}}</td>\r\n               </tr>\r\n               <tr>\r\n                  <td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Maintenance Type Code : {{N1Loop2/ASI/ASI02}}</td>\r\n               </tr>\r\n            </table>\r\n            <br/>\r\n         </table>\r\n      </td>\r\n   </tr>\r\n   <tr></tr>\r\n</table>\r\n<br/>",
            //            //HTML = "<div class='sectionTitle'>Operating Unit</div><table border=0 cellspacing=0 cellpadding=0 width=100%><tr>\r\n<td valign=top width=50%><table border=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n<b>Store: </b>\r\n</td></tr></table>\r\n<table border=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td border=0 width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{N1Loop2/N1_2/N102}} ({{N1Loop2/N1_2/N103}}: {{N1Loop2/N1_2/N104}})</td>\r\n</tr>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{N1Loop2/N3_2/N301}}</td></tr> <tr>\r\n<td width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{Loop/N1Loop2/N4_2/N401}}, {{N1Loop2/N4_2/N402}} {{N1Loop2/N4_2/N403}} {{N1Loop2/N4_2/N404}}</td></tr> <tr>\r\n<td width=100% valign=top align=left>\r\n<table border=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n<b>Contact Information: </b>\r\n</td></tr></table>\r\n<table border=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td width=50% align=left valign=top>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Information Contact : {{N1Loop2/PER_2/PER02}}\r\n<BR>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Telephone : {{Loop/N1Loop2/PER_2/PER04}}\r\n<BR>\r\n</td>\r\n</tr></table><BR>\r\n</td>\r\n</tr>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n<b>Reference Information: </b>\r\n</td></tr>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{N1Loop2/REF_3/REF01-REF01 = 'DNS'}} : {{N1Loop2/REF_3/REF02-REF01 = 'DNS'}}</td></tr>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{ReferenceLabel}} : {{ReferenceValue}} </td></tr>\r\n<table border=0 cellspacing=0 cellpadding=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n<b>Date/Time Reference\r\n</b></td></tr>\r\n</table>\r\n<table border=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Effective : {{N1Loop2/DTM_2/DTM02}} </td></tr>\r\n</table><br>\r\n<table border=0 cellspacing=0 cellpadding=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n<b>Action or Status Indicator:\r\n</b></td></tr></table>\r\n<table border=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Action Code : {{N1Loop2/ASI/ASI01}}\r\n</td></tr>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Maintenance Type Code : {{N1Loop2/ASI/ASI02}}\r\n</td></tr>\r\n</table><br>\r\n</table>\r\n</td>\r\n</tr><tr>\r\n</tr></table><BR>",
            //            //HTML = "<table border=0 width=100% cellspacing=0 cellpadding=0><tr>\r\n<td width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {{ReferenceLabel}} : {{ReferenceValue}}\r\n</td></tr><tr>\r\n<td width=100% valign=top align=left>\r\nEffective : {{N1Loop2/DTM_2/DTM02}}</td></tr></table>",
            //            LineLevelXPath = "//HLLoop1[position()>1]", //"//HLLoop1/HL[HL03 = '36']", //"//HLLoop1[position()>1]", //"//HLLoop1","//HLLoop1/HL[HL03 = '36']"
            //            PlaceHolder = "{{TransactionInformationHtml}}",
            //            XPathConnfigs = new List<XPathConnfig>()
            //            {
            //                new XPathConnfig(){
            //                        XPath="//HL/HL03",
            //                        PlaceHolder="{{HL/HL03}}",
            //                        DefaultValue="",
            //                        MappingRequired= true
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N1_2/N101",
            //                        PlaceHolder="{{N1Loop2/N1_2/N101}}",
            //                        DefaultValue="",
            //                        MappingRequired = true
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N1_2/N102",
            //                        PlaceHolder="{{N1Loop2/N1_2/N102}}",
            //                        DefaultValue="",
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N1_2/N103",
            //                        PlaceHolder="{{N1Loop2/N1_2/N103}}",
            //                        DefaultValue="",
            //                        MappingRequired= true
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N1_2/N104",
            //                        PlaceHolder="{{N1Loop2/N1_2/N104}}",
            //                        DefaultValue="",
            //                },

            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N3_2/N301",
            //                        PlaceHolder="{{N1Loop2/N3_2/N301}}",
            //                        DefaultValue="",
            //                },

            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N4_2/N401",
            //                        PlaceHolder="{{Loop/N1Loop2/N4_2/N401}}",
            //                        DefaultValue="",
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N4_2/N402",
            //                        PlaceHolder="{{N1Loop2/N4_2/N402}}",
            //                        DefaultValue="",
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N4_2/N403",
            //                        PlaceHolder="{{N1Loop2/N4_2/N403}}",
            //                        DefaultValue="",
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/N4_2/N404",
            //                        PlaceHolder="{{N1Loop2/N4_2/N404}}",
            //                        DefaultValue="",
            //                },
            //                //Contact Information:
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/PER_2/PER02",
            //                        PlaceHolder="{{N1Loop2/PER_2/PER02}}",
            //                        DefaultValue=""
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/PER_2/PER04",
            //                        PlaceHolder="{{Loop/N1Loop2/PER_2/PER04}}",
            //                        DefaultValue=""
            //                },

            //                //Reference Information:
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/REF_3[REF01 = 'DNS']/REF01",
            //                        PlaceHolder="{{N1Loop2/REF_3/REF01-REF01 = 'DNS'}}",
            //                        DefaultValue="",
            //                        MappingRequired = true
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/REF_3[REF01 = 'DNS']/REF02",
            //                        PlaceHolder="{{N1Loop2/REF_3/REF02-REF01 = 'DNS'}}",
            //                        DefaultValue="",
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/REF_3[REF01 = 'ST' or REF01 = 'AEM']/REF01",
            //                        PlaceHolder="{{N1Loop2/REF_3/REF01-REF01 = 'ST' or REF01 = 'AEM'}}",
            //                        DefaultValue="",
            //                        MappingRequired=true
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/REF_3[REF01 = 'ST' or REF01 = 'AEM']/REF02",
            //                        PlaceHolder="{{N1Loop2/REF_3/REF02-REF01 = 'ST'}}",
            //                        DefaultValue="",
            //                },
            //                //AEM
            //                //new XPathConnfig(){
            //                //        XPath="//N1Loop2/REF_3[REF01 = 'AEM']/REF02",
            //                //        PlaceHolder="{{N1Loop2/REF_3/REF02-REF01 = 'ST'}}",
            //                //        DefaultValue="",
            //                //},

            //                //// Dynamic Label for Reference
            //                //new XPathConnfig(){
            //                //    XPath="//N1Loop2/REF_3[REF01 = 'ST' or REF01 = 'AEM']/REF01",
            //                //    PlaceHolder="{{ReferenceLabel}}",
            //                //    DefaultValue="Store Number", // Default value
            //                //},

            //                //// Dynamic Value for Reference
            //                //new XPathConnfig(){
            //                //    XPath="//N1Loop2/REF_3[REF01 = 'ST' or REF01 = 'AEM']/REF02",
            //                //    PlaceHolder="{{ReferenceValue}}",
            //                //    DefaultValue="",
            //                //},

            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/DTM_2/DTM02",
            //                        PlaceHolder="{{N1Loop2/DTM_2/DTM02}}",
            //                        DefaultValue="",
            //                        DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }
            //                },


            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/ASI/ASI01",
            //                        PlaceHolder="{{N1Loop2/ASI/ASI01}}",
            //                        DefaultValue="",
            //                        MappingRequired=true
            //                },
            //                new XPathConnfig(){
            //                        XPath="//N1Loop2/ASI/ASI02",
            //                        PlaceHolder="{{N1Loop2/ASI/ASI02}}",
            //                        DefaultValue="",
            //                        MappingRequired=true
            //                },
            //            },
            //            //IsChildLineLevel = true,
            //            //ChildLineLevel=new LineLevel
            //            //{
            //            //    HTML="<TR><TD>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{FST/FST01}}</TD><TD>{{FST/FST02}}: {{FST/FST03}}</TD><TD>{{FST/FST04}}</TD></TR>",
            //            //    LineLevelXPath="//FSTLoop1",
            //            //    PlaceHolder="{{ForecastScheduleHtml}}",
            //            //    XPathConnfigs=new List<XPathConnfig>()
            //            //    {
            //            //        //Quan
            //            //        new XPathConnfig()
            //            //        {
            //            //        XPath="//FST//FST01",
            //            //        DefaultValue="",
            //            //        PlaceHolder="{{FST/FST01}}",
            //            //        },
            //            //        //Timing
            //            //        new XPathConnfig()
            //            //        {
            //            //        XPath="//FST//FST02",
            //            //        DefaultValue="",
            //            //        PlaceHolder="{{FST/FST02}}",
            //            //        MappingRequired=true
            //            //        },
            //            //        new XPathConnfig()
            //            //        {
            //            //        XPath="//FST//FST03",
            //            //        DefaultValue="",
            //            //        PlaceHolder="{{FST/FST03}}",
            //            //        MappingRequired=true
            //            //        },
            //            //        //When
            //            //        new XPathConnfig()
            //            //        {
            //            //        XPath = "//FST//FST04",
            //            //        DefaultValue="",
            //            //        PlaceHolder = "{{FST/FST04}}",
            //            //        DateFormat=new DateFormat{
            //            //            SourceFormat="yyMMdd",
            //            //            TargetFormat="M/dd/yyyy"
            //            //        }
            //            //        },
            //            //    }
            //        }
            //    },
            //}
            //},

            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoadGT850.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoadGT850Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_GT_850.xml"),
            //TemplateSetCode = 850,
            //KDIVersion = "",
            //IsCustom = true,
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG03", PlaceHolder = "{{BEG/BEG03}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG05", PlaceHolder = "{{BEG/BEG05}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG02", PlaceHolder = "{{BEG/BEG02}}", DefaultValue = "", MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BEG/BEG01", PlaceHolder = "{{BEG/BEG01}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//REF/REF02", PlaceHolder = "{{REF/REF02}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CSH/CSH01", PlaceHolder = "{{CSH/CSH01}}", DefaultValue = "" , MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '064']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '064'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '063']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '063'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'ST'}}", DefaultValue = "" , MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'ST'}}", DefaultValue = "" },
            //    LineLevel = null
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
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '996'}}", DefaultValue = "" ,DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }, PreferedXpaths = new List<PreferedXpath>()
            //    {
            //        new PreferedXpath(){ XPath = "//DTM[DTM01 = '996']/DTM02",Identifier = "",TotalNodes = "",SelectedNode = ""},
            //        new PreferedXpath(){ XPath = "//DTM[DTM01 = '010']/DTM02",Identifier = "",TotalNodes = "",SelectedNode = ""}

            //    } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '371'}}", DefaultValue = "" ,DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }, PreferedXpaths = new List<PreferedXpath>()
            //    {
            //        new PreferedXpath(){ XPath = "//DTM[DTM01 = '371']/DTM02",Identifier = "",TotalNodes = "",SelectedNode = ""},
            //        new PreferedXpath(){ XPath = "//DTM[DTM01 = '002']/DTM02",Identifier = "",TotalNodes = "",SelectedNode = ""}

            //    } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '002'}}", DefaultValue = "" ,DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }, PreferedXpaths = new List<PreferedXpath>()
            //    {
            //        new PreferedXpath(){ XPath = "//DTM[DTM01 = '001']/DTM02",Identifier = "",TotalNodes = "",SelectedNode = ""},
            //        new PreferedXpath(){ XPath = "//DTM[DTM01 = '002']/DTM02",Identifier = "",TotalNodes = "",SelectedNode = ""}

            //    } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//MTX_2/MTX02", PlaceHolder = "{{MTX_2/MTX02}}", DefaultValue = "" , ConcatinationUsingSameXPath = true},
            //    LineLevel = null
            //    }
            //    ,
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//AMT_3[AMT01 = 'TT']/AMT02", PlaceHolder = "{{ATM/ATM02-ATM01 = 'TT'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'ST'}}", DefaultValue = "" , ConcatinationUsingDifferentXPath =
            //        new List<string>()
            //        {
            //            "//N1Loop1[N1[N101 = 'ST']]/N1/N102",
            //            "//N1Loop1[N1[N101 = 'ST']]/N3/N301",
            //            "//N1Loop1[N1[N101 = 'ST']]/N3/N302",
            //            "//N1Loop1[N1[N101 = 'ST']]/PER_2/PER02",
            //            "//N1Loop1[N1[N101 = 'ST']]/PER_2/PER03",
            //            "//N1Loop1[N1[N101 = 'ST']]/PER_2/PER04" }
            //        },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BY']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'BY'}}", DefaultValue = "" , ConcatinationUsingDifferentXPath =
            //        new List<string>()
            //        {
            //            "//N1Loop1[N1[N101 = 'BY']]/N1/N102",
            //            "//N1Loop1[N1[N101 = 'BY']]/N3/N301",
            //            "//N1Loop1[N1[N101 = 'BY']]/N3/N302",
            //            "//N1Loop1[N1[N101 = 'BY']]/PER_2/PER02",
            //            "//N1Loop1[N1[N101 = 'BY']]/PER_2/PER03",
            //            "//N1Loop1[N1[N101 = 'BY']]/PER_2/PER04" }
            //        },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //        HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO101}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO109}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO111}}</td> <td width=\"30%\"><br> <b>Vendor's (Seller's) Item Number</b>: {{PO1/PO107}}<br> </td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO103}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO104}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO105}}</td> <td VALIGN=\"TOP\" width=\"15%\"><br>{{PO1/PO106}}</td> </tr>",
            //        LineLevelXPath = "//PO1Loop1[PO1]",
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
            //            XPath="//PO1Loop1[PO1]/PIDLoop1[PID_2]/PID_2/PID05",
            //            PlaceHolder="{{PO1/PO107}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "",
            //            PreferedXpaths = new List<PreferedXpath>()
            //            {
            //                new PreferedXpath(){ XPath = "//PO1Loop1[PO1]/PIDLoop1[PID_2]/PID_2/PID05",Identifier = "",TotalNodes = "",SelectedNode = ""},
            //                new PreferedXpath(){ XPath = "//PO1Loop1[PO1]/PO1",Identifier = "UI",TotalNodes = "",SelectedNode = ""},
            //                new PreferedXpath(){ XPath = "//PO1Loop1[PO1]/PO1",Identifier = "UA",TotalNodes = "",SelectedNode = ""}
            //            }
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
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1/PO106",
            //            PlaceHolder="{{PO1/PO106}}",
            //            DefaultValue="",
            //            MutiplcationUsingXPath = new List<string>()
            //            {
            //                "//PO1Loop1/PO1/PO102",
            //                "//PO1Loop1/PO1/PO104"
            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1/PO105",
            //            PlaceHolder="{{PO1/PO105}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1Loop1[PO1]/PO1",
            //            PlaceHolder="{{PO1/PO109}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "UI",
            //            PreferedXpaths = new List<PreferedXpath>()
            //            {
            //                new PreferedXpath(){ XPath = "//PO1Loop1[PO1]/PO1",Identifier = "UI",TotalNodes = "",SelectedNode = ""},
            //                new PreferedXpath(){ XPath = "//PO1Loop1[PO1]/PO1",Identifier = "UP",TotalNodes = "",SelectedNode = ""},
            //                new PreferedXpath(){ XPath = "//PO1Loop1[PO1]/PO1",Identifier = "UA",TotalNodes = "",SelectedNode = ""}

            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PO1Loop1[PO1]/PO1",
            //            PlaceHolder="{{PO1/PO111}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "MF",
            //            PreferedXpaths = new List<PreferedXpath>()
            //            {
            //                new PreferedXpath(){ XPath = "//PO1Loop1[PO1]/PO1",Identifier = "MF",TotalNodes = "",SelectedNode = ""},
            //                new PreferedXpath(){ XPath = "//PO1Loop1[PO1]/PO1",Identifier = "VN",TotalNodes = "",SelectedNode = ""},
            //                new PreferedXpath(){ XPath = "//PO1Loop1[PO1]/PO1",Identifier = "UA",TotalNodes = "",SelectedNode = ""}

            //            }
            //        }
            //        }
            //    }
            //    }
            //}
            //}



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
        //            HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br/>{{PO1/PO101}}</td>  <td width=\"50%\"><br/> <b>Vendor's (Seller's) Item Number</b>: {{PO1/PO107}}<br/> </td>  <td VALIGN=\"TOP\" width=\"10%\"><br/>{{PO1/PO102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br/>{{PO1/PO103}}</td> <td VALIGN=\"TOP\" width=\"12%\"><br/>{{PO1/PO104}}</td> <td VALIGN=\"TOP\" width=\"10%\"><br/>{{PO1/PO105}}</td>  <td VALIGN=\"TOP\" width=\"15%\"><br/>{{PO1/PO106}}</td> </tr>",
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
            //       //HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br>{{IT1/IT101}}</td> <td width=\"50%\"><br> <b>U.P.C. Consumer Package Code (1-5-5-1)</b>: {{IT1/IT107}}<br> </td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{IT1/IT102}}</td> <td VALIGN=\"TOP\" width=\"5%\"><br>{{IT1/IT103}}</td> <td VALIGN=\"TOP\" width=\"12%\"><br>{{IT1/IT104}}</td> <td VALIGN=\"TOP\" width=\"15%\"><br>{{IT1/IT105}}</td> </tr> <tr> <td width=\"15\"></td> <td width=\"55%\" colspan=\"5\"> </td> </tr>",
            //       //HTML = "<tr>\r\n<td VALIGN=TOP width=5%><br>{{IT1/IT101}}</td>\r\n<td width=50%><br> <b>U.P.C./EAN Case Code (2-5-5)</b>: {{IT1/IT107}}<br> </td>\r\n<td VALIGN=TOP width=10%><br>{{IT1/IT102}}</td>\r\n<td VALIGN=TOP width=5%><br>{{IT1/IT103}}</td>\r\n<td VALIGN=TOP width=12%><br>{{IT1/IT104}}</td>\r\n<td VALIGN=TOP width=15%><br>{{IT1/IT105}}</td>\r\n</tr>\r\n<tr>\r\n<td width=15></td>\r\n<td width=55% colspan=5>\r\n<b>\r\n<p ID=idHeader1000 CLASS=clsHeader TITLE=\"Additional Information\">\r\nAdditional Information\r\n</p><div ID=idBlurb1000 CLASS=clsBlurb>\r\n<table border=0 width=100% background=res://VistaRes.Dll/legalpad.gif cellspacing=1 cellpadding=0>\r\n<tr>\r\n<td align=left width=90%>\r\n</td></tr></table></div></b>\r\n<table border=0 cellspacing=0 cellpadding=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n<b>Additional Item Data:\r\n</b></td></tr></table>\r\n<table border=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Number of Units Shipped : {{IT3/IT301}}\r\n</td></tr>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code : {{IT3/IT302}}\r\n</td></tr>\r\n</table><br>\r\n<table border=0 cellspacing=0 cellpadding=0 width=100%>\r\n<tr>\r\n<td width=1% valign=top>\r\n</td>\r\n<td width=99%><table border=0 width=100% cellspacing=0 cellpadding=0>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n<b>Product/Item Description:\r\n</b></td></tr>\r\n<tr>\r\n<td width=100% valign=top align=left>\r\n{{PIDLoop1/PID_2/PID05}}<br> </td></tr>\r\n</table></td></tr></table>\r\n<table border=0 cellspacing=0 cellpadding=0><tr><td></td></tr></table>\r\n</td></tr>",
            //       HTML = "<tr><td VALIGN=TOP width=5%><br/>{{IT1/IT101}}</td><td width=50%><br/> <b>U.P.C./EAN Case Code (2-5-5)</b>: {{IT1/IT107}}<br/> </td><td VALIGN=TOP width=10%><br/>{{IT1/IT102}}</td><td VALIGN=TOP width=5%><br/>{{IT1/IT103}}</td><td VALIGN=TOP width=12%><br/>{{IT1/IT104}}</td><td VALIGN=TOP width=15%><br/>{{IT1/IT105}}</td></tr><tr><td width=15></td><td width=55% colspan=5><b><p ID=idHeader1000 CLASS=clsHeader TITLE=\"Additional Information\">Additional Information </p></b><table border=0 cellspacing=0 cellpadding=0 width=100% cellspacing=0 cellpadding=0><tr><td width=100% valign=top align=left><b>Additional Item Data:</b></td></tr></table><table border=0 width=100% cellspacing=0 cellpadding=0><tr><td width=100% valign=top align=left>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Number of Units Shipped : {{IT1/IT102}}</td></tr><tr><td width=100% valign=top align=left>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code : {{IT1/IT103}}</td></tr></table><br/><table border=0 cellspacing=0 cellpadding=0 width=100%><tr><td width=1% valign=top></td><td width=99%><table border=0 width=100% cellspacing=0 cellpadding=0><tr><td width=100% valign=top align=left><b>Product/Item Description:</b></td></tr><tr><td width=100% valign=top align=left>{{PIDLoop1/PID_2/PID05}}<br/></td></tr></table></td></tr></table><table border=0 cellspacing=0 cellpadding=0><tr><td></td></tr></table></td></tr>",
            //       //HTML = "<tr>\r\n   <td VALIGN=\"TOP\" width=\"5%\"><br>{{IT1/IT101}}</td>\r\n   <td width=\"50%\"><br> <b>U.P.C./EAN Case Code (2-5-5)</b>: {{IT1/IT107}}<br> </td>\r\n   <td VALIGN=\"TOP\" width=\\\"10%\\\"><br>{{IT1/IT102}}</td>\r\n   <td VALIGN=\"TOP\" width=\\\"5%\\\"><br>{{IT1/IT103}}</td>\r\n   <td VALIGN=\"TOP\" width=\\\"12%\\\"><br>{{IT1/IT104}}</td>\r\n   <td VALIGN=\"TOP\" width=\\\"15%\\\"><br>{{IT1/IT105}}</td>\r\n</tr>\r\n<tr>\r\n   <td width=\"15\"></td>\r\n   <td width=\"55%\" colspan=\"5\">\r\n      <b>\r\n         <p ID=\"idHeader1000\" CLASS=\"clsHeader\" TITLE=\"Additional Information\"><img ID=\"idHeaderButton1000\"\r\n            CLASS=\"clsHeaderButton\" SRC=res://VistaRes.Dll/bullet-plus2.gif WIDTH=\"11\" HEIGHT=\"11\" ALT=\"Click to expand\"> \r\n            Additional Information \r\n         <div ID=\"idBlurb1000\" CLASS=\"clsBlurb\"\r\n            >\r\n            <table border=\"0\" width=\"100%\"     background=\"res://VistaRes.Dll/legalpad.gif\" cellspacing=\"1\" cellpadding=\"0\" >\r\n               <tr>\r\n                  <td align =\"left\" width=\"90%\">\r\n      </b>\r\n      <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n      <tr> \r\n      <td width=\"100%\" valign=\"top\" align=\"left\">\r\n      <b>Additional Item Data:\r\n      </b></td></tr></table>\r\n      <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n      <tr> \r\n      <td width=\"100%\" valign=\"top\" align=\"left\">\r\n      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Number of Units Shipped\r\n      : 68\r\n      </td></tr>\r\n      <tr> \r\n      <td width=\"100%\" valign=\"top\" align=\"left\">\r\n      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code\r\n      : Case\r\n      </td></tr>\r\n      </table><br>\r\n      <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\">\r\n      <tr>\r\n      <td width=\"1%\" valign=\"top\">\r\n      </td>\r\n      <td width = \"99%\"><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n      <tr> \r\n      <td width=\"100%\" valign=\"top\" align=\"left\">\r\n      <b>Product/Item Description:\r\n      </b></td></tr>\r\n      <tr> \r\n      <td width=\"100%\" valign=\"top\" align=\"left\">\r\n      </b>SYN Guava 16oz 12pk OG3<br>    </td></tr>\r\n      </table></td></tr></table>\r\n      <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table>\r\n      </td></tr> \r\n      </table> \r\n      </div> \r\n   </td>\r\n</tr>",
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
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//IT3/IT301",
            //            PlaceHolder="{{IT3/IT301}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//IT3/IT302",
            //            PlaceHolder="{{IT3/IT302}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//PIDLoop1/PID_2/PID05",
            //            PlaceHolder="{{PIDLoop1/PID_2/PID05}}",
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
            //},

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
            //},


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
            //       HTML = "<tr>\r\n   <td VALIGN=\"TOP\" width=\"5%\"><br/></td>\r\n   <td width=\"50%\"><br/> <b>U.P.C./EAN Shipping Container Code (1-2-5-5-1)</b>: {{PO1/PO107}}<br/> </td>\r\n   <td VALIGN=\"TOP\" width=\"10%\"><br/>{{PO1/PO102}}</td>\r\n   <td VALIGN=\"TOP\" width=\"5%\"><br/>{{PO1/PO103}}</td>\r\n   <td VALIGN=\"TOP\" width=\"12%\"><br/>{{PO1/PO104}}</td>\r\n   <td VALIGN=\"TOP\" width=\"15%\"><br/>{{PO1/PO105}}</td>\r\n</tr>\r\n<tr>\r\n   <td width=\"15\"></td>\r\n   <td width=\"55%\" colspan=\"5\">\r\n      <br/><b>Line Item Description</b> \r\n      <table border=\"0\" width=\"100%\" cellspacing=\"1\" cellpadding=\"0\">\r\n         <tr>\r\n            <td></td>\r\n            <td align=\"left\" width=\"90%\">{{PID/PID05}}<br/> </td>\r\n         </tr>\r\n      </table>\r\n   </td>\r\n</tr>",
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

            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad860.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad860Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_860.xml"),
            //TemplateSetCode = 860,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH03", PlaceHolder = "{{BCH/BCH03}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH06", PlaceHolder = "{{BCH/BCH06}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH11", PlaceHolder = "{{BCH/BCH11}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH01", PlaceHolder = "{{BCH/BCH01}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH02", PlaceHolder = "{{BCH/BCH02}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'IA']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'IA'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//FOB/FOB01", PlaceHolder = "{{FOB/FOB01}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//FOB/FOB02", PlaceHolder = "{{FOB/FOB02}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//FOB/FOB06", PlaceHolder = "{{FOB/FOB06}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//FOB/FOB07", PlaceHolder = "{{FOB/FOB07}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD03", PlaceHolder = "{{ITD/ITD03}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD05", PlaceHolder = "{{ITD/ITD05}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD12", PlaceHolder = "{{ITD/ITD12}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '037']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '037'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '038']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '038'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '064']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '064'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '001']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '001'}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD502", PlaceHolder = "{{TD5/TD502}}", DefaultValue = "", MappingRequired = true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD503", PlaceHolder = "{{TD5/TD503}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TD5/TD505", PlaceHolder = "{{TD5/TD505}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9Loop1[N9[N901 = 'PO']]/N9/N901", PlaceHolder = "{{N9/N901-N901 = 'PO'}}", DefaultValue = "" , MappingRequired = true  },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9Loop1[N9[N901 = 'PO']]/N9/N902", PlaceHolder = "{{N9/N902-N901 = 'PO'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//MSG/MSG01", PlaceHolder = "{{MSG/MSG01}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'ST'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'ST'}}", DefaultValue = "", MappingRequired = true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'ST'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'ST'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'ST'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'ST'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'ST'}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CUR/CUR02", PlaceHolder = "{{CUR/CUR02}}", DefaultValue = "" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD01", PlaceHolder = "{{ITD/ITD01}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD02", PlaceHolder = "{{ITD/ITD02}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ITD/ITD07", PlaceHolder = "{{ITD/ITD07}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//REF[REF01 = 'DP']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'DP'}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '063']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '063'}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//DTM[DTM01 = '064']/DTM02", PlaceHolder = "{{DTM/DTM02-DTM01 = '064'}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CUR[CUR01 = 'BY']", PlaceHolder = "{{CUR/CUR-BY}}", DefaultValue = "", GetXPathUsingIdentifier = "BY" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CUR[CUR01 = 'SE']", PlaceHolder = "{{CUR/CUR-SE}}", DefaultValue = "", GetXPathUsingIdentifier = "SE" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCH/BCH11", PlaceHolder = "{{BCH/BCH11}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//FOB", PlaceHolder = "{{FOB-CI}}", DefaultValue = "", GetXPathUsingIdentifier = "CI" },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9Loop1[N9[N901 = 'AH']]/N9[N901 = 'AH']", PlaceHolder = "{{N9/N901-N901 = 'AH'}}", DefaultValue = "", GetXPathUsingIdentifier = "AH"},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" CELLSPACING=\"0\" HEIGHT=\"1\">\r\n<tr>\r\n   <td width=\"5%\"><b>Line</b></td>\r\n   <td width=\"43%\"><b>Description</b></td>\r\n   <td width=\"10%\"><b>Old Quantity</b></td>\r\n   <td width=\"10%\"><b>New Quantity</b></td>\r\n   <td width=\"10%\"><b>Quan Ord</b></td>\r\n   <td width=\"10%\"><b>Quan to Rec</b></td>\r\n   <td width=\"7%\"><b>UI</b></td>\r\n   <td width=\"10%\"><b>Price(Basis)&nbsp; </b></td>\r\n   <td width=\"10%\"><b>Price($)</b></td>\r\n</tr>\r\n<tr>\r\n   <td VALIGN=\"TOP\" width=\"5%\">{{POC/POC01}}</td>\r\n   <td width=\"48%\"> <b>Vendor's Style Number</b>: {{POC/VA}}<br/> <b>U.P.C. Consumer Package Code (1-5-5-1)</b>: {{POC/UP}} <br/> <b>GTIN</b>:{{POC/SK}} <br/> <b>Buyer's Item Number</b>:{{POC/POC13}} <br/> <b>Buyer Part </b>:{{POC/IN}} <br/> <b>Vendor Part </b>: {{POC/VN}} <br/> <b>Pack </b>: {{PO4/PO401}} <br/> <b>Size </b>: {{PO4/PO402}} <br/> <b>Product Size </b>: {{POC/IZ}} <br/> <b>Buyer's Style Number </b>: {{POC/IT}} <br/> <b>Product Color </b>: {{PID/PID05}} <br/> <b>Buyer's Catalog Number </b>: {{POC/CB}} <br/> <b>Retail Unit Price </b>: {{CTP_2/RES}} <br/> <b>Message Text </b>: {{MSG/MSG01}} <br/> <b>Unit or Basis for Measurement Code </b>: {{PO4/PO403}} <br/> <b>UOM </b>: {{POC/POC06}} <br/> <b>Change Type</b>: {{POC/POC02}} <br/> </td>\r\n   <td VALIGN=\"TOP\" width=\"10%\">{{POC/DI}}</td>\r\n   <td VALIGN=\"TOP\" width=\"10%\">{{POC/DI-1}}</td>\r\n   <td VALIGN=\"TOP\" width=\"10%\">{{POC/POC03}}</td>\r\n   <td VALIGN=\"TOP\" width=\"10%\">{{POC/POC04}}</td>\r\n   <td VALIGN=\"TOP\" width=\"3%\">{{PO4/PO403}}</td>\r\n   <td VALIGN=\"TOP\" width=\"6%\"></td>\r\n   <td VALIGN=\"TOP\" width=\"10%\">{{POC/EA}}</td>\r\n</tr>\r\n<tr>\r\n   <td width=\"15\"></td>\r\n   <td width=\"55%\" colspan=\"5\">\r\n      <br/><b>Line Item Description (Source: Product)</b> \r\n      <table border=\"0\" width=\"100%\" background=\"res://VistaRes.Dll/legalpad.gif\" cellspacing=\"1\" cellpadding=\"0\" doDocumentonClick()>\r\n         <tr>\r\n            <td></td>\r\n            <td align=\"left\" width=\"90%\">{{PID/PID05-BO = '75'}} {{PID/PID05-PID01 = '75'}} <br/> </td>\r\n         </tr>\r\n         <tr>\r\n            <td></td>\r\n            <td align=\"left\" width=\"90%\">{{PID/PID05-PID01 = '08'}} <br/></td>\r\n         </tr>\r\n      </table>\r\n   </td>\r\n</tr>\r\n</table>",
            //        LineLevelXPath = "//POCLoop1[POC]",
            //        PlaceHolder = "{{LinedItemHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC/POC01",
            //            PlaceHolder="{{POC/POC01}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/VA}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "VA"
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/UP}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "UP"
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/SK}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "SK"
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC/POC13",
            //            PlaceHolder="{{POC/POC13}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC/POC06",
            //            PlaceHolder="{{POC/POC06}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/IN}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "IN"
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC/POC02",
            //            PlaceHolder="{{POC/POC02}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC/POC03",
            //            PlaceHolder="{{POC/POC03}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC/POC04",
            //            PlaceHolder="{{POC/POC04}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/PO4/PO403",
            //            PlaceHolder="{{PO4/PO403}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/EA}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "EA",
            //            PreferedXpaths = new List<PreferedXpath>()
            //            {
            //                new PreferedXpath(){ XPath = "//POCLoop1[POC]/CTP_2[CTP02 = 'UCP']",Identifier = "UCP",TotalNodes = "2",SelectedNode = "1"},
            //                new PreferedXpath(){ XPath = "//POCLoop1[POC]/POC",Identifier = "EA",TotalNodes = "",SelectedNode = ""}

            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{CTP_2/RES}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "RES",
            //            PreferedXpaths = new List<PreferedXpath>()
            //            {
            //                new PreferedXpath(){ XPath = "//POCLoop1[POC]/CTP_2[CTP02 = 'RES']",Identifier = "RES",TotalNodes = "2",SelectedNode = "1"}

            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/DI}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "DI"
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/DI-1}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "DI",
            //            GetXPathUsingIdentifierOneStepHead = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{PID/PID05-BO = '75'}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "BO"
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/PIDLoop1[PID_2]/PID_2[PID02 = '75']/PID05",
            //            PlaceHolder="{{PID/PID05-PID01 = '75'}}",
            //            DefaultValue="",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/PIDLoop1[PID_2]/PID_2[PID02 = '08']/PID05",
            //            PlaceHolder="{{PID/PID05-PID01 = '08'}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/VN}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "VN"
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/PO4/PO401",
            //            PlaceHolder="{{PO4/PO401}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/PO4/PO402",
            //            PlaceHolder="{{PO4/PO402}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/PO4/PO403",
            //            PlaceHolder="{{PO4/PO403}}",
            //            DefaultValue="",
            //            MappingRequired = true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/IZ}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "IZ",
            //            PreferedXpaths = new List<PreferedXpath>()
            //            {
            //                new PreferedXpath(){ XPath = "//POCLoop1[POC]/PIDLoop1[PID_2]/PID_2[PID02 = '74']/PID05",Identifier = "",TotalNodes = "",SelectedNode = ""},
            //                new PreferedXpath(){ XPath = "//POCLoop1[POC]/POC",Identifier = "IZ",TotalNodes = "",SelectedNode = ""}

            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/PIDLoop1[PID_2]/PID_2[PID02 = '73']/PID05",
            //            PlaceHolder="{{PID/PID05}}",
            //            DefaultValue="",
            //            PreferedXpaths = new List<PreferedXpath>()
            //            {
            //                new PreferedXpath(){ XPath = "//POCLoop1[POC]/POC",Identifier = "BO",TotalNodes = "",SelectedNode = ""},
            //                new PreferedXpath(){ XPath = "//POCLoop1[POC]/PIDLoop1[PID_2]/PID_2[PID02 = '73']/PID05",Identifier = "",TotalNodes = "",SelectedNode = ""}

            //            }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/CB}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "CB"
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/POC",
            //            PlaceHolder="{{POC/IT}}",
            //            DefaultValue="",
            //            GetXPathUsingIdentifier = "IT",
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//POCLoop1[POC]/MSG_5/MSG01",
            //            PlaceHolder="{{MSG/MSG01}}",
            //            DefaultValue="",
            //            ConcatinationUsingSameXPath = true,
            //            ShowInLastLineItem = true
            //        }

            //    }
            //    }
            //}

            //}
            //}

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
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Warehouse Item Detail: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Shipment/Order Status Code : {{W12/W1201}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Number of Units Shipped : {{W12/W1203}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code : {{W12/W1205}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID Qualifier : {{W12/W1207}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID : {{W12/W1208}} </td></tr> </table><br/>",
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
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Reference Identification: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification Qualifier : {{N9/N901}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification : {{N9/N902}} </td></tr> </table><br/>",
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


            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad820.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad820Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_820.xml"),
            //TemplateSetCode = 820,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BPR/BPR01", PlaceHolder = "{{BPR/BPR01}}", DefaultValue = "", MappingRequired= true },
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BPR/BPR02", PlaceHolder = "{{BPR/BPR02}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BPR/BPR03", PlaceHolder = "{{BPR/BPR03}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BPR/BPR04", PlaceHolder = "{{BPR/BPR04}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BPR/BPR16", PlaceHolder = "{{BPR/BPR16}}", DefaultValue = "",  DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BPR/BPR17", PlaceHolder = "{{BPR/BPR17}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TRN/TRN01", PlaceHolder = "{{TRN/TRN01}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//TRN/TRN02", PlaceHolder = "{{TRN/TRN02}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CUR[CUR01 = 'PR']/CUR02", PlaceHolder = "{{CUR/CUR02-CUR01 = 'PR'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'PR']]/N1/N102", PlaceHolder = "{{N1/N102-N101= 'PR'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'PR']]/N1/N103", PlaceHolder = "{{N1/N103-N101= 'PR'}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'PR']]/N1/N104", PlaceHolder = "{{N1/N104-N101= 'PR'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'PE']]/N1/N102", PlaceHolder = "{{N1/N102-N101= 'PE'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[REF_2[REF01 = 'IA']]/REF_2/REF02", PlaceHolder = "{{N1/REF02-REF01= 'IA'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//ENTLoop1[ENT]/ENT/ENT01", PlaceHolder = "{{TRN/TRN01}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Remittance Advice Accounts Receivable Open Item Reference: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification Qualifier : {{RMR/RMR01}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification : {{RMR/RMR02}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Payment Action Code : {{RMR/RMR03}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Monetary Amount : {{RMR/RMR04}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Monetary Amount : {{RMR/RMR05}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Monetary Amount : {{RMR/RMR06}} </td></tr> </table><br/> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Reference Information: </b> </td></tr> </table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Purchase Order Number : {{REF_7/REF02-REF01 = 'PO'}}    </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Department Number : {{REF_7/REF02-REF01 = 'DP'}}   </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Merchandise Type Code : {{REF_7/REF02-REF01 = 'MR'}}   </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Division Identifier : {{REF_7/REF02-REF01 = '19'}}    </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Store Number : {{REF_7/REF02-REF01 = 'ST'}}    </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Microfilm Number : {{REF_7/REF02-REF01 = 'MC'}}   </td></tr> </table><br/> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Date/Time Reference </b></td></tr> </table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Transaction Creation : {{DTM_7/DTM02-DTM01 = '097'}}    </td></tr> </table><br/> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Adjustment: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Monetary Amount : {{ADX_2/ADX01}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Adjustment Reason Code : {{ADX_2/ADX02}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification Qualifier : {{ADX_2/ADX03}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification : {{ADX_2/ADX04}} </td></tr> </table><br/> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Reference Information: </b> </td></tr> </table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Cross Reference Number : {{REF_10/REF02-REF01 = '6O'}}    </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Microfilm Number : {{REF_10/REF02-REF01 = 'MC'}}   </td></tr> </table><br/>",
            //        LineLevelXPath = "//ENTLoop1[RMRLoop1]//RMRLoop1[RMR]",
            //        PlaceHolder = "{{LinedItemHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//RMR/RMR01",
            //            PlaceHolder="{{RMR/RMR01}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//RMR/RMR02",
            //            PlaceHolder="{{RMR/RMR02}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//RMR/RMR03",
            //            PlaceHolder="{{RMR/RMR03}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//RMR/RMR04",
            //            PlaceHolder="{{RMR/RMR04}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//RMR/RMR05",
            //            PlaceHolder="{{RMR/RMR05}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//RMR/RMR06",
            //            PlaceHolder="{{RMR/RMR06}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//REF_7[REF01 = 'PO']/REF02",
            //            PlaceHolder="{{REF_7/REF02-REF01 = 'PO'}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//REF_7[REF01 = 'DP']/REF02",
            //            PlaceHolder="{{REF_7/REF02-REF01 = 'DP'}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//REF_7[REF01 = 'MR']/REF02",
            //            PlaceHolder="{{REF_7/REF02-REF01 = 'MR'}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//REF_7[REF01 = '19']/REF02",
            //            PlaceHolder="{{REF_7/REF02-REF01 = '19'}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//REF_7[REF01 = 'ST']/REF02",
            //            PlaceHolder="{{REF_7/REF02-REF01 = 'ST'}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//REF_7[REF01 = 'MC']/REF02",
            //            PlaceHolder="{{REF_7/REF02-REF01 = 'MC'}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//DTM_7[DTM01 = '097']/DTM02",
            //            PlaceHolder="{{DTM_7/DTM02-DTM01 = '097'}}",
            //            DefaultValue="",
            //            DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//ADXLoop2[ADX_2]/ADX_2/ADX01",
            //            PlaceHolder="{{ADX_2/ADX01}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//ADXLoop2[ADX_2]/ADX_2/ADX02",
            //            PlaceHolder="{{ADX_2/ADX02}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//ADXLoop2[ADX_2]/ADX_2/ADX03",
            //            PlaceHolder="{{ADX_2/ADX03}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//ADXLoop2[ADX_2]/ADX_2/ADX04",
            //            PlaceHolder="{{ADX_2/ADX04}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//ADXLoop2[ADX_2]/REFLoop6[REF_10[REF01 = '6O']]/REF_10/REF02",
            //            PlaceHolder="{{REF_10/REF02-REF01 = '6O'}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//ADXLoop2[ADX_2]/REFLoop6[REF_10[REF01 = 'MC']]/REF_10/REF02",
            //            PlaceHolder="{{REF_10/REF02-REF01 = 'MC'}}",
            //            DefaultValue=""
            //        }


            //    }
            //    }
            //    }
            //}
            //}


            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad812.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad812Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_812.xml"),
            //TemplateSetCode = 812,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD01", PlaceHolder = "{{BCD/BCD01}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD02", PlaceHolder = "{{BCD/BCD02}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD03", PlaceHolder = "{{BCD/BCD03}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD04", PlaceHolder = "{{BCD/BCD04}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD05", PlaceHolder = "{{BCD/BCD05}}", DefaultValue = "",  MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD06", PlaceHolder = "{{BCD/BCD06}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD07", PlaceHolder = "{{BCD/BCD07}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD09", PlaceHolder = "{{BCD/BCD09}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD10", PlaceHolder = "{{BCD/BCD10}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD11", PlaceHolder = "{{BCD/BCD11}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BCD/BCD12", PlaceHolder = "{{BCD/BCD12}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//CUR[CUR01 = 'BY']/CUR02", PlaceHolder = "{{CUR/CUR02-CUR01 = 'BY'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'IA']/N901", PlaceHolder = "{{N9/N901-N901 = 'IA'}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'IA']/N902", PlaceHolder = "{{N9/N902-N901 = 'IA'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'MC']/N901", PlaceHolder = "{{N9/N901-N901 = 'MC'}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'MC']/N902", PlaceHolder = "{{N9/N902-N901 = 'MC'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'DP']/N901", PlaceHolder = "{{N9/N901-N901 = 'DP'}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'DP']/N902", PlaceHolder = "{{N9/N902-N901 = 'DP'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'MR']/N901", PlaceHolder = "{{N9/N901-N901 = 'MR'}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N9[N901 = 'MR']/N902", PlaceHolder = "{{N9/N902-N901 = 'MR'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//PER[PER01 = 'CR']/PER02", PlaceHolder = "{{PER/PER02-PER01 = 'CR'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//PER[PER01 = 'CR']/PER04", PlaceHolder = "{{PER/PER04-PER01 = 'CR'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'XI']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'XI'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'XI']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'XI'}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'XI']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'XI'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SU']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'SU'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = null,
            //    LineLevel = new LineLevel()
            //    {
            //       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Credit/Debit Adjustment Detail: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Adjustment Reason Code : {{CDD/CDD01}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Credit/Debit Flag Code : {{CDD/CDD02}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Assigned Identification : {{CDD/CDD03}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Amount : {{CDD/CDD04}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Price Identifier Code : {{CDD/CDD10}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit Price : {{CDD/CDD11}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit Price : {{CDD/CDD13}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Free-form Message Text : {{CDD/CDD14}} </td></tr> </table><br/> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Extended Reference Information: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification Qualifier : {{N9_3/N901}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reference Identification : {{N9_3/N902}} </td></tr> </table><br/>",
            //        LineLevelXPath = "//CDDLoop1",
            //        PlaceHolder = "{{LinedItemHtml}}",
            //        XPathConnfigs = new List<XPathConnfig>() {
            //        new XPathConnfig()
            //        {
            //            XPath="//CDD/CDD01",
            //            PlaceHolder="{{CDD/CDD01}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//CDD/CDD02",
            //            PlaceHolder="{{CDD/CDD02}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//CDD/CDD03",
            //            PlaceHolder="{{CDD/CDD03}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//CDD/CDD04",
            //            PlaceHolder="{{CDD/CDD04}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//CDD/CDD10",
            //            PlaceHolder="{{CDD/CDD10}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//CDD/CDD11",
            //            PlaceHolder="{{CDD/CDD11}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//CDD/CDD13",
            //            PlaceHolder="{{CDD/CDD13}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//CDD/CDD14",
            //            PlaceHolder="{{CDD/CDD14}}",
            //            DefaultValue=""
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//N9_3/N901",
            //            PlaceHolder="{{N9_3/N901}}",
            //            DefaultValue="",
            //            MappingRequired= true
            //        },
            //        new XPathConnfig()
            //        {
            //            XPath="//N9_3/N902",
            //            PlaceHolder="{{N9_3/N902}}",
            //            DefaultValue=""
            //        }
            //    }
            //    }
            //    }
            //}
            //}



            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad864.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad864Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_864.xml"),
            //TemplateSetCode = 864,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BMG/BMG01", PlaceHolder = "{{BMG/BMG01}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //        XPathConnfig = new XPathConnfig() { XPath = "//DTM/DTM02", PlaceHolder = "{{DTM/DTM02}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //        LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BMG/BMG02", PlaceHolder = "{{BMG/BMG02}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//BMG/BMG03", PlaceHolder = "{{BMG/BMG03}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'FR']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'FR'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'FR']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'FR'}}", DefaultValue = "",  MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'FR']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'FR'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'TO']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'TO'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[REF[REF01 = 'IA' or REF01 = 'VR']]/REF[REF01 = 'IA' or REF01 = 'VR']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'IA'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[REF[REF01 = 'IV']]/REF[REF01 = 'IV']/REF02", PlaceHolder = "{{REF/REF02-REF01 = 'IV'}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//MITLoop1[MIT]/MIT/MIT01", PlaceHolder = "{{MIT/MIT01}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//MITLoop1[MIT]/MIT/MIT02", PlaceHolder = "{{MIT/MIT02}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//MSG/MSG01", PlaceHolder = "{{MSG/MSG01}}", DefaultValue = "",ConcatinationUsingSameXPath = true},
            //    LineLevel = null
            //    }

            //}
            //},

            //new HumanReadableConfiguration()
            //{
            //    TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoadDF832.html"),
            //    TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoadDF832Updated.html"),
            //    PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_DF_832.xml"),
            //    TemplateSetCode = 832,
            //    KDIVersion = "",
            //    configurations = new List<Configuration>() {
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//BCT/BCT01", PlaceHolder = "{{BCT/BCT01}}", DefaultValue = "", MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//BCT/BCT02", PlaceHolder = "{{BCT/BCT02}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//BCT/BCT09", PlaceHolder = "{{BCT/BCT09}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//BCT/BCT10", PlaceHolder = "{{BCT/BCT10}}", DefaultValue = "",MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'DS']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'DS'}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/N1/N104", PlaceHolder = "{{N1Loop1/N1/N104}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/N3/N301", PlaceHolder = "{{N1Loop1/N3/N301}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/N4/N401", PlaceHolder = "{{N1Loop1/N4/N401}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/N4/N402", PlaceHolder = "{{N1Loop1/N4/N402}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/N4/N403", PlaceHolder = "{{N1Loop1/N4/N403}}", DefaultValue = ""},
            //            LineLevel = null
            //        },

            //    new Configuration()
            //    {
            //        XPathConnfig = null,
            //        LineLevel = new LineLevel()
            //        {

            //          //HTML = "<table style=\"border: 0px; border-style: solid; border-color: black; padding: 2pt; \" WIDTH=\"638\">\r\n<tr><td width=\"100%\" class=\"sectiontitle\"><font face=\"Arial\" color=\"LightGrey\">Line Item</font></td></tr>\r\n<tr><td width=\"100%\">\r\n <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td>\r\n<b>Part Numbers</b>\r\n</td></tr></table>\r\n <table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" \r\n bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\"   background=\"res://VistaRes.Dll/legalpad.gif\"> \r\n\r\n<tr><td WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vendor's (Seller's) Item Number</td><td BGCOLOR=\"#FFFFFF\">{{LIN/LIN03-LIN02 = 'VN'}}</td></tr>\r\n<tr><td WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Brand/Label</td><td BGCOLOR=\"#FFFFFF\">{{LIN/LIN05-LIN04 = 'BL'}}</td></tr>\r\n<tr><td WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Commodity Name</td><td BGCOLOR=\"#FFFFFF\">{{LIN/LIN09-LIN08 = 'CN'}}</td></tr>\r\n<tr><td WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;U.P.C./EAN Case Code (2-5-5)</td><td BGCOLOR=\"#FFFFFF\">{{LIN/LIN13-LIN12 = 'UA'}}</td></tr>\r\n<tr><td WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Classification</td><td BGCOLOR=\"#FFFFFF\">{{LIN/LIN23-LIN22 = 'C3'}}</td></tr>\r\n</table>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Reference Identification: </b>\r\n</td></tr>\r\n</table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vendor ID Number\r\n    : {{REF_3/REF02-REF01 = 'VR'}}    </td></tr>\r\n</table><br/>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\">\r\n  <tr>\r\n    <td width=\"1%\" valign=\"top\">\r\n    </td>\r\n    <td width = \"99%\"><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Product/Item Description:\r\n</b></td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n{{PID/PID05}}<br/>    </td></tr>\r\n</table></td></tr></table>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Measurements:\r\n</b></td></tr></table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Measurement Reference ID Code\r\n    : {{MEA/MEA01}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Measurement Qualifier\r\n    : {{MEA/MEA02}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Measurement Value\r\n    : {{MEA/MEA03}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Composite Unit of Measure\r\n    : {{MEA/MEA05}}\r\n    </td></tr>\r\n</table><br/>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Pricing Information:\r\n</b></td></tr></table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Price Identifier Code\r\n    : {{CTPLoop1/CTP_2/CTP02}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit Price\r\n    : {{CTPLoop1/CTP_2/CTP03}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quantity\r\n    : {{CTPLoop1/CTP_2/CTP04}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Composite Unit of Measure\r\n    : {{CTPLoop1/CTP_2/CTP06}}\r\n    </td></tr>\r\n</table><br/>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Date/Time Reference\r\n</b></td></tr>\r\n</table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Effective\r\n    : {{CTPLoop1/DTM_5/DTM02}}     </td></tr>\r\n</table><br/>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Item Characteristics - Vendor's Selling Unit:\r\n</b></td></tr></table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID Qualifier\r\n    : {{G39Loop1/G39/G3902}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID\r\n    : {{G39Loop1/G39/G3903}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit Weight\r\n    : {{G39Loop1/G39/G3905}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Weight Qualifier\r\n    : {{G39Loop1/G39/G3906}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Weight Unit Code\r\n    : {{G39Loop1/G39/G3907}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pack\r\n    : {{G39Loop1/G39/G3917}}\r\n    </td></tr>\r\n</table><br/>\r\n</td></tr>\r\n</table><br/>\r\n <hr style=\"height: 1px; border-style: solid; border-color: LightGrey; padding: 2pt; \" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\"/>",
            //          HTML = "<table style=\"border: 0px; border-style: solid; border-color: black; padding: 2pt; \" WIDTH=\"638\">\r\n<tr><td width=\"100%\" class=\"sectiontitle\"><font face=\"Arial\" color=\"LightGrey\">Line Item</font></td></tr>\r\n<tr><td width=\"100%\">\r\n <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td>\r\n<b>Part Numbers</b>\r\n</td></tr></table>\r\n <table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" \r\n bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\"   background=\"res://VistaRes.Dll/legalpad.gif\"> \r\n\r\n<tr><td WIDTH=\"35%\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vendor's (Seller's) Item Number</td><td >{{LIN/LIN03-LIN02 = 'VN'}}</td></tr>\r\n<tr><td WIDTH=\"35%\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Brand/Label</td><td >{{LIN/LIN05-LIN04 = 'BL'}}</td></tr>\r\n<tr><td WIDTH=\"35%\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Commodity Name</td><td >{{LIN/LIN09-LIN08 = 'CN'}}</td></tr>\r\n<tr><td WIDTH=\"35%\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;U.P.C./EAN Case Code (2-5-5)</td><td >{{LIN/LIN13-LIN12 = 'UA'}}</td></tr>\r\n<tr><td WIDTH=\"35%\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Classification</td><td >{{LIN/LIN23-LIN22 = 'C3'}}</td></tr>\r\n</table>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Reference Identification: </b>\r\n</td></tr>\r\n</table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vendor ID Number\r\n    : {{REF_3/REF02-REF01 = 'VR'}}    </td></tr>\r\n</table><br/>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\">\r\n  <tr>\r\n    <td width=\"1%\" valign=\"top\">\r\n    </td>\r\n    <td width = \"99%\"><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Product/Item Description:\r\n</b></td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n{{PID/PID05}}<br/>    </td></tr>\r\n</table></td></tr></table>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Measurements:\r\n</b></td></tr></table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Measurement Reference ID Code\r\n    : {{MEA/MEA01}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Measurement Qualifier\r\n    : {{MEA/MEA02}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Measurement Value\r\n    : {{MEA/MEA03}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Composite Unit of Measure\r\n    : {{MEA/MEA05}}\r\n    </td></tr>\r\n</table><br/>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Pricing Information:\r\n</b></td></tr></table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Price Identifier Code\r\n    : {{CTPLoop1/CTP_2/CTP02}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit Price\r\n    : {{CTPLoop1/CTP_2/CTP03}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quantity\r\n    : {{CTPLoop1/CTP_2/CTP04}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Composite Unit of Measure\r\n    : {{CTPLoop1/CTP_2/CTP06}}\r\n    </td></tr>\r\n</table><br/>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Date/Time Reference\r\n</b></td></tr>\r\n</table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Effective\r\n    : {{CTPLoop1/DTM_5/DTM02}}     </td></tr>\r\n</table><br/>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Item Characteristics - Vendor's Selling Unit:\r\n</b></td></tr></table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID Qualifier\r\n    : {{G39Loop1/G39/G3902}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID\r\n    : {{G39Loop1/G39/G3903}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit Weight\r\n    : {{G39Loop1/G39/G3905}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Weight Qualifier\r\n    : {{G39Loop1/G39/G3906}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Weight Unit Code\r\n    : {{G39Loop1/G39/G3907}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pack\r\n    : {{G39Loop1/G39/G3917}}\r\n    </td></tr>\r\n</table><br/>\r\n</td></tr>\r\n</table><br/>\r\n <hr style=\"height: 1px; border-style: solid; border-color: LightGrey; padding: 2pt; \" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\"/>",
            //            LineLevelXPath = "//LINLoop1",
            //            PlaceHolder = "{{TransactionInformationHtml}}",
            //            XPathConnfigs = new List<XPathConnfig>()
            //            {
            //                #region LIN
            //                //Vendor's (Seller's) Item Number
            //	            new XPathConnfig(){
            //                    XPath="//LIN[LIN02 = 'VN']/LIN03",
            //                    PlaceHolder="{{LIN/LIN03-LIN02 = 'VN'}}",
            //                    DefaultValue="",
            //                    IsIdentityMarker=true
            //                },
            //                //Brand/Label
            //                new XPathConnfig(){
            //                    XPath="//LIN[LIN04 = 'BL']/LIN05",
            //                    PlaceHolder="{{LIN/LIN05-LIN04 = 'BL'}}",
            //                    DefaultValue=""
            //                },
            //                //Commodity Name
            //                new XPathConnfig(){
            //                    XPath="//LIN[LIN08 = 'CN']/LIN09",
            //                    PlaceHolder="{{LIN/LIN09-LIN08 = 'CN'}}",
            //                    DefaultValue=""
            //                },
            //                //U.P.C./EAN Case Code (2-5-5)
            //                new XPathConnfig(){
            //                    XPath="//LIN[LIN12 = 'UA']/LIN13",
            //                    PlaceHolder="{{LIN/LIN13-LIN12 = 'UA'}}",
            //                    DefaultValue=""
            //                },
            //                //Classification
            //                new XPathConnfig(){
            //                    XPath="//LIN[LIN22 = 'C3']/LIN23",
            //                    PlaceHolder="{{LIN/LIN23-LIN22 = 'C3'}}",
            //                    DefaultValue=""
            //                },
            //                #endregion

            //                #region REF_3
            //                //Vendor ID Number
            //                new XPathConnfig(){
            //                    XPath="//REF_3[REF01 = 'VR']/REF02",
            //                    PlaceHolder="{{REF_3/REF02-REF01 = 'VR'}}",
            //                    DefaultValue=""
            //                },
            //                #endregion

            //                #region PID
            //                //Product/Item Description
            //                new XPathConnfig(){
            //                    XPath="//PID//PID05",
            //                    PlaceHolder="{{PID/PID05}}",
            //                    DefaultValue=""
            //                },
            //                #endregion

            //                #region Measurements
            //                //Measurement Reference ID Code
            //                new XPathConnfig(){
            //                    XPath="//MEA//MEA01",
            //                    PlaceHolder="{{MEA/MEA01}}",
            //                    DefaultValue="",
            //                    MappingRequired=true
            //                },
            //                //Measurement Qualifier
            //                new XPathConnfig(){
            //                    XPath="//MEA//MEA02",
            //                    PlaceHolder="{{MEA/MEA02}}",
            //                    DefaultValue="",
            //                    MappingRequired=true
            //                },
            //                //Measurement Value
            //                new XPathConnfig(){
            //                    XPath="//MEA//MEA03",
            //                    PlaceHolder="{{MEA/MEA03}}",
            //                    DefaultValue=""
            //                },
            //                //Composite Unit of Measure
            //                new XPathConnfig(){
            //                    XPath="//MEA//MEA05",
            //                    PlaceHolder="{{MEA/MEA05}}",
            //                    DefaultValue="",
            //                    MappingRequired=true
            //                },
            //                #endregion

            //                #region Pricing Information
            //                //Price Identifier Code
            //                new XPathConnfig(){
            //                    XPath="//CTPLoop1//CTP_2//CTP02",
            //                    PlaceHolder="{{CTPLoop1/CTP_2/CTP02}}",
            //                    DefaultValue="",
            //                    MappingRequired=true
            //                },
            //                //Unit Price
            //                new XPathConnfig(){
            //                    XPath="//CTPLoop1//CTP_2//CTP03",
            //                    PlaceHolder="{{CTPLoop1/CTP_2/CTP03}}",
            //                    DefaultValue=""
            //                },
            //                //Quantity
            //                new XPathConnfig(){
            //                    XPath="//CTPLoop1//CTP_2//CTP04",
            //                    PlaceHolder="{{CTPLoop1/CTP_2/CTP04}}",
            //                    DefaultValue=""
            //                },
            //                //Composite Unit of Measure
            //                new XPathConnfig(){
            //                    XPath="//CTPLoop1//CTP_2//CTP06",
            //                    PlaceHolder="{{CTPLoop1/CTP_2/CTP06}}",
            //                    DefaultValue="",
            //                    MappingRequired=true
            //                },
            //                #endregion

            //                #region Date/Time Reference
            //                //Effective
            //                new XPathConnfig(){
            //                    XPath="//CTPLoop1//DTM_5//DTM02",
            //                    PlaceHolder="{{CTPLoop1/DTM_5/DTM02}}",
            //                    DefaultValue="",
            //                    DateFormat=new DateFormat{
            //                        SourceFormat="yyyyMMdd",
            //                        TargetFormat="MM/dd/yyyy"
            //                    }
            //                },
            //                #endregion

            //                #region Item Characteristics - Vendor's Selling Unit
            //                //Product/Service ID Qualifier
            //                new XPathConnfig(){
            //                    XPath="//G39Loop1//G39//G3902",
            //                    PlaceHolder="{{G39Loop1/G39/G3902}}",
            //                    DefaultValue="",
            //                    MappingRequired=true
            //                },
            //                //Product/Service ID
            //                new XPathConnfig(){
            //                    XPath="//G39Loop1//G39//G3903",
            //                    PlaceHolder="{{G39Loop1/G39/G3903}}",
            //                    DefaultValue=""
            //                },
            //                 //Unit Weight
            //                 new XPathConnfig(){
            //                    XPath="//G39Loop1//G39//G3905",
            //                    PlaceHolder="{{G39Loop1/G39/G3905}}",
            //                    DefaultValue=""
            //                },
            //                 //Weight Qualifier
            //                 new XPathConnfig(){
            //                    XPath="//G39Loop1//G39//G3906",
            //                    PlaceHolder="{{G39Loop1/G39/G3906}}",
            //                    DefaultValue="",
            //                    MappingRequired=true
            //                },
            //                 //Weight Unit Code
            //                 new XPathConnfig(){
            //                    XPath="//G39Loop1//G39//G3907",
            //                    PlaceHolder="{{G39Loop1/G39/G3907}}",
            //                    DefaultValue="",
            //                    MappingRequired=true
            //                },
            //                 //Pack
            //                 new XPathConnfig(){
            //                    XPath="//G39Loop1//G39//G3917",
            //                    PlaceHolder="{{G39Loop1/G39/G3917}}",
            //                    DefaultValue=""
            //                },
            //                #endregion
            //            },
            //        }
            //    }
            //}
            //}


            //new HumanReadableConfiguration()
            //{
            //TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad894.html"),
            //TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad894Updated.html"),
            //PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_894.xml"),
            //TemplateSetCode = 894,
            //KDIVersion = "",
            //configurations = new List<Configuration>() {
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G82/G8201", PlaceHolder = "{{G82/G8201}}", DefaultValue = "", MappingRequired= true},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G82/G8202", PlaceHolder = "{{G82/G8202}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G82/G8203", PlaceHolder = "{{G82/G8203}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G82/G8204", PlaceHolder = "{{G82/G8204}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G82/G8205", PlaceHolder = "{{G82/G8205}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G82/G8206", PlaceHolder = "{{G82/G8206}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G82/G8207", PlaceHolder = "{{G82/G8207}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//LSLoop1/LS/LS01", PlaceHolder = "{{LSLoop1/LS/LS01}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    new Configuration()
            //    {
            //        XPathConnfig = null,
            //        LineLevel = new LineLevel()
            //        {
            //            HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Line Item Detail/Direct Store Delivery:\r\n</b></td></tr></table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Direct Store Delivery Sequence Number\r\n    : {{G83/G8301}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quantity\r\n    : {{G83/G8302}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code\r\n    : {{G83/G8303}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;U.P.C./EAN Consumer Package Code\r\n    : {{G83/G8304}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID Qualifier\r\n    : {{G83/G8305}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID\r\n    : {{G83/G8306}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Item List Cost\r\n    : {{G83/G8308}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pack\r\n    : {{G83/G8309}}\r\n    </td></tr>\r\n</table><br/>\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n<b>Allowance or Charge:\r\n</b></td></tr></table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > \r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Allowance or Charge Code\r\n    : {{G72/G7201}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Allowance or Charge Method of Handling Code\r\n    : {{G72/G7202}}\r\n    </td></tr>\r\n  <tr> \r\n    <td width=\"100%\" valign=\"top\" align=\"left\">\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Allowance or Charge Total Amount\r\n    : {{G72/G7208}}\r\n    </td></tr>\r\n</table><br/>",
            //            LineLevelXPath = "//G83Loop1",
            //            PlaceHolder = "{{TransactionInformationHtml}}",
            //            XPathConnfigs = new List<XPathConnfig>()
            //            {
            //                //Direct Store Delivery Sequence Number
            //                new XPathConnfig(){
            //                        XPath="//G83//G8301",
            //                        PlaceHolder="{{G83/G8301}}",
            //                        DefaultValue="",
            //                },
            //                //Quantity
            //                new XPathConnfig(){
            //                        XPath="//G83//G8302",
            //                        PlaceHolder="{{G83/G8302}}",
            //                        DefaultValue="",
            //                },
            //                //Unit or Basis for Measurement Code
            //                new XPathConnfig(){
            //                        XPath="//G83//G8303",
            //                        PlaceHolder="{{G83/G8303}}",
            //                        DefaultValue="",
            //                        MappingRequired= true
            //                },
            //                //U.P.C./EAN Consumer Package Code
            //                new XPathConnfig(){
            //                        XPath="//G83//G8304",
            //                        PlaceHolder="{{G83/G8304}}",
            //                        DefaultValue="",
            //                },
            //                //Product/Service ID Qualifier
            //                new XPathConnfig(){
            //                        XPath="//G83//G8305",
            //                        PlaceHolder="{{G83/G8305}}",
            //                        DefaultValue="",
            //                        MappingRequired= true
            //                },
            //                //Product/Service ID
            //                new XPathConnfig(){
            //                        XPath="//G83//G8306",
            //                        PlaceHolder="{{G83/G8306}}",
            //                        DefaultValue="",
            //                },
            //                //Item List Cost
            //                new XPathConnfig(){
            //                        XPath="//G83//G8308",
            //                        PlaceHolder="{{G83/G8308}}",
            //                        DefaultValue="",
            //                },
            //                //Pack
            //                new XPathConnfig(){
            //                        XPath="//G83//G8309",
            //                        PlaceHolder="{{G83/G8309}}",
            //                        DefaultValue="",
            //                },

            //                //Allowance or Charge:

            //                //Allowance or Charge Code
            //                new XPathConnfig(){
            //                        XPath="//G72//G7201",
            //                        PlaceHolder="{{G72/G7201}}",
            //                        DefaultValue="",
            //                        MappingRequired= true
            //                },
            //                //Allowance or Charge Method of Handling Code
            //                new XPathConnfig(){
            //                        XPath="//G72//G7202",
            //                        PlaceHolder="{{G72/G7202}}",
            //                        DefaultValue="",
            //                        MappingRequired= true
            //                },
            //                //Allowance or Charge Total Amount
            //                new XPathConnfig(){
            //                        XPath="//G72//G7208",
            //                        PlaceHolder="{{G72/G7208}}",
            //                        DefaultValue=""
            //                },
            //            }
            //        }
            //    },
            //    //Loop Identifier Code
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//LE/LE01", PlaceHolder = "{{LE/LE01}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    //Delivery/Return Record of Totals:

            //    //Quantity
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G84/G8401", PlaceHolder = "{{G84/G8401}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    //Total Invoice Amount
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G84/G8402", PlaceHolder = "{{G84/G8402}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //    //Total Deposit Dollar Amount
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G84/G8403", PlaceHolder = "{{G84/G8403}}", DefaultValue = ""},
            //    LineLevel = null
            //    },

            //    //Signature Identification
            //    //Signature
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G86/G8601", PlaceHolder = "{{G86/G8601}}", DefaultValue = ""},
            //    LineLevel = null
            //    },

            //    //Record Integrity Check
            //    //Integrity Check Value
            //    new Configuration()
            //    {
            //    XPathConnfig = new XPathConnfig() { XPath = "//G85/G8501", PlaceHolder = "{{G85/G8501}}", DefaultValue = ""},
            //    LineLevel = null
            //    },
            //}
            //},

            ////new HumanReadableConfiguration()
            ////{
            ////TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad875.html"),
            ////TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad875Updated.html"),
            ////PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_875.xml"),
            ////TemplateSetCode = 875,
            ////KDIVersion = "",
            ////configurations = new List<Configuration>() {
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G50[G5001 = 'N']/G5001", PlaceHolder = "{{G50/G5001-G5001 = 'N'}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G50[G5001 = 'N']/G5002", PlaceHolder = "{{G50/G5002-G5001 = 'N'}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G50[G5001 = 'N']/G5003", PlaceHolder = "{{G50/G5003-G5001 = 'N'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G61[G6101 = 'BD']/G6101", PlaceHolder = "{{G61/G6101-G6101 = 'BD'}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G61[G6101 = 'BD']/G6102", PlaceHolder = "{{G61/G6102-G6101 = 'BD'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G61[G6101 = 'BD']/G6103", PlaceHolder = "{{G61/G6103-G6101 = 'BD'}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G61[G6101 = 'BD']/G6104", PlaceHolder = "{{G61/G6104-G6101 = 'BD'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G62[G6201 = '02']/G6201", PlaceHolder = "{{G62/G6201-G6201 = '02'}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G62[G6201 = '02']/G6202", PlaceHolder = "{{G62/G6202-G6201 = '02'}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//NTE[NTE01 = 'GEN']/NTE02", PlaceHolder = "{{NTE/NTE02-NTE01 = 'GEN'}}", DefaultValue = "", ConcatinationUsingSameXPath = true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G66[G6601 = 'PP']/G6601", PlaceHolder = "{{G66/G6601-G6601 = 'PP'}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G66[G6601 = 'PP']/G6602", PlaceHolder = "{{G66/G6602-G6601 = 'PP'}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'VN']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'VN'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'VN']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'VN'}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'VN']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'VN'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'BT'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'BT'}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'BT'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'ST'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'ST'}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'ST'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'ST'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'ST'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'ST'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'ST'}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G76/G7601", PlaceHolder = "{{G76/G7601}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G76/G7602", PlaceHolder = "{{G76/G7602}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G76/G7603", PlaceHolder = "{{G76/G7603}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G76/G7604", PlaceHolder = "{{G76/G7604}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G76/G7605", PlaceHolder = "{{G76/G7605}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G76/G7606", PlaceHolder = "{{G76/G7606}}", DefaultValue = "", MappingRequired= true},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = new XPathConnfig() { XPath = "//G76/G7608", PlaceHolder = "{{G76/G7608}}", DefaultValue = ""},
            ////    LineLevel = null
            ////    },
            ////    new Configuration()
            ////    {
            ////    XPathConnfig = null,
            ////    LineLevel = new LineLevel()
            ////    {
            ////       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Line Item Detail - Product: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quantity : {{G68/G6801}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code : {{G68/G6802}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Item List Cost : {{G68/G6803}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;U.P.C. Case Code : {{G68/G6804}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID Qualifier : {{G68/G6805}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Product/Service ID : {{G68/G6806}} </td></tr> </table><br/> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Line Item Detail - Description: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Free-form Description : {{G69/G6901}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Line Item Detail - Miscellaneous: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pack : {{G70/G7001}} </td></tr> </table><br>",
            ////        LineLevelXPath = "//G68Loop1",
            ////        PlaceHolder = "{{LinedItemHtml}}",
            ////        XPathConnfigs = new List<XPathConnfig>() {
            ////        new XPathConnfig()
            ////        {
            ////            XPath="//G68/G6801",
            ////            PlaceHolder="{{G68/G6801}}",
            ////            DefaultValue=""
            ////        },
            ////        new XPathConnfig()
            ////        {
            ////            XPath="//G68/G6802",
            ////            PlaceHolder="{{G68/G6802}}",
            ////            DefaultValue="",
            ////            MappingRequired= true
            ////        },
            ////        new XPathConnfig()
            ////        {
            ////            XPath="//G68/G6803",
            ////            PlaceHolder="{{G68/G6803}}",
            ////            DefaultValue="",
            ////            MappingRequired= true
            ////        },
            ////        new XPathConnfig()
            ////        {
            ////            XPath="//G68/G6804",
            ////            PlaceHolder="{{G68/G6804}}",
            ////            DefaultValue=""
            ////        },
            ////        new XPathConnfig()
            ////        {
            ////            XPath="//G68/G6805",
            ////            PlaceHolder="{{G68/G6805}}",
            ////            DefaultValue="",
            ////            MappingRequired= true
            ////        },
            ////        new XPathConnfig()
            ////        {
            ////            XPath="//G68/G6806",
            ////            PlaceHolder="{{G68/G6806}}",
            ////            DefaultValue=""
            ////        },
            ////        new XPathConnfig()
            ////        {
            ////            XPath="//G69/G6901",
            ////            PlaceHolder="{{G69/G6901}}",
            ////            DefaultValue=""
            ////        },
            ////        new XPathConnfig()
            ////        {
            ////            XPath="//G70/G7001",
            ////            PlaceHolder="{{G70/G7001}}",
            ////            DefaultValue=""
            ////        }

            ////    }
            ////    }
            ////    }

            //}
            //}

            //new HumanReadableConfiguration()
            //{
            //    TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoadGT824.html"),
            //    TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoadGT824Updated.html"),
            //    PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_GT_824.xml"),
            //    TemplateSetCode = 824,
            //    KDIVersion = "",
            //    configurations = new List<Configuration>() {
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//BGN/BGN01", PlaceHolder = "{{BGN/BGN01}}", DefaultValue = "", MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//BGN/BGN02", PlaceHolder = "{{BGN/BGN02}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//BGN/BGN03", PlaceHolder = "{{BGN/BGN03}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//BGN/BGN04", PlaceHolder = "{{BGN/BGN04}}", DefaultValue = "",TimeFormat =new TimeFormat() { SourceFormat = "hhmm",TargetFormat = "hh:mm tt"}},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//BGN/BGN06", PlaceHolder = "{{BGN/BGN06}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'FR']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'FR'}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'FR']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'FR'}}", DefaultValue = "", MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'FR']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'FR'}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'TO']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'TO'}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'TO']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'TO'}}", DefaultValue = "", MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'TO']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'TO'}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BB']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'BB'}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'PE']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'PE'}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'PE']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'PE'}}", DefaultValue = "", MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'PE']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'PE'}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //         new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'VN']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'VN'}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/PER/PER02", PlaceHolder = "{{PER/PER02}}", DefaultValue = ""},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/PER/PER03", PlaceHolder = "{{PER/PER03}}", DefaultValue = "", MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/PER/PER04", PlaceHolder = "{{PER/PER04}}", DefaultValue = ""},
            //            LineLevel = null
            //        },

            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/PER/PER05", PlaceHolder = "{{PER/PER05}}", DefaultValue = "", MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1/PER/PER06", PlaceHolder = "{{PER/PER06}}", DefaultValue = ""},
            //            LineLevel = null
            //        },

            //        new Configuration()
            //        {
            //            XPathConnfig = new XPathConnfig() { XPath = "//SE/SE01", PlaceHolder = "{{SE/SE01}}", DefaultValue = ""},
            //            LineLevel = null
            //        },

            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTI/OTI01",PlaceHolder="{{OTI/OTI01}}",DefaultValue="", MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTI/OTI02",PlaceHolder="{{OTI/OTI02}}",DefaultValue="", MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTI/OTI03",PlaceHolder="{{OTI/OTI03}}",DefaultValue=""},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTI/OTI04",PlaceHolder="{{OTI/OTI04}}",DefaultValue=""},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTI/OTI05",PlaceHolder="{{OTI/OTI05}}",DefaultValue=""},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTI/OTI06",PlaceHolder="{{OTI/OTI06}}",DefaultValue="",DateFormat =new DateFormat() {SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTI/OTI07",PlaceHolder="{{OTI/OTI07}}",DefaultValue="",TimeFormat =new TimeFormat() { SourceFormat = "hhmm",TargetFormat = "hh:mm tt"}},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTI/OTI08",PlaceHolder="{{OTI/OTI08}}",DefaultValue=""},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTI/OTI09",PlaceHolder="{{OTI/OTI09}}",DefaultValue=""},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTI/OTI10",PlaceHolder="{{OTI/OTI10}}",DefaultValue="", MappingRequired = true},
            //            LineLevel = null
            //        },

            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTILoop1/REF_2[REF01 = 'EQ']/REF02",PlaceHolder="{{REF_2/REF02-REF01 = 'EQ'}}",DefaultValue="", MappingRequired = false},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTILoop1/REF_2[REF01 = 'WY']/REF02",PlaceHolder="{{REF_2/REF02-REF01 = 'WY'}}",DefaultValue="", MappingRequired = false},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTILoop1/REF_2[REF01 = 'SI']/REF02",PlaceHolder="{{REF_2/REF02-REF01 = 'SI'}}",DefaultValue="", MappingRequired = false},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTILoop1/REF_2[REF01 = '11']/REF02",PlaceHolder="{{REF_2/REF02-REF01 = '11'}}",DefaultValue="", MappingRequired = false},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTILoop1/REF_2[REF01 = 'BM']/REF02",PlaceHolder="{{REF_2/REF02-REF01 = 'BM'}}",DefaultValue="", MappingRequired = false},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTILoop1/REF_2[REF01 = 'IA']/REF02",PlaceHolder="{{REF_2/REF02-REF01 = 'IA'}}",DefaultValue="", MappingRequired = false},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//OTILoop1/REF_2[REF01 = 'BP']/REF02",PlaceHolder="{{REF_2/REF02-REF01 = 'BP'}}",DefaultValue="", MappingRequired = false},
            //            LineLevel = null
            //        },

            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig(){XPath="//DTM/DTM01",PlaceHolder="{{DTM/DTM01}}",DefaultValue="", MappingRequired = true},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig() { XPath="//DTM/DTM02", PlaceHolder="{{DTM/DTM02}}", DefaultValue="", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig() { XPath="//DTM/DTM03", PlaceHolder="{{DTM/DTM03}}", DefaultValue="", TimeFormat =new TimeFormat() { SourceFormat = "hhmm",TargetFormat = "hh:mm tt"}},
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig() { XPath="//DTM/DTM04", PlaceHolder="{{DTM/DTM04}}", DefaultValue="" },
            //            LineLevel = null
            //        },

            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig() { XPath = "//AMT/AMT01", PlaceHolder = "{{AMT/AMT01}}", DefaultValue = "" },
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig() { XPath = "//AMT/AMT02", PlaceHolder = "{{AMT/AMT02}}", DefaultValue = "" },
            //            LineLevel = null
            //        },

            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig() { XPath = "//QTY/QTY01", PlaceHolder = "{{QTY/QTY01}}", DefaultValue = "", MappingRequired = true },
            //            LineLevel = null
            //        },
            //        new Configuration() {
            //            XPathConnfig = new XPathConnfig() { XPath = "//QTY/QTY02", PlaceHolder = "{{QTY/QTY02}}", DefaultValue = "" },
            //            LineLevel = null
            //        },

            //    new Configuration()
            //    {
            //        XPathConnfig = null,
            //        LineLevel = new LineLevel()
            //        {
            //            HTML = "<tr><td><table style=\"margin-top : 10px\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\">\r\n<tr>\r\n   <td valign=\"top\" width=\"50%\">\r\n      <b>Technical Error Description: </b>\r\n      <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n         <tr>\r\n            <td width=\"50%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Application Error Condition Code :<span> {{TEDLoop1/TED/TED01}}</span> </td>\r\n         </tr>\r\n         <tr>\r\n            <td width=\"50%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Free Form Message :<span> {{TEDLoop1/TED/TED02}} </span>  </td>\r\n         </tr>\r\n         <tr>\r\n            <td width=\"50%\" valign=\"top\" align=\"left\"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Copy of Bad Data Element : <span>{{TEDLoop1/TED/TED07}}</span> </td>\r\n         </tr>\r\n      </table>\r\n   </td>\r\n</tr>\r\n</table></td></tr>\r\n<tr>\r\n   <td width=\"15\"/>\r\n   <td width=\"55%\" colspan=\"5\"> </td>\r\n</tr>\r\n<br/>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">\r\n   <tr>\r\n      <td width=\"100%\" valign=\"top\" align=\"left\"><b>Notes: </b></td>\r\n   </tr>\r\n</table>\r\n<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" >\r\n   <tr>\r\n      <td border=\"0\" width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Note</b><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span>{{NTE/NTE02}}</span></td>\r\n   </tr>\r\n</table>",
            //            LineLevelXPath = "//TEDLoop1",
            //            PlaceHolder = "{{TransactionInformationHtml}}",
            //            XPathConnfigs = new List<XPathConnfig>() {

            //                new XPathConnfig()
            //                {
            //                    XPath="//TED/TED01",
            //                    PlaceHolder="{{TEDLoop1/TED/TED01}}",
            //                    DefaultValue="",
            //                    MappingRequired = true
            //                },
            //                new XPathConnfig()
            //                {
            //                    XPath="//TED/TED02",
            //                    PlaceHolder="{{TEDLoop1/TED/TED02}}",
            //                    DefaultValue=""
            //                },
            //                new XPathConnfig()
            //                {
            //                    XPath="//TED/TED07",
            //                    PlaceHolder="{{TEDLoop1/TED/TED07}}",
            //                    DefaultValue=""
            //                },

            //                new XPathConnfig()
            //                {
            //                    XPath=".//NTE/NTE01",
            //                    PlaceHolder="{{NTE/NTE01}}",
            //                    DefaultValue="",
            //                    ConcatinationUsingSameXPath = true,
            //                    AllowNodeSameRepetation = true
            //                },
            //                new XPathConnfig()
            //                {
            //                    XPath=".//NTE/NTE02",
            //                    PlaceHolder="{{NTE/NTE02}}",
            //                    DefaultValue="",
            //                    ConcatinationUsingSameXPath = true,
            //                    AllowNodeSameRepetation = true
            //                },
            //            }
            //        }
            //    }
            //    }
            //}


            //    new HumanReadableConfiguration()
            //    {
            //    TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoadGT875.html"),
            //    TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoadGT875Updated.html"),
            //    PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_GT_875.xml"),
            //    TemplateSetCode = 875,
            //    KDIVersion = "",
            //    configurations = new List<Configuration>() {
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G50[G5001 = 'N']/G5001", PlaceHolder = "{{G50/G5001-G5001 = 'N'}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G50[G5001 = 'N']/G5002", PlaceHolder = "{{G50/G5002-G5001 = 'N'}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G50[G5001 = 'N']/G5003", PlaceHolder = "{{G50/G5003-G5001 = 'N'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G61[G6101 = 'BD']/G6101", PlaceHolder = "{{G61/G6101-G6101 = 'BD'}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G61[G6101 = 'BD']/G6102", PlaceHolder = "{{G61/G6102-G6101 = 'BD'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G61[G6101 = 'BD']/G6103", PlaceHolder = "{{G61/G6103-G6101 = 'BD'}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G61[G6101 = 'BD']/G6104", PlaceHolder = "{{G61/G6104-G6101 = 'BD'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G62[G6201 = '02']/G6201", PlaceHolder = "{{G62/G6201-G6201 = '02'}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G62[G6201 = '02']/G6202", PlaceHolder = "{{G62/G6202-G6201 = '02'}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//NTE[NTE01 = 'GEN']/NTE02", PlaceHolder = "{{NTE/NTE02-NTE01 = 'GEN'}}", DefaultValue = "", ConcatinationUsingSameXPath = true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G66[G6601 = 'PP']/G6601", PlaceHolder = "{{G66/G6601-G6601 = 'PP'}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G66[G6601 = 'PP']/G6602", PlaceHolder = "{{G66/G6602-G6601 = 'PP'}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'VN']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'VN'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'VN']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'VN'}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'VN']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'VN'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'BT'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'BT'}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BT']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'BT'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'ST'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'ST'}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'ST'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N3/N301", PlaceHolder = "{{N3/N301-N101 = 'ST'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N401", PlaceHolder = "{{N4/N401-N101 = 'ST'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N402", PlaceHolder = "{{N4/N402-N101 = 'ST'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N4/N403", PlaceHolder = "{{N4/N403-N101 = 'ST'}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G76/G7601", PlaceHolder = "{{G76/G7601}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G76/G7602", PlaceHolder = "{{G76/G7602}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G76/G7603", PlaceHolder = "{{G76/G7603}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G76/G7604", PlaceHolder = "{{G76/G7604}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G76/G7605", PlaceHolder = "{{G76/G7605}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G76/G7606", PlaceHolder = "{{G76/G7606}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G76/G7608", PlaceHolder = "{{G76/G7608}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//N9/N902", PlaceHolder = "{{N9/N902}}", DefaultValue = "" },
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G62/G6202", PlaceHolder = "{{G62/G6202-G6201 = '996'}}", DefaultValue = "" ,DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }, PreferedXpaths = new List<PreferedXpath>()
            //        {
            //            new PreferedXpath(){ XPath = "//G62[G6201 = '996']/G6202",Identifier = "",TotalNodes = "",SelectedNode = ""},
            //            new PreferedXpath(){ XPath = "//G62[G6201 = '010']/G6202",Identifier = "",TotalNodes = "",SelectedNode = ""}

            //        } },
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G62/G6202", PlaceHolder = "{{G62/G6202-G6201 = '371'}}", DefaultValue = "" ,DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }, PreferedXpaths = new List<PreferedXpath>()
            //        {
            //            new PreferedXpath(){ XPath = "//G62[G6201 = '371']/G6202",Identifier = "",TotalNodes = "",SelectedNode = ""},
            //            new PreferedXpath(){ XPath = "//G62[G6201 = '002']/G6202",Identifier = "",TotalNodes = "",SelectedNode = ""}

            //        } },
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G62/G6202", PlaceHolder = "{{G62/G6202-G6201 = '002'}}", DefaultValue = "" ,DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }, PreferedXpaths = new List<PreferedXpath>()
            //        {
            //            new PreferedXpath(){ XPath = "//G62[G6201 = '001']/G6202",Identifier = "",TotalNodes = "",SelectedNode = ""},
            //            new PreferedXpath(){ XPath = "//G62[G6201 = '002']/G6202",Identifier = "",TotalNodes = "",SelectedNode = ""}

            //        } },
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//NTE/NTE02", PlaceHolder = "{{MTX_2/MTX02}}", DefaultValue = "" , ConcatinationUsingSameXPath = true},
            //        LineLevel = null
            //        }
            //        ,
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//G76/G7608", PlaceHolder = "{{G76/G7608}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = null,
            //        LineLevel = new LineLevel()
            //        {
            //           HTML = "<tr> <td VALIGN=\"TOP\" width=\"5%\"><br>{{PO1/PO101}}</td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{G68/G6804}}</td> <td VALIGN=\"TOP\" width=\"15%\"><br>{{G68/G6806}}</td> <td width=\"13%\"><br> <b>Vendor's (Seller's) Item Number </b>: {{G69/G6901}}<br> </td> <td VALIGN=\"TOP\" width=\"8%\"><br>{{G68/G6801}}</td> <td VALIGN=\"TOP\" width=\"13%\"><br> {{G68/G6802}} </td>  <td VALIGN=\"TOP\" width=\"10%\"><br>{{G68/G6803}}</td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{G68/G6805}}</td> <td VALIGN=\"TOP\" width=\"10%\"><br>{{G68/TotalPrice}}</td></tr>",
            //            LineLevelXPath = "//G68Loop1",
            //            PlaceHolder = "{{LinedItemHtml}}",
            //            XPathConnfigs = new List<XPathConnfig>() {
            //            new XPathConnfig()
            //            {
            //                XPath="//PO1/PO101",
            //                PlaceHolder="{{PO1/PO101}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//G68/G6801",
            //                PlaceHolder="{{G68/G6801}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//G68/G6802",
            //                PlaceHolder="{{G68/G6802}}",
            //                DefaultValue="",
            //                MappingRequired= true
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//G68/G6803",
            //                PlaceHolder="{{G68/G6803}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//G68/G6804",
            //                PlaceHolder="{{G68/G6804}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//G68/G6805",
            //                PlaceHolder="{{G68/G6805}}",
            //                DefaultValue="",
            //                MappingRequired= true
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//G68/G6806",
            //                PlaceHolder="{{G68/G6806}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//G69/G6901",
            //                PlaceHolder="{{G69/G6901}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//G70/G7001",
            //                PlaceHolder="{{G70/G7001}}",
            //                DefaultValue=""
            //            }
            //            ,
            //            new XPathConnfig()
            //            {
            //                XPath="//G70/G7001",
            //                PlaceHolder="{{G68/TotalPrice}}",
            //                DefaultValue="",
            //                MutiplcationUsingXPath = new List<string>(){ "//G68/G6801", "//G68/G6803" }
            //            }

            //        }
            //        }
            //        }

            //}
            //    }





            //    new HumanReadableConfiguration()
            //    {
            //    TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad846.html"),
            //    TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoad846Updated.html"),
            //    PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_846.xml"),
            //    TemplateSetCode = 846,
            //    KDIVersion = "",
            //    configurations = new List<Configuration>() {
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//BIA/BIA01", PlaceHolder = "{{BIA/BIA01}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//BIA/BIA02", PlaceHolder = "{{BIA/BIA02}}", DefaultValue = "", MappingRequired= true},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//BIA/BIA03", PlaceHolder = "{{BIA/BIA03}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//BIA/BIA04", PlaceHolder = "{{BIA/BIA04}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" } },
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//BIA/BIA05", PlaceHolder = "{{BIA/BIA05}}", DefaultValue = "",TimeFormat= new TimeFormat() { SourceFormat = "HHmmss",TargetFormat = "hh:mm:ss tt"} },
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//REF/REF02", PlaceHolder = "{{REF/REF02}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//REF/REF03", PlaceHolder = "{{REF/REF03}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT01", PlaceHolder = "{{CTT/CTT01}}", DefaultValue = ""},
            //        LineLevel = null
            //        },
            //        new Configuration()
            //        {
            //        XPathConnfig = null,
            //        LineLevel = new LineLevel()
            //        {
            //            HTML = "<table style=\"border: 0px; border-style: solid; border-color: black; padding: 2pt; \" WIDTH=\"638\">   <tr><td width=\"100%\" class=\"sectiontitle\"><font face=\"Arial\" color=\"#D60D00\">Line Item</font></td></tr>   <tr><td width=\"100%\">   </center></div>    <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td>   <b>Part Numbers</b>   </td></tr></table>   <table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\"    bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\"   background=\"res://VistaRes.Dll/legalpad.gif\">    <TR><TD WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{LIN/LIN02}}</TD><TD BGCOLOR=\"#FFFFFF\">{{LIN/LIN03}}</TD></TR>   <TR><TD WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{LIN/LIN04}}</TD><TD BGCOLOR=\"#FFFFFF\">{{LIN/LIN05}}</TD></TR>   <TR><TD WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{LIN/LIN06}}</TD><TD BGCOLOR=\"#FFFFFF\">{{LIN/LIN07}}</TD></TR>   </TR>   </table>   <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table>   <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\">   <tr>   <td width=\"1%\" valign=\"top\">   </td>   <td width = \"99%\"><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" >    <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   <b>Product/Item Description:   </b></td></tr>   <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   </b>{{PID/PID05}}<br>    </td></tr>   </table></td></tr></table>   <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table>   <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">   <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   <b>Quantity:   </b></td></tr></table>   <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" >    <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quantity Qualifier   : {{QTY/QTY01}}   </td></tr>   <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quantity   : {{QTY/QTY02}}   </td></tr>   <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Composite Unit of Measure   : {{QTY/QTY03}}   </td></tr>   </table><br>   <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\">   <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   <b>Line Item Schedule:   </b></td></tr></table>   <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" >    <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quantity   : {{SCH/SCH01}}   </td></tr>   <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Unit or Basis for Measurement Code   : {{SCH/SCH02}}   </td></tr>   <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Date/Time Qualifier   : {{SCH/SCH05}}   </td></tr>   <tr>    <td width=\"100%\" valign=\"top\" align=\"left\">   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Date   : {{SCH/SCH06}}   </td></tr>   </table><br>   </td></tr>   </table><br>   <hr style=\"height: 1px; border-style: solid; border-color: #D60D00; padding: 2pt; \" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" >",
            //            LineLevelXPath = "//LINLoop1[LIN]",
            //            PlaceHolder = "{{LinedItemHtml}}",
            //            XPathConnfigs = new List<XPathConnfig>() {
            //            new XPathConnfig()
            //            {
            //                XPath="//LIN/LIN02",
            //                PlaceHolder="{{LIN/LIN02}}",
            //                DefaultValue="",
            //                MappingRequired= true
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//LIN/LIN03",
            //                PlaceHolder="{{LIN/LIN03}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//LIN/LIN04",
            //                PlaceHolder="{{LIN/LIN04}}",
            //                DefaultValue="",
            //                MappingRequired= true
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//LIN/LIN05",
            //                PlaceHolder="{{LIN/LIN05}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//LIN/LIN06",
            //                PlaceHolder="{{LIN/LIN06}}",
            //                DefaultValue="",
            //                MappingRequired= true
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//LIN/LIN07",
            //                PlaceHolder="{{LIN/LIN07}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//PID/PID05",
            //                PlaceHolder="{{PID/PID05}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//QTY/QTY01",
            //                PlaceHolder="{{QTY/QTY01}}",
            //                DefaultValue="",
            //                MappingRequired= true
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//QTY/QTY02",
            //                PlaceHolder="{{QTY/QTY02}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//QTY/QTY03",
            //                PlaceHolder="{{QTY/QTY03}}",
            //                DefaultValue="",
            //                MappingRequired= true
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//SCH/SCH01",
            //                PlaceHolder="{{SCH/SCH01}}",
            //                DefaultValue=""
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//SCH/SCH02",
            //                PlaceHolder="{{SCH/SCH02}}",
            //                DefaultValue="",
            //                MappingRequired= true
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//SCH/SCH05",
            //                PlaceHolder="{{SCH/SCH05}}",
            //                DefaultValue="",
            //                MappingRequired= true
            //            },
            //            new XPathConnfig()
            //            {
            //                XPath="//SCH/SCH06",
            //                PlaceHolder="{{SCH/SCH06}}",
            //                DefaultValue="", 
            //                DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }
            //            }

            //        }
            //        }
            //        }

            //}
            //    }

            //};


//            new HumanReadableConfiguration()
//            {
//                TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoadGT830.html"),
//                TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XpathLoadGT830Updated.html"),
//                PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGINAL_GT_830.xml"),
//                TemplateSetCode = 830,
//                KDIVersion = "",
//                configurations = new List<Configuration>() {
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//BFR/BFR01", PlaceHolder = "{{BFR/BFR01}}", DefaultValue = "", MappingRequired = true},
//                        LineLevel = null
//                    },
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//BFR/BFR02", PlaceHolder = "{{BFR/BFR02}}", DefaultValue = ""},
//                        LineLevel = null
//                    },
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//BFR/BFR04", PlaceHolder = "{{BFR/BFR04}}", DefaultValue = "",MappingRequired = true},
//                        LineLevel = null
//                    },
//                        new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//BFR/BFR05", PlaceHolder = "{{BFR/BFR05}}", DefaultValue = "",MappingRequired=true},
//                        LineLevel = null
//                    },
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//BFR/BFR06", PlaceHolder = "{{BFR/BFR06}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
//                        LineLevel = null
//                    },
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//BFR/BFR07", PlaceHolder = "{{BFR/BFR07}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
//                        LineLevel = null
//                    },
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//BFR/BFR08", PlaceHolder = "{{BFR/BFR08}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
//                        LineLevel = null
//                    },
//        new Configuration()
//        {
//        XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT01", PlaceHolder = "{{CTT/CTT01}}", DefaultValue = ""},
//        LineLevel = null
//        },
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//REF/REF02", PlaceHolder = "{{REF/REF02}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyyyMMdd", TargetFormat = "MM/dd/yyyy" }},
//                        LineLevel = null
//                    },
//                    //Message From
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'FR']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'FR'}}", DefaultValue = ""},
//                        LineLevel = null
//                    },
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'FR']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'FR'}}", DefaultValue = "", MappingRequired = true},
//                        LineLevel = null
//                    },
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'FR']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'FR'}}", DefaultValue = ""},
//                        LineLevel = null
//                    },
//                    //Message To
//                    new Configuration()
//                    {
//                        XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'TO']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'TO'}}", DefaultValue = ""},
//                        LineLevel = null
//                    },
//                new Configuration()
//                {
//                    XPathConnfig = null,
//                    LineLevel = new LineLevel()
//                    {
//                        IsChildLineLevel = true,
//                        HTML = "<table style=\"border: 0px; border-style: solid; border-color: black; padding: 2pt; \" WIDTH=\"638\"><tr><td width=\"100%\" class=\"sectiontitle\"><font face=\"Arial\" color=\"#FF0000\">Line Item {{LIN/LIN01}}</font></td></tr><tr><td width=\"100%\"/><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td><b>Part Numbers</b></td></tr></table><table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\" background=\"res://VistaRes.Dll/legalpad.gif\"><TR><TD WIDTH=\"35%\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Buyer's Item Number</TD><TD >{{LIN/LIN03}}</TD></TR><TR><TD WIDTH=\"35%\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vendor's (Seller's) Item Number</TD><TD >{{LIN/LIN05}}</TD></TR><TR><TD WIDTH=\"35%\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Buyer's Size Code</TD><TD >{{LIN/LIN07}}</TD></TR><TR><TD WIDTH=\"35%\" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Buyers Color</TD><TD >{{LIN/LIN09}}</TD></TR></TR></table><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td/></tr></table><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tr><td width=\"100%\" valign=\"top\" align=\"left\"><b>Unit Detail:</b></td></tr></table><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tr><td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Composite Unit of Measure: {{UIT/UIT01}}</td></tr></table><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tr><td width=\"100%\" valign=\"top\" align=\"left\"><b>Quantity:</b></td></tr></table><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tr><td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quantity Qualifier: {{QTY/QTY01}}</td></tr><tr><td width=\"100%\" valign=\"top\" align=\"left\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quantity: {{QTY/QTY02}}</td></tr></table><b>Forecast Schedule</b><table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\" background=\"res://VistaRes.Dll/legalpad.gif\"><TR><TD ><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Quan</strong></TD><TD ><strong>Timing</strong></TD><TD ><strong>When</strong></TD></TR>{{ForecastScheduleHtml}}</table><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td/></tr></table></td></tr></table>",
//                        LineLevelXPath = "//LINLoop1",
//                        PlaceHolder = "{{TransactionInformationHtml}}",
//                        XPathConnfigs = new List<XPathConnfig>()
//                        {

//                            #region LIN
//                        new XPathConnfig(){
//                                XPath="//LIN//LIN01",
//                                PlaceHolder="{{LIN/LIN01}}",
//                                DefaultValue="",
//                                IsIdentityMarker=true
//                            },
//                            //   Buyer's Item Number
//                            new XPathConnfig(){
//                                XPath="//LIN//LIN03",
//                                DefaultValue="",
//                                PlaceHolder="{{LIN/LIN03}}",

//                            },
//                            // Vendor's (Seller's) Item Number
//                            new XPathConnfig(){
//                                XPath="//LIN/LIN05",
//                                DefaultValue="",
//                                PlaceHolder="{{LIN/LIN05}}",
//                            },

//                            //  Buyer's Size Code
//                            new XPathConnfig(){
//                                XPath="//LIN/LIN07",
//                                DefaultValue="",
//                                PlaceHolder="{{LIN/LIN07}}",
//                            },
//                            // Buyers Color
//                            new XPathConnfig(){
//                                XPath="//LIN/LIN09",
//                                DefaultValue="",
//                                PlaceHolder="{{LIN/LIN09}}",
//                            }, 
//#endregion

//                            #region UIT
//    //  Composite Unit of Measure
//                            new XPathConnfig(){
//                                XPath="//UIT//UIT01",
//                                PlaceHolder="{{UIT/UIT01}}",
//                                DefaultValue="",
//                                MappingRequired = true,
//                            }, 
//#endregion

//                            #region QTY
//    // Quantity Qualifier
//                            new XPathConnfig(){
//                                XPath="//QTY//QTY01",
//                                PlaceHolder="{{QTY/QTY01}}",
//                                DefaultValue="",
//                                MappingRequired = true,
//                            },
//                            //Quantity
//                            new XPathConnfig(){
//                                XPath="//QTY//QTY02",
//                                DefaultValue="",
//                                PlaceHolder="{{QTY/QTY02}}",
//                            }

//#endregion
//                        },

//                        ChildLineLevel=new LineLevel
//                        {
//                            HTML="<TR><TD>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{FST/FST01}}</TD><TD>{{FST/FST02}}: {{FST/FST03}}</TD><TD>{{FST/FST04}}</TD></TR>",
//                            LineLevelXPath="//FSTLoop1",
//                            PlaceHolder="{{ForecastScheduleHtml}}",
//                            XPathConnfigs=new List<XPathConnfig>()
//                            {
//                                //Quan
//                                new XPathConnfig()
//                                {
//                                XPath="//FST//FST01",
//                                DefaultValue="",
//                                PlaceHolder="{{FST/FST01}}",
//                                },
//                                //Timing
//                                new XPathConnfig()
//                                {
//                                XPath="//FST//FST02",
//                                DefaultValue="",
//                                PlaceHolder="{{FST/FST02}}",
//                                MappingRequired=true
//                                },
//                                new XPathConnfig()
//                                {
//                                XPath="//FST//FST03",
//                                DefaultValue="",
//                                PlaceHolder="{{FST/FST03}}",
//                                MappingRequired=true
//                                },
//                                //When
//                                new XPathConnfig()
//                                {
//                                XPath = "//FST//FST04",
//                                DefaultValue="",
//                                PlaceHolder = "{{FST/FST04}}",
//                                DateFormat=new DateFormat{
//                                    SourceFormat="yyyyMMdd",
//                                    TargetFormat="MM/dd/yyyy"
//                                }
//                                },
//                            }
//                        }
//                    }
//                }
//            }
//        }

            //           new HumanReadableConfiguration()
            //           {
            //               TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XPathLoad852.html"),// Placeholder file
            //               TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XPathLoad852Updated.html"),
            //               PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGNAL_852.xml"), // Packing file where xml path defined
            //               TemplateSetCode = 852,
            //               KDIVersion = "",
            //               configurations = new List<Configuration>() {

            //                   #region Reporting Date/Action
            //	new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//XQ/XQ01", PlaceHolder = "{{XQ/XQ01}}", DefaultValue = "", MappingRequired = true},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//XQ/XQ02", PlaceHolder = "{{XQ/XQ02}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "MMddyyyy", TargetFormat = "MM/dd/yyyy" }},
            //                       LineLevel = null
            //                   },
            //                    new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//XQ/XQ03", PlaceHolder = "{{XQ/XQ03}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "MMddyyyy", TargetFormat = "MM/dd/yyyy" }},
            //                       LineLevel = null
            //                   }, 
            //#endregion

            //                   #region Resale Dealer

            //         new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'DU']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'DU'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },
            //                        new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'DU']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'DU'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   }, 
            //#endregion

            //                   #region Date/Time Reference
            //	new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//DTM/DTM02", PlaceHolder = "{{DTM/DTM02}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "MMddyyyy", TargetFormat = "MM/dd/yyyy" }},
            //                       LineLevel = null
            //                   }, 
            //#endregion

            //                   #region Vendor

            //         new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'VN']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'VN'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },
            //                        new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'VN']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'VN'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   }, 
            //#endregion

            //                   #region Line Count
            //	      new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT01", PlaceHolder = "{{CTT/CTT01}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   }, 
            //#endregion

            //               new Configuration()
            //               {
            //                   XPathConnfig = null,
            //                   LineLevel = new LineLevel()
            //                   {
            //                       HTML = "<table style=\"border: 0px; border-style: solid; border-color: black; padding: 2pt; \" WIDTH=\"638\"> <tr> <td width=\"100%\" class=\"sectiontitle\"> <font face=\"Arial\" color=\"#FA9101\">Line Item {{LIN/LIN01}}</font> </td> </tr> <tr> <td width=\"100%\"> </center> </div> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td> <b>Part Numbers</b> </td> </tr> </table> <table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\" background=\"res://VistaRes.Dll/legalpad.gif\"> <TR> <TD WIDTH=\"35%\">     Vendor's (Seller's) Item Number</TD> <TD>{{LIN/LIN03}}</TD> </TR> <TR> <TD WIDTH=\"35%\">     U.P.C. Consumer Package Code (1-5-5-1)</TD> <TD>{{LIN/LIN05}}</TD> </TR> </TR> </table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td/> </tr> </table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Reference Identification: </b> </td> </tr> </table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Reference Identification Qualifier : {{N9_3/N901}} </td> </tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Reference Identification : {{N9_3/N902}} </td> </tr> </table> <br> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b> Cost of Goods Sold : {{AMT/AMT02}} </b> </td> </tr> </table> {{ChildTransaction}} <hr style=\"height: 1px; border-style: solid; border-color: #FA9101; padding: 2pt; \" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" >",
            //                       LineLevelXPath = "//LINLoop1",
            //                       PlaceHolder = "{{TransactionInformationHtml}}",
            //                       XPathConnfigs = new List<XPathConnfig>()
            //                       {

            //                           #region LIN
            //	                    new XPathConnfig(){
            //                               XPath="//LIN//LIN01",
            //                               PlaceHolder="{{LIN/LIN01}}",
            //                               DefaultValue="",
            //                               IsIdentityMarker=true,
            //                           },
            //                           //   Part Numbers
            //                           new XPathConnfig(){
            //                               XPath="//LIN//LIN03",
            //                                DefaultValue="",
            //                               PlaceHolder="{{LIN/LIN03}}",

            //                           },
            //                           // Reference Identification
            //                           new XPathConnfig(){
            //                               XPath="//LIN/LIN05",
            //                                DefaultValue="",
            //                               PlaceHolder="{{LIN/LIN05}}",
            //                           },

            //                           //  Buyer's Size Code
            //                           new XPathConnfig(){
            //                               XPath="//N9_3/N901",
            //                                DefaultValue="",
            //                               PlaceHolder="{{N9_3/N901}}",
            //                               MappingRequired = true,
            //                           },
            //                           // Buyers Color
            //                           new XPathConnfig(){
            //                               XPath="//N9_3/N902",
            //                                DefaultValue="",
            //                               PlaceHolder="{{N9_3/N902}}",
            //                           },
            //                           new XPathConnfig(){
            //                               XPath="//AMT/AMT02",
            //                                DefaultValue="",
            //                               PlaceHolder="{{AMT/AMT02}}",
            //                           }
            //#endregion


            //                       },
            //                       IsChildLineLevel=true,
            //                       ChildLineLevel=new LineLevel()
            //                       {
            //                           HTML="<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td/> </tr> </table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Product Activity Reporting: </b> </td> </tr> </table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Activity Code : {{ZA/ZA01}} </td> </tr> </table> <br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> <td> <b>Destination Quantities</b> <tr> <td width=\"100%\" align=\"left\">      Standard Address Number (SAN): {{SDQ/SDQ03}}: {{SDQ/SDQ04}} {{SDQ/SDQ01}}<br> </td> </tr> </td> </table>",
            //                       LineLevelXPath="//ZALoop1",
            //                       PlaceHolder="{{ChildTransaction}}",
            //                       XPathConnfigs=new List<XPathConnfig>()
            //                       {
            //                           new XPathConnfig(){
            //                               XPath="//ZA/ZA01",
            //                               PlaceHolder="{{ZA/ZA01}}",
            //                               DefaultValue="",
            //                               MappingRequired=true,
            //                           },
            //                            new XPathConnfig(){
            //                               XPath="//SDQ/SDQ03",
            //                               PlaceHolder="{{SDQ/SDQ03}}",
            //                               DefaultValue="",
            //                           },
            //                            new XPathConnfig(){
            //                               XPath="//SDQ/SDQ04",
            //                               PlaceHolder="{{SDQ/SDQ04}}",
            //                               DefaultValue="",
            //                           },
            //                            new XPathConnfig(){
            //                               XPath="//SDQ/SDQ01",
            //                               PlaceHolder="{{SDQ/SDQ01}}",
            //                               DefaultValue="",
            //                               MappingRequired=true,
            //                           },
            //                       },
            //                       }
            //                   }
            //               }
            //           }
            //       }

            //           new HumanReadableConfiguration()
            //           {
            //               TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XPathLoad861.html"),// Placeholder file
            //               TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XPathLoad861Updated.html"),
            //               PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGNAL_861.xml"), // Packing file where xml path defined
            //               TemplateSetCode = 861,
            //               KDIVersion = "",
            //               configurations = new List<Configuration>() {

            //                   #region Beginning Segment for Receiving Advice or Acceptance Certificate:
            //	new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BRA/BRA01", PlaceHolder = "{{BRA/BRA01}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BRA/BRA02", PlaceHolder = "{{BRA/BRA02}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //                       LineLevel = null
            //                   },
            //                    new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BRA/BRA03", PlaceHolder = "{{BRA/BRA03}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //                     new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BRA/BRA04", PlaceHolder = "{{BRA/BRA04}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   }, 
            //#endregion

            //                   #region Date/Time Reference
            //	new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//DTM/DTM02", PlaceHolder = "{{DTM/DTM02}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //                       LineLevel = null
            //                   }, 
            //#endregion
            //                new Configuration()
            //               {
            //               XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT01", PlaceHolder = "{{CTT/CTT01}}", DefaultValue = "" },
            //               LineLevel = null
            //               },
            //                   #region Vendor

            //                        new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'VN']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'VN'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   }, 
            //#endregion

            //               new Configuration()
            //               {
            //                   XPathConnfig = null,
            //                   LineLevel = new LineLevel()
            //                   {
            //                       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Receiving Conditions: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Quantity Units Received or Accepted : {{RCD/RCD02}} </td></tr> </table><br> </center></div> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Item Detail (Shipment): </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Number of Units Shipped : {{SN1/SN102}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Unit or Basis for Measurement Code : {{SN1/SN103}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td> <b>Part Numbers</b> </td></tr></table> <table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\" background=\"res://VistaRes.Dll/legalpad.gif\"> <TR><TD WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">     Buyer's Part Number</TD><TD BGCOLOR=\"#FFFFFF\">{{LIN/LIN03}}</TD></TR> </TR> </table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Purchase Order Reference: </b> </td></tr> </table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Purchase Order Number : {{PRF_2/PRF01}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Date : {{PRF_2/PRF04}} </td></tr> </table><br> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > </table><br> <hr style=\\"height: 3px; border-style: solid; border-color: #FA9101; padding: 2pt; \\" WIDTH=\\"100%\\" CELLPADDING=\\"0\\" cellspacing=\\"1\\" HEIGHT=\\"1\\">",
            //                       LineLevelXPath = "//RCDLoop1",
            //                       PlaceHolder = "{{ChildItems}}",
            //                       XPathConnfigs = new List<XPathConnfig>()
            //                       {
            //                           new XPathConnfig(){
            //                               XPath="//RCD//RCD02",
            //                               PlaceHolder="{{RCD/RCD02}}",
            //                               DefaultValue="",
            //                           },
            //                           #region LIN
            //	                    new XPathConnfig(){
            //                               XPath="//SN1//SN102",
            //                               PlaceHolder="{{SN1/SN102}}",
            //                               DefaultValue="",
            //                           },
            //                           //   Part Numbers
            //                           new XPathConnfig(){
            //                               XPath="//SN1//SN103",
            //                                DefaultValue="",
            //                               PlaceHolder="{{SN1/SN103}}",
            //                               MappingRequired=true,

            //                           },
            //                           // Reference Identification
            //                           new XPathConnfig(){
            //                               XPath="//LIN/LIN03",
            //                                DefaultValue="",
            //                               PlaceHolder="{{LIN/LIN03}}",
            //                           },

            //                           //  Buyer's Size Code
            //                           new XPathConnfig(){
            //                               XPath="//PRF_2/PRF01",
            //                                DefaultValue="",
            //                               PlaceHolder="{{PRF_2/PRF01}}",
            //                           },
            //                           // Buyers Color
            //                           new XPathConnfig(){
            //                               XPath="//PRF_2/PRF04",
            //                                DefaultValue="",
            //                               PlaceHolder="{{PRF_2/PRF04}}",
            //                                DateFormat = new DateFormat() { SourceFormat = "yyMMdd", TargetFormat = "MM/dd/yyyy" }
            //                           },
            //#endregion


            //                       },
            //                   }
            //               }
            //           }
            //       }


            //            new HumanReadableConfiguration()
            //           {
            //               TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XPathLoad862.html"),// Placeholder file
            //               TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XPathLoad862Updated.html"),
            //               PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGNAL_862.xml"), // Packing file where xml path defined
            //               TemplateSetCode = 862,
            //               KDIVersion = "",
            //               configurations = new List<Configuration>() {

            //                   #region Beginning Segment for Receiving Advice or Acceptance Certificate:
            //	            new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BSS/BSS01", PlaceHolder = "{{BSS/BSS01}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BSS/BSS02", PlaceHolder = "{{BSS/BSS02}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BSS/BSS03", PlaceHolder = "{{BSS/BSS03}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyMMdd", TargetFormat = "M/dd/yyyy" }},
            //                       LineLevel = null
            //                   },
            //                    new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BSS/BSS04", PlaceHolder = "{{BSS/BSS04}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //                    new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BSS/BSS05", PlaceHolder = "{{BSS/BSS05}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyMMdd", TargetFormat = "M/dd/yyyy" }},
            //                       LineLevel = null
            //                   },
            //                     new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BSS/BSS06", PlaceHolder = "{{BSS/BSS06}}", DefaultValue = "",DateFormat = new DateFormat() { SourceFormat = "yyMMdd", TargetFormat = "M/dd/yyyy" }},
            //                       LineLevel = null
            //                   },
            //                     new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BSS/BSS07", PlaceHolder = "{{BSS/BSS07}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },
            //                     new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BSS/BSS08", PlaceHolder = "{{BSS/BSS08}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },
            //                     new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//BSS/BSS11", PlaceHolder = "{{BSS/BSS11}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //#endregion

            //                  new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SU']]/N1/N101", PlaceHolder = "{{N1/N101-N101 = 'SU'}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //                  new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SU']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'SU'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SU']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'SU'}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'SU']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'SU'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },


            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N101", PlaceHolder = "{{N1/N101-N101 = 'ST'}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //                  new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'ST'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'ST'}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'ST']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'ST'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },

            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BY']]/N1/N101", PlaceHolder = "{{N1/N101-N101 = 'BY'}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //                  new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BY']]/N1/N102", PlaceHolder = "{{N1/N102-N101 = 'BY'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BY']]/N1/N103", PlaceHolder = "{{N1/N103-N101 = 'BY'}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//N1Loop1[N1[N101 = 'BY']]/N1/N104", PlaceHolder = "{{N1/N104-N101 = 'BY'}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },



            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//REF/REF01", PlaceHolder = "{{REF/REF01}}", DefaultValue = "",MappingRequired=true},
            //                       LineLevel = null
            //                   },
            //                   new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//REF/REF02", PlaceHolder = "{{REF/REF02}}", DefaultValue = ""},
            //                       LineLevel = null
            //                   },



            //                new Configuration()
            //               {
            //               XPathConnfig = new XPathConnfig() { XPath = "//CTT/CTT01", PlaceHolder = "{{CTT/CTT01}}", DefaultValue = "" },
            //               LineLevel = null
            //               },

            //               new Configuration()
            //               {
            //                   XPathConnfig = null,
            //                   LineLevel = new LineLevel()
            //                   {
            //                       HTML = "<table style=\"border: 0px; border-style: solid; border-color: black; padding: 2pt; \" WIDTH=\"638\"> <tr><td width=\"100%\" class=\"sectiontitle\"><font face=\"Arial\" color=\"LightGrey\">Line Item</font></td></tr> <tr><td width=\"100%\"> </center></div> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td> <b>Part Numbers</b> </td></tr></table> <table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\" background=\"res://VistaRes.Dll/legalpad.gif\"> <TR><TD WIDTH=\"35%\" >     Buyer's Part Number</TD><TD >{{LIN/LIN03}}</TD></TR> <TR><TD WIDTH=\"35%\" >     Part Number Description</TD><TD >{{LIN/LIN05}}</TD></TR> <TR><TD WIDTH=\"35%\" >     Purchaser's Order Line Number</TD><TD >{{LIN/LIN07}}</TD></TR> <TR><TD WIDTH=\"35%\" >     Purchase Order Number</TD><TD >{{LIN/LIN09}}</TD></TR> </TR> </table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Unit Detail: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Composite Unit of Measure : {{UIT/UIT01}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Reference Identification: </b> </td></tr> </table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      {{REF_2/REF01}} : {{REF_2/REF02}} </td></tr> </table><br> <b>Forecast Schedule</br> <table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\" background=\"res://VistaRes.Dll/legalpad.gif\"> <TR><TD ><strong>     Quan</strong></TD><TD ><strong>Timing</strong></TD><TD ><strong>When</strong></TD></TR> {{ForecastScheduleHtml}} </table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Carrier Details (Routing Sequence/Transit Time): </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Routing Sequence Code : {{TD5/TD501}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Transportation Method/Type Code : {{TD5/TD504}} </td></tr> </table><br> </td></tr> </table>",
            //                       LineLevelXPath = "//LINLoop1",
            //                       PlaceHolder = "{{ParentOfChild}}",
            //                       XPathConnfigs = new List<XPathConnfig>()
            //                       {
            //                           new XPathConnfig(){
            //                               XPath="//LIN/LIN03",
            //                               PlaceHolder="{{LIN/LIN03}}",
            //                               DefaultValue="",
            //                               IsIdentityMarker=true,
            //                           },
            //                          new XPathConnfig(){
            //                               XPath="//LIN/LIN05",
            //                               PlaceHolder="{{LIN/LIN05}}",
            //                               DefaultValue="",
            //                           },
            //                          new XPathConnfig(){
            //                               XPath="//LIN/LIN07",
            //                               PlaceHolder="{{LIN/LIN07}}",
            //                               DefaultValue="",
            //                           },
            //                          new XPathConnfig(){
            //                               XPath="//LIN/LIN09",
            //                               PlaceHolder="{{LIN/LIN09}}",
            //                               DefaultValue="",
            //                           },
            //                          new XPathConnfig(){
            //                               XPath="//UIT/UIT01",
            //                               PlaceHolder="{{UIT/UIT01}}",
            //                               DefaultValue="",
            //                               MappingRequired=true,
            //                           },
            //                           new XPathConnfig(){
            //                               XPath="//REF_2/REF01",
            //                               PlaceHolder="{{REF_2/REF01}}",
            //                               DefaultValue="",
            //                               MappingRequired=true,
            //                           },
            //                            new XPathConnfig(){
            //                               XPath="//REF_2/REF02",
            //                               PlaceHolder="{{REF_2/REF02}}",
            //                               DefaultValue="",
            //                           },
            //                             new XPathConnfig(){
            //                               XPath="//TD5/TD501",
            //                               PlaceHolder="{{TD5/TD501}}",
            //                               DefaultValue="",
            //                               MappingRequired=true,
            //                           },
            //                             new XPathConnfig(){
            //                               XPath="//TD5/TD504",
            //                               PlaceHolder="{{TD5/TD504}}",
            //                               DefaultValue="",
            //                               MappingRequired=true,
            //                           },

            //                       },
            //                       IsChildLineLevel = true,
            //                       ChildLineLevel=new LineLevel
            //                       {
            //                           HTML="<TR><TD>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{{FST/FST01}}</TD><TD>{{FST/FST02}}: {{FST/FST03}}</TD><TD>{{FST/FST04}}</TD></TR>",
            //                         LineLevelXPath="//FSTLoop1",
            //                         PlaceHolder="{{ForecastScheduleHtml}}",
            //                         XPathConnfigs=new List<XPathConnfig>()
            //                         {
            //                             //Quan
            //                             new XPathConnfig()
            //                             {
            //                               XPath="//FST//FST01",
            //                                DefaultValue="",
            //                               PlaceHolder="{{FST/FST01}}",
            //                             },
            //                             //Timing
            //                             new XPathConnfig()
            //                             {
            //                               XPath="//FST//FST02",
            //                                DefaultValue="",
            //                               PlaceHolder="{{FST/FST02}}",
            //                               MappingRequired=true
            //                             },
            //                             new XPathConnfig()
            //                             {
            //                               XPath="//FST//FST03",
            //                                DefaultValue="",
            //                               PlaceHolder="{{FST/FST03}}",
            //                               MappingRequired=true
            //                             },
            //                             //When
            //                             new XPathConnfig()
            //                             {
            //                               XPath = "//FST//FST04",
            //                                DefaultValue="",
            //                               PlaceHolder = "{{FST/FST04}}",
            //                               DateFormat=new DateFormat{
            //                                   SourceFormat="yyMMdd",
            //                                   TargetFormat="M/dd/yyyy"
            //                               }
            //                             },
            //                         }
            //                       }
            //                   }
            //               }
            //           }
            //       }

            //           new HumanReadableConfiguration()
            //           {
            //               TemplatePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XPathLoad947.html"),// Placeholder file
            //               TemplatePathUpdatedTemp = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\XPathLoad947Updated.html"),
            //               PackingPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"EdiWork\Packing_ORIGNAL_947.xml"), // Packing file where xml path defined
            //               TemplateSetCode = 947,
            //               KDIVersion = "",
            //               configurations = new List<Configuration>() {


            //                   #region Date/Time 
            //	new Configuration()
            //                   {
            //                       XPathConnfig = new XPathConnfig() { XPath = "//W15/W1501", PlaceHolder = "{{W15/W1501}}", DefaultValue = "", DateFormat = new DateFormat() { SourceFormat = "yyMMdd", TargetFormat = "MM/dd/yyyy" }},
            //                       LineLevel = null
            //                   }, 
            //#endregion

            ////               new Configuration()
            ////               {
            ////                   XPathConnfig = null,
            ////                   LineLevel = new LineLevel()
            ////                   {
            ////                       HTML = "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Receiving Conditions: </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Quantity Units Received or Accepted : {{RCD/RCD02}} </td></tr> </table><br> </center></div> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Item Detail (Shipment): </b></td></tr></table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Number of Units Shipped : {{SN1/SN102}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Unit or Basis for Measurement Code : {{SN1/SN103}} </td></tr> </table><br> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td> <b>Part Numbers</b> </td></tr></table> <table border=\"0\" WIDTH=\"100%\" CELLPADDING=\"0\" cellspacing=\"1\" HEIGHT=\"1\" bordercolor=\"#808080\" bordercolorlight=\"#C0C0C0\" bordercolordark=\"#808080\" background=\"res://VistaRes.Dll/legalpad.gif\"> <TR><TD WIDTH=\"35%\" BGCOLOR=\"#FFFFFF\">     Buyer's Part Number</TD><TD BGCOLOR=\"#FFFFFF\">{{LIN/LIN03}}</TD></TR> </TR> </table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td></td></tr></table> <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> <tr> <td width=\"100%\" valign=\"top\" align=\"left\"> <b>Purchase Order Reference: </b> </td></tr> </table> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Purchase Order Number : {{PRF_2/PRF01}} </td></tr> <tr> <td width=\"100%\" valign=\"top\" align=\"left\">      Date : {{PRF_2/PRF04}} </td></tr> </table><br> <table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" > </table><br> <hr style=\\"height: 3px; border-style: solid; border-color: #FA9101; padding: 2pt; \\" WIDTH=\\"100%\\" CELLPADDING=\\"0\\" cellspacing=\\"1\\" HEIGHT=\\"1\\">",
            ////                       LineLevelXPath = "//RCDLoop1",
            ////                       PlaceHolder = "{{ChildItems}}",
            ////                       XPathConnfigs = new List<XPathConnfig>()
            ////                       {
            ////                           new XPathConnfig(){
            ////                               XPath="//RCD//RCD02",
            ////                               PlaceHolder="{{RCD/RCD02}}",
            ////                               DefaultValue="",
            ////                           },
            ////                           #region LIN
            ////	                    new XPathConnfig(){
            ////                               XPath="//SN1//SN102",
            ////                               PlaceHolder="{{SN1/SN102}}",
            ////                               DefaultValue="",
            ////                           },
            ////                           //   Part Numbers
            ////                           new XPathConnfig(){
            ////                               XPath="//SN1//SN103",
            ////                                DefaultValue="",
            ////                               PlaceHolder="{{SN1/SN103}}",
            ////                               MappingRequired=true,

            ////                           },
            ////                           // Reference Identification
            ////                           new XPathConnfig(){
            ////                               XPath="//LIN/LIN03",
            ////                                DefaultValue="",
            ////                               PlaceHolder="{{LIN/LIN03}}",
            ////                           },

            ////                           //  Buyer's Size Code
            ////                           new XPathConnfig(){
            ////                               XPath="//PRF_2/PRF01",
            ////                                DefaultValue="",
            ////                               PlaceHolder="{{PRF_2/PRF01}}",
            ////                           },
            ////                           // Buyers Color
            ////                           new XPathConnfig(){
            ////                               XPath="//PRF_2/PRF04",
            ////                                DefaultValue="",
            ////                               PlaceHolder="{{PRF_2/PRF04}}",
            ////                                DateFormat = new DateFormat() { SourceFormat = "yyMMdd", TargetFormat = "MM/dd/yyyy" }
            ////                           },
            ////#endregion


            ////                       },
            ////                   }
            ////               }
            //           }
            //       }


        };




        public static List<HumanReadableConfigurationMapping> humanReadableConfigurationMappings = new List<HumanReadableConfigurationMapping>()
        {
            new HumanReadableConfigurationMapping()
            {
                  TransactionSetCode = 824,
                  Version = 4010,
                  Code = "34",
                  Value = "Payment Declined",
                  CompanyId = "3",
                  TenantId = "faf18357-3373-4d52-8793-d80f1f82cdeb"
            },
            new HumanReadableConfigurationMapping()
            {
                  TransactionSetCode = 824,
                  Version = 4010,
                  Code = "9",
                  Value = "D-U-N-S+4",
                  CompanyId = "3",
                  TenantId = "faf18357-3373-4d52-8793-d80f1f82cdeb"
            },
            new HumanReadableConfigurationMapping()
            {
                  TransactionSetCode = 824,
                  Version = 4010,
                  Code = "TR",
                  Value = "Transaction Set Reject",
                  CompanyId = "3",
                  TenantId = "faf18357-3373-4d52-8793-d80f1f82cdeb"
            },
            new HumanReadableConfigurationMapping()
            {
                  TransactionSetCode = 824,
                  Version = 4010,
                  Code = "TN",
                  Value = "Transaction Reference Number",
                  CompanyId = "3",
                  TenantId = "faf18357-3373-4d52-8793-d80f1f82cdeb"
            },
            new HumanReadableConfigurationMapping()
            {
                  TransactionSetCode = 824,
                  Version = 4010,
                  Code = "810",
                  Value = "Invoice",
                  CompanyId = "3",
                  TenantId = "faf18357-3373-4d52-8793-d80f1f82cdeb"
            },
            new HumanReadableConfigurationMapping()
            {
                  TransactionSetCode = 824,
                  Version = 4010,
                  Code = "003",
                  Value = "Invoice",
                  CompanyId = "3",
                  TenantId = "faf18357-3373-4d52-8793-d80f1f82cdeb"
            },
            new HumanReadableConfigurationMapping()
            {
                  TransactionSetCode = 824,
                  Version = 4010,
                  Code = "006",
                  Value = "Duplicate",
                  CompanyId = "3",
                  TenantId = "faf18357-3373-4d52-8793-d80f1f82cdeb"
            },
            new HumanReadableConfigurationMapping()
            {
                  TransactionSetCode = 824,
                  Version = 4010,
                  Code = "010",
                  Value = "Total Out of Balance",
                  CompanyId = "3",
                  TenantId = "faf18357-3373-4d52-8793-d80f1f82cdeb"
            },
            new HumanReadableConfigurationMapping()
            {
                  TransactionSetCode = 824,
                  Version = 4010,
                  Code = "53",
                  Value = "Original payment item count",
                  CompanyId = "3",
                  TenantId = "faf18357-3373-4d52-8793-d80f1f82cdeb"
            }
        };
    }
}
