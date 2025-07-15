using System;
class Program
{

  public static void Main(String[] args)
  {
      Console.WriteLine("Hello C#");
      bool a = true; 
    Console.WriteLine(a);



   Console.WriteLine("VALUE TYPE:");
    Console.WriteLine("__________________________");
    Console.WriteLine("Integers:");
    byte a = 12;
    Console.WriteLine("byte\tA  = {0}\t{1}\t{2}\t{3}", a, typeof(byte), byte.MaxValue, byte.MinValue);
    sbyte b = 12;
    Console.WriteLine("sbyte\tB  = {0}\t{1}\t{2}\t{3}", b, typeof(sbyte), sbyte.MaxValue, sbyte.MinValue);
    short c = 12;
    Console.WriteLine("short\tC  = {0}\t{1}\t{2}\t{3}", c, typeof(short), short.MaxValue, short.MinValue);
    ushort d = 12;
    Console.WriteLine("ushort\tD  = {0}\t{1}\t{2}\t{3}", d, typeof(ushort), ushort.MaxValue, ushort.MinValue);
    int e = 12;
    Console.WriteLine("int\tE = {0}\t{1}\t{2}\t{3}", e, typeof(int), int.MaxValue, int.MinValue);
    int f = 12;
    Console.WriteLine("uint\tF = {0}\t{1}\t{2}\t{3}", f, typeof(uint), uint.MaxValue, uint.MinValue);
    int g = 12;
    Console.WriteLine("long\tG = {0}\t{1}\t{2}\t{3}", g, typeof(long), long.MaxValue, long.MinValue);
    int h = 12;
    Console.WriteLine("ulong\tH = {0}\t{1}\t{2}\t{3}", h, typeof(ulong), ulong.MaxValue, ulong.MinValue);



    Console.WriteLine("\nFloating Point:");
    float i = 123.34f;
      Console.WriteLine ("float\tI = {0}\t{1}\t{2}\t{3}", i, typeof(float), float.MaxValue, float.MinValue);
    double j = 123.34;
    Console.WriteLine("double\tJ = {0}\t{1}\t{2}\t{3}", j, typeof(double), double.MaxValue, double.MinValue);
    decimal k= 123.34m;
   Console.WriteLine ("decimal\tK = {0}\t{1}\t{2}\t{3}", k, typeof(decimal), decimal.MaxValue, decimal.MinValue);


    Console.WriteLine("\nText:");
    char l = 'f';
    Console.WriteLine("char\tL = {0}\t{1}\t{2}\t{3}", l, typeof(char));


    Console.WriteLine("\nBoolean:");
  bool m = true;
    Console.WriteLine("bool\tM = {0}\t{1}", m, typeof(bool));

   
        

    }
}
    


