using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;


namespace Bakery.Tests 
{
  [TestClass]

  public class BakeryTests
  {
    [TestMethod]
    public void BakedGoods_CreateInstanceOfClass_True()
    {
      BakedGoods newBakery = new BakedGoods();
      Assert.AreEqual(typeof(BakedGoods), newBakery.GetType());
    }

    [TestMethod]
    public void BakedGoods_GetLoafCost_5()
    {
      BakedGoods newBakery = new BakedGoods();
      int result = newBakery.LoafCost;
      Assert.AreEqual(result, 5);
    }

    [TestMethod]
    public void BakedGoods_GetPastryCost_2()
    {
      BakedGoods newBakery = new BakedGoods();
      int result = newBakery.PastryCost;
      Assert.AreEqual(result, 2);
    }
  }




}