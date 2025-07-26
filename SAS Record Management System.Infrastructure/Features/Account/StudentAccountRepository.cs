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
          
        public async Task AddAccountAsync(StudentAccountRegistrationDTO dtoAddAccount)
        {
            var domain = _mapper.Map<StudentAccountRegistration>(dtoAddAccount);
            await _context.StudentAccountRegistrations_Db.AddAsync(domain);
            await _context.SaveChangesAsync();
        }


        public async Task RegisterAccount(StudentAccountRegistrationDTO dtoRegister, int Id)
        {
            UserAccountRegistrationCredentials user = new UserAccountRegistrationCredentials
            {
                FirstName = dtoRegister.FirstName,
                Middlename = dtoRegister.Middlename,
                LastName = dtoRegister.LastName,
                Email = dtoRegister.Email,
                UserName = dtoRegister.Email
            };

            var Register = await _userManager.CreateAsync(user, dtoRegister.Password);

            if (Register.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Student");

                //Remove Account from StudentRegistration table in admin after successfully transfer data into Asp.Net Users
                var CurrentRegisterAccount = _context.StudentAccountRegistrations_Db.Find(Id);
                if (CurrentRegisterAccount != null)
                {
                   _context.StudentAccountRegistrations_Db.Remove(CurrentRegisterAccount);
                   await _context.SaveChangesAsync();
                }
            }        
        }


        public async Task<bool> SignIn(StudentAccountRegistrationDTO dtoSignIn)
        {
            var SignInAccount = await _signInManager.PasswordSignInAsync(dtoSignIn.Email, dtoSignIn.Password, true, lockoutOnFailure: false);
            return SignInAccount.Succeeded;
        }


        public async Task<bool> VerifyEmail(StudentAccountRegistrationDTO dtoVerify)
        {
            var user = await _userManager.FindByNameAsync(dtoVerify.Email);
            if(user == null)
            {
                return false;
            }
            return true;
        }



        public async Task<bool> ChangePassword(StudentAccountRegistrationDTO dtoChangepass)
        {
            return true;
        }



        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }



    }
}
