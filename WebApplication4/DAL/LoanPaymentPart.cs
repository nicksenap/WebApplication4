using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.DAL
{
    public class LoanPaymentPart
    {
        [Key]
        public int id { set;get; }
        public DateTime CreationDate { get; set; }

        public LoanPaymentPartStatus Status { set; get; }
        public LoanPaymentPartType Type { set; get; }

        public double PaidAmount { set; get; }
        public double ExpectAmount { set; get; }

        public Loan Loan { set; get; }
        public LoanPayment LoanPayment { set; get; }


    }


}