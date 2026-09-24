var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy( policity =>
            {
                policity
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            }
        );
    }
);

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

var port = Environment.GetEnvironmentVariable("Port")??"10000";
app.Run($"http://0.0.0.0:{port}");
