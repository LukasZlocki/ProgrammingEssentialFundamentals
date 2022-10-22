
Animal genericAnimal = new Animal();
Console.WriteLine($"generic animal: {genericAnimal.AsText()}\n");

Animal tiger = new Tiger();
Console.WriteLine($"tiger: {tiger.AsText()}\n");

Animal lion = new Lion();
Console.WriteLine($"lion: {lion.AsText()}\n"); // takes description from Animal base class

Console.ReadKey();

Console.WriteLine($"**--**--**--**--**"); 
Console.WriteLine($"generic animal: {genericAnimal.GetDescription()}\n");
Console.WriteLine($"generic tiger: {tiger.GetDescription()}\n");
Console.WriteLine($"generic lion: {lion.GetDescription()}\n"); // takes description from Animal base class

Console.ReadKey();

Console.WriteLine($"**--**--**--**--**");
Lion lion2 = new Lion();
Console.WriteLine($"lion2: {lion2.AsText()}\n"); // takes description from Animal base class
Console.WriteLine($"generic lion2: {lion2.GetDescription()}\n"); 

Console.ReadKey();


public class Animal
{
    public string AsText()
    {
        return $"This is an animal of type: {GetDescription()}";
    }

    public virtual string GetDescription()
    {
        return "generic animal";
    }
}

public class Tiger : Animal
{
    public override string GetDescription() // <- overriden method
    {
        return "tiger, the king of Asia";
    }
}

public class Lion : Animal
{
    public new string GetDescription() // <- hidden method , key: new
    {
        return "lion, the king of Africa";
    }
}