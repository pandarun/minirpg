using MiniRpg.Core;

namespace MiniRpg
{
	class NullCommand : IGameCommand
	{


		public IState Execute (IState current)
		{
			return current;
		}
	}



}
