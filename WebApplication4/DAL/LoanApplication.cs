using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Antlr.Runtime;

namespace WebApplication4.DAL
{
    public class LoanApplication
    {
        [Key]
        public int Id { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; set; }
        public double Amount { get; set; }
        public int Months { get; set; }

        public bool isSigned { set; get; }
        public bool isVerified { set; get; }
        public LoanApplicationStatus Status { set; get; }

        public double UCScore { set; get; }
        public string UCData { get; set; }
        public int UCViews { set; get; }
        public int UCQueries { set; get; }

        public int P2PScore { set; get; } 

        public double APR { set; get; }
        public string DataScore { set; get;}
        public CreditFlag Flag { set; get; }
        public string AMLData { get; set; }

        //public virtual ICollection<LoanApplicationChangeLog> StatusLogs { set; get; }

        public LoanApplication()
        {
            // this.CreationDate = DateTime.Today;
            //this.StatusLogs = new List<LoanApplicationChangeLog>();
        }
    }

    
}