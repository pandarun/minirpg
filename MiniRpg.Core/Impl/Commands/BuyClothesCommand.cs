namespace MiniRpg.Core.Impl.Commands
{
    using MiniRpg.Core.IFaces;

    public class BuyClothesCommand : IGameCommand
	{
		#region IGameCommand implementation
		public IState Execute (IState cur)
		{
			return cur.BuyArmor ();
		}
		#endregion
	}



}
