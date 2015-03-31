using System;
using MiniRpg.Core;
using MiniRpg.Tests;

namespace MiniRpg
{
	public class AskForHelp : IGameCommand
	{
		#region IGameCommand implementation

		public IState Execute (IState cur)
		{
			return cur;
		}
		#endregion
	}



}
