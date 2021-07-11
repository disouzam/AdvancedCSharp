// https://channel9.msdn.com/Series/C-Advanced/Introduction-to-Language-Integrated-Query-LINQ--C-Advanced-1-of-8

using System;
using System.Collections.Generic;
using System.Linq;

namespace RestrictionOperators
{
  class Program
  {
    static void Main(string[] args)
    {

      // LINQ query structure
      // This sample uses where to find all elements of an array less than 5. 
      // It demonstrates the components of a query, including a where clause that filters for small numbers.
      List<int> numbers = new List<int>(){5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

      var lowNums = from num in numbers
                    where num < 5
                    select num;

      Console.WriteLine("Numbers < 5:");
      foreach (var x in lowNums)
      {
        Console.WriteLine(x);
      }
    private static void printHeaders(string text)
    {
      Console.WriteLine(SEPARATOR);
      Console.WriteLine(text);
      Console.WriteLine(SEPARATOR);
    }
  }
}
