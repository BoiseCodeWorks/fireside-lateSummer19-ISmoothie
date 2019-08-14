using System;
using SmoothieShack.Models;
using SmoothieShack.Services;

namespace SmoothieShack
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var SmoothieShackShack = new Menu();
      var checkout = new CheckoutService();
      var bestFriendsMug = new Chachkie()
      {
        Name = "Worlds Okayest Friend",
        Price = 17.99m
      };
      var apple = new Fruit()
      {
        Name = "Apple",
        Price = .5m
      };
      var caffiene = new EnergyShot()
      {
        Name = "Double Double",
        Price = .75m
      };

      var sunrise = new Smoothie()
      {
        Name = "Sunrise"
      };
      sunrise.Fruits.Add(apple);
      sunrise.Shots.Add(caffiene);
      //   SmoothieShackShack.AvailableFruit.Add(apple);
      //   SmoothieShackShack.Shots.Add(caffiene);
      var jakesOrder = new Order();
      jakesOrder.Smoothies.Add(sunrise);
      jakesOrder.Souvenirs.Add(bestFriendsMug);
      //   jakesOrder.Souvenirs.Add
      checkout.PrintTotal(jakesOrder);
    }
  }
}
