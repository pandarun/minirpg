using System;
using System.Configuration;


namespace MiniRpg.Core
{
	public class FightElement : ConfigurationElement
	{
		[ConfigurationProperty("winChance")]
		public WinChanceElement WinChance
		{
			get
			{ 
				return (WinChanceElement)this["winChance"]; }
			set
			{ this["winChance"] = value; }
		}

		[ConfigurationProperty("win")]
		public WinElement Win
		{
			get
			{ 
				return (WinElement)this["win"]; }
			set
			{ this["win"] = value; }
		}

		[ConfigurationProperty("loose")]
		public LooseElement Loose
		{
			get
			{ 
				return (LooseElement)this["loose"]; }
			set
			{ this["loose"] = value; }
		}
	}


}

