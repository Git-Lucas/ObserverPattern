using ObserverPattern.Entities;

namespace ObserverPattern.Events;
public interface IProductSold
{
    event Action<Product, int> OnProductSold;
}
