using SaleShop.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace SaleShop.Areas.Admin.Models
{
    public class UserModel
    {
        SaleShopDbcontext context = null;
        public UserModel()
        {
            context = new SaleShopDbcontext();
        }
        public int Add(User x)
        {
          
            try
            {
                var record = context.Users.Add(x);
                context.SaveChanges();
                return record.ID;
            }
            catch(Exception e)
            {
               
            }
            return 0;
        }
        public List<User> getAll()
        {
            return context.Users.Where(x => x.ID != 0).ToList();
        }
        public  IEnumerable<User> getPaging(int page,int size)
        {
            return context.Users.OrderBy(x=>x.ID).ToPagedList(page, size);
        }
        public User getItemID(int id)
        {
            return context.Users.SingleOrDefault(x => x.ID == id);
        }
    }
}