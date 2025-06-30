var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Root Page!");
app.MapGet("/about", () => "About Page!");
app.MapPut("/", () => "This is a put");
app.MapDelete("/", () => "This is an Delete");

app.Run();
