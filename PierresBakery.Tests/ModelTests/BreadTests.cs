using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
    Bread newBread = new Bread(1);
    Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]

    public void GetBread_ReturnsAmountandPrice_Int()
    {
      Bread newBread = new Bread(1);
      int result = 5;
      Assert.AreEqual(newBread.TotalCost,result);
    }

    [TestMethod]

    public void BogoDeal_CheckForFreeLoaf_True()
    {
      Bread newBread = new Bread(4);
      Assert.AreEqual(true, newBread.BogoDeal());
    }

    [TestMethod]

    public void CheckTwo_CheckForAtLeastTwoLoafs_True()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(true, newBread.CheckTwo());
    }

    // [TestMethod]

    // public void ApplyBogoDeal_GetTotalPriceForAmount_Int()
    // {
    //   Bread newBread = new Bread(4);
    //   Assert.AreEqual(newBread.ApplyBogoDeal(),15);
    // }

    [TestMethod]

    public void ApplyBogoDeal_GetTotalPriceForAmount_Int()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(newBread.ApplyBogoDeal(),4);
    }


  }
}