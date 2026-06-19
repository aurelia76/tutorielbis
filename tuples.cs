using System;

class tuples
{
  static void main()
  {
    var pt = {X:1, Y:2};
    var slope = (double)pt.Y/(double) pt.X;
    Console.writeLine($"A line form the origin to the point{pt} has a slope of {slope}");
  }
}
