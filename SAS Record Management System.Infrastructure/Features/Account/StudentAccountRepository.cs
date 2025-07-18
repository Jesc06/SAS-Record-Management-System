using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SAS_Record_Management_System.Domain.Entities.Account;
using SAS_Record_Management_System.Infrastructure.Persistence.Data;
using SAS_Record_Management_System.Application.Features.Account.DTO;
using SAS_Record_Management_System.Application.Features.Account.Interfaces;


namespace SAS_Record_Management_System.Infrastructure.Features.Account
{
    public class StudentAccountRepository : IstudentAccountRegistration
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public StudentAccountRepository(IMapper mapper, ApplicationDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }
          
        public async Task AddAsync(StudentAccountRegistrationDTO modelDomain)
        {
            var domain = _mapper.Map<StudentAccountRegistration>(modelDomain);
            await _context.StudentAccountRegistrations_Db.AddAsync(domain);
            await _context.SaveChangesAsync();
        }


    }
}
