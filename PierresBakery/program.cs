using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    static void Main()
    {
      Bread breadOrder = new Bread(3, 5, 10);
      Console.WriteLine(breadOrder.GetType());
      Console.WriteLine($"3 loaves of bread is {breadOrder.Price} for two loaves, the third is free!");
      Console.WriteLine($"Your total is: {breadOrder.Total}");
      Console.WriteLine($"Your total is: {breadOrder.CheckPrice()}.");
    }
  }
}