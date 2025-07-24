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
        Task AddAsync(StudentAccountRegistrationDTO dto);
        Task RegisterAccount(StudentAccountRegistrationDTO dto, int Id);
        Task<bool> SignIn(StudentAccountRegistrationDTO dto);
        Task Logout();
    }
}
