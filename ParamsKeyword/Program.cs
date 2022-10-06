
/*
static int Sum(int[] numbers)
{
    var sum = 0;
    foreach(var number in numbers)
    {
        sum += number;
    }
    return sum;
}


// This run of Sum method takes resources
Sum(new int[] { 1, 2, 3, 4 });
Sum(new int[] { 1,2 });
Sum(new int[] { 6 });
*/


// Better solution with params:

static int Sum(params int[] numbers)
{
    var sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }
    return sum;
}

Sum(1, 2, 3, 4 );
Sum(1, 2 );
Sum( 6 );
Console.ReadKey();

// Important hint to params :
// Error params must be the last parameter of the function
//static void SomeFunction(params int[], int a, int b)