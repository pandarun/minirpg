namespace MiniRpg.Core.IFaces
{
    using System.Collections.Generic;

    public interface ISettings
	{
		int Health { get;}
		int Money { get; }
		int Power { get; }
		int MaxHealth { get; }
		int WeaponPrice { get; }
		IEnumerable<IEquipment> Equipments {get;}

		int ClothesPrice {get;}

		int ClothesMaxHealthUpFrom {get;}

		int ClothesMaxHealthUpTo {get;}

		double BaseChance {get;}

		double MaxChance {get;}

		double PowerScale {get;}

		int HealthPenalty {get;}

		double HealthPenltyScale {get;}

		int MoneyUp {get;}

		int HealPrice {get;}

		int HealUp {get;}

        int WeaponPowerUpFrom { get; }

        int WeaponPowerUpTo { get; }
	}

}

