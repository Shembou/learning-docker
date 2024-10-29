using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Site_Api.DbContexts;
using Site_Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var FrontEndOrigins = "_frontEndOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: FrontEndOrigins,
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:3000", "http://localhost:4000")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AuthenticationRepository>();
builder.Services.AddScoped<ShowsRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();

app.UseCors(FrontEndOrigins);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ApplicationDbContext>();
    if (context.Database.GetPendingMigrations().Any())
    {
        context.Database.Migrate();
    }
}

app.Run();
