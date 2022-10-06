
var pet1 = new Pet("Dog");
Pet pet2 = new Pet("Cat");

var lazyInitializerForPet = new LazyInitializer<Pet>();
var lazyInitializerForList = new LazyInitializer<List<int>>();



public class LazyInitializer<T> where T: new()
{
    public T _value;
    public T Get()
    {
        if (_value == null)
        {
            _value = new T();
        }
        return _value;
    }
}

class Pet
{
    string Name;

    public Pet(string name)
    {
        Name = name;
    }

}

