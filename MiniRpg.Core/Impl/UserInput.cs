using System.Configuration;

namespace MiniRpg.Tests
{
	public static class UserInput 
	{
		public static string Heal = ConfigurationManager.AppSettings["HealKey"];
		public static string Attack = ConfigurationManager.AppSettings["AttackKey"];
		public static string BuySword = ConfigurationManager.AppSettings["BuySword"];
		public static string BuyArmor = ConfigurationManager.AppSettings["BuyArmorKey"];
		public static string AskBot = ConfigurationManager.AppSettings["AskBotKey"];

	}

}

