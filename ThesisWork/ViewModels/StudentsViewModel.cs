using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;
using ThesisWork.Repository;

namespace ThesisWork.ViewModels
{
    class StudentsViewModel
    {
        StudentRepository repos = new StudentRepository();
        public int GetStudentsCountByGroup(string group) 
        {
            
            return repos.GetStudentsNumberByGroup(group);
        }
        public  bool Apply()
        {
            try
            {
                return repos.Save();
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public IEnumerable<Student> SelectAll()
        {
            return repos.GetAll();
        }
        public bool UpdateTable(IEnumerable<Student> students)
        {
            try
            {
                repos.UpdateTable(students);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }
        public List<Student> SortByYear(List<Student>students)
        {
            Comparer comparer = new Comparer();


            students.Sort(comparer);
            return students;
        }
    }
    
}
