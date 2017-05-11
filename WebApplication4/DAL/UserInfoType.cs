﻿ using System;
using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;
 using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class UserInfoType
    {
        

        [Key]
        public int Id { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; set; }
        public UserInfoTypeStatus Status { get; set; }
        public string Name { get; set; }
        public virtual ICollection<UserInfoData> Data { get; set; }

        public UserInfoType()
        {
            Data = new List<UserInfoData>();
        }
    }
}
