namespace TT_hoby.OopOperations
{
  public class Square : IShape
  {
    private double _side;

    public Square(double side)
    {
      _side = side;
    }

    public bool IsValid() => _side > 0;

    public double Area() => _side * _side;

    public double Perimeter() => 4 * _side;
  }
}