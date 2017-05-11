using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class InvestmentAccount
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Currency BaseCurrency { set; get; }

        public InvestAccountStatus Status { set; get; }
        public InvestAccountType Type { set; get; }

        public int InvestCount { get; set; }
        public int TotalAmount { get; set; }

        public bool isActive { set; get; }
        public bool isDeleted { set; get; }

        public double LeftAmount { set; get; }
        public double SpecialsAmount { set; get; }
        public double ReturnAmount { set; get; }

        public double TRInterestAmount { set; get; }
        public double TRPrincipleAmount { set; get; }
        public double TReservedAmount { set; get; }

        public double TInvestedAmount { set; get; }
        public double TTransferedAmountIn { set; get; }
        public double TTransferedAmountOut { set; get; }



        public virtual ICollection<InvestmentAsset> InvestmentAssets { set; get; }
        public virtual ICollection<InvestmentAccountPayment> InvestAccountPayments { set; get; }
    }
}