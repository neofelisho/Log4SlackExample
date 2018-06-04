using System;
using log4net;
using log4net.Config;

namespace Log4SlackExample
{
    internal class Program
    {
        private static readonly Lazy<ILog> LazyLog = new Lazy<ILog>(() =>
        {
            var log = LogManager.GetLogger(typeof(Program));
            XmlConfigurator.Configure();
            return log;
        });

        private static ILog Logger => LazyLog.Value;

        private static void Main()
        {
            Console.WriteLine("Enter the message you want to send to slack...");
            var msg = Console.ReadLine();
            Logger.Info(msg);

            Console.Read();
        }
    }
}