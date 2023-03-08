using WebOrders.Api.Requests.Orders;

namespace WebOrders.Api.Handlers.Orders;

public static class OrdersHandlersExtensions
{
    public static WebApplication MapOrderExtension(this WebApplication app)
    {
        app.MediateGet<GetAllOrdersRequest>(ApiEndpoints.Orders.GetAll);

        return app;
    }
}