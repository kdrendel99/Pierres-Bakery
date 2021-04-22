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
      Bread newBread = new Bread(1,5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}