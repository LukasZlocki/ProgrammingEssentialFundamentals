/* Section: #42 "Builder pattern"
// builderi s a design pattern that allows the step-by-step cinstruction of omplex objects
// Advantages:
// - provide parameters to the builder one by one  
// even if some process are running meantime
// - Good place for some more complex logic so we can keep constr simple

// Disadvantages:
// - A lot of extra code
// - Does not enforce providing all parameters
// - Risk of overwritten some values
*/

// Just imagine construcotr like that:
// var dog1 = new Pet("Dog", "Louis Chares Bryan the third", "Rex", "Tina")
// WTF so many parametr in constructor
// Builder pattern make it simpler and easy to understand

var builder = new Person.Builder();
//.WithName("Alex")
//.WithYearOfBirth(1950)
//.Build();

var name = ReadName();
builder = builder.WithName(name);
// Now the program is doing complcated calculation or other things...

int year = ReadYear();
builder = builder.WithYearOfBirth(year);
// Now the program is doing complcated calculation or other things...

// Here we build person object
var person = builder.Build();


static string ReadName()
{
    return ""; // complex reading operation here
}

static int ReadYear()
{
    return 0; // complex reading operation here
}

public class Person
{
    private string Name { get; }
    private int YearOfBirth { get; }

    private Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    // Nested builder class
    public class Builder
    {
        private string _name;
        private int _yearOfBirth;
        private int _age;

        public Builder WithName(string name)
        {
            _name = name;
            return this;
        }

        public Builder WithYearOfBirth(int yearOfBirth)
        {
            _yearOfBirth = yearOfBirth;
            // plus of builder is : Here I can put some extend validation ex. if year > 1980
            // I do not need to put it in constructor but can as a separate logic due to builder pattern
            return this;
        }

        public Person Build()
        {
            return new Person(_name, _yearOfBirth);
        }

    }

}


