using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using WebApplication4.DAL;

namespace WebApplication4.Models
{
    public class DropdownElement
    {
        public int DropdownValue { set; get; }
        public List<SelectListItem> DropDownItems { set; get; }
    }

    public class LoanViewModel
    {

        [Required]
        [Display(Name = "Amount")]
        public double Amount { get; set; }

        [Required]
        public int Months { set; get; }


        //public int JobType { set; get; }


        //public int MaritalStatus { set; get; }
        [Required]
        [Display(Name = "Boendeform")]
        public int LivingStatus { get; set; }

        public List<SelectListItem> LivingStatusItems { get; set; }


        [Required]
        [Display(Name = "Jobbstatus")]
        public int JobStatus { get; set; }

        public List<SelectListItem> JobStatusItems { get; set; }


        [Required]
        [Display(Name = "Civilstånd")]
        public int CivilStatus { get; set; }

        public List<SelectListItem> CivilStatusItems { get; set; }


        [Required]
        [Display(Name = "Andelning")]
        public int LoanCategory { get; set; }

        public List<SelectListItem> LoanCategoryItems { get; set; }


        [Required]
        [Display(Name = "Sysselsättning")]
        public int JobType { get; set; }

        public List<SelectListItem> JobTypeItems { get; set; }


        





        // private readonly List<> _flavors;

        //[Display(Name = "Favorite Flavor")]
        //public int SelectedFlavorId { get; set; }

        //public string JobStatus { set; get; }

        //public  int LoanCategory { set; get; }

        [Display(Name = "Select Status")]
        public string Status { get; set; }

        public class EnumDynamicType
        {
            public List<SelectListItem> Default { get; set; }
            public List<SelectListItem> Swedish { get; set; }
            public List<SelectListItem> English { get; set; }
        }
    }

   
}