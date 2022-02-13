using ECommerce.Parsers;
using ECommerce.Parsers.Ozon;
using HttpClients = ECommerce.HttpClients;
using OzonHttpClients = ECommerce.HttpClients.Ozon;
using ResourceWebAppHttpClients = ECommerce.HttpClients.ResourceWebApp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<OzonHttpClients.CategoryHttpClient>();
builder.Services.AddSingleton<OzonHttpClients.HomeHttpClient>();
builder.Services.AddSingleton<OzonHttpClients.ListingHttpClient>();
builder.Services.AddSingleton<OzonHttpClients.ProductHttpClient>();
builder.Services.AddSingleton<OzonHttpClients.OzonHttpContext>();

builder.Services.AddSingleton<ResourceWebAppHttpClients.CatalogHttpClient>();
builder.Services.AddSingleton<ResourceWebAppHttpClients.CategoryHttpClient>();
builder.Services.AddSingleton<ResourceWebAppHttpClients.ProductHttpClient>();
builder.Services.AddSingleton<ResourceWebAppHttpClients.ResourceWebAppHttpContext>();

builder.Services.AddSingleton<HttpClients.HttpContext>();

builder.Services.AddSingleton<HomeParser>();
builder.Services.AddSingleton<OzonParserContext>();

builder.Services.AddSingleton<ParserContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
        builder.WithOrigins("http://localhost:8080").AllowAnyMethod()
            .AllowAnyHeader().AllowCredentials());
});

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling =
        Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => type.ToString());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseCors("CorsPolicy");
app.UseAuthorization();
app.MapControllers();
app.Run();
