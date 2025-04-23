using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Lis‰‰ controller-tuki
builder.Services.AddControllers();

var app = builder.Build();

// K‰ytet‰‰n routeja
app.MapControllers();

app.Run();
