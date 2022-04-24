using App.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = "server=localhost;port=9000;user=root;password=example;database=finalProject";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
builder.Services.AddDbContext<AppDbContext>(
    dbContextOptions => dbContextOptions
        .UseMySql(connectionString, serverVersion)
        .LogTo(Console.Write, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors()
);
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.Use(async (context, next) => {
    Console.WriteLine("MW 1 ===>");
    await next();
    Console.WriteLine("<=== MW 1");
});
app.Use(async (context, next) => {
    Console.WriteLine("MW 2 ===>");
    await next();
    Console.WriteLine("<=== MW 2");
});

app.MapControllerRoute(
    name: "raceList",
    defaults: new { controller = "Races", action = "List" },
    pattern: "/races");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
using (var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<AppDbContext>().Database.EnsureCreated();
    // TODO SEED DATA
}
app.Run();

// docker-compose-v1.exe up --build
// dotnet ef database drop