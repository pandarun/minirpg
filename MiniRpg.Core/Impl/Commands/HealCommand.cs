using MiniRpg.Core;


namespace MiniRpg.Tests
{
    using MiniRpg.Core.IFaces;

    public class HealCommand : IGameCommand
	{
		#region IGameCommand implementation
		public IState Execute (IState cur)
		{
			return cur.Heal ();
		}
		#endregion
	}


}

