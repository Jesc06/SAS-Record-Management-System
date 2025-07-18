using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS_Record_Management_System.Application.Features.Account.DTO;


namespace SAS_Record_Management_System.Application.Features.ViewAllStudentAccount.Interfaces
{
    public interface IGetAllAccounts
    {
        Task<List<StudentAccountRegistrationDTO>> GetAllAccounts();
    }
}
