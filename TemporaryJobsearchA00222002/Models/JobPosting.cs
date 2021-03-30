using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemporaryJobsearchA00222002.Models
{
    public class JobPosting
    {
        public int ID { get; set; }

        [Display(Name = "Job Name")]
        public string JobName { get; set; }

        [Display(Name = "Salary")]
        public string Salary { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Job Specification")]
        [StringLength(4000)]
        public string JobSpecifications { get; set; }

        [Display(Name = "Job Requirment")]
        public string jobRequirment { get; set; }

        [Display(Name = "Company Number")]
        [Phone]
        public string CompanyNumber { get; set; }
    }
}
