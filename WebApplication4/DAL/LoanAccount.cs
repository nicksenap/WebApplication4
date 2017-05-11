using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class LoanAccount
    {
        [Key]
        public int Id { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; set; }
        public int Months { get; set; }
        public double LimitAmount { set; get; }
        // The Max you can get.

        public double TotalPayedAmountIn { set; get; }
        public double TotalPayedAmountOut { set; get; }

        public LoanAccoutType Type { set; get; }
        public LoanAccountStatus Status { set; get; }

        public double Apr { get; set; }
        public int Risk { get; set; }

        public virtual List<Loan> Loans { set; get; }
        public virtual P2PUser User { set; get; }
        
    }

   
}