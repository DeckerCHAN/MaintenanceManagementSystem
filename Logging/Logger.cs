using System;
using System.Diagnostics;
using log4net;
using log4net.Config;

namespace MMS.Logging
{
    public static class Logger
    {
        public static ILog GetLogger()
        {
            return LogManager.GetLogger(new StackTrace().GetFrame(1).GetMethod().ReflectedType);
        }
    }
}