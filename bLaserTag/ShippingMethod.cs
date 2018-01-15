using System.Configuration;
using System.Collections.Generic;

namespace bLaserTag
{
    public class ShippingMethod
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public static IEnumerable<ShippingMethod> GetShippingMethods()
        {
            var config = ConfigurationManager.GetSection("shippingMethods") as ShippingMethodConfigSection;

            //Console.WriteLine(config["Tata Motors"].Code);
            foreach (ShippingMethodConfigInstanceElement e in config.Instances)
            {
                yield return new ShippingMethod { Name = e.Name, Code = e.Code };
            }
        }
    }

    public class ShippingMethodConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
        public ShippingMethodConfigInstanceCollection Instances
        {
            get { return (ShippingMethodConfigInstanceCollection)this[""]; }
            set { this[""] = value; }
        }
    }

    public class ShippingMethodConfigInstanceCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ShippingMethodConfigInstanceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            //set to whatever Element Property you want to use for a key
            return ((ShippingMethodConfigInstanceElement)element).Name;
        }
    }

    public class ShippingMethodConfigInstanceElement : ConfigurationElement
    {
        //Make sure to set IsKey=true for property exposed as the GetElementKey above
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }

        [ConfigurationProperty("code", IsRequired = true)]
        public string Code
        {
            get { return (string)base["code"]; }
            set { base["code"] = value; }
        }
    }
}