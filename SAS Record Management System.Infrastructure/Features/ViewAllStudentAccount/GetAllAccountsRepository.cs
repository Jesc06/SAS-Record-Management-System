using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS_Record_Management_System.Application.Features.ViewAllStudentAccount.Interfaces;
using SAS_Record_Management_System.Infrastructure.Persistence.Data;
using SAS_Record_Management_System.Application.Features.Account.DTO;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace SAS_Record_Management_System.Infrastructure.Features.ViewAllStudentAccount
{
    public class GetAllAccountsRepository : IGetAllAccounts
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GetAllAccountsRepository(IMapper mapper, ApplicationDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StudentAccountRegistrationDTO>> GetAllAccounts()
        {
            return await _context.StudentAccountRegistrations_Db.ProjectTo<StudentAccountRegistrationDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }


    }
}
