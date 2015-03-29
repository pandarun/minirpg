using System.Collections.Generic;
using System.Linq;

namespace MiniRpg.Core
{

	public class Settings : ISettings {

		public Settings (int health, int money, int power) 
			: this(health, money, power, health, Enumerable.Empty<IEquipment>())
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

		public System.Collections.Generic.IEnumerable<IEquipment> Equipments {
			get;
			private set;
		}
		#endregion
	}
}
