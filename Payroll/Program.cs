using Microsoft.EntityFrameworkCore;
using PayrollApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PayrollApp.Data.PayrollContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("PayrollContext")));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    PayrollApp.Areas.ContributionsData.Models.SeedData.Initialize(services);
    PayrollApp.Areas.EmploymentData.Models.SeedData.Initialize(services);
    PayrollApp.Areas.HoursData.Models.SeedData.Initialize(services);
    PayrollApp.Areas.PayrollData.Models.SeedData.Initialize(services);
    PayrollApp.Areas.ReimbursementsData.Models.SeedData.Initialize(services);
    PayrollApp.Areas.TaxData.Models.SeedData.Initialize(services);
    PayrollApp.Areas.ThirdPartiesData.Models.SeedData.Initialize(services);
}

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

new List<string>() {
    "Employment",
    "ThirdParties",
    "Contributions",
    "Reimbursements",
    "Hours",
    "Payroll",
    "Person",
    "Tax",
}.ForEach((string area) => app.MapAreaControllerRoute(
    name: $"{area}",
    areaName: $"{area}Data",
    pattern: $"{area}/{{controller=Home}}/{{action=Index}}/{{id?}}"));

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

