using System;
class Numbers
{
  void nombreEntiers()
  {
    int a=18;
    int b=6;
    int c=a+b;
    Console.WriteLine(c);
    int d=a-b;
    Console.WriteLine(d);
    int e=a*b;
    Console.WriteLine(e);
    int f=a/b;
    Console.WriteLine(f);
  }
  void OrdrePriorite()
  {
    int a=5;
    int b=4;
    int c = 2;
    int d= a+b*c;
    Console.WriteLine(d);
    d=(a+b)*c;
    Console.WriteLine(d);
    d=(a+b)-6*c+(12*4)/3+12;
    Console.WriteLine(d);
    
    int e=7;
    int f=4;
    int g=3;
    int h = (e+f)/g;
    Console.WriteLine(h);
  }

  void divisionReste()
  {
    int a= 7;
    int b=4;
    int c=(a+b)/3;
    int d = (a+b)%3;
    Console.WriteLine($"quotient{c}");
    Console.WriteLine($"reste{d}");
  }
  void nombreDouble()
  {
    double a = 19;
    double b= 23;
    double c= 8;
    double d = (a+b)/c;
    Console.WriteLine(d);
  }
  void nombreDecimal()
  {
    double a= 1.0;
    double b = 3.0;
    Console.WriteLine(a/b);
    decimal c= 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c/d);
  }
  static void Main()
  {
   //nombreEntiers();
    //OrdrePriorite();
    //divisionReste();
    int min = int.MinValue;
    int max = int.MaxValue;
    //Console.WriteLine($"le portée des entiers {min} jusqu'à {max}");
    //int what = max+3;
    //Console.WriteLine ($"depassement {what}");
    //nombreDouble();
    nombreDecimal();
  }
}
