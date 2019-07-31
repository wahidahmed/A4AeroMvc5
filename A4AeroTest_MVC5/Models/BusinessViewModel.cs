using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A4AeroTest_MVC5.Models
{
    public class BusinessViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }

        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Street { get; set; }
        public string City { get; set; }

      
        public string State { get; set; }

        [Display(Name = "Zip/Postal Code")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip must be than 5 charecter")]
        public string Zip { get; set; }
        public string Country { get; set; }

        [Display(Name = "Mobile number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{5})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{2})[-. ]?([0-9]{2})$", ErrorMessage = "Not a valid Mobile number")]
        public string Mobile { get; set; }

        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{2})[-. ]?([0-9]{2})$", ErrorMessage = "Not a valid Phone number")]
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string ReferredBy { get; set; }
        public string Logo { get; set; }
        public int? Status { get; set; }

        [Required(ErrorMessage = "Balance is required")]
        public decimal Balance { get; set; }

        public string LoginUrl { get; set; }

        public string SecurityCode { get; set; }
        public string SMTPServer { get; set; }
        public int? SMTPPort { get; set; }
        public string SMTPUsername { get; set; }
        public string SMTPPassword { get; set; }

        public bool Deleted { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}