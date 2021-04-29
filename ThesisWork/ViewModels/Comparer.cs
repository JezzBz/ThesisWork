using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;

namespace ThesisWork.ViewModels
{
  
class Comparer : IComparer<Student>
    {
        public int Compare(Student student1,Student student2 )
        {
            if (int.Parse(student1.SudtingYear.Split("-")[0]) > int.Parse(student2.SudtingYear.Split("-")[0]))
            {
                return -1;
            }
            else if(int.Parse(student1.SudtingYear.Split("-")[0]) < int.Parse(student2.SudtingYear.Split("-")[0])) 
            {
                return 1;
            }
            return 0;

            
        }

        
    }

}
