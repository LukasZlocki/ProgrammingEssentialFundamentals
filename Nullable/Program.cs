// nullable

//int Height = null // <--error
int? height = null;
Nullable<int> height2 = null;

if (height.HasValue)
{
    Console.WriteLine($"Height is {height.Value}");
}
else
{
    Console.WriteLine("Height is null");
}

int number = height.Value;

Console.ReadLine();