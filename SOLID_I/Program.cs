/* Section: 49 "SOLID - I - Interface Segregation Principle (ISP)"
*/




// Example 2 - solution
// we are creating additional interface for chargable bikes

public interface IChargable
{
    void Charge();
}

public interface IBike
{
    void Ride();
    void InflateTheTyre();
    // void Charge(); // this method is added, problem in standard bike class because charging implementation need to be covered (but it is a classic bike) 
}

// electric bike class is added
public class ElectricBIke : IBike, IChargable
{
    public void Charge()
    {
        Console.WriteLine("Charging battery of electric bike.");
    }

    public void InflateTheTyre()
    {
        Console.WriteLine("Use pump to inflate the tyre.");
    }

    public void Ride()
    {
        Console.WriteLine("Use your muscke ti move forward.");
    }
}

public class BIke : IBike
{
    public void InflateTheTyre()
    {
        Console.WriteLine("Use pump to inflate the tyre.");
    }

    public void Ride()
    {
        Console.WriteLine("Use your muscke ti move forward.");
    }
}





/*
// Example 2 - problem

public interface IBike{
    void Ride();
    void InflateTheTyre();
    void Charge(); // this method is added, problem in standard bike class because charging implementation need to be covered (but it is a classic bike) 
}

// electric bike class is added
public class ElectricBIke : IBike
{
    public void Charge()
    {
        Console.WriteLine("Charging battery of electric bike.");
    }

    public void InflateTheTyre()
    {
        Console.WriteLine("Use pump to inflate the tyre.");
    }

    public void Ride()
    {
        Console.WriteLine("Use your muscke ti move forward.");
    }
}

public class BIke : IBike
{
    public void Charge()
    {
        throw new NotSupportedException("This is non-electric bike");
    }

    public void InflateTheTyre()
    {
        Console.WriteLine("Use pump to inflate the tyre.");
    }

    public void Ride()
    {
        Console.WriteLine("Use your muscke ti move forward.");
    }
}

*/



/*
// Example 1
var list = new List<int>();
var array = new int[0];

AddToList(list);
AddToList(array); /// arra

Console.Read();


static void AddToList(List<int> list){
    list.Add(1);
}

*/

