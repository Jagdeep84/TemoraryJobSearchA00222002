using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemporaryJobsearchA00222002.Models
{
    public class Candidate
    {
     
        public int ID { get; set; }

        [Display(Name = "Candidate Name")]
        public String CandidateName {get; set;}

        [Display(Name = "Education")]
        public String Education { get; set; }

        [Display(Name = "Self Description")]
        [StringLength(4000)]
        public String Description { get; set; }

        [Display(Name = "Contact Number")]
        [Phone]
        public string ContactNumber { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = " Region")]
        public string Region { get; set; }

        [Display(Name = "Postal Code ")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }
    }
}
