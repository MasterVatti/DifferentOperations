namespace TT_hoby.OopOperations
{
  public class Rectangle : IShape
  {
    private double _length;
    private double _width;

    public Rectangle(double length, double width)
    {
      _length = length;
      _width = width;
    }

    public bool IsValid() => _length > 0 && _width > 0;

    public double Area() => _length * _width;

    public double Perimeter() => 2 * (_length + _width);
  }
}