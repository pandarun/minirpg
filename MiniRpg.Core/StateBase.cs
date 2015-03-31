using System;
using System.Collections.Generic;
using MiniRpg.Core;
using System.Linq;
using System.Text;

public class StateBase : IState {

	public StateBase (int health, int maxHealth, int power, int money)
		: this(health,maxHealth, power,money, Enumerable.Empty<IEquipment>())
	{
	}

	public StateBase(int health, int maxHealth, int power, int money, IEnumerable<IEquipment> inventory)  {
		this.Health = health;
		this.MaxHealth = maxHealth;
		this.Power = power;
		this.Money = money;
		this.Equipment = inventory;
	}

	#region IState implementation

	protected virtual bool CalcuateFightResult ()
	{
		var winProbability = Math.Min (0.4 + Power * 0.05, 0.7);
		var random = new Random ();
		var result = (random.NextDouble () < winProbability);
		return result;
	}

	public IState Fight ()
	{
		var result = CalcuateFightResult ();

		return result 
			?  new StateBase(((int)(0.9 * Health)) >= 0 ?  ((int)(0.9 * Health)) : 0, MaxHealth, Power, Money + 5)
			:  new StateBase(Health - 40  >= 0 ? Health  - 40  : 0, MaxHealth, Power, Money);
		
	}

	public IState Heal ()
	{
		var healed = Health + 10;
		return new StateBase ( healed >= MaxHealth ? MaxHealth : healed, MaxHealth, Power, Money - 3);
	}

	bool NotEnoughMoneyFor (int itemPrice)
	{
		return Money - itemPrice < 0;
	}

	public IState BuyWeapon ()
	{
		if (NotEnoughMoneyFor (Game.Settings.WeaponPrice)) {

			return this;
		}
			
		var random = new Random ();
		var powerUp = random.Next (1,2);

		return new StateBase (Health, MaxHealth, Power + powerUp, Money - 10);
	}

	bool NotEnoughMoney ()
	{
		return Money - 10 < 0;
	}

	public IState BuyArmor ()
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

	public IEnumerable<IEquipment> Equipment {
		get;
		private set;
	}

	public bool IsTerminal {
		get {
			return this.Health <= 0;
		}

	}

	string PrintInventory ()
	{
		if (!Equipment.Any ())
			return "[]";

		var sb = new StringBuilder ();
		foreach (var item in Equipment) {
			sb.Append (item.Name);
		}

		return sb.ToString ();
	}

	public override string ToString ()
	{
		return string.Format (
@"[StateBase: 
 Health={0}, Power={1}, MaxHealth={2}, Money={3}, Equipment={4}, IsTerminal={5}
]"
		, Health
		, Power
		, MaxHealth
		, Money
		, PrintInventory()
		, IsTerminal);
	}

	#endregion


}
