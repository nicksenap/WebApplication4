 using System;
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
        public DateTime CreationDate { get; set; }
        public UserInfoTypeStatus Status { get; set; }
        public UserInfoTypeType Type { get; set; }
        public string Name { get; set; }
        public string Properties { get; set; }


        public UserInfoType()
        {
            
        }
    }
}
