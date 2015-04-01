namespace MiniRpg.Core.Impl
{
    using System.Collections.Generic;
    using System.Linq;

    using MiniRpg.Core.IFaces;

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

		    lock (this.syncObj)
		    {
                if (Game.Settings == null)
                {
                    Game.Settings = this._settingsProvider.Provide();
                }    
		    }

			var defaultState = new StateBase (Game.Settings.Health, Game.Settings.MaxHealth, Game.Settings.Power, Game.Settings.Money);
			this.States.Add(defaultState);

		}


		#region IGame implementation

		public IList<IState> States { get; private set; }

		public IState State {
			get {
				return this.States.LastOrDefault();
			}
		}

		bool HasEnded {
			get {
				return this.State != null && this.State.IsTerminal;
			}

		}

		public void Run ()
		{
			
			while (!this.HasEnded) {		
				this.Render (Messages.AskForInput);
				var command = this.Accept ();
				var newState = command.Execute (this.State);
				this.States.Add (newState);
				this.Render ();

                if(this.State.IsTerminal)
                    this.Render(Messages.YouLoose);
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
			var message = this.State != null ? this.State.ToString() : string.Empty;
			this._outputController.Write(message);
		}

		void Render(string message)
		{
			this._outputController.Write (message);
		}
	}

}

