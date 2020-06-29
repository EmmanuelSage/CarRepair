using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Car_Repair.Models
{
    public class Customer
    {
        [StringLength(12,ErrorMessage ="Wrong input")]
        [Display(Name = "Enter Name")]
        public string Name { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9._%+-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }

        [Range (11,11)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Message { get; set; }

        public string LoginErrorMessage { get; set; }

    }
}