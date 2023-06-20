using Microsoft.EntityFrameworkCore;
using OmniAPI.Main.DataAccess;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<OmniAPI.Data.OmniContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("OmniConnection"))
    .EnableSensitiveDataLogging()
    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

builder.Services.AddScoped(typeof(IMovieRepository), typeof(MovieRespository));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
