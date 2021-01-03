using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.ViewModels
{
    public class PerdoruesiCreateViewModel
    {
        [Required(ErrorMessage = "Plotësoni fushën")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Plotësoni fushën")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Plotësoni fushën")]
        public virtual string Email { get; set; }

        [RequiredEx(IsRequired = true)]
        [DataType(DataType.Password)]
        public virtual string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Konfirmo fjalekalimin")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Fjalekalimet nuk perputhen")]
        public virtual string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Plotësoni fushën")]
        public virtual string RoleId { get; set; }

        [RegularExpression(@"^([+]3[83]{1}[0-9]{9})$", ErrorMessage = "Invalid phone number")]
        [Required(ErrorMessage = "Plotësoni fushën")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Plotësoni fushën")]
        public string Address { get; set; }
    }

    public class RequiredExAttribute : RequiredAttribute
    {
        public bool IsRequired { get; set; }

        public override bool IsValid(object value)
        {
            if (IsRequired)
                return base.IsValid(value);
            else
            {
                return true;
            }
        }

        public override bool RequiresValidationContext
        {
            get
            {
                return IsRequired;
            }
        }
    }
}
