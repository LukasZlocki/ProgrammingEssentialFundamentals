/*
static int? Divide(int a, int b)
{
    try
    {
        return a / b;
    }
    catch(DivideByZeroException)
    {
        Console.WriteLine("No dividing by zero!");
        return null;
    }
    finally
    {
        Console.WriteLine("Executing finally block");
    }
}
*/
static int? Divide(int a, int b)
{
    try
    {
        return a / b;
    }
    catch 
    {
        Console.WriteLine("Sth went wrong but i do not know what.");
        return null;
    }
    finally
    {
        Console.WriteLine("Executing finally block");
    }
}


Divide(5, 0);

Console.ReadLine();
