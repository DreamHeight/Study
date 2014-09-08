using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Model
{
    [Table("DT_User")]
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("F_Id")]
        public int F_Id{ get; set; }

        [Required]
        [MaxLength(30,ErrorMessage = "您输入的用户名称过长")]
        [Column("F_UserName")]
        public string F_UserName { get; set; }

        [Required]
        [Column("F_Password")]
        public string F_Password { get; set; }

        [Required]
        [Column("F_CreateTime")]
        public DateTime F_CreateTime { get; set; }

        [Required]
        [Column("F_UpdateTime")]
        public DateTime F_UpdateTime { get; set; }

        [Required]
        [Column("F_IsRemove")]
        public bool F_IsRemove { get; set; }
    }
}
