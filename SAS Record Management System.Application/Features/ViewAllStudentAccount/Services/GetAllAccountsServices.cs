using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS_Record_Management_System.Application.Features.ViewAllStudentAccount.Interfaces;
using SAS_Record_Management_System.Application.Features.Account.DTO;

namespace SAS_Record_Management_System.Application.Features.ViewAllStudentAccount.Services
{
    public class GetAllAccountsServices 
    {
        private readonly IGetAllAccounts _getAllAccounts;
        public GetAllAccountsServices(IGetAllAccounts getAllAccounts)
        {
            _getAllAccounts = getAllAccounts;
        }

        public async Task<IEnumerable<StudentAccountRegistrationDTO>> GetAllAccountsAsync()
        {
            return await _getAllAccounts.GetAllAccounts();
        }


        public async Task<StudentAccountRegistrationDTO> GetId(int id)
        {
            return await _getAllAccounts.GetAccountById(id);
        }



    }
}
