using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.DAL
{
    public class LoanPayment
    {
        [Key]
        public int Id { set; get; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { set; get; }
        public DateTime DueDate { set; get; }
        public DateTime NotificationDate { set; get; }

        // Enum
        public LoanPaymentStatus Status { set; get; }
        public LoanPaymentType Type { set; get; }

        public double PaidAmount { set; get; }
        public double ExpectAmount { set; get; }

        public int Number { set; get; } //Which Number is this payment

        public virtual ICollection<LoanPaymentPart> LoanPaymentParts { set; get; }

        public double Balance { set; get; }
        public double OutStandingBalance { set; get; }
        
        public virtual Loan Loan { set; get; }

        public LoanPayment()
        {
            this.CreationDate = DateTime.Today;
            this.LoanPaymentParts = new List<LoanPaymentPart>();
        }
    }
}