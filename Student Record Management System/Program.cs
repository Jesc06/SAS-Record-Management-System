using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SAS_Record_Management_System.Application.Mappings;
using Student_Record_Management_System.Mappings;
using SAS_Record_Management_System.Infrastructure.Persistence.Data;
using SAS_Record_Management_System.Application.Features.Account.Interfaces;
using SAS_Record_Management_System.Application.Features.Account.Services;
using SAS_Record_Management_System.Infrastructure.Features.Account;
using SAS_Record_Management_System.Infrastructure.Identity;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(ViewMappingProfile));

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IstudentAccountRegistration, StudentAccountRepository>();
builder.Services.AddScoped<StudentAccountRegistrationService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

builder.Services.AddIdentity<UserAccountRegistrationCredentials, IdentityRole>(option => 
{
    option.Password.RequireDigit = false;
    option.Password.RequireLowercase = false;
    option.Password.RequireUppercase = false;
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequiredLength = 3;
})
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


using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<UserAccountRegistrationCredentials>>();
    await RolesSeed.Seeder(roleManager, userManager);
}


app.Run();
