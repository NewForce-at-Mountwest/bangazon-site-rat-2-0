using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonSite.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string PhoneNumber { get; set; }
        public List<PaymentType> PaymentTypes { get; set; } = new List<PaymentType>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Product> Products { get; set; }
        public DateTime AccountCreated { get; set; }
        public DateTime LastActive { get; set; }


    }
}
