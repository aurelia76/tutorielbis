using System;
class types
{
  static void Main()
  {
    public record Point(int X, int Y);
    Point pt3 = new Point(1,1);
    var pt4 = pt3 with {Y=10};
    Console.WriteLine($"les deux points sont {pt3} et {pt4}");
  }
}
