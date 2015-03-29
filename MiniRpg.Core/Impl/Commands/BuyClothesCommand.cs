using System;
using MiniRpg.Core;

namespace MiniRpg
{
	public class BuyClothesCommand : IGameCommand
	{
		#region IGameCommand implementation
		public IState Execute (IState cur)
		{
			return cur.BuyArmor ();
		}
		#endregion
	}



}
