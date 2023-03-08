namespace WebOrders.Application.Entities;

public class Product
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required double Price { get; init; }
}