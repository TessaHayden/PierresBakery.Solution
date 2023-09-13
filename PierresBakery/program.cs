using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierres Bakery.");
      Console.WriteLine("How many loaves of bread would you like to purchase?");
      string breadQty = Console.ReadLine();
      Console.WriteLine("How many pastries would you like to purchase?");
      string pastryQty = Console.ReadLine();
      int breadQuantity = int.Parse(breadQty);
      int pastryQuantity = int.Parse(pastryQty);
      Bread newBread = new Bread(5);
      int Total = Bread.PriceCalc(breadQuantity);
      Console.WriteLine($"{Total}");
    }
  }
}