namespace MiniRpg.Tests.Helpes
{
    using MiniRpg.Core.IFaces;

    public static class Mother
	{
		public static IGameCommand HealCommand {
			get { 
				return new HealCommand ();
			}

		}
	}

}

