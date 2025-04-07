using Financeiro.Api.Data;
using Financeiro.Api.Repository;
using Financeiro.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionSql = builder.Configuration.GetConnectionString("ConnectionSqlServer") ?? throw new InvalidOperationException("Connection string não encontrada");
//var connection = builder.Configuration.GetConnectionString("ConnectionMySql");
//builder.Services.AddDbContext<ApiDbcontext>(o => o.UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.AddDbContext<ApiDbcontext>(x => x.UseSqlServer(connectionSql));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //adicionado automapper

builder.Services.AddScoped<DbContext, ApiDbcontext>();

builder.Services.AddScoped<IContasPagar, ContasPagarRepository>();
builder.Services.AddScoped<ICategorias, CategoriasRepository>();
builder.Services.AddScoped<IPagamentos, PagamentosRepository>();
//builder.Services.AddScoped<IContasReceber, ContasReceberRepository>();
//builder.Services.AddScoped<IPagamentos, PagamentosRepository>();
//builder.Services.AddScoped<ICategorias, CategoriasRepository>();
//builder.Services.AddScoped<ICartaoCredito, CartaoCreditoRepository>();
//builder.Services.AddScoped<IReceitas, ReceitasRepository>();
//builder.Services.AddScoped<ITags, TagsRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Financeiro API",
        Version = "v1.0"
    });
    var xmlFile = "Financeiro.Api.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

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
