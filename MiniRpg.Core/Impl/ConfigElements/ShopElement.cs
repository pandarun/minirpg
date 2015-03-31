using System.Configuration;


namespace MiniRpg.Core
{
	public class ShopElement : ConfigurationElement
	{

		[ConfigurationProperty("weapon")]
		public WeaponElement Weapon
		{
			get
			{ 
				return (WeaponElement)this["weapon"]; }
			set
			{ this["weapon"] = value; }
		}

		[ConfigurationProperty("clothes")]
		public ClothesElement Clothes
		{
			get
			{ 
				return (ClothesElement)this["clothes"]; }
			set
			{ this["clothes"] = value; }
		}




	}

}

