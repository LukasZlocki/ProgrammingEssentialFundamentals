// Section: 47 "O in SOLID - Example1"
// Open / clode principle
// Opened: it can be xtended so new functionality can be added.
// Closed: we shouldn't be forced to modify the existing code to introduce this piece of functionality
// Def: Modules, classes and functions should be opened for extension but closed for modification.



// After refactor the code 
// ***********************

public interface IShape
{
    double CalculateArea();
}

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    // this is added to class
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Triangle : IShape
{
    public double Base { get; }
    public double Height { get; }

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }
    // this is added to class
    public double CalculateArea()
    {
        return Base * Height / 2.0;
    }
}


public class Square : IShape
{
    public double Side { get; }

    public Square(double side)
    {
        Side = side;
    }
    // this is added to class
    public double CalculateArea()
    {
        return Side * Side;
    }
}

public class AreaCalculator
{
    public double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}




/* Before refactor the code 
// **************************
public class Circle {
    public double Radius { get;}

    public Circle(double radius){
        Radius = radius;
    }
}

public class Triangle{
    public double Base { get;}
    public double Height { get; }

    public Triangle (double @base, double height){
        Base = @base;
        Height = height;
    }
}

// if we add this class than we will break SOLID rule 
// because we have to add additional CalculateArea method to AreaCalculator class
public class Square{
    public double Side { get;}

    public Square (double side){
        Side = side;
    }

}

public class AreaCalculator{
    public double CalculateArea(Circle circle){
        return Math.PI * circle.Radius * circle.Radius;
    }
    public double CalculateArea(Triangle triangle){
        return triangle.Base * triangle.Height / 2.0;
    }

    // I had to add this method after creating class Square
    public double CalculateArea(Square square){
        return square.Side * square.Side;
    }
}


*/

