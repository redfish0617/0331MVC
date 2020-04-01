using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_3.Models
{
    public class vmLogin
    {
        [Display(Name = "帳號")]
        public String UserID { get; set; }
        [Display(Name = "密碼")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Display(Name = "保持登入狀態")]
        public bool IsPersistent { get; set; }
    }
}