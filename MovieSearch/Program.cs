using Contracts;
using Microsoft.Extensions.Options;
using Repositories;
using Repositories.Configurations;
using Services;
using Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<RepositoryContext>(provider =>
{
    var options = provider.GetService<IOptions<ImDbSettings>>();
    return new RepositoryContext(options);
});
builder.Services
    .Configure<ImDbSettings>(builder.Configuration
    .GetSection("ImDbSettings"));
builder.Services
    .AddScoped<IMovieRepository, MovieRepository>();
builder.Services
    .AddScoped<IMovieService, MovieService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
