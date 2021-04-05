using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;
using ThesisWork.ViewModels;

namespace ThesisWork.Parsers
{
    class ScheduleParser
    {
        private static StudentsViewModel studentsViewModel = new StudentsViewModel();
        public void /*PracticeSchedule*/ ParseScheduleByTeacher()
        {
            
        }
        public static PracticeSchedule ParseScheduleFromExcel(PracticeSchedule schedule, DataRowCollection rows)
        {
            foreach (DataRow row in rows)
            {
                if (row[0].ToString() == "")
                {
                    break;
                }
                if (row[5].ToString().Contains("год"))
                {
                    schedule.EducationYear = row[5].ToString().ToLower().Split("уч")[0].Replace(" ", "");
                    
                }
                if (int.TryParse(row[0].ToString(), out int s))
                {
                    schedule.GroupNumber = row[1].ToString();
                    schedule.HeadFcs = row[2].ToString();
                    schedule.Vector = row[3].ToString();
                    string year = row[4].ToString().ToLower().Split("по")[1].Replace(" ", "").Split(".")[2].Split("г")[0];
                    schedule.StartDate = DateTime.ParseExact(row[4].ToString().ToLower().Split("с")[1].Split("по")[0].Replace(" ", "") + "." + year, "d.M.yyyy", null);
                    schedule.EndDate = DateTime.ParseExact(row[4].ToString().ToLower().Split("по")[1].Replace(" ", "").Split("г")[0], "d.M.yyyy", null);
                    schedule.StudentsNumber = studentsViewModel.GetStudentsCountByGroup(schedule.GroupNumber);
                    

                }



            }
            return schedule;
        }
    }
}
