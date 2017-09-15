namespace Log4NetTest
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            LoggingConfigurator.ConfigureLogging();
            //log4net.Config.XmlConfigurator.Configure();

            log.Debug("log Debug");
            log.Info("log Info");
            log.Warn("log Warn");
            log.Error("log Error");
            log.Fatal("log Fatal");
            log.Error("Error", new System.Exception());

            Console.Write("Logs realizados!");

            Console.ReadKey();
        }
    }
}
