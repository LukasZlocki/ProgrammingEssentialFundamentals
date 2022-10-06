

var test = new Test();

// not able tor each static field
//var staticInt = test.maxCount;
// reach can be done only by using class name 
var staticInt = Test.maxCount;

// static class
var sum = Calculator.Add(1, 2);


class Test
{
    public static int maxCount = 50;
    private List<int> _elements = new List<int>();

    public int GetCurrentCount()
    {
        return _elements.Count;
    }

    // returns only static valuse of static field
    public static int GeMaxCount()
    {
        return maxCount;
    }

}


// static class works as container for static methods
static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

// static class with static constructor
static class TimeMonitor
{
    private static readonly DateTime _startTime;

    //ctor
    static TimeMonitor()
    {
        _startTime = DateTime.Now;
    }

    public static string Report()
    {
        return $"Monitored time at {_startTime}";
    }
}