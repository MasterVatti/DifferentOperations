namespace TT_hoby.OopOperations
{
  public class Rhombus : IShape
  {
    private double _side;
    private double _height;

    public Rhombus(double side, double height)
    {
      _side = side;
      _height = height;
    }

    public bool IsValid() => _side > 0 && _height > 0;

    public double Area() => _side * _height;

    public double Perimeter() => 4 * _side;
  }
}