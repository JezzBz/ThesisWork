﻿using Microsoft.EntityFrameworkCore;
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
        public void AddStudent(Student student)
        {
            if (!DataBase.Students.Any(x=>x==student))
            {
                DataBase.Students.Add(student);
            }
            else
            {
                DataBase.Students.Update(student);
            }
          
        }
        public  bool Save() 
        {
            int count =  DataBase.SaveChanges();

            return count>0; 
        }

        public List<string> SelectYears()
        {
            List<string> Years = new List<string>();
            IEnumerable<Student> students = GetAll();
            foreach ( var item in students)
            {
                if (!Years.Contains(item.SudtingYear))
                {
                    Years.Add(item.SudtingYear);
                }
                
            }
            return Years;
        }
    }
}
