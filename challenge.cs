using System;
using System.Linq;

public class Program 
{
    public static string HighLow(string str) 
    {
      var numbers = str.Split(' ').Select(x=>int.Parse(x));
      return numbers.Max().ToString() + " " + numbers.Min().ToString();
    }
}