using System;
using System.Configuration;


namespace MiniRpg.Core
{
	public class GameSettingsSection : ConfigurationSection
	{
		[ConfigurationProperty("health", DefaultValue = "100", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int Health
		{
			get
			{ return (int)this["health"]; }
			set
			{ this["health"] = value; }
		}

		[ConfigurationProperty("maxHealth", DefaultValue = "100", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int MaxHealth
		{
			get
			{ return (int)this["maxHealth"]; }
			set
			{ this["maxHealth"] = value; }
		}

		[ConfigurationProperty("power", DefaultValue = "12", IsRequired = false)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int Power
		{
			get
			{ return (int)this["power"]; }
			set
			{ this["power"] = value; }
		}

		[ConfigurationProperty("money", DefaultValue = "12", IsRequired = false)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int Money
		{
			get
			{ return (int)this["money"]; }
			set
			{ this["money"] = value; }
		}

		[ConfigurationProperty("shopSettings")]
		public ShopElement ShopSettings
		{
			get
			{ 
				return (ShopElement)this["shopSettings"]; }
			set
			{ this["shopSettings"] = value; }
		}

		[ConfigurationProperty("fightSettings")]
		public FightElement FightSettings
		{
			get
			{ 
				return (FightElement)this["fightSettings"]; }
			set
			{ this["fightSettings"] = value; }
		}

		[ConfigurationProperty("healerSettings")]
		public HealerElement HealerSettings
		{
			get
			{ 
				return (HealerElement)this["healerSettings"]; }
			set
			{ this["healerSettings"] = value; }
		}

		[ConfigurationProperty("inventory",
			IsDefaultCollection = false)]
		public InventoryItemCollection Inventory
		{
			get
			{
				InventoryItemCollection inventoryItemCollection =
					(InventoryItemCollection)base["inventory"];
				return inventoryItemCollection;
			}
		}
	}
}

