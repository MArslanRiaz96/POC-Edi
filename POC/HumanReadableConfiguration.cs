using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC
{
    public class HumanReadableConfiguration
    {
        public string TemplatePath { get; set; }
        public string TemplatePathUpdatedTemp { get; set; }
        public string PackingPath { get; set; }
        public int TemplateSetCode { get; set; }
        public bool? IsCustom { get; set; }
        public string KDIVersion { get; set; }
        public List<Configuration> configurations{ get; set; }
    }
    public class Configuration
    {
        public XPathConnfig XPathConnfig { get; set; }
        public LineLevel  LineLevel{ get; set; }
    }
    public class LineLevel 
    {
        public string HTML { get; set; }
        public string LineLevelXPath { get; set; }
        public string PlaceHolder { get; set; }
        public List<XPathConnfig> XPathConnfigs { get; set; }
        public bool IsChildLineLevel { get; set; }
        public LineLevel ChildLineLevel { get; set; }
    }
    public class XPathConnfig
    {
        public string XPath { get; set; }
        public string PlaceHolder { get; set; }
        public string DefaultValue { get; set; }
        public bool MappingRequired { get; set; }
        public DateFormat DateFormat { get; set; }
        public TimeFormat TimeFormat { get; set; }
        public List<string> MutiplcationUsingXPath { get; set; }
        public List<string> AdditionUsingPlaceHolders { get; set; }
        public bool ConcatinationUsingSameXPath { get; set; }
        public string GetXPathUsingIdentifier { get; set; }
        public bool GetXPathUsingIdentifierOneStepHead { get; set; }
        public bool ShowInLastLineItem { get; set; }
        public List<PreferedXpath> PreferedXpaths { get; set; }
        public List<string> ConcatinationUsingDifferentXPath { get; set; }
        public bool AllowNodeSameRepetation { get; set; }
        public bool IsIdentityMarker { get; set; }

    }
    public class PreferedXpath
    {
        public string XPath { get; set; }
        public string Identifier { get; set; }
        public string TotalNodes { get; set; }
        public string SelectedNode { get; set; }
    }
    public class DateFormat
    {
        public string SourceFormat { get; set; }
        public string TargetFormat { get; set; }
    }
    public class TimeFormat
    {
        public string SourceFormat { get; set; }
        public string TargetFormat { get; set; }
    }
    public class HumanReadableConfigurationMapping
    {
        public int TransactionSetCode { get; set; }
        public int Version { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public string CompanyId { get; set; }
        public string TenantId { get; set; }
        public string entity_name { get; set; }
    }
}
