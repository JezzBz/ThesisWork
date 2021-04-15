using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;
using ThesisWork.Repository;
using ThesisWork.ViewModels;

namespace ThesisWork.Parsers
{
    class ScheduleParser
    {
        private static StudentsViewModel studentsViewModel = new StudentsViewModel();
        public void /*PracticeSchedule*/ ParseScheduleByTeacher()
        {
            
        }
        public static void ParseScheduleFromExcel(DataRowCollection rows, PracticeRepository practiceRepository, ScheduleRepository scheduleRepository, CompetenceRepository competenceRepository)
        {


            string practiceName="";
            string practiceSemestr = "";
            string educationYear = "";
            foreach (DataRow row in rows)
            {
                PracticeSchedule schedule = new PracticeSchedule();
                Practice practice = new Practice();
                if (row[0].ToString() == "")
                {
                    //break;
                }
                if (row[0].ToString().ToLower().Contains("практика"))
                {
                    
                        practiceName = row[0].ToString().Split(".")[0];

                        practiceSemestr= row[0].ToString().ToLower().Split("семестр")[1].Replace(" ", "");
                }
                if (row[5].ToString().Contains("год"))
                {
                    educationYear = row[5].ToString().ToLower().Split("уч")[0].Replace(" ", "");
                    
                }
                if (int.TryParse(row[0].ToString(), out int s))
                {
                    schedule.EducationYear = educationYear;
                    practice.Semestr = practiceSemestr;
                    practice.Name = practiceName;
                    practice.PracticeView = row[6].ToString();
                    practice.PracticeType = row[7].ToString();
                    practice.WeeksNumber = int.Parse(row[8].ToString().Replace(" ",""));

                    schedule.SchedulePage = "";
                    schedule.WeeksNumber = practice.WeeksNumber;
                    schedule.GroupNumber = row[1].ToString();
                    schedule.HeadFcs = row[2].ToString();
                    schedule.Vector = row[3].ToString();
                    string year = row[4].ToString().ToLower().Split("по")[1].Replace(" ", "").Split(".")[2].Split("г")[0];
                    schedule.StartDate = DateTime.ParseExact(row[4].ToString().ToLower().Split("с")[1].Split("по")[0].Replace(" ", "") + "." + year, "d.M.yyyy", null);
                    schedule.EndDate = DateTime.ParseExact(row[4].ToString().ToLower().Split("по")[1].Replace(" ", "").Split("г")[0], "d.M.yyyy", null);
                    #region Hours
                    schedule.StudentsNumber = studentsViewModel.GetStudentsCountByGroup(schedule.GroupNumber);
                    if (practice.PracticeType.ToLower()== "концентрированная")
                    {
                        if (schedule.StudentsNumber>15)
                        {
                            schedule.HoursSRS = (float)Math.Round(2.5 * 6 * schedule.WeeksNumber,1);
                        }
                        else
                        {
                            schedule.HoursSRS = schedule.StudentsNumber * schedule.WeeksNumber;
                        }
                        schedule.ExamenHours = (float)0.35 * schedule.WeeksNumber;
                    }
                    else
                    {
                        schedule.HoursSRS = 2 * schedule.WeeksNumber;
                        schedule.ExamenHours = (float) 0.35 * schedule.WeeksNumber;
                        schedule.HoursClass = schedule.HoursSRS - 4;
                    }
                  
                    #endregion
                    practiceRepository.SavePractice(practice);
                    practiceRepository.Save();
                     schedule.PracticeId = practiceRepository.Select(practice).Id;
                    scheduleRepository.SaveSchedule(schedule);
                    scheduleRepository.Save();
                    foreach (var item in  row[5].ToString().Split("\n") )
                    {

                        Competence competence = new Competence();
                        competence.PracticeScheduleId = scheduleRepository.Select(schedule).Id;
                    
                        competence.ThisCompetence = item;
                        if (competence.ThisCompetence!="")
                        {
                            competenceRepository.SaveCompetence(competence);
                            competenceRepository.Save();
                        }
                        

                    }
                    
                   

                }



            }
            
        }

    }
}
