using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WebApplication1.entity;
using WebApplication1.NewFolder1;

var builder = WebApplication.CreateBuilder(args);
//use connection string 
builder.Services.AddDbContext<MovieContext>(options => options
.UseSqlServer(builder.Configuration.GetConnectionString("MovieDb")).ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning)));
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{ 
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<MovieContext>();
           await context.Database.MigrateAsync();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error has occured");
    }
    app.MapGet("/", () => "Hello World!");
    Console.WriteLine(builder.Configuration.GetConnectionString("MovieDb"));
    app.Run();

         }
