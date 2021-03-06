﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.DAL
{
    public class InvestmentAccountPayment
    {
        [Key]
        public int Id { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; set; }

        public double Amount { set; get; }
        public string Reference { set; get; } 

        public virtual InvestmentAccount InvestAccount { set; get; }
        public virtual InvestmentAsset FromAsset { set; get; }
        public virtual InvestmentAsset ToAsset { set; get; }

        public InvestAccountStatus Status { set; get; }
        public InvestAccountType Type { set; get; }
        public InvestAccountDirection Direction { set; get; }


        public InvestmentAccountPayment()
        {
                    
        }

        
    }

    
}