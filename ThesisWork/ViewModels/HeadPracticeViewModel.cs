using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;
using ThesisWork.Repository;

namespace ThesisWork.ViewModels
{
    class HeadPracticeViewModel
    {
        private readonly ScheduleRepository Schedule = new ScheduleRepository();
        public IEnumerable<PracticeSchedule> ScheduleInfo(string fcs)
        {
            
            return Schedule.ScheduleInfo(fcs);
        }
    }
}
