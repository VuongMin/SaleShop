using SaleShop.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaleShop.Areas.Admin.Models
{
    public class LoginModel
    {
        //This is model accset from Dbcontext with method
        SaleShopDbcontext context = null;
        public LoginModel()
        {
            context = new SaleShopDbcontext();
        }
        public long CheckLogin(string ID,string password)
        {
            var Res = context.Users.Where(x => x.UserName == ID && x.Password == password).SingleOrDefault();
            if(Res!=null)
            {
                return Res.ID;
            }
            return 0;
        }
    }
}