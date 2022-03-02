using System;
using System.Collections.Generic;
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
        public List<XPathConnfig> XPathConnfigs { get; set; }
    }
    public class XPathConnfig
    {
        public string XPath { get; set; }
        public string PlaceHolder { get; set; }
        public string DefaultValue { get; set; }
    }
}
