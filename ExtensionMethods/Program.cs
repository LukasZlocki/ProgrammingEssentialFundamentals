
var multilineString = @"ASDLFJALKSDFLLKJLKSDJF,
                        SDJFLKJSDLKFJASDLKJFLASDJ,
                        KLJSDLKJFLSDLFJSDFLSDJFLSDJF,
                        KJSDLKAFJLASJDFLJASDFASDFSDF,
                        KLKJLSDFJLKSJDFOOOOOOOOOOOOO.";

// extension method usage
var numberOfLines = multilineString.GetNumberOfLines(); // <--- ! 
Console.WriteLine($"number of lines is {numberOfLines}");
Console.ReadLine();


//public static class StringOperations
//{
//    public static int GetNumberOfLines(string input)
//    {
//        return input.Split("\n").Length;
//    }
//}


// extension : static clas, static methos, this keyword
public static class StringExtensions
{
    public static int GetNumberOfLines(this string input)
    {
        return input.Split("\n").Length;
    }
}