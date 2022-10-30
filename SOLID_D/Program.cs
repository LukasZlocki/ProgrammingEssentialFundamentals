/* Section: 50 "SOLID - D - Interface Segregation Principle (ISP)"
*/


// Example - refactoring to meets dependency inversion pronciple
class YourStore
{
    private readonly IDelivery _delivery;

    public YourStore(IDelivery delivery)
    {
        _delivery = delivery;
    }

    public void SellItem(string item, string address)
    {
        var package = PreparePackage(item, address);
        _delivery.DeliverPackage(package);
    }

    private string PreparePackage(string item, string address)
    {
        return "package reaty to be shipped";
    }

}

public interface IDelivery
{
    void DeliverPackage(string package);
}

internal class FastWheelsDelivery : IDelivery
{
    public void DeliverPackage(string package)
    {
        //delivering with a bike
    }
}

internal class HeavyCargoDelivery : IDelivery
{
    public void DeliverPackage(string package)
    {
        //delivering with TIR accross the country, even heaviest packages
    }
}



/*
// Example - initial situation
class YourStore{
    FastWheelsDelivery _delivery = new FastWheelsDelivery();

    public void SellItem(string item, string address){
        var package = PreparePackage(item, address);
        _delivery.DeliverPackage(package);
    }
`
    private string PreparePackage(string item, string address){
        return "package reaty to be shipped";
    }

}


internal class FastWheelsDelivery{
    public void DeliverPackage(string package){
        //delivering with a bike
    }
}

*/

