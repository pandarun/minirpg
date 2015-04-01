namespace MiniRpg.Core.Impl
{
    using MiniRpg.Core;
    using MiniRpg.Core.IFaces;
    using MiniRpg.Core.Impl.ConfigElements;

    public class AppConfigSettingsProvider : ISettingsProvider
	{
		#region ISettingsProvider implementation
		public ISettings Provide ()
		{

			var config =
				(GameSettingsSection)System.Configuration.ConfigurationManager.GetSection(
					"miniRpgSettingsSectionGroup/gameSettings");

			var playerSettings = new PlayerSettings (config.Health, config.Money, config.Power, config.MaxHealth);

			var fightSettings = new FightSettings (config.FightSettings);
			var shopSettins = new ShopSettings (config.ShopSettings);
			var healSettings = new HealerSettings (config.HealerSettings);

			return new Settings(playerSettings, fightSettings, shopSettins, healSettings);

		}
		#endregion
	}


}
