using MiniRpg.Core;

namespace MiniRpg.Tests
{
	public static class Mother
	{
		public static IGameCommand HealCommand {
			get { 
				return new HealCommand ();
			}

		}
	}

}

