
namespace MiniRpg.Core.Impl
{

	public class PlayerSettings
	{
		public PlayerSettings (int health, int money, int power, int maxHealth)
		{
			this.Health = health;
			this.Money = money;
			this.Power = power;
			this.MaxHealth = maxHealth;
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

		#endregion
	}

}
