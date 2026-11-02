using Homework03;
var builder=WebApplication.CreateBuilder(args); builder.Services.AddSingleton<IProductRepository,InMemoryProductRepository>(); var app=builder.Build(); app.MapGet("/products",(IProductRepository r)=>Results.Ok(r.GetAll())); app.Run();
