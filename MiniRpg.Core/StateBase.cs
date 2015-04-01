using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniRpg.Core
{
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
            var winProbability = Math.Min (Game.Settings.BaseChance + this.Power * Game.Settings.PowerScale, Game.Settings.MaxChance);
            var random = new Random ();
            var result = (random.NextDouble () < winProbability);
            return result;
        }

        public IState Fight ()
        {
            var result = this.CalcuateFightResult ();

            var healthMutator = result
                ? (() => ((int)((1- Game.Settings.HealthPenltyScale) * this.Health)))
                : new Func<int>(() => this.Health - Game.Settings.HealthPenalty);

            var moneyMutator = result 
                ? () => this.Money + Game.Settings.MoneyUp 
                : new Func<int>(()=> this.Money) ;

            return new StateBase(healthMutator() >= 0 ? healthMutator() : 0, this.MaxHealth, this.Power, moneyMutator());

        }

        public IState Heal ()
        {
            if (this.NotEnoughMoneyFor(Game.Settings.HealPrice))
            {

                return this;
            }

            var healed = this.Health + Game.Settings.HealUp;
            return new StateBase ( healed >= this.MaxHealth ? this.MaxHealth : healed, this.MaxHealth, this.Power, this.Money - Game.Settings.HealPrice);
        }

        bool NotEnoughMoneyFor (int itemPrice)
        {
            return this.Money - itemPrice < 0;
        }

        public IState BuyWeapon ()
        {
            if (this.NotEnoughMoneyFor (Game.Settings.WeaponPrice)) {

                return this;
            }
			
            var random = new Random ();
            var powerUp = random.Next(Game.Settings.WeaponPowerUpFrom, Game.Settings.WeaponPowerUpTo);

            return new StateBase (this.Health, this.MaxHealth, this.Power + powerUp, this.Money - Game.Settings.WeaponPrice);
        }

        public IState BuyArmor ()
        {
            var random = new Random ();
            var healthCapacityUp = random.Next (Game.Settings.ClothesMaxHealthUpFrom, Game.Settings.ClothesMaxHealthUpTo);
            return new StateBase (this.Health, this.MaxHealth + healthCapacityUp, this.Power, this.Money);
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
            if (!this.Equipment.Any ())
                return "[]";

            var sb = new StringBuilder ();
            foreach (var item in this.Equipment) {
                sb.Append (item.Name);
            }

            return sb.ToString ();
        }

        public override string ToString ()
        {
            return string.Format (
@"
[ 
 Health={0}, MaxHealth={2}, Power={1}, Money={3}, IsTerminal={4}
]"
                , this.Health
                , this.Power
                , this.MaxHealth
                , this.Money
                , this.IsTerminal);
        }

        #endregion


    }
}
