using ObserverPattern.Entities;

Product product = new(name: "MacBook Pro 2024 - M2 8-core CPU and 10-core GPU",
                      minimumInStock: 20);

product.Purchase(50);
product.Sell(10);
product.Sell(30);
