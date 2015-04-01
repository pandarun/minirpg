using System;

namespace MiniRpg
{
    using MiniRpg.Core.IFaces;

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
