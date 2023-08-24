using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using OmniAPI.Data;
using OmniAPI.Main.DataAccess;
using OmniAPI.Main.Services;
using System.Reflection;
//TODO common using file
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(options =>
{
    //options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    //{
    //    Type = SecuritySchemeType.OAuth2,
    //    Flows = new OpenApiOAuthFlows
    //    {
    //        ClientCredentials = new OpenApiOAuthFlow
    //        {
    //            TokenUrl = new Uri("https://localhost:5001/connect/token"),
    //            Scopes = new Dictionary<string, string>
    //            {
    //                { "omniapi", "Access to Omni API" },
    //            }
    //        }
    //    }
    //});
    //options.AddSecurityRequirement(new OpenApiSecurityRequirement
    //{
    //    {
    //        new OpenApiSecurityScheme
    //        {
    //            Reference = new OpenApiReference
    //            {
    //                Id = "oauth2", //The name of the previously defined security scheme.
    //                Type = ReferenceType.SecurityScheme
    //            }
    //        },new List<string>()
    //    }
    //});
});

builder.Services.AddCors();

builder.Services.AddDbContext<OmniContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("OmniConnection"))
    .EnableSensitiveDataLogging()
    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = "https://localhost:5001";//identity provider
        options.TokenValidationParameters.ValidateAudience = false;//można określać dla kogo jest token ale nie jest częścią standardu 
        options.TokenValidationParameters.ValidTypes = new[] { "at+jwt" };
    });
//builder.Services.AddIdentity<User, IdentityRole>()
//    .AddEntityFrameworkStores<OmniContext>();
//builder.Services.Configure<IdentityOptions>(options =>
//{
//    options.Password.RequiredLength = 8;
//    options.Password.RequireNonAlphanumeric = true;
//    options.Password.RequireLowercase = true;
//    options.Password.RequireUppercase = true;
//    options.Password.RequireDigit = true;
//    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZąćęłńóśźżĄĆĘŁŃÓŚŹŻ";
//    options.User.RequireUniqueEmail = true;
//});

builder.Services.AddScoped(typeof(IMovieRepository), typeof(MovieRespository));
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddScoped(typeof(JWTService));
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => options
    .WithOrigins(new[] {"http://localhost:3000", "http://localhost:5555", "http://localhost:4444"}  )
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
); 

app.UseAuthorization();
app.MapControllers();
app.Run();
