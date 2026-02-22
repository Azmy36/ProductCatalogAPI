using Assignment2App.Interfaces;
using Assignment2App.Services;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    })
    .ConfigureApiBehaviorOptions(options =>
    {
        // Allow text/json content type
        options.SuppressConsumesConstraintForFormFileParameters = true;
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });

// Configure JSON input formatter to accept text/json
builder.Services.Configure<Microsoft.AspNetCore.Mvc.MvcOptions>(options =>
{
    var jsonInputFormatter = options.InputFormatters
        .OfType<SystemTextJsonInputFormatter>()
        .FirstOrDefault();
    
    if (jsonInputFormatter != null)
    {
        jsonInputFormatter.SupportedMediaTypes.Add("text/json");
    }
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Allow CORS so Swagger UI and other clients can call the API
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Register our services
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // In Development, don't redirect HTTP to HTTPS so Swagger/curl on http://localhost:5000 work without cert issues
}
else
{
    app.UseHttpsRedirection();
}
app.UseCors();
app.UseAuthorization();
app.MapControllers();

app.Run();
