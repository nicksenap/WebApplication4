using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.DAL
{
    public class Investment
    {
        [Key]
        public int Id { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; set; }

        public Currency BaseCurrency { set; get; }
        public InvestmentType Type { set; get; }
        public InvestmentStatus Status { set; get; }

        public bool IsSigned { set; get; }
        public bool IsVerified { set; get; }
        
        public double APR { set; get; }
        public double LoanPercentage { set; get; }
        public double InvestedAmount { set; get; }
        public double InvestedAmountReturn { set; get; }

        public double InterestAmountReturn { set; get; }
        public double InterestAmountReturnExpect { set; get; }

        public double TotalMonthlyReturns { set; get; }
        public double TotalMonthlyReturnsExpected { set; get; }

        public double MonthlyPrincipalReturn { set; get; }
        public double MonthlyPrincipalReturnExpected { set; get; }

        public virtual Loan Loan { set; get; }
        public virtual InvestmentAsset InvestmentAsset { set; get; }
        public virtual InvestmentAccount InvestAccount { set; get; }

    }

}