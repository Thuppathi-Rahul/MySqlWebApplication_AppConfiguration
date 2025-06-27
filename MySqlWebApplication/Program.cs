using Microsoft.Extensions.Azure;
using MySqlWebApplication.Services;

var builder = WebApplication.CreateBuilder(args);

//var connectionstring = "Endpoint=https://appconfig8900.azconfig.io;Id=9NiR;Secret=/S4arzLmh9z1JJOdUWW6byaj1XpImtkh4Xc6yqeXk+8=";

//builder.Host.ConfigureAppConfiguration(builder => {

   // builder.AddAzureAppConfiguration(connectionstring);
//});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IProductService, ProductService>();


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
