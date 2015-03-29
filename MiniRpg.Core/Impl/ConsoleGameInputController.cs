using System;
using MiniRpg.Core;
using MiniRpg.Tests;

namespace MiniRpg
{
	public class ConsoleGameInputController : IGameInputController
	{
		#region IGameInputController implementation
		public IGameCommand Read ()
		{
			var input = Console.ReadLine ();
			switch (input) {
			case "W" : 
				return new AttackCommand();
			case "A" : 
				return new BuyWeaponCommand();
			case "D" : 
				return new BuyClothesCommand();
			case "S" : 
				return new HealCommand();
			case "E" : 
				return new AskForHelp();
			default:	
				return new NullCommand ();
			}

		}
		#endregion
	}


}
