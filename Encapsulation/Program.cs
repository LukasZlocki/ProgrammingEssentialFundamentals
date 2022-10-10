
var lineSegment = new LineSegment(
    new Point(-3, 2),
    new Point(1, 1));


class Point
{
    public float X {get; }
    public float Y { get; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}

class LineSegment
{
    // below fields are example of hidding (get only)
    public Point  Start { get; }
    public Point End { get; }

    public LineSegment(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    // below method is example of encapsulation
    public float Length()
    {
        var xCoordinatesDifference = End.X - Start.X;
        var yCoordinatesDifference = Start.Y - End.Y;
        return (float)Math.Sqrt(
            (xCoordinatesDifference * yCoordinatesDifference) +
            (yCoordinatesDifference * yCoordinatesDifference));
    }

}