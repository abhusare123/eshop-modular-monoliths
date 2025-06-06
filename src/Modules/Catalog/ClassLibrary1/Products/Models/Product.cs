namespace Catalog.Products.Models;

public class Product : Entity<Guid>
{
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public decimal Price { get; private set; }
    public List<string> Categories { get; private set; } = default!;

    public string ImageFile { get; private set; } = default!;

    public static Product Create(string name, string description, decimal price, List<string> categories, string imageFile)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegative(price);
        return new Product
        {
            Name = name,
            Description = description,
            Price = price,
            Categories = categories,
            ImageFile = imageFile
        };
    }

    public void Update(string name, string description, decimal price, List<string> categories, string imageFile)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegative(price);
        Name = name;
        Description = description;
        Price = price;
        Categories = categories;
        ImageFile = imageFile;
    }
}
