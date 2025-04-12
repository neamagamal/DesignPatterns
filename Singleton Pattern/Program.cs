namespace Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            Console.WriteLine(object.ReferenceEquals(logger1, logger2));
        }
    }
}
