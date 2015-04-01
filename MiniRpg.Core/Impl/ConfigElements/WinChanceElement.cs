namespace MiniRpg.Core.Impl.ConfigElements
{
    using System.Configuration;

    public class WinChanceElement : ConfigurationElement
	{

		[ConfigurationProperty("baseChance", DefaultValue = "0.4", IsRequired = true)]
		public double BaseChance
		{
			get
			{ return (double)this["baseChance"]; }
			set
			{ this ["baseChance"] = value; }
		}

		[ConfigurationProperty("powerScale", DefaultValue = "0.05", IsRequired = true)]
		public double PowerScale
		{
			get
			{ return (double)(this["powerScale"]); }
			set
			{ this["powerScale"] = value; }
		}


		[ConfigurationProperty("maxChance", DefaultValue = "0.7", IsRequired = true)]
		public double MaxChance
		{
			get
			{ return (double)(this["maxChance"]); }
			set
			{ this["maxChance"] = value; }
		}
	}



}

