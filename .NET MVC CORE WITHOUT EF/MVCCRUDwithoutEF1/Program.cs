using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCCRUDwithoutEF1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCCRUDwithoutEF1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCCRUDwithoutEF1Context") ?? throw new InvalidOperationException("Connection string 'MVCCRUDwithoutEF1Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
