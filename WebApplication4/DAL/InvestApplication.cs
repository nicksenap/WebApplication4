using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class InvestApplication
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int Amount { get; set; }
        public int Months { get; set; }
    }
}