// Generics


var currencies = new Dictionary<string, string>
{
    ["USA"] = "USD",
    ["Great Britain"] = "GBP"
};



// List of Types
class List<T>
{
    public void Add(T item)
    {
        // ...
    }
}



/*
// Solution without Generics
class IntegersList
{
    public void Add(int item)
    {
         // ...
    }
}
class DoublesList
{
    public void Add(double item)
    {
        // ...
    }
}
class StringsList
{
    public void Add(string item)
    {
        // ...
    }
}
*/