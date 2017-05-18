using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication4.DAL;

namespace WebApplication4.Models
{

    public class LoanViewModel
    {
        [Required]
        [Display(Name = "Amount")]
        public double Amount { get; set; }

        [Required]
        public int Months { set; get; }

        [Required]
        public JobType JobType { set; get; }

        [Required]
        public MaritalStatus MaritalStatus { set; get; }

        [Required]
        public LivingStatus LivingStatus { set; get; }

        [Required]
        public JobStatus JobStatus { set; get; }

        [Required]
        public  LoanCategory LoanCategory { set; get; }

    }
}