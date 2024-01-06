using Microsoft.EntityFrameworkCore;
using MVCApp.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
//adding db con string from appsettings
var conn = builder.Configuration.GetConnectionString("SchoolmanagementDBConnection");
builder.Services.AddDbContext<SchoolmanagementDbContext>(q => q.UseSqlServer(conn));
builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
