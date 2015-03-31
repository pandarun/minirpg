using System;
using System.Configuration;


namespace MiniRpg.Core
{
	public class LooseElement : ConfigurationElement
	{
		[ConfigurationProperty("healthPenalty", DefaultValue = "40", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int HealthPenalty
		{
			get
			{ return (int)this["healthPenalty"]; }
			set
			{ this["healthPenalty"] = value; }
		}
	}



}

