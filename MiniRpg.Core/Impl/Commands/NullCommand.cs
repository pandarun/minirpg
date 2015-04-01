namespace MiniRpg.Core.Impl.Commands
{
    using MiniRpg.Core.IFaces;

    class NullCommand : IGameCommand
	{

		public IState Execute (IState current)
		{
			return current;
		}
	}



}
