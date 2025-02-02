public class Product
{
    public int ProductId { get; set; }  // Unique ID for each product
    public string Name { get; set; }    // Name of the product
    public string Description { get; set; } // Product description
    public string Category { get; set; }  // Category of the product (e.g., electronics, groceries, etc.)
    public string ExternalId { get; set; } // External product ID (e.g., SKU or external store ID)
    public decimal CurrentPrice { get; set; }  // Current price of the product
    public DateTime LastPriceUpdated { get; set; } // Timestamp of the last price update
    public string ImageUrl { get; set; }  // Optional: Link to product image
}
