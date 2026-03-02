using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DIT.MVC.Data;
using DIT.MVC.Areas.Identity.Data;
using dit.database.net;
using dit.services;
using Microsoft.AspNetCore.Identity.UI.Services;
using DIT.MVC.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");
var emailEnabledString = builder.Configuration.GetValue<string>("emailenabled") ?? throw new InvalidOperationException("EmailEnabled setting not found.");
var connectionStringDIT = builder.Configuration.GetConnectionString("DITConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");
builder.Services.AddLogging(logger => {
    logger.AddConsole();
});
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
if(emailEnabledString != null && emailEnabledString == "true")
    builder.Services.AddTransient<IEmailSender, EmailSenderService>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySQL(connectionString));
builder.Services.AddDbContext<dit.database.net.DitDbContext>(options =>
    options.UseMySQL(connectionStringDIT));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddTransient<IClubService, Club>();

builder.Services.AddDefaultIdentity<DITUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseMigrationsEndPoint();
//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    //db.Database.Migrate();
}
app.Run();
