namespace MiniRpg.Core.IFaces
{
    using System.Collections.Generic;

    public interface IState
	{
		int Health { get; }
		int Power {get; }
		int MaxHealth { get; }
		int Money { get; }
		IEnumerable<IEquipment> Equipment {get;}
		bool IsTerminal  {get;}

		IState Fight();
		IState Heal();
		IState BuyArmor();
		IState BuyWeapon();
	}


}

