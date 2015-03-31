using System;
using MiniRpg.Core;

namespace MiniRpg
{
	public class ConsoleGameOutputController : IGameOputputController
	{
		#region IGameOputputController implementation
		public void Write (string message)
		{
			Console.WriteLine(message);
		}
		#endregion
	}


}
