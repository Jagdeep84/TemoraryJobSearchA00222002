using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemporaryJobsearchA00222002.Models
{
    public class Employer
    {
        public int ID { get; set; }
        [Display(Name = "Employer Name")]
        public string EmployerName { get; set; }

        [Display(Name = "Post")]
        public string EmployerPost { get; set; }

        [Display(Name = "Self Description")]
        [StringLength(4000)]
        public string Description { get; set; }

        [Display(Name = "Contact Number")]
        [Phone]
        public string ContactNumber { get; set; }
    }
}
