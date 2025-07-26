using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS_Record_Management_System.Application.Features.Account.DTO;

namespace SAS_Record_Management_System.Application.Features.Account.Interfaces
{
    public interface IstudentAccountRegistration
    {   
        Task AddAccountAsync(StudentAccountRegistrationDTO dtoAddAccount);
        Task RegisterAccount(StudentAccountRegistrationDTO dtoRegister, int Id);
        Task<bool> VerifyEmail(StudentAccountRegistrationDTO dtoVerify);
        Task<bool> ChangePassword(StudentAccountRegistrationDTO dtoChangepass);
        Task<bool> SignIn(StudentAccountRegistrationDTO dtoSignIn);
        Task Logout();
    }
}
