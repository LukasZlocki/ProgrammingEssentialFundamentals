// Section 41 "Singleton"

public sealed class Singleton
{
    private static Singleton instance = null;
    public string Id { get;} // Only for presentaion purpose

    private Singleton()
    {
        Id = Guid.NewGuid().ToString();
    }

    public static Singleton Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}