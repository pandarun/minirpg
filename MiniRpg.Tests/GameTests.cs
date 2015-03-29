using System;
using NUnit.Framework;
using MiniRpg.Core;
using NSubstitute;
using FluentAssertions;

namespace MiniRpg.Tests
{
	[TestFixture]
	public class GameTests
	{
		private Game gameUnderTest;


		[SetUp]
		public void SetUp() {
			var settingsProvider = Substitute.For<ISettingsProvider> ();
			var gameController = Substitute.For<IGameInputController> ();
			var outputControoler = Substitute.For<IGameOputputController> ();

			settingsProvider.Provide ().Returns (Mother.InMemorySettings);
			gameController.Read ().Returns (Mother.HealCommand);


			this.gameUnderTest = new Game (settingsProvider, gameController, outputControoler);
		}

		[Test]
		public void Game_CanReadSettigs() {
			var settings = this.gameUnderTest.ReadSettings ();
			settings.Should ().ShouldBeEquivalentTo (Mother.InMemorySettings);
		}

		[Test]
		public void Game_CanRun() {
			this.gameUnderTest.Run ();
		}

		[Test]	
		public void Game_CanAcceptUserInput(string input) {

			var command = this.gameUnderTest.Accept ();
			command.Execute (gameUnderTest.State);

		}



	}
}

