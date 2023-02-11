using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;


namespace Bakery.Tests 
{
  [TestClass]

  public class BakeryTests
  {
    [TestMethod]
    public void Kitchen_CreateInstanceOfClass_True()
    {
      BakedGoods newBakery = new BakedGoods();
      Assert.AreEqual(typeof(BakedGoods), newBakery.GetType());
    }
  }


}