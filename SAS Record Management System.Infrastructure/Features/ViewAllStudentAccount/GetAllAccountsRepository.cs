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
using SAS_Record_Management_System.Domain.Entities.Account;

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

        public async Task<List<StudentAccountRegistrationDTO>> GetAllAccounts()
        {
      
            return await _context.StudentAccountRegistrations_Db.Select(x => new StudentAccountRegistrationDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                Middlename = x.Middlename,
                LastName = x.LastName,
                Gender = x.Gender,
                YearOfBirth = x.YearOfBirth,
                MonthOfBirth = x.MonthOfBirth,
                DateOfBirth = x.DateOfBirth,
                HomeAddress = x.HomeAddress,
                MobileNumber = x.MobileNumber,
                Email = x.Email,
                Program = x.Program,
                YearLevel = x.YearLevel,
                StudentID = x.StudentID,
                Password = x.Password,
            }).ToListAsync();

        }



    }
}
