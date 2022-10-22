// Section 34 "Overloading methods"

Console.WriteLine("ints 2x: " + Mathem.Add(1, 1));

Console.WriteLine("strings: " + Mathem.Add("Joe", " is me"));
Console.WriteLine("ints 3x: " + Mathem.Add(1, 1, 4));

class Mathem
{
    public static int Add (int a, int b)
    {
        return a + b;
    }

    public static string Add (string a, string b)
    {
        return a + b;
    }

    public static int Add (int a, int b, int c)
    {
        return (a + b) + c;
    }
}