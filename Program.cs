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
      Console.WriteLine("");
      Console.WriteLine("WelCome. We are selling 12 seeds Delicious Killer Bread Loaves and Lemon Tart Pastries");
      MyBread.LoavesOrderGetter();
      MyPastry.PastryOrderGetter();
      Dictionary<int, float> OrderKeeper = new Dictionary<int, float>();
      OrderKeeper.Add(11, MyBread.TotalPrice);
      OrderKeeper.Add(12, MyPastry.TotalPrice);
      float FirstOrderTotal = OrderKeeper[11] + OrderKeeper[12];
      Console.WriteLine("");
      Console.WriteLine("Your Current Order total for both Loaves and pastries is" + " " +FirstOrderTotal);
      Console.WriteLine("");
      Console.WriteLine("You sure you are done? Want to buy more? Input Y for the second order");
      string SecondOrder = Console.ReadLine();
      if (SecondOrder == "Y" || SecondOrder == "y")
      {
        MyBread.LoavesOrderGetter();
        MyPastry.PastryOrderGetter();
        OrderKeeper.Add(21, MyBread.TotalPrice);
        OrderKeeper.Add(22, MyPastry.TotalPrice);
        float SecondOrderTotal = OrderKeeper[21] + OrderKeeper[22];
        Console.WriteLine("");
        Console.WriteLine("Your second Order total for both Loaves and pastries is" + " " +SecondOrderTotal);
        float GrandTotal = OrderKeeper[11] + OrderKeeper[12] + OrderKeeper[21] + OrderKeeper[22];
        Console.WriteLine("");
        Console.WriteLine("Your Grand Total for both the orders is: $" + GrandTotal);

      } else
      {
        Console.WriteLine("Have a Wonderful Day and Please Come again");
      }
    }
    

      
  }
}