namespace Singleton_Pattern;
public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {

                    _instance = new Logger();

                }
            }
            return _instance;
        }
    }
    private Logger()
    {
        Console.WriteLine("logger");
    }
    public void Log(string message)
    {
        Console.WriteLine($"{message}");
    }
}
