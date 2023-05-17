using NLog;

class Program
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    static void Main()
    {
        var config = new NLog.Config.XmlLoggingConfiguration("NLog.config");
        NLog.LogManager.Configuration = config;
        
        Console.WriteLine(string.Join(", ", config.AllTargets));

        Logger.Trace("Это проверочный лог");
        LogManager.Flush();
        LogManager.Shutdown();
    }
}