using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Assignment2.Data;
using Assignment2.Areas.Identity.Data;
using Assignment2.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Assignment2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerManagementConnString")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<Assignment2Context>();

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Authorization

AddAuthorizationPolicies(builder.Services);

#endregion

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();


void AddAuthorizationPolicies(IServiceCollection services)
{
    services.AddAuthorization(options =>
    {
        options.AddPolicy(Constants.Policies.RequireCustomer, policy => policy.RequireRole(Constants.Roles.Customer));
        options.AddPolicy(Constants.Policies.RequireManager, policy => policy.RequireRole(Constants.Roles.Manager));
        options.AddPolicy(Constants.Policies.RequireReception, policy => policy.RequireRole(Constants.Roles.Reception));
        options.AddPolicy(Constants.Policies.RequireHousekeeper, policy => policy.RequireRole(Constants.Roles.Housekeeper));
    });
}
