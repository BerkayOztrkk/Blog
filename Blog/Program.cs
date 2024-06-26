using Blog.Data.Context;
using Blog.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Blog.Service.Extensions;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;



var builder = WebApplication.CreateBuilder(args);

builder.Services.LoadDataExtension(builder.Configuration);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.LoadServiceExtension();
builder.Services.AddSession();


builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric=false;
    opt.Password.RequireLowercase=false;
    opt.Password.RequireUppercase=false;


})
    .AddRoleManager<RoleManager<AppRole>>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath=new PathString("/Admin/Auth/Login");
    config.LogoutPath=new PathString("/Admin/Auth/Logout");
    config.Cookie=new CookieBuilder
    {
        Name="Blog",
        HttpOnly=true,
        SameSite=SameSiteMode.Strict,
        SecurePolicy=CookieSecurePolicy.SameAsRequest


    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan=TimeSpan.FromDays(1);
    config.AccessDeniedPath=new PathString("/Admin/Auth/AccesDenied");


});
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
app.UseSession();
app.UseRouting();


app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
        );
    endpoints.MapDefaultControllerRoute();
});

app.Run();
