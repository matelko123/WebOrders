using MediatR;
using WebOrders.Api.Handlers.Orders;
using WebOrders.Application;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
{
    ConfigurationManager config = builder.Configuration;
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    
    builder.Services.AddApplication(config);
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