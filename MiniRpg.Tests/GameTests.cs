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

			settingsProvider.Provide ().Returns (Mother.InMemorySettings);
			gameController.Read (Arg.Any<string>()).Returns (Mother.HealCommand);
			this.gameUnderTest = new Game (settingsProvider, gameController);
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

			this.gameUnderTest.Accept (input);
		}



	}
}

