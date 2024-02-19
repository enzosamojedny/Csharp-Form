using C__Coderhouse_MAIN.database;
using C__Coderhouse_MAIN.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Coderhouse_MAIN.Services
{
    public static class UserService
    {   
        public static List<Users> GetUsers() {

            using(DatabaseContext context = new DatabaseContext())
            {
                List<Users> users = context.Users.ToList();
                return users;
            }
        }
        //public static List<Users> GetUserById(int id)
        //{

        //    using (DatabaseContext context = new DatabaseContext())
        //    {
        //        List<Users> users = context.Users.ToList();
        //        var user = from u in users where u.Id == id select u;
        //        return user.ToList();
        //    }
        //}
        public static Users GetUserById(int id)
        {

            using (DatabaseContext context = new DatabaseContext())
            {
                List<Users> users = UserService.GetUsers();
                foreach (Users item in users)
                {
                    if (item.Id == id)
                    {
                        return item;
                    }
                }
                    return null;
            }
        }
        public static bool AddUser(Users user)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                return true;
            }
        }
    }
}
