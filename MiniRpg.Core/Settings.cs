using System.Collections.Generic;

namespace MiniRpg.Core
{

	public class Settings : ISettings {

		public Settings (int health, int money, int power)
		{
			this.Health = health;
			this.Money = money;
			this.Power = power;
			this.MaxHealth = Health;
			this.Equipments = new List<IEquipment> (){ };
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

		public System.Collections.Generic.IList<IEquipment> Equipments {
			get;
			private set;
		}
		#endregion
	}
}
