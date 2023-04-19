using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
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
        });

builder.Services.AddIdentity<Customer, IdentityRole>()
    .AddEntityFrameworkStores<GProjectContext>()
    .AddDefaultTokenProviders();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}


app.Run();