using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSpotterAPI.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string? NameSurname { get; set; }
        public override string? UserName { get; set; } 
        public override string? Email { get; set; }

        public string? Password { get; set; }    

        public string? PasswordConfirm { get; set; }

    }
}


