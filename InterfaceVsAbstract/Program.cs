//Section: 31 "InterfaceVsAbstract class"


// Abstract class

//var animal = new Animal(); // Not able to create instance of the abstract class
var dog = new Dog(); // OK here, concrete instances can be created.

abstract class Animal
{
    public abstract void Move();
}

abstract class Mammal : Animal
{
    public void ProduceMilk()
    {
        Console.WriteLine("Producing milk");
    }
}

class Snake : Animal
{
    public override void Move()
    {
        Console.WriteLine("Slithering on belly");
    }
}

class Dog : Animal
{
    public override void Move()
    {
        Console.WriteLine("Runing on legs");
    }
}


// Interface

interface IFLyable
{
    void Fly();
}

class Bird : IFLyable
{
    public void Fly()
    {
        Console.WriteLine("Fly in Bird class");
    }

}

class Drone : IFLyable
{
    public void Fly()
    {
        Console.WriteLine("Fly in Drone class");
    }
}