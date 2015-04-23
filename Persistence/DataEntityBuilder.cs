using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace MMS.Persistence
{
    public static class DataEntityBuilder
    {
        public static MMSEntities BuildMmsEntities(String connectString)
        {
            return new MMSEntities(connectString);
        }

        public static MMSEntities BuildMmsEntities()
        {
            var configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = "Config\\Persistence.config";
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            return BuildMmsEntities(config.ConnectionStrings.ConnectionStrings["MMSEntities"].ConnectionString);
        }

    }
}
