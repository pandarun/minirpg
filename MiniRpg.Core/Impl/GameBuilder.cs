namespace MiniRpg.Core.Impl
{
    using MiniRpg.Core;
    using MiniRpg.Core.IFaces;

    public class GameBuilder
	{
		private ISettingsProvider settingsProvider;
		private IGameInputController inputController;
		private IGameOputputController gameOutputController;

		public GameBuilder WithAppConfigSettings(){

			this.settingsProvider = new AppConfigSettingsProvider();
			return this;
		}

		public GameBuilder WithConsoleInput(){
			this.inputController = new ConsoleGameInputController();
			return this;
		}

		public GameBuilder WithConsoleOuput(){
			this.gameOutputController = new ConsoleGameOutputController();
			return this;
		}

		public Game Build(){
			return new Game (this.settingsProvider, this.inputController, this.gameOutputController);
		}
	}

}
