using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Car_Repair.Models
{
    public class LoginDetails
    {  
        [Required(ErrorMessage ="This field is Required")]     
        public string UserName { get; set; }

        [Required(ErrorMessage = "This field is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string LoginErrorMessage { get; set; }

    }
}