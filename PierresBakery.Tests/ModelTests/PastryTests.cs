using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
    Pastry newPastry = new Pastry(1);
    Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]

    public void GetPastry_ReturnsPriceforAmount_Int()
    {
      Pastry newPastry = new Pastry(1);
      int result = 2;
      Assert.AreEqual(newPastry.TotalCost,result);
    }

    // [TestMethod]

    // public void BogoDeal_CheckForThreePastryDiscount_True()
    // {
    //   Pastry newPastry = new Pastry(6);
    //   Assert.AreEqual(true, newPastry.BogoDeal());
    // }

    [TestMethod]

    public void ApplyBogoDeal_GetTotalForAmount_Int()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(newPastry.ApplyBogoDeal(),10);
    }
  }
}