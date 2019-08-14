namespace SmoothieShack.Interfaces
{
  public interface IPurchaseable
  {
    string Name { get; set; }
    decimal Price { get; }
  }
}