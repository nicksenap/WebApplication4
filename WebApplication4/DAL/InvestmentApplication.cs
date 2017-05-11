using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class InvestmentApplication
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int Amount { get; set; }
        public int Months { get; set; }

        public virtual ICollection<Investment> Investments { set; get; }
        public virtual ICollection<InvestmentAccountPayment> InvestAccountPayments { set; get; }

        public InvestmentApplication()
        {
            
        }

      
    }
}