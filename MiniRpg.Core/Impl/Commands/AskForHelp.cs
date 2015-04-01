namespace MiniRpg.Core.Impl.Commands
{
    using MiniRpg.Core.IFaces;

    public class AskForHelp : IGameCommand
	{
		#region IGameCommand implementation

		public IState Execute (IState cur)
		{
            // TODO : implement bot
			return cur;
		}
		#endregion
	}



}
