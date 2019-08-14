using System.Collections.Generic;

namespace SmoothieShack.Interfaces
{
  public interface IOrder
  {
    List<IPurchaseable> Items { get; }
  }
}