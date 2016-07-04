using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
namespace ERPStudy.Config
{
    class FactoryElement:ConfigurationElement
    {
        [ConfigurationProperty("name")]
        public string Name { get; set; }

        [ConfigurationProperty("assembly")]
        public string Assembly { get; set; }

        [ConfigurationProperty("class")]
        public string Class { get; set; }
    }
}
