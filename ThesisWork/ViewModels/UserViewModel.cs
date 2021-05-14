using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;
using ThesisWork.Repository;

namespace ThesisWork.ViewModels
{
    class UserViewModel
    {
        public static bool Add(string login,string password,string surname,string name,string patronymic,string role)
        {
            UserRepository Repository = new UserRepository();
            if (!Repository.CheckLogin(login))
            {
                User NewUser = new User();

                NewUser.Login = login;
                NewUser.Password = password;
                NewUser.Name = name;
                NewUser.Surname = surname;
                NewUser.Patronymic = patronymic;
                NewUser.Role = role;
                NewUser.FCs = name + " " + surname + " " + patronymic;
                
                return Repository.AddUser(NewUser);
            }
            return false;
        }
    }
}
