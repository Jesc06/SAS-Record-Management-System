using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SAS_Record_Management_System.Domain.Entities.Account;

namespace SAS_Record_Management_System.Infrastructure.Persistence.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserAccountRegistrationCredentials>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<StudentAccountRegistration> StudentAccountRegistrations_Db { get; set; }
    }
}
