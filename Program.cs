var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

app.MapGet("/", () =>
{
    return "Api Tecnologia funcionando";
});

app.MapGet("/api/Tecnologia", () =>
{
    return Results.Ok(new[]
    {
        // TECLADOS
        new
        {
            id = 1,
            codigo = "P001",
            nombre = "Teclado Mecánico RGB",
            categoria = "Teclados",
            marca = "Redragon",
            precio = 159.90,
            stock = 15,
            descripcion = "Teclado mecánico con iluminación RGB y switches azules.",
            imagen = "https://images.unsplash.com/photo-1587829741301-dc798b83add3"
        },

        new
        {
            id = 2,
            codigo = "P002",
            nombre = "Teclado Gamer RGB",
            categoria = "Teclados",
            marca = "Logitech",
            precio = 189.90,
            stock = 10,
            descripcion = "Teclado gamer con iluminación RGB y diseño ergonómico.",
            imagen = "https://images.unsplash.com/photo-1595225476474-87563907a212"
        },

        // MOUSES
        new
        {
            id = 3,
            codigo = "P003",
            nombre = "Mouse Gamer RGB",
            categoria = "Mouses",
            marca = "Logitech",
            precio = 99.90,
            stock = 20,
            descripcion = "Mouse gamer con sensor óptico y 6 botones.",
            imagen = "https://images.unsplash.com/photo-1527814050087-3793815479db"
        },

        new
        {
            id = 4,
            codigo = "P004",
            nombre = "Mouse Inalámbrico",
            categoria = "Mouses",
            marca = "HP",
            precio = 69.90,
            stock = 25,
            descripcion = "Mouse inalámbrico compacto para oficina y estudio.",
            imagen = "https://images.unsplash.com/photo-1527864550417-7fd91fc51a46"
        },

        // MONITORES
        new
        {
            id = 5,
            codigo = "P005",
            nombre = "Monitor Gamer 24 pulgadas",
            categoria = "Monitores",
            marca = "LG",
            precio = 699.90,
            stock = 8,
            descripcion = "Monitor Full HD de 24 pulgadas con 144Hz.",
            imagen = "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf"
        },

        new
        {
            id = 6,
            codigo = "P006",
            nombre = "Monitor Gamer 27 pulgadas",
            categoria = "Monitores",
            marca = "Samsung",
            precio = 999.90,
            stock = 6,
            descripcion = "Monitor de 27 pulgadas con resolución Full HD y 165Hz.",
            imagen = "https://images.unsplash.com/photo-1616763355548-1b606f439f86"
        },

        // TARJETAS GRÁFICAS
        new
        {
            id = 7,
            codigo = "P007",
            nombre = "RTX 4060 8GB",
            categoria = "Tarjetas Gráficas",
            marca = "NVIDIA",
            precio = 1499.90,
            stock = 5,
            descripcion = "Tarjeta gráfica NVIDIA GeForce RTX 4060 con 8GB GDDR6.",
            imagen = "https://images.unsplash.com/photo-1591488320449-011701bb6704"
        },

        new
        {
            id = 8,
            codigo = "P008",
            nombre = "RTX 4070 12GB",
            categoria = "Tarjetas Gráficas",
            marca = "NVIDIA",
            precio = 2699.90,
            stock = 4,
            descripcion = "Tarjeta gráfica de alto rendimiento con 12GB GDDR6X.",
            imagen = "https://images.unsplash.com/photo-1555617981-dac3880eac6e"
        },

        // PROCESADORES
        new
        {
            id = 9,
            codigo = "P009",
            nombre = "Ryzen 5 5600G",
            categoria = "Procesadores",
            marca = "AMD",
            precio = 499.90,
            stock = 12,
            descripcion = "Procesador AMD Ryzen 5 con gráficos integrados.",
            imagen = "https://images.unsplash.com/photo-1591799264318-7e6ef8ddb7ea"
        },

        new
        {
            id = 10,
            codigo = "P010",
            nombre = "Intel Core i5 12400F",
            categoria = "Procesadores",
            marca = "Intel",
            precio = 599.90,
            stock = 10,
            descripcion = "Procesador Intel Core i5 de 12va generación.",
            imagen = "https://images.unsplash.com/photo-1555618568-17f7b7b6f5d1"
        },

        // MEMORIA RAM
        new
        {
            id = 11,
            codigo = "P011",
            nombre = "Memoria RAM 16GB DDR4",
            categoria = "Memorias RAM",
            marca = "Kingston",
            precio = 189.90,
            stock = 20,
            descripcion = "Memoria RAM DDR4 de 16GB para PC.",
            imagen = "https://images.unsplash.com/photo-1562976540-1502c2145186"
        },

        new
        {
            id = 12,
            codigo = "P012",
            nombre = "Memoria RAM 32GB DDR5",
            categoria = "Memorias RAM",
            marca = "Corsair",
            precio = 399.90,
            stock = 9,
            descripcion = "Kit de memoria RAM DDR5 de 32GB.",
            imagen = "https://images.unsplash.com/photo-1541029071515-84cc54f84dc5"
        },

        // ALMACENAMIENTO
        new
        {
            id = 13,
            codigo = "P013",
            nombre = "SSD 500GB",
            categoria = "Almacenamiento",
            marca = "Kingston",
            precio = 179.90,
            stock = 18,
            descripcion = "SSD de 500GB para mejorar la velocidad del equipo.",
            imagen = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b"
        },

        new
        {
            id = 14,
            codigo = "P014",
            nombre = "SSD NVMe 1TB",
            categoria = "Almacenamiento",
            marca = "Western Digital",
            precio = 329.90,
            stock = 14,
            descripcion = "SSD NVMe de 1TB de alta velocidad.",
            imagen = "https://images.unsplash.com/photo-1597848212624-e19a1c9b5b8f"
        },

        // PLACAS MADRE
        new
        {
            id = 15,
            codigo = "P015",
            nombre = "Placa Madre B550",
            categoria = "Placas Madre",
            marca = "MSI",
            precio = 499.90,
            stock = 7,
            descripcion = "Placa madre compatible con procesadores AMD Ryzen.",
            imagen = "https://images.unsplash.com/photo-1518770660439-4636190af475"
        },

        new
        {
            id = 16,
            codigo = "P016",
            nombre = "Placa Madre B660",
            categoria = "Placas Madre",
            marca = "ASUS",
            precio = 559.90,
            stock = 6,
            descripcion = "Placa madre para procesadores Intel de 12va generación.",
            imagen = "https://images.unsplash.com/photo-1591488320449-011701bb6704"
        },

        // FUENTES DE PODER
        new
        {
            id = 17,
            codigo = "P017",
            nombre = "Fuente de Poder 650W",
            categoria = "Fuentes",
            marca = "Corsair",
            precio = 329.90,
            stock = 11,
            descripcion = "Fuente de poder de 650W para equipos gamer.",
            imagen = "https://images.unsplash.com/photo-1625842268584-8f3296236761"
        },

        // GABINETES
        new
        {
            id = 18,
            codigo = "P018",
            nombre = "Gabinete Gamer RGB",
            categoria = "Gabinetes",
            marca = "Thermaltake",
            precio = 299.90,
            stock = 8,
            descripcion = "Gabinete gamer con panel lateral de vidrio y RGB.",
            imagen = "https://images.unsplash.com/photo-1587202372634-32705e3bf49c"
        },

        // AUDÍFONOS
        new
        {
            id = 19,
            codigo = "P019",
            nombre = "Audífonos Gamer",
            categoria = "Audio",
            marca = "HyperX",
            precio = 249.90,
            stock = 13,
            descripcion = "Audífonos gamer con micrófono incorporado.",
            imagen = "https://images.unsplash.com/photo-1599669454699-248893623440"
        },

        // WEBCAM
        new
        {
            id = 20,
            codigo = "P020",
            nombre = "Webcam Full HD",
            categoria = "Webcams",
            marca = "Logitech",
            precio = 229.90,
            stock = 10,
            descripcion = "Webcam Full HD para clases, reuniones y streaming.",
            imagen = "https://images.unsplash.com/photo-1587825140708-dfaf72ae4b04"
        }
    });
});

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";

app.Run($"http://0.0.0.0:{port}");
