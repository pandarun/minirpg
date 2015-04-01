namespace MiniRpg.Core.Impl.Commands
{
    using MiniRpg.Core.IFaces;

    public class BuyWeaponCommand : IGameCommand
	{
		#region IGameCommand implementation
		public IState Execute (IState cur)
		{
			return cur.BuyWeapon ();
		}
		#endregion
	}



}
