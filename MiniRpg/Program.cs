using System;
using MiniRpg.Core;

namespace MiniRpg
{
	class Pogram
	{
		public static void Main (string[] args)
		{

			var game = new GameBuilder ()
				.WithConsoleInput ()
				.WithAppConfigSettings ()
				.WithConsoleOuput ()
				.Build();

			game.Init ();
			game.Run ();

			Console.WriteLine ("Press Enter to Exit");
			Console.ReadKey ();			
		}
	}
}
