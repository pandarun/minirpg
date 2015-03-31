using MiniRpg.Core;
using System.Configuration;

namespace MiniRpg
{
	public class ShopSettings
	{

		public ShopSettings (ShopElement shopSection)
		{
			WeaponPrice = shopSection.Weapon.WeaponPrice;
			WeaponPowerUpFom = shopSection.Weapon.PowerUpFrom;
			WeaponPopwerUpTo = shopSection.Weapon.PowerUpTo;
			ClothesPrice = shopSection.Clothes.ClothesPrice;
			ClothesMaxHealthUpFrom = shopSection.Clothes.MaxHealthUpFrom;
			ClothesMaxHealthUpTo = shopSection.Clothes.MaxHealthUpTo;
		}	

		public int WeaponPrice {
			get;
			private set;
		}

		public int WeaponPowerUpFom {
			get;
			private set;
		}

		public int WeaponPopwerUpTo {
			get;
			private set;
		}

		public int ClothesPrice {
			get;
			private set;
		}

		public int ClothesMaxHealthUpFrom {
			get;
			private set;
		}

		public int ClothesMaxHealthUpTo {
			get;
			private set;
		}

	}



}
