namespace MiniRpg.Core.Impl.ConfigElements
{
    using System.Configuration;

    public class WinElement : ConfigurationElement
	{
		[ConfigurationProperty("healthPenaltyScale", DefaultValue = "0.1", IsRequired = true)]
		public double HealthPenaltyScale
		{
			get
			{ return (double)(this["healthPenaltyScale"]); }
			set
			{ this["healthPenaltyScale"] = value; }
		}

		[ConfigurationProperty("moneyUp", DefaultValue = "5", IsRequired = true)]
		[IntegerValidator(ExcludeRange = false, MaxValue = int.MaxValue, MinValue = 0)]
		public int MoneyUp
		{
			get
			{ return (int)this["moneyUp"]; }
			set
			{ this["moneyUp"] = value; }
		}


	}



}

