using System;

namespace TT_hoby.OopOperations
{
  public class Circle : IShape
  {
    private double _radius;

    public Circle(double radius)
    {
      _radius = radius;
    }

    public bool IsValid() => _radius > 0;

    public double Area() => Math.PI * _radius * _radius;

    public double Perimeter() => 2 * Math.PI * _radius;
  }
}