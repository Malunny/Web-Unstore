namespace Unstore.Models;

public class ProductPurchase
{
    public int ProductId { get; set; }
    public decimal PriceOnPurchase { get; set; }
    public Product Product { get; set; }
    
    public int PurchaseId { get; set; }
    public Purchase Purchase { get; set; }
    
    public int Quantity { get; set; }
}