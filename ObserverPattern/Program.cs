using ObserverPattern.Entities;
using ObserverPattern.Services;

Product product = new(name: "MacBook Pro 2024 - M2 8-core CPU and 10-core GPU",
                      minimumInStock: 20);

product.Purchase(50);

SellProductUseCase sellProduct = new();
sellProduct.Execute(product, 10);
sellProduct.Execute(product, 30);
