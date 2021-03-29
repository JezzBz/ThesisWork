using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;

namespace ThesisWork.Repository
{
    class ScheduleRepository
    {
        private static readonly ApplicationContext DataBase = new ApplicationContext();
        public  IEnumerable<PracticeSchedule> ScheduleInfo(string directorFcs) => DataBase.PracticeSchedule.Select(x => x).Where(x=>x.DirectorFcs == directorFcs);

          
       
    }
}
