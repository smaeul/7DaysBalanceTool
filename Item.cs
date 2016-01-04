using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace _7DaysBalanceTool
{
    class Item
    {
        public Item(UInt32 id, String name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Item(XElement data, Boolean fill)
        {
            try {
                this.ID = Convert.ToUInt32(data.Attribute("id").Value);
                this.Name = data.Attribute("name").Value;
            } catch {
                throw new ArgumentException("The given XElement does not represent a valid item.");
            }

            if (fill) throw new ArgumentException("Items do not currently support properties.");
        }

        public UInt32 ID { get; }
        public String Name { get; }
    }
}
