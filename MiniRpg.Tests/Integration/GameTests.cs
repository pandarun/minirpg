﻿using FluentAssertions;
using MiniRpg.Core;
using NUnit.Framework;

namespace MiniRpg.Tests.Integration
{
    using MiniRpg.Core.Impl;

    [TestFixture]
	public class GameTests
	{
		private Game gameUnderTest;


		[SetUp]
		public void SetUp() {

			var game = new GameBuilder ()
				.WithAppConfigSettings ()
				.WithConsoleInput ()
				.WithConsoleOuput ()
				.Build();

			game.Init ();

			this.gameUnderTest = game;
		}

		[TestCase(85)]
		[TestCase(90)]
		[TestCase(100)]
		public void CanHeal(int health){
			var init = this.gameUnderTest.State;
			var current = new StateBase (health, init.MaxHealth, init.Power, init.Money);
			this.gameUnderTest.States.Add(current);

			var actual = this.gameUnderTest.State.Heal ();

			actual.Health.Should ().BeLessOrEqualTo (current.MaxHealth);
			actual.Health.Should ().BeGreaterOrEqualTo (current.Health);
			actual.Health.Should ().BeInRange (current.Health, current.Health + Game.Settings.HealUp);
		}

		[Test]
		public void CanWinFight()
		{
			var init = this.gameUnderTest.State;
			var expectedHealth = (1 - Game.Settings.HealthPenltyScale) * init.Health;
			var expectedMoney = init.Money + Game.Settings.MoneyUp;
			var current = new TestableState (true, init.Health, init.MaxHealth, init.Power, init.Money);
			this.gameUnderTest.States.Add(current);


			var actualState = this.gameUnderTest.State.Fight ();

			actualState.Health.Should ().Be ((int)expectedHealth);
			actualState.Money.Should ().Be (expectedMoney);
		}

		[Test]
		public void CanLooseFight() {
			var init = this.gameUnderTest.State;
			var expecteHealth = init.Health - Game.Settings.HealthPenalty;
			var current = new TestableState (false, init.Health, init.MaxHealth, init.Power, init.Money);
			this.gameUnderTest.States.Add(current);

			var actual = this.gameUnderTest.State.Fight ();

			actual.Health.Should ().Be (expecteHealth);
		}

		[Test]
		public void CanBuyArmor() {
			var currentMaxHealth = this.gameUnderTest.State.MaxHealth;

			var actual = this.gameUnderTest.State.BuyArmor ();

			actual.MaxHealth
                .Should ()
                .BeInRange (currentMaxHealth + Game.Settings.ClothesMaxHealthUpFrom, currentMaxHealth + Game.Settings.ClothesMaxHealthUpTo);

		}

		[TestCase(10, 1)]
		public void CanBuyWeapon(int money, int power) {

			var init = this.gameUnderTest.State;
			var current = new StateBase (init.Health, init.MaxHealth, power, money);
			var currentPower = current.Power;
			var currentMoney = current.Money;
			this.gameUnderTest.States.Add(current);

			var actual = this.gameUnderTest.State.BuyWeapon ();

			actual.Power.Should ().BeInRange (currentPower + Game.Settings.WeaponPowerUpFrom, currentPower + Game.Settings.WeaponPowerUpTo);
			actual.Money.Should ().Be (currentMoney - Game.Settings.WeaponPrice);
		}




	}
}

