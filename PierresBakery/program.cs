using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierres Bakery");
      Console.WriteLine("We are offering a buy 2, get 1 free for our loaves of bread!  Single loaves are $5 or 4 loaves for $15!  Pastries are buy 3, get 1 free!  Single pastries cost $2")
      Console.WriteLine("How many loaves of bread would you like?");
      string breadQuantity = Console.ReadLine();
      Console.WriteLine("How many pastries would you like?");
      string pastryQuantity = Console.ReadLine();
      int breadQty = int.Parse(breadQuantity);
      int pastyQty = int.Parse(pastryQuantity);
    }
  }
}