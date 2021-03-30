using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemporaryJobsearchA00222002.Models
{
    public class Resume
    {
        public int ID { get; set; }

        [Display(Name = "Applicant Name")]
        public string ApplicantNmae { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "Contact Number")]
        [Phone]
        public string ContctNumber { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Objective")]
        [StringLength(4000)]
        public string Objective { get; set; }

        [Display(Name = "Education")]
        [StringLength(4000)]
        public string Education { get; set; }

        [Display(Name = "Experincer")]
        [StringLength(4000)]
        public string Experience { get; set; }

        [Display(Name = "Skill")]
        [StringLength(4000)]
        public string Skill { get; set; }

        [Display(Name = "Activities")]
        [StringLength(4000)]
        public string Activities { get; set; }


    }
}
