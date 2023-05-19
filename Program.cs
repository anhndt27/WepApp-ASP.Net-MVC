using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAppFinal.BusinessLayer.DTOs.MapperDto;
using WebAppFinal.Data;
using WebAppFinal.DataLayer.Context;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.Extensions;
using WebAppFinal.Extentions;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppIdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'AppIdentityContextConnection' not found.");

builder.Services.AddDbContext<AppIdentityContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppIdentityContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(c => c.AddProfile<MapCourseProfile>(), typeof(Program));

builder.Services.AddServices();
var app = builder.Build();



/*
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseErrorLogging();
app.Use(async (context, next) =>
{
    await next();

    if (context.Response.StatusCode == 404)
    {
        context.Response.Redirect("/Home/Error");
        context.Response.ContentLength = 0;
    }
});*/
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
