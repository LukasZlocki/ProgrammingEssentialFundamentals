static void AddOne(int number)
{
    ++number;
}

static void AddOneToList(List<int> list)
{
    list.Add(1);
}

int a = 5;
Console.WriteLine($"number is {a}");
AddOne(a);
Console.WriteLine($"NOW number is {a}");

var list = new List<int>();
Console.WriteLine($"list contains {list.Count} elements");
AddOneToList(list);
Console.WriteLine($"NOW list contains {list.Count} elements");

// Values Types
int b = 10;
int c = b;
++c;
Console.WriteLine($"number b is {b}");
Console.WriteLine($"number c is {c}");

// Reference types
var listA = new List<int> { 1, 2, 3, 4};
var listB = listA;
listB.Add(10);
Console.WriteLine($"ListaA contains {listA.Count} elements");
Console.WriteLine($"ListaB contains {listB.Count} elements");

Console.ReadKey();