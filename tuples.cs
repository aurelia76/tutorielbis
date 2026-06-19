using System;

class tuples
{
  static void Main()
  {
    var pt = (X:1, Y:2);
    var slope = (double)pt.Y/(double) pt.X;
    Console.WriteLine($"A line form the origin to the point{pt} has a slope of {slope}");
    pt = pt.X+5;
    Console.WriteLine($"point is now at {pt}");
    var pt2= (pt.X,Y:10);
    Console.WriteLine($"the point 'pt2' est a {pt2}");
  }
}
