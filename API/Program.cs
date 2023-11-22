var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//This is the main entry point into our application 
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
//when a request runs in the pipeline, we can run software or code as it comes into it's way in the API server

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
