using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.DAL
{
    public class InvestmentAsset
    {
        public InvestmentAsset()
        {
            this.Investments = new List<Investment>();            
        }

        [Key]
        public int Id { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; set; }

        public InvestmentAssetStatus Status { set; get; }
        public InvestmentAssetType Type { set; get; }

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

        public virtual ICollection<Investment> Investments { set; get; }
        public virtual Rate Production { set; get; }
    }

   
}