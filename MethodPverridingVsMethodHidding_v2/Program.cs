// Section 35 "Method overriding Vs method hidding"

// class from open source library
public class Circle
{
    public double Radius { get; }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Circumference()
    {
        return 2 * Math.PI * Radius;
    }

    // Someone add this methods after SmartCircle was implemented
    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public string Draw()
    {
        return "Drawing from oupen source class... ";
    }

}

public class SmartCircle : Circle
{
    public SmartCircle(double radius) : base(radius)
    {

    }

    /* removing due to apperance in open source class
    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
    */

    // bu adding "new" key word i know that there is a method in open source class but I would like to use this very method(ex. I like its implementaion
    public new string Draw()
    {
        return "Drawing circle ...";
    }
}