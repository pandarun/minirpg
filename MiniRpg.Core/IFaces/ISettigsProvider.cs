namespace MiniRpg.Core
{
	public interface ISettingsProvider
	{
		ISettings Provide();
	}

	public interface IGameInputController {
		IGameCommand Read();
	}

	public interface IGameOputputController {
		void Write(string message);
	}
}

