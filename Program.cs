var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", () =>
{
    return Results.File("./index.html", "text/html");
});

app.MapGet("/api/datetime", () =>
{
    var dateTime = DateTime.Now.ToString();
    return Results.Text(dateTime, "text/html");
});

app.Run();
