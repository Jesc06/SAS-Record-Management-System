using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SAS_Record_Management_System.Infrastructure.Persistence.Data;
using SAS_Record_Management_System.Infrastructure.Features;
using SAS_Record_Management_System.Application.Features.ViewAllStudentAccount.Interfaces;
using SAS_Record_Management_System.Infrastructure.Features.ViewAllStudentAccount;
using SAS_Record_Management_System.Application.Mappings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


builder.Services.AddScoped<IGetAllAccounts,GetAllAccountsRepository>();
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);


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
    pattern: "{controller=Request}/{action=request}/{id?}"
);

app.Run();
