using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class LoanViewModel
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Amount")]
        public double Amount { get; set; }

        [Required]
        [StringLength(12)]
        public int Months { set; get; }

    }
}