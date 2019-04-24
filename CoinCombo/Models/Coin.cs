using System.Collections.Generic;
using System;

namespace CoinCombo
{
  public class Coin
  {
    private double _change;
    private List<string> _return;

    public Coin (double change)
    {
      _change = change;
    }

    public List<string> GetReturn()
    {
      return _return;
    }

    public int HowMuchChange()
    {
      double changeLeft = _change;
      int numOfQuarters = 0;
      if (_change >= .25)
      {
        double doubleNumOfQuarters = changeLeft / .25;
        numOfQuarters = Convert.ToInt32(doubleNumOfQuarters);
        changeLeft = changeLeft % .25;
      }
      return numOfQuarters;
    }
  }
}
