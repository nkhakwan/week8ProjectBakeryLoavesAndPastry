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
      
      LoavesOrderGetter();
      PastryOrderGetter();

    }
    static void LoavesOrderGetter()
      {
        Loaves MyBread = new Loaves();
        Console.WriteLine("Loaves are $5 a piece. Buy two and get one for free");
        Console.WriteLine("How Many Breads do you want?");
        string NoOfLoavesString = Console.ReadLine();
        int NoOfLoaves = int.Parse(NoOfLoavesString);
        MyBread.BreadPrice(NoOfLoaves);
        Console.WriteLine("You have bought "+ NoOfLoaves + " Loaves. Your Total loaves with Promotion are " + MyBread.TotalLoaves);
        Console.WriteLine("And the total Price you pay is "+ " " + MyBread.TotalPrice);
      }

      static void PastryOrderGetter()
      {
        Pastries MyPastry = new Pastries();
        Console.WriteLine("What about Pastries? How many do you want? If you buy two, it is $2 a piece. For 3 it is $5");
        Console.WriteLine("How Many Pastries do you want?");
        string NoOfPastriesS = Console.ReadLine();
        int NoOfPastries = int.Parse(NoOfPastriesS);
        MyPastry.PastryPriceCalculate(NoOfPastries);
        Console.WriteLine("Your total Price for " + NoOfPastries+ " Pastries" + " "+ "is "+ MyPastry.TotalPrice + " Dollars");
      }
  }
}