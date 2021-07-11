// https://channel9.msdn.com/Series/C-Advanced/Introduction-to-Language-Integrated-Query-LINQ--C-Advanced-1-of-8

using System;
using System.Collections.Generic;
using System.Linq;
using Try101LinqSamples;
namespace RestrictionOperators
{
  class Program
  {
    private const string SEPARATOR = "===============================================================";
    static void Main(string[] args)
    {
      
      // This sample uses where to find all elements of an array less than 5. 
      // It demonstrates the components of a query, including a where clause that filters for small numbers.
      printHeaders("LINQ query structure");

      int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

      var lowNums = from num in numbers
                    where num < 5
                    select num;

      Console.WriteLine("Numbers < 5:");
      foreach (var x in lowNums)
      {
        Console.WriteLine(x);
      }

      // This sample uses where to find all products that are out of stock. Its where clause examines a property of the items in the input sequence.
      printHeaders("Filter elements on a property");
      List<Product> products = Restrictions.GetProductList();

      var soldOutProducts = from prod in products
                            where prod.UnitsInStock == 0
                            select prod;

      Console.WriteLine("Sold out products:");
      foreach (var product in soldOutProducts)
      {
          Console.WriteLine($"{product.ProductName} is sold out!");
      }
      
      // This sample demonstrates an indexed Where clause that returns digits whose name is shorter than their value.
      printHeaders("Filter elements based on position");

      string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

      var shortDigits = digits.Where((digit, index) => digit.Length < index);

      Console.WriteLine("Short digits:");
      foreach (var d in shortDigits)
      {
          Console.WriteLine($"The word {d} is shorter than its value.");
}
    }
  
    private static void printHeaders(string text)
    {
      Console.WriteLine("");
      Console.WriteLine(SEPARATOR);
      Console.WriteLine(text);
      Console.WriteLine(SEPARATOR);
    }
  }
}
