using Microsoft.EntityFrameworkCore;
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
        public int GetStudentsNumberByGroup(string group) => DataBase.Students.Count(x => x.GroupNumber == group);
        public  IEnumerable<Student> GetAll() => DataBase.Students.Select(x=>x);
        
        public void UpdateTable(IEnumerable<Student> students)
        {
            DataBase.Students.UpdateRange(students);
        }
        public void AddStudent(Student student)=> DataBase.Students.Add(student);
        public  bool Save() 
        {
            int count =  DataBase.SaveChanges();

            return count>0; 
        }
           
       
    }
}
