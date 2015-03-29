using System;
using MiniRpg.Core;

namespace MiniRpg
{
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
