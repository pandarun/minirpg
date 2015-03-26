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

		public static ISettings InMemorySettings {
			get { 
				return new Settings (100, 10, 1);
			}
		}
	}

}

