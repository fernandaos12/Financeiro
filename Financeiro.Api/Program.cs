using Financeiro.Api.Data;
using Financeiro.Api.Repository;
using Financeiro.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connection = builder.Configuration.GetConnectionString("ConnectionMySql");
builder.Services.AddDbContext<ApiDbcontext>(o => o.UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.AddScoped<DbContext,ApiDbcontext>();
//builder.Services.AddScoped<IContasPagar,ContasPagarRepository>();
builder.Services.AddTransient<ContasPagarRepository>();
builder.Services.AddTransient<ContasReceberRepository>();
builder.Services.AddTransient<PagamentosRepository>();
builder.Services.AddTransient<CategoriasRepository>();
builder.Services.AddTransient<CartaoCreditoRepository>();
builder.Services.AddTransient<ReceitasRepository>();
builder.Services.AddTransient<TagsRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build();
                });
            });
var app = builder.Build();

app.UseRouting();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("EnableCORS");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
