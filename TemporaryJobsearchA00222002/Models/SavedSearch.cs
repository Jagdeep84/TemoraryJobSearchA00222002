using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemporaryJobsearchA00222002.Models
{
    public class SavedSearch
    {
        public int ID { get; set; }

        [Display(Name = "Job Name")]
        public string JobName { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
    }
}
