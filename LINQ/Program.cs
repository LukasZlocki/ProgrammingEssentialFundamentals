using System.Linq;

var pirates = new List<Person>
{ new Person("Anne", "Bonny", 1698),
  new Person("Charles", "Vane", 1980),
  new Person("Bart", "Roberts", 1682)
};


var bornAfter1695QuerySyntax = from pirate in pirates where pirate.YearOfBirth > 1685 select pirate;

foreach (var pirate in bornAfter1695QuerySyntax)
{
    Console.WriteLine($"{pirate}");
}

Console.WriteLine("***");

var bornAfter1685MethodSyntax = pirates.Where(p => p.YearOfBirth > 1685);

foreach(var pirate in bornAfter1685MethodSyntax)
{
    Console.WriteLine(pirate);
}

IEnumerable<Person> orderByLastName = pirates.OrderBy(p => p.LastName); ;

IEnumerable<int> OnlyYearsOfBirth = pirates.Select(p => p.YearOfBirth);

double avarageYearOfBirth = pirates.Average(p => p.YearOfBirth);

bool isAnyPirateBornBefore1650 = pirates.Any(p => p.YearOfBirth < 1650);

bool areAllPiratesBornAfter1650 = pirates.All(p => p.YearOfBirth > 1650);

IEnumerable<Person> pirateswithLastNameStartingWithR = pirates.Where(p => p.LastName.StartsWith("R"));

Person firstPirateByAlphabet = pirates.OrderBy(p => p.LastName).First();

IEnumerable<Person> piratesFromYoungestToOldest = pirates.OrderBy(p => p.YearOfBirth).Reverse();

Console.ReadKey();




public class Person
{
    public string Name;
    public string LastName;
    public int YearOfBirth;

    public Person(string name, string lastName, int yearOfBirth)
    {
        Name = name;
        LastName = lastName;
        YearOfBirth = yearOfBirth;
    }

    public override string ToString()
    {
        return $"{Name} {LastName} born in {YearOfBirth}";
        
    }
}