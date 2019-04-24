
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CoinCombo;
using System;

namespace CoinCombo.Tests
{
  [TestClass]
  public class CoinTest
  {
    [TestMethod]
    public void CoinConstructor_CreatesInstanceOfCoin_Coin()
    {
      Coin newCoin = new Coin(1.37);
      Assert.AreEqual(typeof(Coin), newCoin.GetType());
    }

    [TestMethod]
    public void
    GetReturn_RetrievesReturnProperty_ListString()
    {
      Coin newCoin = new Coin(1.37);
      List<string> result = newCoin.GetReturn();
      Assert.AreEqual(result, newCoin.GetReturn());
    }

    [TestMethod]
    public void
    HowMuchChange_CalcultatesLowestAmountOfQuarters_int()
    {
      Coin newCoin = new Coin(1.37);
      int result = newCoin.HowMuchChange();
      Assert.AreEqual(5, result);
      Console.WriteLine(result);
    }

    [TestMethod]
    public void
    HowMuchChange_CalcultatesLowestAmountOfDimes_int()
    {
      Coin newCoin = new Coin(.24);
      int result = newCoin.HowMuchChange();
      Assert.AreEqual(2, result);
      Console.WriteLine(result);
    }
  }
}
