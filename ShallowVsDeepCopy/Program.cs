// Section: 25 "Shallow Vs deep copy"

var john1 = new Person("(John)", 175, new Pet("Lucky", 5));
var johnShallowCopy = john1.ShallowCopy();
johnShallowCopy.Pet.Age = 10;
johnShallowCopy.Height = 150;

Console.WriteLine($"reference type: John's pet age : {john1.Pet.Age}");
Console.WriteLine($"reference type: John shallow copy's age:" + $"{johnShallowCopy.Pet.Age}");

Console.WriteLine($"value type: John's height : {john1.Height}");
Console.WriteLine($"value type: John shallow copy's height:" + $"{johnShallowCopy.Height}");

var john2 = new Person("(John)", 175, new Pet("Lucky", 5));
var john2DeepCopy = john2.DeepCopy();
john2DeepCopy.Pet.Age = 10;

Console.WriteLine($"reference type: John's pet age : {john2.Pet.Age}");
Console.WriteLine($"reference type: John deep copy's age:" + $"{john2DeepCopy.Pet.Age}");

// Ciekawostka : przypisanie
var person = new Person("Alex", 183, null);
var person2 = person;
person2.Height = 170;

Console.WriteLine($"Person's height {person.Height}");
Console.WriteLine($"Person2's height: {person2.Height} ");

Console.ReadKey();

class Person
{
    public string Name;
    public int Height;
    public Pet Pet;

    public Person(string name, int height, Pet pet)
    {
        Name = name;
        Height = height;
        Pet = pet;
    }

    public Person ShallowCopy()
    {
        return (Person)MemberwiseClone();
    }

    public Person DeepCopy()
    {
        return new Person(Name, Height, new Pet(Pet.Name, Pet.Age));
    }

}

class Pet
{
    public string Name;
    public int Age;

    public Pet(string name, int age)
    {
        Name = name;
        Age = age;
    }

}
