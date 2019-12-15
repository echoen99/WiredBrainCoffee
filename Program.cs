﻿using System;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoffee.ShopInfoTool
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("WiredBrainCoffee - Shop Info Tool!");

      Console.WriteLine("Write 'help' to list available coffee shop commands, " +
        "write 'quit1' to exit application");

      var coffeeShopDataProvider = new CoffeeShopDataProvider();

      while (true)
      {
        var line = Console.ReadLine();

        if (string.Equals("quit1", line, StringComparison.OrdinalIgnoreCase))
        {
          break;
        }

        var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

        if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
        {
          Console.WriteLine("> Available coffee shop commands:");
          foreach (var coffeeShop in coffeeShops)
          {
            Console.WriteLine($"> " + coffeeShop.Location);
          }
        }
      }

    }
  }
}
