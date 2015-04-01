namespace MiniRpg.Core.Impl
{
    using System.Collections.Generic;
    using System.Linq;

    using MiniRpg.Core.IFaces;

    public class Settings : ISettings {

		public Settings(PlayerSettings playerSettings, FightSettings fightSettings, ShopSettings shopSettings, HealerSettings healSettings) 
			: this(playerSettings.Health, playerSettings.MaxHealth, playerSettings.Money, playerSettings.Power){

			this.WeaponPrice = shopSettings.WeaponPrice;
            this.WeaponPowerUpFrom = shopSettings.WeaponPowerUpFrom;
            this.WeaponPowerUpTo = shopSettings.WeaponPopwerUpTo;

			this.ClothesPrice = shopSettings.ClothesPrice;
			this.ClothesMaxHealthUpFrom = shopSettings.ClothesMaxHealthUpFrom;
			this.ClothesMaxHealthUpTo = shopSettings.ClothesMaxHealthUpTo;

			this.BaseChance = fightSettings.BaseChance;
			this.MaxChance 	= fightSettings.MaxChance;
			this.PowerScale = fightSettings.PowerScale;

			this.HealthPenalty = fightSettings.HealthPenalty;
			this.HealthPenltyScale = fightSettings.HealthPenltyScale;
			this.MoneyUp = fightSettings.MoneyUp;
			this.PowerScale = fightSettings.PowerScale;

			this.HealPrice 	= healSettings.HealPrice;
			this.HealUp 	= healSettings.Healup;


		}

	    public int WeaponPowerUpTo { 
            get;
            private set; 
        }

	    public int WeaponPowerUpFrom { 
            get; 
            private set; 
        }

	    public Settings (int health, int money, int power) 
			: this(health, money, power, health, Enumerable.Empty<IEquipment>())
		{
		}

        public Settings(int health, int maxHealth, int money, int power)
            : this(health, money, power, maxHealth, Enumerable.Empty<IEquipment>())
        {
        }

		public Settings (int health, int money, int power, int maxHealth, IEnumerable<IEquipment> equipments)
		{
			this.Health = health;
			this.Money = money;
			this.Power = power;
			this.MaxHealth = maxHealth;
			this.Equipments = equipments;
		}

		#region ISettings implementation
		public int Health {
			get;
			private set;
		}
		public int Money {
			get;
			private set;
		}
		public int Power {
			get;
			private set;
		}

		public int MaxHealth {
			get;
			private set;
		}

		public int WeaponPrice {
			get;
			private set;
		}

		public IEnumerable<IEquipment> Equipments {
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

		public double BaseChance {
			get;
			private set;
		}

		public double MaxChance {
			get;
			private set;
		}

		public double PowerScale {
			get;
			private set;
		}

		public int HealthPenalty {
			get;
			private set;
		}

		public double HealthPenltyScale {
			get;
			private set;
		}

		public int MoneyUp {
			get;
			private set;
		}

		public int HealPrice {
			get;
			private set;
		}

		public int HealUp {
			get;
			private set;
		}
		#endregion
	}
}
