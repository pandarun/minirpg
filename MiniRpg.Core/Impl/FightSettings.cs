namespace MiniRpg.Core.Impl
{
    using MiniRpg.Core.Impl.ConfigElements;

    public class FightSettings
	{
		public FightSettings (FightElement fightSection)
		{
			this.BaseChance = fightSection.WinChance.BaseChance;
			this.MaxChance = fightSection.WinChance.MaxChance;
			this.PowerScale = fightSection.WinChance.PowerScale;
			this.HealthPenltyScale = fightSection.Win.HealthPenaltyScale;
			this.MoneyUp = fightSection.Win.MoneyUp;
			this.HealthPenalty = fightSection.Loose.HealthPenalty;
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
