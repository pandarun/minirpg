using System.Collections.Generic;

namespace MiniRpg.Core
{
	public interface IState
	{
		int Health { get; }
		int Power {get; }
		int MaxHealth { get; }
		int Money { get; }
		IList<IEquipment> Equipment {get;}
		bool IsTerminal  {get;}

		IState Fight();
		IState Heal();
		IState BuyArmor();
		IState BuyWeapon();
	}


}

