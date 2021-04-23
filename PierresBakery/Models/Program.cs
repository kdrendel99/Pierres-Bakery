using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to bakery. Choose Bread:");
      int breadAmount = Int32.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(breadAmount);
      Console.WriteLine(breadOrder.ApplyBogoDeal());
      // Pastry pastryOrder = new Pastry();
    }
  }
}