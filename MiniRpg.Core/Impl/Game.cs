using System.Collections.Generic;
using System.Linq;


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
			this.States = new List<IState> () {};
		}

		#region IGame implementation

		public IList<IState> States { get; private set; }

		public IState State {
			get {
				return States.LastOrDefault();
			}
		}

		bool HasEnded {
			get {
				return State != null && State.IsTerminal;
			}

		}

		public void Run ()
		{
			while (!HasEnded) {
				var command = Accept ();
				var newState = command.Execute (State);
				States.Add (newState);
			}

		}

		#endregion

		public ISettings ReadSettings ()
		{
			return this.settingsProvider.Provide ();
		}

		public IGameCommand Accept() {
			return this.inputContoller.Read ();
		}
	}

}

