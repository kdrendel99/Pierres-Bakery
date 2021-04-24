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
    //   set {TotalCost = value * 5;}
    //   get {}
      

      // Below is the code that works
      get {return Amount * 5;}
      set {;}
    }

    public bool CheckTwo()
    {
      if (Amount >= 2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public int ApplyBogoDeal()
    {
      if (CheckTwo())
      {

        int QuantityPaidForAfterDiscount = Convert.ToInt32(Math.Ceiling(Amount/1.5));
        int NewTotalCost = QuantityPaidForAfterDiscount * 5;
        return NewTotalCost;
      }
      else
      {
        return TotalCost;
      }
    }
  }
}