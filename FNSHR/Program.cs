using FNSHR.Data;
using FNSHR.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//var cs = builder.Configuration.GetConnectionString("Default");
//builder.Services.AddDbContext<dataContext>(options => options.UseSqlServer(cs));

//builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
//{
  //  options.Password.RequireDigit = false;
    //options.Password.RequiredLength = 5;
    //options.Password.RequireLowercase = false;
//});

builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<AppDbContext>();
builder.Services.AddSingleton<toDoService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
