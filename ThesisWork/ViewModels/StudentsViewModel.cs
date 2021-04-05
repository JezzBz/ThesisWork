using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
    
}
