namespace MiniRpg.Core
{
	public interface ISettingsProvider
	{
		ISettings Provide();
	}

	public interface IGameInputController {
		IGameCommand Read();
	}
}

