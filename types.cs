using System;
public record Point(int X, int Y);
public double Slope()=>(double)X/ (double)Y;
class types
{
  static void Main()
  {
    Point pt3 = new Point(1,1);
    var pt4 = pt3 with {Y=10};
    Console.WriteLine($"les deux points sont {pt3} et {pt4}.");
    double slopeResult = pt4.Slope();
    Console.WriteLine($"the slope of {pt4} is {slopeResult}"); 
  }
}
