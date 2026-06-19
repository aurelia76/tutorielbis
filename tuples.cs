using System;

class tuples
{
  static void Main()
  {
    var pt = new {X:1, Y:2};
    var slope = (double)pt.Y/(double) pt.X;
    Console.WriteLine($"A line form the origin to the point{pt} has a slope of {slope}");
    pt = new {X: pt.X+5, Y:pt.Y};
    Console.WriteLine($"point is now at {pt}");
  }
}
