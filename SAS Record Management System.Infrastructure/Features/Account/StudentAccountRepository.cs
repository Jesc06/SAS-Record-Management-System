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
using Microsoft.AspNetCore.Identity;



namespace SAS_Record_Management_System.Infrastructure.Features.Account
{
    public class StudentAccountRepository : IstudentAccountRegistration
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<UserAccountRegistrationCredentials> _userManager;
        private readonly SignInManager<UserAccountRegistrationCredentials> _signInManager;
        public StudentAccountRepository(SignInManager<UserAccountRegistrationCredentials> signInManager, UserManager<UserAccountRegistrationCredentials> userManager, IMapper mapper, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }
          
        public async Task AddAsync(StudentAccountRegistrationDTO dto)
        {
            var domain = _mapper.Map<StudentAccountRegistration>(dto);
            await _context.StudentAccountRegistrations_Db.AddAsync(domain);
            await _context.SaveChangesAsync();
        }


        public async Task RegisterAccount(StudentAccountRegistrationDTO dto, int Id)
        {
            UserAccountRegistrationCredentials user = new UserAccountRegistrationCredentials
            {
                FirstName = dto.FirstName,
                Middlename = dto.Middlename,
                LastName = dto.LastName,
                Email = dto.Email,
                UserName = dto.Email
            };

            var Register = await _userManager.CreateAsync(user,dto.Password);

            if (Register.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Student");

                var CurrentRegisterAccount = _context.StudentAccountRegistrations_Db.Find(Id);
                if (CurrentRegisterAccount != null)
                {
                   _context.StudentAccountRegistrations_Db.Remove(CurrentRegisterAccount);
                   await _context.SaveChangesAsync();
                }
            }        
        }

        public async Task<bool> SignIn(StudentAccountRegistrationDTO dto)
        {
            var SignInAccount = await _signInManager.PasswordSignInAsync(dto.Email, dto.Password, true, lockoutOnFailure: false);
            return SignInAccount.Succeeded;
        }


        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }



    }
}
