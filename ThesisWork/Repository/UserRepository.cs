using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;

namespace ThesisWork.Repository
{
    class UserRepository
    {
        private static readonly ApplicationContext DataBase = new ApplicationContext();
        public static User Login(string password,string login)=>DataBase.User.FirstOrDefault(x => x.Password == password && x.Login == login);
           
        
        public  bool AddUser(User user) 
        {
            DataBase.Add(user);
            var count = DataBase.SaveChanges();
            if (count == 1) return true;
            else return false;
           
        }
        public bool CheckLogin(string login) => DataBase.User.Any(x => x.Login == login);
        
           
        
    }
}

