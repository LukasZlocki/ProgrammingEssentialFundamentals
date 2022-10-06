

static string Greet(string name)
{
    if (name == null)
    {
        return "Hello, stranger";
    }
    return $"Hello {name}";
}

// Coalescing operator
static string Greet2(string name)
{
    return $"Hello {name ?? "stranger"}";
}


Console.WriteLine(Greet2("Adam"));
Console.WriteLine(Greet2(null));
Console.ReadLine();


// Null Coalescing assigment
private static List<int> _numbers;
static void AddToNumbers(int number)
{
    //if(number == null)
    //{
    //    _numbers = new List<int>();
    //}
    //_numbers.Add(number);
    (_numbers ??= new List<int>()).Add(number);
}