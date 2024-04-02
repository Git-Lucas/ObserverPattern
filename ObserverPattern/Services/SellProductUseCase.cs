using ObserverPattern.Entities;
using ObserverPattern.Events;

namespace ObserverPattern.Services;
public class SellProductUseCase : IProductSold
{
    public event Action<Product, int> OnProductSold;

    public SellProductUseCase()
    {
        OnProductSold += ProductSold.OnProductSoldNotifyCsSystem;
        OnProductSold += ProductSold.OnProductSoldNotifyPurchasingSystem;
    }

    public void Execute(Product product, int quantity)
    {
        product.Sell(quantity);

        OnProductSold.Invoke(product, quantity);
    }
}
