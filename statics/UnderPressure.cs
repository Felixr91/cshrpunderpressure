using System;
using System.Linq;

namespace challenges.Statics
{
  static class UnderPressure
  {
    public static int DoubleInt(int num)
    {
      return num * 2;
    }
    public static bool IsEven(int num)
    {
      return num % 2 == 0;
    }
    public static string GetFileExtension(string str)
    {
      //check if contains '.'
      if (str.Contains('.'))
      {
        //split on index of last '.'
        var strArray = str.Split('.');
        //return string at last index of split
        return strArray[strArray.Length - 1];
      }
      System.Console.WriteLine("INVALID EXTENSION");
      return null;

    }

    public static string LongestString(string[] strArr)
    {
      string longestStr = strArr[0];
      for (int i = 0; i < strArr.Length; i++)
      {
        if (strArr[i].Length > longestStr.Length)
        {
          longestStr = strArr[i];
        }
      }
      return longestStr;
    }
    public static string LongestString(string[] strArr, bool sort)
    {
      Array.Sort(strArr, (a, b) => b.Length - a.Length);
      return strArr[0];
    }

    public static int SumArray(int[] nums)
    {
      return nums.Sum();
    }

    public static float SumArray(float[] nums)
    {
      float total = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        total += nums[i];
      }
      return total;
    }







  }
}