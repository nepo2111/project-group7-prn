using project_group7_prn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_group7_prn.DAO
{
    public class UserDAO
    {
        public User GetUserByEmail(string email)
        {
            User user = null;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                user = context.Users.FirstOrDefault(x => x.Email.Equals(email));
            }

                return user;
        }

        public void AddUser(User user)
        {
            if (user == null) return;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            if (user == null) return;
            using (onlineShopSWPContext context = new onlineShopSWPContext())
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
    }
}
