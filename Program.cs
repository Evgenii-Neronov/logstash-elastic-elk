using NLog;

class Program
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    static void Main()
    {
        Console.WriteLine(string.Join(", ", LogManager.Configuration.AllTargets));
        Logger.Trace("2222222");
        LogManager.Flush();
        LogManager.Shutdown();
    }
}