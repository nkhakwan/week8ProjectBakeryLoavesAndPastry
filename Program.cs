using System;
using System.Collections.Generic;
using Bakery.Bread;
using Bakery.Pastry;


namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Loaves MyBread = new Loaves();
      Pastries MyPastry = new Pastries();
      MyBread.LoavesOrderGetter();
      MyPastry.PastryOrderGetter();

    }
    

      
  }
}