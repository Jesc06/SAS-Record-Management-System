using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS_Record_Management_System.Application.Interfaces;
using SAS_Record_Management_System.Infrastructure.Data;
using SAS_Record_Management_System.Domain.Entities;


namespace SAS_Record_Management_System.Infrastructure.Repositories.StudentAccountRegistrationRepository
{
    
    public class StudentAccountRepository : IstudentAccountRegistration
    {
        private readonly ApplicationDbContext _context;
        public StudentAccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(StudentAccountRegistration modelDomain)
        {
            await _context.StudentAccountRegistrations.AddAsync(modelDomain);
            await _context.SaveChangesAsync();
        }

    }
}
