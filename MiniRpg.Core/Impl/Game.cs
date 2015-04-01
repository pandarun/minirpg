using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;


namespace MiniRpg.Core
{
	public class Game : IGame
	{
		public static ISettings Settings {
			get;
			private set;
		}

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

	    private readonly object syncObj = new object();



		public void Init() {

			this.States.Clear();

		    lock (syncObj)
		    {
                if (Game.Settings == null)
                {
                    Game.Settings = _settingsProvider.Provide();
                }    
		    }

			var defaultState = new StateBase (Game.Settings.Health, Game.Settings.MaxHealth, Game.Settings.Power, Game.Settings.Money);
			this.States.Add(defaultState);

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

