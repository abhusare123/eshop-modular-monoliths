namespace Catalog.Products.Events;

public record class ProductPriceChagnedEvent(Product Product) : IDomainEvent;
