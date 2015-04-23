using System;
using System.Configuration;

namespace MMS.Persistence
{
    public class DBStorage
    {
        #region instance
        private static DBStorage Instance;

        public static DBStorage GetDbStorage()
        {
            return Instance ?? (Instance = new DBStorage());
        }
        #endregion

        private KeyValueConfigurationCollection Config;
        private String ConnectingString;
        private DBStorage()
        {
            this.Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings;
            this.ConnectingString = this.Config["DbConnectingString"].Value;
        }
    }
}