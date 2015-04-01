namespace MiniRpg.Core.Impl.ConfigElements
{
    using System.Configuration;

    public class WeaponElement : ConfigurationElement
	{

		[ConfigurationProperty("weaponPrice", DefaultValue = "10", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int WeaponPrice
		{
			get
			{ return (int)this["weaponPrice"]; }
			set
			{ this["weaponPrice"] = value; }
		}

		[ConfigurationProperty("powerUpFrom", DefaultValue = "1", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int PowerUpFrom
		{
			get
			{ return (int)this["powerUpFrom"]; }
			set
			{ this["powerUpFrom"] = value; }
		}

		[ConfigurationProperty("powerUpTo", DefaultValue = "2", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int PowerUpTo
		{
			get
			{ return (int)this["powerUpTo"]; }
			set
			{ this["powerUpTo"] = value; }
		}
	}


}

