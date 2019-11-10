using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaleShop.Commond
{
    [Serializable]
    public class UserSesion
    {
        public long ID { set; get; }
        public string User { set; get; }
    }
}