using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
namespace ERPStudy.Config
{
    class FactorysElement:ConfigurationElementCollection
    {

        protected override ConfigurationElement CreateNewElement()
        {
            return new FactoryElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FactoryElement)element).Name;
        }

        public FactoryElement this[string name]
        {
            get
            {
                return BaseGet(name) as FactoryElement;
            }
        }
    }
}
