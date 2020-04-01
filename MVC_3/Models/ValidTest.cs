using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVC_3.Models
{
    public class ValidTest
    {
        [Display(Name = "ID")]
        public String StudentID { get; set; }
        [Display(Name = "Name")]
        public String StudentName { get; set; }

    }
}