using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = MMS.Logging.Logger.GetLogger();
            logger.Info("Hello!");
            logger.Warn("Hello!");
            logger.Error("Hello!");
            Console.WriteLine(ConfigurationManager.AppSettings["countoffiles"]);
            Console.ReadKey();
        }
    }
}
