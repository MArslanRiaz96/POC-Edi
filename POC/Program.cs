using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;

namespace POC
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var ListLoadCollection in ListLoadCollections.humanReadableConfigurations)
            {
                 var tes  = JsonConvert.SerializeObject(ListLoadCollection);
                Byte[] bytes = File.ReadAllBytes(ListLoadCollection.TemplatePath);
                String file = Convert.ToBase64String(bytes);
                XPathHelper.XPathMapper(ListLoadCollection);
            }
        }
        
    }
    
}
