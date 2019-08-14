using System.Collections.Generic;
using System.Linq;
using SmoothieShack.Interfaces;

namespace SmoothieShack.Models
{

  public class Order : IOrder
  {
    public List<Smoothie> Smoothies { get; set; } = new List<Smoothie>();
    public List<Chachkie> Souvenirs { get; set; } = new List<Chachkie>();

    public List<IPurchaseable> Items
    {
      get
      {
        return new List<IPurchaseable>().Concat(Smoothies).Concat(Souvenirs).ToList();
      }
    }

  }
}