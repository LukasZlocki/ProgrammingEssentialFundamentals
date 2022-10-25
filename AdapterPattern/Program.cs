// Section 43 "Adapter pattern"
// Adapter is a design pattern that allows converting an interface of a class to the interface expected by a client.


// Adapter pattern - Solution
public class HotelsByCityNameFInderAdapter : IHotelByCityFinder
{
    private readonly IHotelByZipCodeFinder _hotelByZipCodeFinder;

    public HotelsByCityNameFInderAdapter(IHotelByZipCodeFinder hotelsByZipCodeFinder)
    {
        _hotelByZipCodeFinder = hotelsByZipCodeFinder;
    }

    public IEnumerable<Hotel> FindByCity(string city)
    {
        var zipCodes = GetZipCodesForCity(city);
        return zipCodes.SelectMany(zipCode => _hotelByZipCodeFinder.FindByZipCode(zipCode));
    }

    private IEnumerable<string> GetZipCodesForCity(string city)
    {
        if (city == "London")
        {
            return new[] { "E1 6AN", "E1 7AA" };
        }
        throw new Exception("Unknow city");
    }
}



// Problem:
public class Hotel
{
    public string Name { get; }
    public Hotel(string name)
    {
        Name = name;
    }
}

// Other team needs finding hotel by city not by zip code
public interface IHotelByCityFinder
{
    IEnumerable<Hotel> FindByCity(string city);
}


// *** package to find hotel by ZipCode

public interface IHotelByZipCodeFinder
{
    IEnumerable<Hotel> FindByZipCode(string zipCode);
}

public class HotelsByZipCodeFinder : IHotelByZipCodeFinder
{
    public IEnumerable<Hotel> FindByZipCode(string zipCode)
    {
        switch (zipCode)
        {
            case "E1 6AN":
                return new[]
                {
                    new Hotel("Imperial Hotel"),
                    new Hotel("Golden Duck Hotel")
                };
            case "E1 7AA":
                return new[] { new Hotel("Ambassador Hotel") };
            default:
                return Enumerable.Empty<Hotel>();
        }
    }
}

