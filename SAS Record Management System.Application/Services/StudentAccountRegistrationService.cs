using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS_Record_Management_System.Application.Interfaces;
using SAS_Record_Management_System.Domain.Entities;
using SAS_Record_Management_System.Application.DTOs;

namespace SAS_Record_Management_System.Application.Services
{
    public class StudentAccountRegistrationService
    {
        private readonly IstudentAccountRegistration _studentAccountRegistration;
        public StudentAccountRegistrationService(IstudentAccountRegistration studentAccountRegistration)
        {
            _studentAccountRegistration = studentAccountRegistration;
        }


        public async Task<bool> RegisterAccountAsync(StudentAccountRegistration model)
        {
            await _studentAccountRegistration.AddAsync(model);
            return true;
        }



    }
}
