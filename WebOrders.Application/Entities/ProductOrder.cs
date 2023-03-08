namespace WebOrders.Application.Entities;

public class ProductOrder
{
    public required Guid Id { get; init; }
    public required int Quantity { get; init; }
    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
}