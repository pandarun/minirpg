namespace MiniRpg.Core.Impl.Commands
{
    using MiniRpg.Core.IFaces;

    public class AttackCommand : IGameCommand
	{

		#region IGameCommand implementation

		public IState Execute (IState cur)
		{
			return cur.Fight ();
		}
		#endregion
	}



}
