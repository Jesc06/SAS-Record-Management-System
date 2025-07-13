using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SAS_Record_Management_System.Application.Interfaces;
using SAS_Record_Management_System.Application.Services;
using SAS_Record_Management_System.Infrastructure.Data;
using SAS_Record_Management_System.Infrastructure.Repositories.StudentAccountRegistrationRepository;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IstudentAccountRegistration, StudentAccountRepository>();
builder.Services.AddScoped<StudentAccountRegistrationService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

builder.Services.AddIdentity<UserAccountRegistrationCredentials, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders()
    .AddRoles<IdentityRole>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Account}/{action=Login}/{id?}"
);

app.Run();
