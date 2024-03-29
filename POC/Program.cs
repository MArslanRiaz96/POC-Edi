﻿using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
                var content = Encoding.UTF8.GetString(bytes);
                String file = Convert.ToBase64String(bytes);
                var mapping = ListLoadCollections.humanReadableConfigurationMappings.Where(x => x.TransactionSetCode == ListLoadCollection.TemplateSetCode).ToList();
                XPathHelper.XPathMapper(ListLoadCollection, mapping);
            }
        }
        
    }
    
}
