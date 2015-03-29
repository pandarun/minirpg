using MiniRpg.Core;

namespace MiniRpg
{
	public class GameBuilder
	{
		private ISettingsProvider settingsProvider;
		private IGameInputController inputController;

		public GameBuilder WithAppConfigSettings(){

			this.settingsProvider = new AppConfigSettingsProvider();
			return this;
		}

		public GameBuilder WithConsoleInput(){
			this.inputController = new ConsoleGameInputController();
			return this;
		}

		public Game Build(){
			return new Game (this.settingsProvider, this.inputController);
		}
	}

}
