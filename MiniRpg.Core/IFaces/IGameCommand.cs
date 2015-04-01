namespace MiniRpg.Core.IFaces
{
	public interface IGameCommand
	{
		IState Execute(IState current);
	}


	
}

