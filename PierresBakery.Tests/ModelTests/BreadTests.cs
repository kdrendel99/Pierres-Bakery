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
  }
}