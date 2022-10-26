/* Section: 46 "S in SOLID - single responsibility"
*/

// Advantages:
//  sdmaller, more cohesive and more readable classes
//  reusable code
//  easy to maintain of the code
//  faster development and less bugs

// In example below class PeopleInformationPrinter has many responsibilities.
// reading from database, converting data from database to text, writing text to file.
// This need to be splitted into class responsible only for reading from database, converting strings, writing to file.

public class PeopleInformationPrinter
{
    private readonly string _connectionString;
    private readonly string _resultFilePath;

    public PeopleInformationPrinter(string connectionString, string resultFilePath)
    {
        _connectionString = connectionString;
        _resultFilePath = resultFilePath;
    }

    public PeopleInformationPrinter()
    {
        var people = ReadFromDatabase();
        var text = BuildText(people);
        File.WriteAllText(_resultFilePath, text);
    }

    // connecting to database
    private IEnumerable<Person> ReadFromDatabase()
    {
        // code to read from DB
        // ...

    }

    private string BuildText(IEnumerable<Person> people)
    {
        return string.Join("\n", people.Select(person => person.ToString()));
    }
}

public class Person
{
    public string Name;
}
