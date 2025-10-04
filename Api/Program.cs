var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/hello", () => "hello store api");

app.Run();