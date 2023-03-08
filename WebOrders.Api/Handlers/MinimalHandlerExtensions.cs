using MediatR;

namespace WebOrders.Api.Handlers;

public static class MinimalHandlerExtensions
{
    public static WebApplication MediateGet<TRequest>(
        this WebApplication app,
        string template) where TRequest : IRequest<IResult>
    {
        app.MapGet(template, async (IMediator mediator,
            [AsParameters] TRequest request) => await mediator.Send(request));

        return app;
    }
    
    public static WebApplication MediatePost<TRequest>(
        this WebApplication app,
        string template) where TRequest : IRequest<IResult>
    {
        app.MapPost(template, async (IMediator mediator,
            [AsParameters] TRequest request) => await mediator.Send(request));

        return app;
    }
}