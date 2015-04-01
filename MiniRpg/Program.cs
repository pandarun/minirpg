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

		    while (true)
		    {
		        game.Init ();
			    game.Run ();    
		    }
			
		}
	}
}
