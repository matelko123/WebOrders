using MediatR;
using WebOrders.Api.Handlers.Orders;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    
    builder.Services.AddMediatR(x => x.AsScoped(), typeof(Program));
}

WebApplication app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    
    app.MapOrderExtension();
    
    app.Run();
}