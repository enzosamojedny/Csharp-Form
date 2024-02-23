using C__Coderhouse_MAIN.database;
using C__Coderhouse_MAIN.models;
using Microsoft.EntityFrameworkCore;
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


        public static Users GetUserByID(int id)
        {

            using (DatabaseContext context = new DatabaseContext())
            {
                List<Users> users = UserService.GetUsers();
                foreach (Users item in users)
                {
                    if (item.ID == id)
                    {
                        return item;
                    }
                }
                    return null;
            }
        }
        public static bool UpdateUserByID(Users user, int id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {

            
                Users? userFound = context.Users.Where(u=>u.ID==id).FirstOrDefault();

                userFound.Name = user.Name;
                userFound.LastName = user.LastName;
                userFound.Email = user.Email;
                userFound.Password = user.Password;
                userFound.Username = user.Username;
                context.Users.Update(userFound);
                context.SaveChanges();
                return true;
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
