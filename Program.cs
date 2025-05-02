using InventoryAPI.Data;
using InventoryAPI.Repositories;
using InventoryAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<TransactionRepository>();
builder.Services.AddScoped<ProductService>(); // Para Swagger
// builder.Services.AddSwaggerGen();           // Documentación API
builder.Services.AddDbContext<InventoryDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// ✅ 4. Configurar middleware
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

app.UseHttpsRedirection();
app.UseRouting();         
app.UseCors("AllowAll");   
app.UseAuthorization();   

app.MapControllers();     


app.Run();