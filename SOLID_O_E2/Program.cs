/* Section: 47 "O in SOLID - Example2"
*/
// Code should be open for extension but close for modification
//  

// After refactoring the code

// we use factory pattern in order to solve problem
public interface IIceCreamFactory
{
    IceCream Create(IceCreamType iceCreamType);
}

public class IceCreanFactory : IIceCreamFactory
{
    public IceCream Create(IceCreamType iceCreamType)
    {
        switch (iceCreamType)
        {
            case IceCreamType.Vanilla:
                return new IceCream(IceCreamType.Vanilla,
                new[] { "Cream", "Sugar", "Vanilla" });
            case IceCreamType.Chocolate:
                return new IceCream(IceCreamType.Chocolate,
                new[] { "Cream", "Sugar", "Chocolate" });
            case IceCreamType.Strawberry:
                return new IceCream(IceCreamType.Strawberry,
                new[] { "Cream", "Sugar", "Strawberry" });
            default:
                throw new Exception ArgumentException($"Invalid type of ice cream {iceCreamType}");
        }
    }
}

public enum IceCreamType
{
    Vanilla,
    Chocolate,
    Strawberry
}

public class IceCream
{
    public IceCreamType IceCreamType { get; }
    public string[] Ingriedients { get; }

    public IceCream(IceCreamType iceCreamType, string[] ingredients)
    {
        IceCreamType = iceCreamType;
        Ingriedients = ingredients;
    }
}

public class RandomIceCreamGenerator
{
    private Random _random = new Random();
    private readonly IIceCreamFactory _iceCreamFactory;

    public RandomIceCreamGenerator(IIceCreamFactory iceCreamFactory)
    {
        _iceCreamFactory = iceCreamFactory;
    }

    public IceCream Generate()
    {
        var iceCreamType = GetRandomIceCreamType();
        return _iceCreamFactory.Create(iceCreamType);
    }
    private IceCreamType GetRandomIceCreamType()
    {
        var values = Enum.GetValues(typeof(IceCreamType));

        return (IceCreamType)values.GetValue(_random.Next(values.Length));
    }
}



// before refactoring
// ******************
/*
public enum IceCreamType{
    Vanilla,
    Chocolate,
    Strawberry
}

public class IceCream{
    public IceCreamType IceCreamType { get; }
    public string[] Ingriedients { get; }

    public IceCream(IceCreamType iceCreamType, string[] ingredients){
        IceCreamType = iceCreamType;
        Ingriedients = ingredients;
    }
}

public class RandomIceCreamGenerator{
    private Random _random = new Random();

    public IceCream Generate(){
        var iceCreamType = GetRandomIceCreamType();
        switch (iceCreamType){
            case IceCreamType.Vanilla:
                return new IceCream(IceCreamType.Vanilla,
                new[] {"Cream", "Sugar", "Vanilla"});
            case IceCreamType.Chocolate:
                return new IceCream(IceCreamType.Chocolate,
                new[] {"Cream", "Sugar", "Chocolate"});
            case IceCreamType.Strawberry:
                return new IceCream(IceCreamType.Strawberry,
                new[] {"Cream", "Sugar", "Strawberry"});
            default:
                throw new Exception ArgumentException($"Invalid type of ice cream {iceCreamType}");
        }
    }
    private IceCreamType GetRandomIceCreamType(){
        var values = Enum.GetValues(typeof(IceCreamType));
        
        return (IceCreamType)values.GetValue(_random.Next(values.Length));
            
        
    }
}
*/
