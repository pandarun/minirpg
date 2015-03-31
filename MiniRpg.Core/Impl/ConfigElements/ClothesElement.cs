using System.Configuration;


namespace MiniRpg.Core
{
	public class ClothesElement : ConfigurationElement
	{

		[ConfigurationProperty("clothesPrice", DefaultValue = "0", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int ClothesPrice
		{
			get
			{ return (int)this["clothesPrice"]; }
			set
			{ this["clothesPrice"] = value; }
		}

		[ConfigurationProperty("maxHealthUpFrom", DefaultValue = "1", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int MaxHealthUpFrom
		{
			get
			{ return (int)this["maxHealthUpFrom"]; }
			set
			{ this["maxHealthUpFrom"] = value; }
		}

		[ConfigurationProperty("maxHealthUpTo", DefaultValue = "2", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int MaxHealthUpTo
		{
			get
			{ return (int)this["maxHealthUpTo"]; }
			set
			{ this["maxHealthUpTo"] = value; }
		}
	}


}

