using System;

namespace MiniRpg.Core
{
	public class Game : IGame
	{
		ISettingsProvider settingsProvider;

		IGameInputController inputContoller;

		public Game (ISettingsProvider settings, IGameInputController inputContoller)
		{
			this.inputContoller = inputContoller;
			this.settingsProvider = settings;
		}

		#region IGame implementation

		public void Run ()
		{
			throw new NotImplementedException ();
		}

		#endregion

		public ISettings ReadSettings ()
		{
			return this.settingsProvider.Provide ();
		}

		public void Accept(string input) {
			var command = this.inputContoller.Read (input);

		}
	}

}

