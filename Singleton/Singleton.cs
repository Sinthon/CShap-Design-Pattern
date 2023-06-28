namespace Creational_Design_Pattern.Singleton;

public class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();

    private Singleton()
    {
        // Private constructor to prevent direct instantiation
    }

    public string MyProperty { get; set; } = string.Empty;

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
        }
        return instance;
    }
}
