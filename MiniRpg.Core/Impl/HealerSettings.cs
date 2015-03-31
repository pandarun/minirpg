using MiniRpg.Core;
using System.Configuration;

namespace MiniRpg
{
	public class HealerSettings
	{
		public HealerSettings (HealerElement healerSettings)
		{
			HealPrice = healerSettings.HealPrice;
			Healup = healerSettings.HealUp;
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
