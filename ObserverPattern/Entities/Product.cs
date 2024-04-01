using ObserverPattern.Events;

namespace ObserverPattern.Entities;
public class Product(string name, int minimumInStock) : IProductSold
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; } = name;
    public int StockQuantity { get; private set; }
    public int MinimumInStock { get; } = minimumInStock;

    public event Action<Product, int> OnProductSold = ProductSold.OnProductSold;

    public void Purchase(int quantity)
    {
        StockQuantity += quantity;
    }

    public void Sell(int quantity)
    {
        if (quantity > StockQuantity)
        {
            throw new Exception("The quantity being sold is greater than what is in stock.");
        }

        StockQuantity -= quantity;

        OnProductSold.Invoke(this, quantity);
    }
}
