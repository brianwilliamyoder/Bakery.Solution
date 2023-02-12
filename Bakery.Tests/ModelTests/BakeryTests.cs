using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;


namespace Bakery.Tests 
{
  [TestClass]

  public class BakeryTests
  {
    [TestMethod]
    public void Bread_CreateInstanceOfClass_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void Bread_GetLoafCost_5()
    {
      Bread newBread = new Bread();
      int result = newBread.LoafCost;
      Assert.AreEqual(result, 5);
    }

    [TestMethod]
    public void CalculateBread_GetTotal_5()
    {
    Bread newBread = new Bread();
    int result = newBread.CalculateBread(1);
    Assert.AreEqual(result, 5);
    }

    [TestMethod]
    public void CalculateBread_GetTotal_10()
    {
      Bread newBread = new Bread();
      int result = newBread.CalculateBread(3);
      Assert.AreEqual(result, 10);
    }
    
    [TestMethod]
    public void CalculateBread_GetTotal_95()
    {
      Bread newBread = new Bread();
      int result = newBread.CalculateBread(28);
      Assert.AreEqual(result, 95);
    }

    [TestMethod]
    public void Pastry_CreateInstance_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void CalculatePastry_GetTotal_2()
    {
      Pastry newPastry = new Pastry();
      int result = newPastry.CalculatePastry(1);
      Assert.AreEqual(result, 2);
    }

    [TestMethod]
    public void CalculatePastry_GetTotal_4()
    {
      Pastry newPastry = new Pastry();
      int result = newPastry.CalculatePastry(3);
      Assert.AreEqual(result, 4);
    }
  }
}