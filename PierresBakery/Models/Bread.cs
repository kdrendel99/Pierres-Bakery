using System.Collections.Generic;
using System;
using System.Linq;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }

    public Bread(int amount)
    {
      Amount = amount;
    }

    public int TotalCost
    {
      get {return Amount * 5;}
    }
  }
}