using System;
using System.Collections.Generic;
using Bakery.Bread;


namespace Bakery
{
  public class Program
  {
    public static void Main()
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
  }
}