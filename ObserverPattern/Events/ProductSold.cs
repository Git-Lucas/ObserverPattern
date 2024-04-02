using ObserverPattern.Entities;

namespace ObserverPattern.Events;
public static class ProductSold
{
    public static void OnProductSoldNotifyCsSystem(Product product, int quantity)
    {
        Console.WriteLine($"\nMessage to customer success system: {quantity} product(s) sold: '{product.Name}'.");
    }

    public static void OnProductSoldNotifyPurchasingSystem(Product product, int quantity)
    {
        if (product.StockQuantity < product.MinimumInStock)
        {
            Console.WriteLine($"Message to purchasing system: The product '{product.Name}' has less " +
                              $"than the minimum quantity in stock. {nameof(product.StockQuantity)}: {product.StockQuantity}" +
                              $" | {nameof(product.MinimumInStock)} {product.MinimumInStock}.");
        }
    }
}
