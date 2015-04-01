namespace MiniRpg.Core.Impl
{
    using MiniRpg.Core.Impl.ConfigElements;

    public class ShopSettings
	{

		public ShopSettings (ShopElement shopSection)
		{
			this.WeaponPrice = shopSection.Weapon.WeaponPrice;
			this.WeaponPowerUpFrom = shopSection.Weapon.PowerUpFrom;
			this.WeaponPopwerUpTo = shopSection.Weapon.PowerUpTo;
			this.ClothesPrice = shopSection.Clothes.ClothesPrice;
			this.ClothesMaxHealthUpFrom = shopSection.Clothes.MaxHealthUpFrom;
			this.ClothesMaxHealthUpTo = shopSection.Clothes.MaxHealthUpTo;
		}	

		public int WeaponPrice {
			get;
			private set;
		}

		public int WeaponPowerUpFrom {
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
