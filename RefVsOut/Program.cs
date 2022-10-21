// Section: 31 "differnece ref / out"


Program1 program = new Program1();

program.Show();


class Program1
{

    public async void Show()
    {
        // ref
        int number = 10;
        Console.WriteLine($"number is: {number}");
        AddOne(number);
        Console.WriteLine($"now is: {number}");
        AddOneByReference(ref number);
        Console.WriteLine($"now(after reference) is: {number}");

        // out
        var validInput = "35";
        var invalidInput = "aa";
        int result;
        bool wasParsingSuccesful1 = TryToParseToInt(validInput, out result);
        Console.WriteLine($"validInput: Is parsing OK: {result}");
        bool wasParsingSuccesful2 = TryToParseToInt(invalidInput, out result);
        Console.WriteLine($"invalidInput: Is parsing OK: {result}");
        Console.ReadLine();
    }

    // ref
    private static void AddOne(int a)
    {
        Console.WriteLine($"Calling AddOne function");
        ++a;
    }

    private static void AddOneByReference(ref int a)
    {
        Console.WriteLine($"Calling AddOne by reference function");
        ++a;
    }

    private static bool TryToParseToInt(string input, out int result)
    {
        try
        {
            result = int.Parse(input);
            return true;
        }
        catch
        {
            result = 0;
            return false;
        }
    }


}
