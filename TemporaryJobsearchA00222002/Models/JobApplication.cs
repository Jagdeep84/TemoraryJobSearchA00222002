using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemporaryJobsearchA00222002.Models
{
    public class JobApplication
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Postal Code ")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [Display(Name = "Contact Number")]
        [Phone]
        public string Phonenumber { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Emailaddress { get; set; }

        [Display(Name = "Social Security Number")]
        public int SocialSecurityNumber { get; set; }

    }
}
