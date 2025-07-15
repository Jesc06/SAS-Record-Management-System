using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS_Record_Management_System.Application.Interfaces;
using SAS_Record_Management_System.Infrastructure.Data;
using SAS_Record_Management_System.Domain.Entities;
using SAS_Record_Management_System.Application.DTOs;
using AutoMapper;


namespace SAS_Record_Management_System.Infrastructure.Repositories.StudentAccountRegistrationRepository
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
