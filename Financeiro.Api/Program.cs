using Financeiro.Application;
using Financeiro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionSql = builder.Configuration.GetConnectionString("ConnectionSqlServer") ?? throw new InvalidOperationException("Connection string não encontrada");
//var connection = builder.Configuration.GetConnectionString("ConnectionMySql");
//builder.Services.AddDbContext<ApiDbcontext>(o => o.UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionSql));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //adicionado automapper

builder.Services.AddScoped<DbContext, AppDbContext>();

builder.Services.AddApplicationServices();  //adicionando inj dependencia

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen();


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
app.UseSwagger();

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
