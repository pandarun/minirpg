using System.Collections.Generic;
namespace MiniRpg.Core
{
	public interface ISettings
	{
		int Health { get;}
		int Money { get; }
		int Power { get; }
		int MaxHealth { get; }
		IEnumerable<IEquipment> Equipments {get;}
	}

}

