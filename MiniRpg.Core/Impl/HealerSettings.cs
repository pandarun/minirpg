namespace MiniRpg.Core.Impl
{
    using MiniRpg.Core.Impl.ConfigElements;

    public class HealerSettings
	{
		public HealerSettings (HealerElement healerSettings)
		{
			this.HealPrice = healerSettings.HealPrice;
			this.Healup = healerSettings.HealUp;
		}

		public int HealPrice {
			get;
			private set;
		}
		public int Healup {
			get;
			private set;
		}
	}



}
