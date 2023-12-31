using SearchService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

try 
{
    await DbInitializer.InitDb(app);
} 
catch (System.Exception e)
{
    Console.WriteLine(e);
}

app.Run();
