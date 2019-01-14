using System;
using challenges.Statics;

namespace challenges
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine(UnderPressure.DoubleInt(3));
      Console.WriteLine(UnderPressure.IsEven(4));
      Console.WriteLine(UnderPressure.IsEven(5));
      Console.WriteLine(UnderPressure.GetFileExtension("basic.txt"));
      Console.WriteLine(UnderPressure.GetFileExtension("cra.z.y.txt"));
      Console.WriteLine(UnderPressure.GetFileExtension("noExtension"));
      string[] testArr = new string[] {
          "Hello",
          "from",
          "the",
          "Otters",
          "slide"
      };
      Console.WriteLine(UnderPressure.LongestString(testArr));
      Console.WriteLine(UnderPressure.LongestString(testArr, true));
    }
  }
}
