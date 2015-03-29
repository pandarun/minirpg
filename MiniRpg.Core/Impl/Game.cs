using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;


namespace MiniRpg.Core
{
	public class Game : IGame
	{
		ISettingsProvider _settingsProvider;

		IGameInputController _inputContoller;

		IGameOputputController _outputController;

		public bool IsInitialized {
			get;
			private set;
		}

		public Game (ISettingsProvider settings, IGameInputController inputContoller, IGameOputputController outputController)
		{
			this._inputContoller = inputContoller;
			this._settingsProvider = settings;
			this._outputController = outputController;
			this.States = new List<IState> (){};
		}

		public void Init() {
			if (IsInitialized) return;
			var settings = _settingsProvider.Provide ();
			var defaultState = new StateBase (settings.Health, settings.MaxHealth, settings.Power, settings.Money);
			this.States.Add(defaultState);
			IsInitialized = true;
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
				Render (Messages.AskForInput);
				var command = Accept ();
				var newState = command.Execute (State);
				States.Add (newState);
				Render ();
			}

		}

		#endregion

		public ISettings ReadSettings ()
		{
			return this._settingsProvider.Provide ();
		}

		public IGameCommand Accept() {
			return this._inputContoller.Read ();
		}

		void Render ()
		{
			var message = State != null ? State.ToString() : string.Empty;
			_outputController.Write(message);
		}

		void Render(string message)
		{
			_outputController.Write (message);
		}
	}

}

