using MiniRpg.Core;
namespace MiniRpg
{
	public class FightSettings
	{
		public FightSettings (FightElement fightSection)
		{
			BaseChance = fightSection.WinChance.BaseChance;
			MaxChance = fightSection.WinChance.MaxChance;
			PowerScale = fightSection.WinChance.PowerScale;
			HealthPenltyScale = fightSection.Win.HealthPenaltyScale;
			MoneyUp = fightSection.Win.MoneyUp;
			HealthPenalty = fightSection.Loose.HealthPenalty;
		}

		public double BaseChance {
			get;
			private set;
		}

		public double MaxChance {
			get;
			private set;
		}

		public double PowerScale {
			get;
			private set;
		}

		public double HealthPenltyScale {
			get;
			private set;
		}

		public int MoneyUp {
			get;
			private set;
		}

		public int HealthPenalty {
			get;
			private set;
		}
	}




}
