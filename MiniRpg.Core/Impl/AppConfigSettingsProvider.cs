using MiniRpg.Core;
using System.Configuration;

namespace MiniRpg
{
	public class AppConfigSettingsProvider : ISettingsProvider
	{
		#region ISettingsProvider implementation
		public ISettings Provide ()
		{

			GameSettingsSection config =
				(GameSettingsSection)System.Configuration.ConfigurationManager.GetSection(
					"miniRpgSettingsSectionGroup/gameSettings");

			return new Settings(config.Health, config.Money, config.Power);

		}
		#endregion
	}


}
