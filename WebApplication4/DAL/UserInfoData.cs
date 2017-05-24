using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace WebApplication4.DAL
{
   
        public class UserInfoData
        {

            [Key]
            public int Id { get; set; }

            [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
            public DateTime CreationDate { get; set; }
            public UserInfoDataStatus Status { get; set; }
            public string Data { get; set; }

            //public Gender gender { set; get; }
            //public CivilStatus CivilStatus { set; get; }

            //public int Cars { set; get; }
            //public int e { set; get; }
            //public string Title { set; get; }
            


        public virtual P2PUser P2PUser { get; set; }
            public virtual UserInfoType UserInfoType { get; set; }

            public UserInfoData()
            {
                // this.CreationDate = DateTime.Today;
            }
        }

   
}