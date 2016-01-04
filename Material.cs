using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace _7DaysBalanceTool
{
    class Material
    {
        public class MaterialProperty
        {
            public String Name;
            public String Value;
        }

        public Material(String name)
        {
            this.Name = name;

            this.properties = new Dictionary<string, MaterialProperty>();
        }

        public Material(XElement data, Boolean fill)
        {
            try {
                this.Name = data.Attribute("id").Value;
            } catch {
                throw new ArgumentException("The given XElement does not represent a valid material.");
            }

            this.properties = new Dictionary<string, MaterialProperty>();

            if (fill) this.Fill(data);
        }

        public void AddProperty(String name, String value)
        {
            switch (name) {
            default:
                try {
                    this.properties.Add(name, new MaterialProperty() { Name = name, Value = value });
                } catch {
                    Debug.WriteLine("WARN: Material " + this.Name + " has duplicate property '" + name + "'.");
                    this.properties[name].Value = value;
                }
                break;
            }
        }

        public void AddProperty(XElement propertyNode)
        {
            String name = propertyNode.Attribute("name")?.Value;
            String value = propertyNode.Attribute("value")?.Value;
            if (name == null || value == null) {
                throw new ArgumentNullException("Material " + this.Name + " has a property missing a name or value.");
            }
            this.AddProperty(name, value);
        }

        public void Fill(XElement data)
        {
            foreach (XElement property in data.Elements("property")) this.AddProperty(property);
        }

        public XElement GetXML()
        {
            // Possibly needs type attribute from original XML
            return new XElement("material",
                new XAttribute("id", this.Name),
                this.properties.Select(prop => new XElement("property",
                    new XAttribute("name", prop.Key),
                    new XAttribute("value", prop.Value))));
        }

        public String Property(String name)
        {
            switch (name) {
            default:
                MaterialProperty prop;
                if (this.properties.TryGetValue(name, out prop)) return prop.Value;
                else return null;
            }
            
        }

        public String Name { get; }

        private Dictionary<String, MaterialProperty> properties;
    }
}
