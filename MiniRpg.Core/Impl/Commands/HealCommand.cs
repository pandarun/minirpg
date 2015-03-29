using MiniRpg.Core;


namespace MiniRpg.Tests
{
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

