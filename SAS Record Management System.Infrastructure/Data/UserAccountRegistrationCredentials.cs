using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SAS_Record_Management_System.Infrastructure.Data
{
    public class UserAccountRegistrationCredentials : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string Middlename { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; }
        public required int YearOfBirth { get; set; }
        public required string MonthOfBirth { get; set; }
        public required int DateOfBirth { get; set; }
        public required string HomeAddress { get; set; }
        public required string MobileNumber { get; set; }
        public required string Email { get; set; }
        public required string Program { get; set; }
        public required string YearLevel { get; set; }  
        public required string StudentID { get; set; }
        public required string Password { get; set; }
        public required string ConfirmPassword { get; set; }
    }
}
