using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class Loan
    {
        [Key]
        public int Id { set; get; }
        public DateTime CreationDate { set; get; }
        public DateTime PayoutDate { set; get; }
        public DateTime FirstDuoDate { set; get; }

        public Currency BaseCurrency { set; get; }
        public LoanType Type { set; get; }
        public LoanStatus Status { set; get; }

        public double Amount { set; get; }
        public int Month { set; get; }

        public double EffectiveInterestRatePA { set; get; }
        public double EffectiveInterestRatePM { set; get; }

        public double FlatInterestRatePM { set; get; }
        public double FlatInterestRatePA { set; get; }

        public double EMIInterestAmount { set; get; }

        public double EMI { set; get; } // Monthly payback
        public double EAI { set; get; } // Yearly payback

        public double PaybackAmountTotal { set; get; }
        public double InterestPaybackAmountTotal { set; get; }

        public LoanAccount LoanAccount { set; get; }

        public virtual ICollection<LoanPayment> LoanPayments { set; get; }
        public virtual LoanRate RateAPR { set; get; }
        public virtual LoanRate RateEIR { set; get; }

        public double APR { set; get; }    

        public double BTI { set; get; } // BTI = Bucket Total Interest
        public double BTI_Expected { set; get; }
        public double BTI_Owed { set; get; }
        public double BTI_Paid { set; get; }

        public double BTP { set; get; } // BTP = Bucket Total Principe 
        public double BTP_Expected { set; get; }
        public double BTP_Owed { set; get; }
        public double BTP_Paid { set; get; }

        public double BT { set; get; } // BT = Bucket Total


        public Loan()
        {
            this.LoanPayments = new List<LoanPayment>();
            this.CreationDate = DateTime.Today;
        }
    }

    
}