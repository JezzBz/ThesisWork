using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;

namespace ThesisWork.Repository
{
    class StudentRepository
    {
        private static readonly ApplicationContext DataBase = new ApplicationContext();
        public int GetStudentsNumberByGroup(string group) => DataBase.Students.Select(x => x.GroupNumber == group).Count();
        public void AddStudent(Student student)
        {
            DataBase.Students.Add(student);
            DataBase.SaveChanges();
        }
    }
}
