using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS_Record_Management_System.Application.Interfaces;
using SAS_Record_Management_System.Infrastructure.Data;
using SAS_Record_Management_System.Domain.Entities;
using SAS_Record_Management_System.Application.DTOs;


namespace SAS_Record_Management_System.Infrastructure.Repositories.StudentAccountRegistrationRepository
{
    public class StudentAccountRepository : IstudentAccountRegistration
    {
        private readonly ApplicationDbContext _context;
        public StudentAccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(StudentAccountRegistrationDTO modelDomain)
        {
            StudentAccountRegistration domain = new StudentAccountRegistration
            {
                FirstName = modelDomain.FirstName,
                Middlename = modelDomain.Middlename,
                LastName = modelDomain.LastName,
                Gender = modelDomain.Gender,
                YearOfBirth = modelDomain.YearOfBirth,
                MonthOfBirth = modelDomain.MonthOfBirth,
                DateOfBirth = modelDomain.DateOfBirth,
                HomeAddress = modelDomain.HomeAddress,
                MobileNumber = modelDomain.MobileNumber,
                Email = modelDomain.Email,
                Program = modelDomain.Program,
                YearLevel = modelDomain.YearLevel,
                StudentID = modelDomain.StudentID,
                Password = modelDomain.Password,
                ConfirmPassword = modelDomain.ConfirmPassword
            };
            await _context.StudentAccountRegistrations.AddAsync(domain);
            await _context.SaveChangesAsync();
        }

    }
}
