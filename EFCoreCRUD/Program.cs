using EFCoreCRUD.Connection;
using EFCoreCRUD.Models;
using System;
using System.Linq;

namespace EFCoreCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Добавление
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                User user = new User { Age = 1, Id = 1, Name = "qwe" };
                User user1 = new User { Name = "sfsdsf", Id = 2, Age = 3 };
                applicationContext.Add(user);
                applicationContext.Add(user1);
                applicationContext.SaveChanges();
            }
            //Get
            using(ApplicationContext applicationContext = new ApplicationContext())
            {
                var Users = applicationContext.Users.ToList();
                foreach(var t in Users)
                {
                    Console.WriteLine($"Id={t.Id}, Name={t.Name}, Age={t.Age}");
                }
            }
            //Editing
            using(ApplicationContext applicationContext = new ApplicationContext())
            {
                User user = applicationContext.Users.FirstOrDefault();
                if (user!=null)
                {
                    user.Age = 55;
                    applicationContext.SaveChanges();
                }
            }
            //Del
            using(ApplicationContext applicationContext = new ApplicationContext())
            {
                User user = applicationContext.Users.FirstOrDefault();
                if(user!=null)
                {
                    applicationContext.Remove(user);
                    applicationContext.SaveChanges();
                }
            }
        }
    }
}
