using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using log4net;
using log4net.Core;

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
