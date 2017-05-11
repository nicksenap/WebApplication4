using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class InvestmentPayment
    {
        [Key]
        public int Id { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; set; }
        public InvestmentPaymentStatus Status { set; get; }
        public InvestmentPaymentType Type { set; get; }
        public double PrincipalAmount { set; get; }
        public double InterestAmount { set; get; }
        public double TotalAmount { set; get; }

        public virtual Investment Investment { set; get; }


    }

}