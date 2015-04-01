namespace MiniRpg.Core.Impl.ConfigElements
{
    using System.Configuration;

    public class HealerElement : ConfigurationElement
	{
		[ConfigurationProperty("healPrice", DefaultValue = "10", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int HealPrice
		{
			get
			{ return (int)this["healPrice"]; }
			set
			{ this["healPrice"] = value; }
		}

		[ConfigurationProperty("healUp", DefaultValue = "10", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int HealUp
		{
			get
			{ return (int)this["healUp"]; }
			set
			{ this["healUp"] = value; }
		}
	}

}

