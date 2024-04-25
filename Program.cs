using Microsoft.EntityFrameworkCore;
using open_house_api_c_sharp.infra.data;
using open_house_api_c_sharp.infra.exceptions.interfaces;
using open_house_api_c_sharp.infra.exceptions.tratarExeption;
using open_house_api_c_sharp.infra.middlewares;
using open_house_api_c_sharp.modules.categoria.repository;
using open_house_api_c_sharp.modules.categoria.repository.interfaces;
using open_house_api_c_sharp.modules.categoria.service;
using open_house_api_c_sharp.modules.categoria.service.interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ConectionContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Connection")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<ICategoriaService, CategoriaService>();

builder.Services.AddTransient<IErrorResultTask, TratarNotFoundException>();
builder.Services.AddTransient<IErrorResultTask, TratarDbUpdateException>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware(typeof(GlobalErrorHandlingMiddleware));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();