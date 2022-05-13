using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using TBR.Infrastructure.GoogleBookAPI;

var builder = WebApplication.CreateBuilder(args);
var TBRApiKey = builder.Configuration["TBR:UserApiKey"];

// Add services to the container.

    builder.Services.AddAuthentication(options =>
      {
          options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
          options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
      })
     .AddCookie()
    .AddGoogle(googleOptions =>
    {
    googleOptions.ClientId = builder.Configuration["Authentication:Google:ClientId"];
    googleOptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
    googleOptions.SaveTokens = true;
    });

   builder.Services.AddControllersWithViews();
   builder.Services.AddRazorPages();
builder.Services.AddTransient<IGoogleBookAPI, GoogleBookAPI>();
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

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
