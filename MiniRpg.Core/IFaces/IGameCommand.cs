namespace MiniRpg.Core
{
	public interface IGameCommand
	{
		IState Execute(IState current);
	}


	
}

