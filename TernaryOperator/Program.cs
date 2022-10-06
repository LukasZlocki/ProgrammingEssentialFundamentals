
int dog = 18;
string size;

/*
if (dog > 25)
{
    size = "big";
}
else if (dog < 5)
{
    size = "small";
}
else
{
    size = "medium";
}
*/

//ternary
//size = dog > 25 ? "big" : "small"; 

// nested ternary in ternary
size = dog > 25 ? "big" : (dog < 5 ? "small" : "medium");

string comment = dog > 50 ? "This is huge dog" : "standard dog"; 

Console.WriteLine($"The dog is {size}");
Console.WriteLine($"{comment}");
Console.ReadKey();