using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace _7DaysBalanceTool
{
    class Block
    {
        /// <summary>
        /// Represents an event that may cause a block to drop an item.
        /// </summary>
        public class BlockEvent
        {
            public List<UInt32> Count;
            public String Event;
            public Item Name;
            public Single Probability;
            public Single StickChance;
            public String ToolCategory;
        }

        /// <summary>
        /// Represents a basic property of a block.
        /// </summary>
        public class BlockProperty
        {
            public String Name;
            public String Value;
        }

        /// <summary>
        /// Represents a property of a block that has a second parameter.
        /// </summary>
        public class BlockPropertyDoubleParam : BlockPropertySingleParam
        {
            public String Param2;
        }

        /// <summary>
        /// Represents a property of a block that additionally has a parameter.
        /// </summary>
        public class BlockPropertySingleParam : BlockProperty
        {
            public String Param1;
        }

        /// <summary>
        /// Creates an empty instance of a block with the specified name and ID.
        /// </summary>
        /// <param name="id">The internal ID number of the block.</param>
        /// <param name="name">The internal name of the block.</param>
        public Block(UInt32 id, String name)
        {
            this.ID = id;
            this.Name = name;

            this.events = new Dictionary<string, BlockEvent>();
            this.properties = new Dictionary<string, BlockProperty>();
            this.recipesMade = new List<Recipe>();
            this.recipesUsed = new List<Recipe>();
        }

        /// <summary>
        /// Creates an instance of a block from existing XML data.
        /// </summary>
        /// <param name="data">An XElement representing the block to create.</param>
        /// <param name="fill">Whether or not to fill events and properties from child elements.</param>
        public Block(XElement data, Boolean fill)
        {
            try {
                this.ID = Convert.ToUInt32(data.Attribute("id").Value);
                this.Name = data.Attribute("name").Value;
            } catch {
                throw new ArgumentException("The given XElement does not represent a valid block.");
            }

            this.events = new Dictionary<string, BlockEvent>();
            this.properties = new Dictionary<string, BlockProperty>();
            this.recipesMade = new List<Recipe>();
            this.recipesUsed = new List<Recipe>();

            if (fill) this.Fill(data);
        }

        /// <summary>
        /// Adds an event to the block.
        /// </summary>
        /// <param name="count">The set of possible numbers of items that drop when the event happens.</param>
        /// <param name="eventName">The name of the event; i.e., what causes it.</param>
        /// <param name="name">The name of the item that drops when the event happens.</param>
        /// <param name="probability">The probability that something will drop when the event happens.</param>
        /// <param name="stickChance">The chance that the dropped item will attach itself to the terrain.</param>
        /// <param name="toolCategory">The category of tool used to destroy the block required to drop items.</param>
        public void AddEvent(List<UInt32> count, String eventName, String name, Single probability,
            Single stickChance, String toolCategory)
        {
            try {
                this.events.Add(eventName, new BlockEvent() { Count = count, Event = eventName,
                    Name = this.itemList[name], Probability = probability, StickChance = stickChance,
                    ToolCategory = toolCategory });
            } catch {
                Debug.WriteLine("WARN: Block " + this.ID + " has duplicate event '" + eventName + "'.");
                // NOTE: Previous event data is not overwritten.
                // FIXME: This may break tool categories.
                // XXX: Events can drop blocks or items. This breaks strong typing
            }
        }

        /// <summary>
        /// Adds an event to the block from an existing drop element.
        /// </summary>
        /// <param name="eventNode">The drop element.</param>
        public void AddEvent(XElement eventNode)
        {
            String eventName = eventNode.Attribute("event")?.Value;
            if (eventName == null) {
                throw new ArgumentNullException("Block " + this.ID + " has an event element without a name.");
            }
            this.AddEvent(eventNode.Attribute("count")?.Value?.Split(',')?.Select(c => Convert.ToUInt32(c))?.ToList(),
                eventName, eventNode.Attribute("name")?.Value, Convert.ToSingle(eventNode.Attribute("prob")?.Value),
                Convert.ToSingle(eventNode.Attribute("stick_chance")?.Value),
                eventNode.Attribute("tool_category")?.Value);
        }

        /// <summary>
        /// Adds a property to the block.
        /// </summary>
        /// <param name="name">The name of the property.</param>
        /// <param name="value">The value of the property.</param>
        /// <param name="param1">The first parameter of the property, or null.</param>
        /// <param name="param2">The second parameter of the property, or null.</param>
        public void AddProperty(String name, String value, String param1, String param2)
        {
            switch (name) {
            case "CanMobsSpawnOn":
                this.CanMobsSpawnOn = Convert.ToBoolean(value);
                break;
            case "CanPickup":
                this.CanPickup = Convert.ToBoolean(value);
                if (param1 != null) this.PickupTarget = this.itemList[param1];
                break;
            case "CanPlayersSpawnOn":
                this.CanPlayersSpawnOn = Convert.ToBoolean(value);
                break;
            case "Class":
                this.Class = value;
                break;
            case "Collide":
                this.Collide = value;
                break;
            case "Damage":
                this.Damage = Convert.ToUInt32(value);
                break;
            case "Damage_received":
                this.DamageReceived = Convert.ToUInt32(value);
                break;
            case "DowngradeBlock":
                this.DowngradeBlock = this.blockList[value];
                break;
            case "Extends":
                this.Extends = this.blockList[value];
                break;
            case "FallDamage":
                this.FallDamage = Convert.ToBoolean(value);
                break;
            case "FuelValue":
                this.FuelValue = Convert.ToUInt32(value);
                break;
            case "LootList":
                this.LootList = Convert.ToUInt32(value);
                break;
            case "Material":
                this.Material = this.materialList[value];
                break;
            case "MaxDamage":
                this.MaxDamage = Convert.ToUInt32(value);
                break;
            case "PickupTarget":
                this.PickupTarget = this.itemList[value];
                break;
            case "Weight":
                this.Weight = Convert.ToUInt32(value);
                break;
            default:
                try {
                    BlockProperty newProperty;
                    if (propertiesWithParam2.Contains(name)) {
                        newProperty = new BlockPropertyDoubleParam() { Param1 = param1, Param2 = param2 };
                    } else if (propertiesWithParam1.Contains(name)) {
                        newProperty = new BlockPropertySingleParam() { Param1 = param1 };
                    } else {
                        newProperty = new BlockProperty();
                    }
                    newProperty.Name = name;
                    newProperty.Value = value;
                    this.properties.Add(name, newProperty);
                } catch {
                    Debug.WriteLine("WARN: Block " + this.ID + " has duplicate property '" + name + "'. Overriding.");
                    if (propertiesWithParam2.Contains(name)) {
                        (this.properties[name] as BlockPropertyDoubleParam).Param2 = param2;
                    }
                    if (propertiesWithParam1.Contains(name)) {
                        (this.properties[name] as BlockPropertySingleParam).Param1 = param1;
                    }
                    this.properties[name].Value = value;
                }
                break;
            }
        }

        /// <summary>
        /// Adds a property to the block from an existing property element.
        /// </summary>
        /// <param name="propertyNode">The property element.</param>
        public void AddProperty(XElement propertyNode)
        {
            String name = propertyNode.Attribute("name")?.Value;
            String value = propertyNode.Attribute("value")?.Value;
            String param1 = propertyNode.Attribute("param1")?.Value;
            String param2 = propertyNode.Attribute("param2")?.Value;
            if (name == null || value == null) {
                throw new ArgumentNullException("Block " + this.ID + " has a property missing a name or value.");
            }
            if (param1 != null && !propertiesWithParam1.Contains(name)) {
                Debug.WriteLine("WARN: param1 at block " + this.ID + " property " + name + " will be ignored.");
            }
            if (param2 != null && !propertiesWithParam2.Contains(name)) {
                Debug.WriteLine("WARN: param2 at block " + this.ID + " property " + name + " will be ignored.");
            }
            this.AddProperty(name, value, param1, param2);
        }

        /// <summary>
        /// Gets the data for the named event.
        /// </summary>
        /// <param name="eventName">The name of the event to get data for.</param>
        /// <returns>The object representing the event.</returns>
        public BlockEvent Event(String eventName)
        {
            return this.events[eventName];
        }

        /// <summary>
        /// Fills the block object with properties and events from the given block element. Note that this does not
        /// modify the ID or Name of the block.
        /// </summary>
        /// <param name="data">The block element, containing drop and property elements.</param>
        public void Fill(XElement data)
        {
            foreach (XElement drop in data.Elements("drop")) this.AddEvent(drop);
            foreach (XElement property in data.Elements("property")) this.AddProperty(property);
        }

        /// <summary>
        /// Gets an XML representation of the block, that can be used to generate a compatible XML data file.
        /// </summary>
        /// <returns>An XElement with all of the block's data, in game-compatible format.</returns>
        public XElement GetXML()
        {
            // FIXME: param1, param2, named properties
            return new XElement("block",
                new XAttribute("id", this.ID),
                new XAttribute("name", this.Name),
                this.events.OrderBy(drop => drop.Value.Event).Select(drop => new XElement("drop",
                    new XAttribute("count", String.Join(",", drop.Value.Count.Select(v => v.ToString()).ToArray())),
                    new XAttribute("event", drop.Value.Event),
                    new XAttribute("name", drop.Value.Name),
                    new XAttribute("prob", drop.Value.Probability),
                    new XAttribute("stick_chance", drop.Value.StickChance),
                    new XAttribute("tool_category", drop.Value.ToolCategory))),
                this.properties.OrderBy(prop => prop.Value.Name).Select(prop => new XElement("property",
                    new XAttribute("name", prop.Value.Name),
                    new XAttribute("value", prop.Value.Value))));
        }

        /// <summary>
        /// Gets a string representing the value of the named property.
        /// </summary>
        /// <param name="name">The property to retrieve the value of.</param>
        /// <returns>The value of the property as a string.</returns>
        public String Property(String name)
        {
            switch (name) {
            case "CanMobsSpawnOn":
                return this.CanMobsSpawnOn.ToString() ?? this.Extends?.Property(name);
            case "CanPickup":
                return this.CanPickup.ToString() ?? this.Extends?.Property(name);
            case "CanPlayersSpawnOn":
                return this.CanPlayersSpawnOn.ToString() ?? this.Extends?.Property(name);
            case "Class":
                return this.Class ?? this.Extends?.Property(name);
            case "Collide":
                return this.Collide ?? this.Extends?.Property(name);
            case "Damage":
                return this.Damage.ToString() ?? this.Extends?.Property(name);
            case "DamageReceived":
                return this.DamageReceived.ToString() ?? this.Extends?.Property(name);
            case "DowngradeBlock":
                return this.DowngradeBlock?.Name ?? this.Extends?.Property(name);
            case "Extends":
                return this.Extends?.Name;
            case "FallDamage":
                return this.FallDamage.ToString() ?? this.Extends?.Property(name);
            case "FuelValue":
                return this.FuelValue.ToString() ?? this.Extends?.Property(name);
            case "LootList":
                return this.LootList.ToString() ?? this.Extends?.Property(name);
            case "Material":
                return this.Material?.Name ?? this.Extends?.Property(name);
            case "MaxDamage":
                return this.MaxDamage.ToString() ?? this.Extends?.Property(name);
            case "PickupTarget":
                return this.PickupTarget?.Name ?? this.Extends?.Property(name);
            case "Weight":
                return this.Weight.ToString() ?? this.Extends?.Property(name);
            default:
                BlockProperty prop;
                if (this.properties.TryGetValue(name, out prop)) return prop.Value;
                else return this.Extends?.Property(name);
            }
        }

        /// <summary>
        /// Sets the lists containing the relevant game configuration, including the list of blocks to which this
        /// block belongs.
        /// </summary>
        /// <param name="blockList">The list containing this block object.</param>
        /// <param name="groupList">The list of groups.</param>
        /// <param name="itemList">The list of items.</param>
        /// <param name="materialList">The list of materials.</param>
        /// <param name="recipeList">The list of recipes.</param>
        public void SetContext(Dictionary<String, Block> blockList, Dictionary<String, Group> groupList,
            Dictionary<String, Item> itemList, Dictionary<String, Material> materialList,
            Dictionary<String, Recipe> recipeList)
        {
            this.blockList = blockList;
            this.groupList = groupList;
            this.itemList = itemList;
            this.materialList = materialList;
            this.recipeList = recipeList;
        }

        /// <summary>
        /// The numeric ID of the block.
        /// </summary>
        public UInt32 ID { get; }
        /// <summary>
        /// The untranslated textual name of the block, used as an index in several places.
        /// </summary>
        public String Name { get; }

        // For the properties below without defaults, null is probably the best default.
        public Boolean CanMobsSpawnOn { get; set; } = true;
        public Boolean CanPickup { get; set; } = false;
        public Boolean CanPlayersSpawnOn { get; set; } = true;
        public String Class { get; set; }
        public String Collide { get; set; }
        public UInt32 Damage { get; set; } = 0;
        public UInt32 DamageReceived { get; set; } = 0;
        public Block DowngradeBlock { get; set; }
        public Block Extends { get; set; }
        public Boolean FallDamage { get; set; } = true;
        public UInt32 FuelValue { get; set; } = 0;
        public UInt32 LootList { get; set; }
        public Material Material { get; set; }
        public UInt32 MaxDamage { get; set; }
        public Item PickupTarget { get; set; }
        public UInt32 Weight { get; set; } = 0;

        private Dictionary<String, Block> blockList;
        private Dictionary<String, Group> groupList;
        private Dictionary<String, Item> itemList;
        private Dictionary<String, Material> materialList;
        private Dictionary<String, Recipe> recipeList;

        private Dictionary<String, BlockEvent> events;
        private Dictionary<String, BlockProperty> properties;
        private List<Recipe> recipesMade;
        private List<Recipe> recipesUsed;
        
        /// <summary>
        /// The set of properties that are allowed (known) to have one or more parameters.
        /// </summary>
        private static readonly String[] propertiesWithParam1 = { "CanPickup", "Model", "PlantGrowing.GrowOnTop" };
        /// <summary>
        /// The set of properties that are allowed (known) to have two or more parameters.
        /// </summary>
        private static readonly String[] propertiesWithParam2 = { "PlantGrowing.GrowOnTop" };
    }
}
