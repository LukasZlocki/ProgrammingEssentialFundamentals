/* Section: 46 "S in SOLID - single responsibility"
*/

// One reason to change

// Advantages:
//  sdmaller, more cohesive and more readable classes
//  reusable code
//  easy to maintain of the code
//  faster development and less bugs

// In example below class PeopleInformationPrinter has many responsibilities.
// reading from database, converting data from database to text, writing text to file.
// This need to be splitted into class responsible only for reading from database, converting strings, writing to file.


// ******* AFTER refactoring *********

public class PeopleInformationPrinter
{
    private readonly IReader<Person> _reader;
    private readonly IPeopleTextFormatter _peopleTextFormatter;
    private readonly IWriter _writer;

    public PeopleInformationPrinter(IReader<Person> reader, IPeopleTextFormatter peopleTextFormatter, IWriter writer)
    {
        _reader = reader;
        _peopleTextFormatter = peopleTextFormatter;
        _writer = writer;
    }

    public void Print()
    {
        var people = _reader.Read();
        var text = _peopleTextFormatter(people);
        _writer.Write(text);
    }
}

public interface IWriter
{
    public void Write(string text);
}


public class TextWriter : IWriter
{
    private string _filePath;
    public void Write(string text)
    {
        File.WriteAllText(_filePath, text);
    }
}

public interface IPeopleTextFormatter
{
    public string BuildText(IEnumerable<Person> people);
}

public class PeopleTextFormatter : IPeopleTextFormatter
{
    public string BuildText(IEnumerable<Person> people)
    {
        return string.Join("\n", people.Select(p => p.ToString()));
    }
}

public interface IReader<T>
{
    IEnumerable<Person> Read();
}

// class for reading from database
public class DatabaseReader : IReader<Person>
{
    private readonly string _connectionString;
    public DatabaseReader(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IEnumerable<Person> Read()
    {
        // code to read from DB ex from SQL connection
        // ... simulation below
        var peopleList = new List<Person>();
        
        Person person1 = new Person();
        person1.Name = "John";

        Person person2 = new Person();
        person2.Name = "Barbara";

        Person person3 = new Person();
        person3.Name = "Wes";

        peopleList.Add(person1);
        peopleList.Add(person2);
        peopleList.Add(person3);

        return peopleList;
    }
}


public class Person
{
    public string Name;
}


/*
 
// ******* BEFORE refactoring *********

// This class responsibility:
//      * connecting to database 
//      * transforming peope's data to text
//      * writing the text to a text file
// if we change engine in DB or data formatiing class will ned be adjusted and willl not be working in old implementations.
public class PeopleInformationPrinter
{
    private readonly string _connectionString;
    private readonly string _resultFilePath;

    public PeopleInformationPrinter(string connectionString, string resultFilePath)
    {
        _connectionString = connectionString;
        _resultFilePath = resultFilePath;
    }

    public void Print()
    {
        var people = ReadFromDatabase();
        var text = BuildText(people);
        File.WriteAllText(_resultFilePath, text);
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
        // code to read from DB ex from SQL connection
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


*/