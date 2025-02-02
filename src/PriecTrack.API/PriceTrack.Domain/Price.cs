public class Price
{
    public int PriceId { get; set; }  // Unique ID for the price record
    public int ProductId { get; set; }  // Foreign key to Product
    public decimal PriceAmount { get; set; }  // Price of the product at the time
    public DateTime DateRecorded { get; set; } // Date when the price was recorded
    
    // Navigation property
    public Product Product { get; set; }
}
