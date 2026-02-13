namespace WebApplication1.Domain;

public class Order
{
    public int Id  {get; set;}
    public string CustomerEmail { get; set; } = "";
    public DateTime CreatedAtUtc { get; set; } =  DateTime.UtcNow;
    
    public decimal TotalAmount { get; set; }

    public List<OrderItem> Items { get; set; } = new();
}

