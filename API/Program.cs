using System.Text;
using API.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//This is the main entry point into our application 
builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);




var app = builder.Build();

// Configure the HTTP request pipeline.
//when a request runs in the pipeline, we can run software or code as it comes into it's way in the API server

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod()
        .WithOrigins("https://localhost:4200"));

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
