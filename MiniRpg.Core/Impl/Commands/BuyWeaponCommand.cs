using System;
using MiniRpg.Core;

namespace MiniRpg
{
	public class BuyWeaponCommand : IGameCommand
	{
		#region IGameCommand implementation
		public IState Execute (IState cur)
		{
			return cur.BuyWeapon ();
		}
		#endregion
	}



}
