
namespace MiniRpg.Tests
{
	public class TestableState : StateBase
	{
		public TestableState (bool shouldWin, int health, int maxHealth, int power, int money) 
			: base(health ,maxHealth, power, money)
		{
			this.ShouldWin = shouldWin;
		}

		public bool ShouldWin {
			get;
			private set;
		}

		protected override bool CalcuateFightResult ()
		{
			return ShouldWin;
		}
	}
}

