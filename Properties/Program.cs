// Properties
// Allow us to make a custome implementation

var person = new Person(1950);
person._yearOfBirth = 2100;

//person.LastName = "Smith"; // Not able to set value - private accesor

Console.ReadKey();



class Person
{
    public DateTime? DateOfDeath { get; set; }
    public int? LengthOfLife
    {
        get
        {
            return DateOfDeath == null ?
                null :
                (int)(DateOfDeath.Value - DateOfBirth).TotalDays / 365;
        }
    }

    public string LastName { get; private set; }

    public void SetLastName(string lastName)
    {
        LastName = lastName;
    }

    public int _yearOfBirth
    {
        get
        {
            return _dateOfBirth.Year;
        }
        set
        {
            _dateOfBirth = new DateTime(value, _dateOfBirth.Month, _dateOfBirth.Day);
        }
    }

    private DateTime _dateOfBirth { get; set; }
    public DateTime DateOfBirth {
        get
        {
            return _dateOfBirth;   
        }
        set
        {
            if(value < DateTime.Now)
            {
                _dateOfBirth = value;
            }
        }
    }

    // Ctor
    public Person(int yearOfBirth)
    {
        _yearOfBirth = yearOfBirth;
    }
}





