namespace MiniRpg.Core.Impl
{
    using System;

    using MiniRpg.Core.IFaces;
    using MiniRpg.Core.Impl.Commands;
    using MiniRpg.Tests;

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
