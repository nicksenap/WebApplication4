using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class UserChangeLog
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public int RowID { get; set; }

        public string OriginalValue { get; set; }
        public string ChangeValue { get; set; }
        public string Editor { get; set; }
        public string IPNumber { get; set; }



        public virtual P2PUser User { get; set; }
    }
}