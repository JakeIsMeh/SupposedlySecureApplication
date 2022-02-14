using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace SupposedlySecureApplication.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Required]
        public string FirstName { get; set; }

        [PersonalData]
        [Required]
        public string LastName { get; set; }
        
        [PersonalData]
        public DateTime lastLoginTime { get; set; }
        
        [PersonalData]
        public string lastLoginIp { get; set; }
        
        [PersonalData]
        [Required]
        public CreditCard creditCard { get; set; } 
        
        [PersonalData]
        public DateTime dateOfBirth { get; set; }
        
        [PersonalData]
        public byte[] photo { get; set; }
    }
}