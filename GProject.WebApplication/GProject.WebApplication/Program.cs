using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using GProject.Data.DomainClass;
using GProject.Data.Context;
using GProject.WebApplication.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSession(c =>
{
    c.IOTimeout = TimeSpan.FromDays(1);
}
);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(c =>
{
    c.IOTimeout = TimeSpan.FromSeconds(20);
    c.Cookie.HttpOnly = true;
    c.Cookie.IsEssential = true;
}
            );
builder.Services.AddDbContext<GProjectContext>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
})
        .AddGoogle(yy =>
        {
            yy.ClientId = "157635440787-v046f76b5rm5h0dfreqic0ams7cn0qj1.apps.googleusercontent.com";
            yy.ClientSecret = "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";
        }).AddCookie(dd =>
        {
            dd.LoginPath = "/Account/login";
            dd.LogoutPath = "/Account/logout";
            dd.AccessDeniedPath = "/Account/AccessDenied";
        });

builder.Services.AddIdentity<Customer, IdentityRole>()
    .AddEntityFrameworkStores<GProjectContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IOAuthRepository, OAuthRepository>();
builder.Services.AddAuthorization();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAuthentication();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();