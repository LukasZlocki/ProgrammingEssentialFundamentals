// Section 33 "Virtual Vs abstract methods"
// Summary:
//  - virtual method may be overriden
//  - abstract method MUST BE overriden


// Overide
var user = new User
{
    Name = "Gamer123",
    Email = "mail@mail.com"
};

Console.WriteLine(user);
Console.ReadKey();


// Virtual
var personDataBuilders = new List<PersonDataBuilder>
{
    new PersonDataBuilder(),
    new EmbellishedPersonDataBuilder()
};

foreach(var builder in personDataBuilders)
{
    Console.WriteLine(builder.BuildPersonData("John", "Smith", 1980) + "\n\n");
}
Console.ReadKey();

// Virtual
public class PersonDataBuilder
{
    public virtual string BuildPersonData(
        string name, string lastName, int yearOfBirth)
    {
        return $"{name} {lastName} was born in {yearOfBirth}";
    }
}

// Virtual
public class EmbellishedPersonDataBuilder : PersonDataBuilder
{
    public override string BuildPersonData(string name, string lastName, int yearOfBirth)
    {
        var prettyLine = "**--**--**--**--**--";
        return $"{prettyLine}\n" + $"{base.BuildPersonData(name, lastName, yearOfBirth)}\n" + $"{prettyLine}";
    }
}


// Abstract
public abstract class Printer
{
    public abstract void Print(string text);
}

// Abstract
public class TextFilePrinter : Printer
{
    public override void Print(string text)
    {
        File.WriteAllText("someFile.txt", text);
    }
}


// Override
class User
{
    public string Name;
    public string Email;

    public override string ToString()
    {
        return $"User name: {Name}, user email {Email}";
    }
}
