using System;
using System.Configuration;

namespace MiniRpg.Core
{

	public class InventoryItemConfigElement : ConfigurationElement
	{
		public InventoryItemConfigElement()
		{
		}

		public InventoryItemConfigElement(string elementName)
		{
			Name = elementName;
		}

		[ConfigurationProperty("name", 
			DefaultValue = "Item",
			IsRequired = true, 
			IsKey = true)]
		public string Name
		{
			get
			{
				return (string)this["name"];
			}
			set
			{
				this["name"] = value;
			}
		}

		[ConfigurationProperty("type", 
			DefaultValue = "Weapon",
			IsRequired = true, 
			IsKey = true)]
		public ItemTypeEnum Enum
		{
			get { return (ItemTypeEnum)this["type"]; }
			set { this["type"] = value; }
		}

		[Flags]
		public enum ItemTypeEnum
		{
			None = 0,
			Weapon = 1,
			Clothes = 2
		}

	}
}
