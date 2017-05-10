using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.DAL
{
   
        public class UserInfoData
        {

            [Key]
            public int Id { get; set; }
            public DateTime CreationDate { get; set; }
            public UserInfoDataStatus Status { get; set; }
            public string Data { get; set; }
            public virtual P2PUser P2PUser { get; set; }
            public virtual UserInfoType UserInfoType { get; set; }

            public UserInfoData()
            {
                this.CreationDate = DateTime.Today;
            }
        }
    }