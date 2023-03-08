using MediatR;
using WebOrders.Api.Requests.Orders;

namespace WebOrders.Api.Handlers.Orders;

public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersRequest, IResult>
{
    public async Task<IResult> Handle(GetAllOrdersRequest request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return TypedResults.Ok(new List<string>
        {
            "John",
            "Mac",
            "Pat"
        });
    }
}