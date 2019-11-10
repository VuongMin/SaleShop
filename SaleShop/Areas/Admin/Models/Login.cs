using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaleShop.Areas.Admin.Models
{
    public class Login
    {
        //This is custom model create for view_login to mapping action_result Login()
        [Required(ErrorMessage ="You have to input UserName .")]
        public string UserName { set; get; }
        [Required(ErrorMessage ="You have to input Password .")]
        public string Password { set; get; }
        public bool Remember { set; get; }
    }
}