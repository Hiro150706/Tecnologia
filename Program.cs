var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/",() =>
{
     return "Api Tecnologia funcionando";
});
app.MapGet("/api/Tecnologia",() =>
{
    return Results.Ok(new[]
    {
        new{
            id=1,
            codigo="P001",
            nombre="Teclado",
        },
        new{
            id=2,
            codigo="P002",
            nombre="Mause",
        }
    });
});


app.Run();
