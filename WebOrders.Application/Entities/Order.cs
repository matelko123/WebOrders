namespace WebOrders.Application.Entities;

public class Order
{
    public required Guid Id { get; init; }
    public required DateTime OrderDate { get; init; }
    public ICollection<ProductOrder> ProductOrders { get; set; }
}