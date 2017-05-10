using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class InvestAccount
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int InvestCount { get; set; }
        public int Amount { get; set; }
    }
}