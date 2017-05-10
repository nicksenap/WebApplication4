﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.DAL
{
    public class LoanRate
    {
        [Key]
        public int Id { set; get; }

        public DateTime CreationDate { set; get; }
        public DateTime VaildFromDate { set; get; }
        public DateTime VaildUntilDate { set; get; }

        public LoanRateStatus Status { set; get; }
        public LoanRateType Type { set; get; }

        public int P2PScoreMax { set; get; }
        public int P2PScoreMin { set; get; }

        public int AmountMin { set; get; }
        public int AmountMax { set; get; }

        public int MonthMin { set; get; }
        public int MonthMax { set; get; }

        public string Name { set; get; }
        public string Description { set; get; }

        public double Value { set; get; }
    }


}