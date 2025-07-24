using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SAS_Record_Management_System.Infrastructure.Persistence.Data
{
    public class UserAccountRegistrationCredentials : IdentityUser
    {
        public string FirstName { get; set; }
        public string Middlename { get; set; }
        public string LastName { get; set; }
    }
}
