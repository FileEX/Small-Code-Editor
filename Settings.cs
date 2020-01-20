/*
 * Created by SharpDevelop.
 * User: alkom
 * Date: 10.06.2019
 * Time: 15:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;

namespace MTA_Code_Editor
{
	public class Settings
	{
		public Settings()
		{
		}
		
		public void setSettingValue(string setting, string nValue)
		{
			Configuration cfgManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			KeyValueConfigurationCollection cfgColl = cfgManager.AppSettings.Settings;
			
			cfgColl[setting].Value = nValue;
			cfgManager.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection(cfgManager.AppSettings.SectionInformation.Name);
		}
		
		public string getSettingValue(string setting)
		{
			return (string)ConfigurationManager.AppSettings.Get(setting);
		}
	}
}
