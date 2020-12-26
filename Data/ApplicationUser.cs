using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public override string UserName { get; set; }

        [Required]
        public override string Email { get; set; }

        [StringLength(64, MinimumLength = 3)]
        public string FirstName { get; set; }

        [StringLength(64, MinimumLength = 3)]
        public string LastName { get; set; }
    }
}
