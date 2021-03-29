using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;
using ThesisWork.Repository;

namespace ThesisWork.ViewModels
{
    class LoginViewModel
    {
        public static User Login(string password,string login)
        {
           
            User user =UserRepository.Login(password, login);
            if (user != null) return user;

            else return null;
           
        }
       
    }
}
