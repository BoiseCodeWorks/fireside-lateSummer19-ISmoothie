using System.Collections.Generic;
using System.Linq;
using SmoothieShack.Interfaces;

namespace SmoothieShack.Services
{
  public class CheckoutService
  {
    public void PrintTotal(IOrder order)
    {
      var sum = order.Items.Sum(i =>
      {
        System.Console.WriteLine($"{i.Name} - {i.Price}");
        return i.Price;
      }
      );
      System.Console.WriteLine($"Total: {sum}");
    }
  }
}