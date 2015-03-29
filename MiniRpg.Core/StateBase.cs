using System;
using MiniRpg.Core;

public class StateBase : IState {

	public StateBase (int health, int maxHealth, int power, int money)
	{
		this.Health = health;
		this.MaxHealth = maxHealth;
		this.Power = power;
		this.Money = money;
	}

	#region IState implementation

	public IState Fight ()
	{
		var winProbability = Math.Min (0.4 + Power * 0.05, 0.7);
		var random = new Random ();
		var result = (random.NextDouble() < winProbability);


		return result 
			?  new StateBase((int)(0.9 * Health), MaxHealth, Power, Money + 5)
			:  new StateBase(Health - 40, MaxHealth, Power, Money);
		
	}

	public IState Heal ()
	{
		return new StateBase (Health + 10 > MaxHealth ? MaxHealth : Health, MaxHealth, Power, Money - 3);
	}

	public IState BuyArmor ()
	{
		var random = new Random ();
		var powerUp = random.Next (1,2);
		return new StateBase (Health, MaxHealth, Power + powerUp, Money - 10);
	}

	public IState BuyWeapon ()
	{
		var random = new Random ();
		var healthCapacityUp = random.Next (1,2);
		return new StateBase (Health, MaxHealth + healthCapacityUp, Power, Money);
	}

	public int Health {
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

	public int Money {
		get;
		private set;
	}

	public System.Collections.Generic.IList<IEquipment> Equipment {
		get {
			throw new NotImplementedException ();
		}
	}

	public bool IsTerminal {
		get {
			return this.Health <= 0;
		}

	}

	public override string ToString ()
	{
		return string.Format ("[StateBase: Health={0}, Power={1}, MaxHealth={2}, Money={3}, Equipment={4}, IsTerminal={5}]", Health, Power, MaxHealth, Money, Equipment, IsTerminal);
	}

	#endregion


}
