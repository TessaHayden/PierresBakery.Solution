using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierres Bakery.");
      Console.WriteLine("Our deals today are:");
      Console.WriteLine("Buy 2 loaves of bread, get one free!");
      Console.WriteLine("How many loaves of bread would you like to purchase?");
      string breadQty = Console.ReadLine();
      Console.WriteLine("Buy 3 pastries, get one free!");
      Console.WriteLine("How many pastries would you like to purchase?");
      string pastryQty = Console.ReadLine();
      int breadQuantity = int.Parse(breadQty);
      int pastryQuantity = int.Parse(pastryQty);
      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();
      int Total = Bread.PriceCalcBread(breadQuantity) + Pastry.PriceCalcPastry(pastryQuantity);
      Console.WriteLine($"Your order total is: ${Total}");
    }
  }
}