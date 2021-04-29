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
        public static void ParseScheduleFromExcel(DataTableCollection data, PracticeRepository practiceRepository, ScheduleRepository scheduleRepository, CompetenceRepository competenceRepository,int auditorehours)
        {


            foreach (DataTable table in data)
            {

                string practiceName = "";
                string practiceSemestr = "";
                string educationYear = "";

                foreach (DataRow row in table.Rows)
                {
                    PracticeSchedule schedule = new PracticeSchedule();
                    Practice practice = new Practice();

                    if (row.IsNull(0) || row.IsNull(1))
                    {
                        continue;
                    }


                    if (row[0].ToString().ToLower().Contains("практика"))
                    {

                        practiceName = row[0].ToString().Split(".")[0];

                        practiceSemestr = row[0].ToString().ToLower().Split("семестр")[1].Replace(" ", "");
                    }

                    if (row[5].ToString().Contains("год"))
                    {
                        educationYear = row[5].ToString().ToLower().Split("уч")[0].Replace(" ", "");

                    }



                    if (int.TryParse(row[0].ToString(), out int s))
                    {



                        practice.PracticeView = row[6].ToString();
                        practice.PracticeType = row[7].ToString();


                        schedule.EducationYear = educationYear;
                        practice.Semestr = practiceSemestr;
                        practice.Name = practiceName;


                        practice.WeeksNumber = int.Parse(row[8].ToString().Replace(" ", ""));




                        schedule.SchedulePage = "";
                        schedule.WeeksNumber = practice.WeeksNumber;
                        schedule.GroupNumber = row[1].ToString();
                        schedule.HeadFcs = row[2].ToString();
                        schedule.Vector = row[3].ToString();
                        schedule.SchedulePage = table.TableName;
                        string year = row[4].ToString().ToLower().Split("по")[1].Replace(" ", "").Split(".")[2].Split("г")[0];

                        Debug.WriteLine(schedule.GroupNumber);
                        Debug.WriteLine(row[4]);
                        Debug.WriteLine(row[4].ToString().Split("с")[1]);
                        Debug.WriteLine(row[4].ToString().Split("с")[1].Replace(" ", ""));
                        Debug.WriteLine(row[4].ToString().Split("с")[1].Replace(" ", "").Split("по")[0]);
                        schedule.StartDate = DateTime.ParseExact(row[4].ToString().ToLower().Split("с")[1].Replace(" ", "").Split("по")[0] + "." + year, "d.M.yyyy", null);
                        Debug.WriteLine(schedule.StartDate);
                        schedule.EndDate = DateTime.ParseExact(row[4].ToString().ToLower().Split("по")[1].Replace(" ", "").Split("г")[0], "d.M.yyyy", null);
                        Debug.WriteLine("3");

                        #region Hours
                        schedule.StudentsNumber = studentsViewModel.GetStudentsCountByGroup(schedule.GroupNumber);

                        schedule.ExamenHours = (float)Math.Round(0.35 * schedule.StudentsNumber, 2);
                        schedule.HoursClass = auditorehours;
                        if (practice.PracticeType.ToLower() == "концентрированная")
                        {

                            if (schedule.StudentsNumber > 15)
                            {
                                schedule.HoursSum = (float)Math.Round(2.5 * 6 * schedule.WeeksNumber, 2);


                            }
                            else
                            {
                                schedule.HoursSum = (schedule.StudentsNumber * schedule.WeeksNumber);
                            }


                        }
                        else
                        {
                            schedule.HoursSum = (2 * schedule.WeeksNumber) + schedule.ExamenHours;

                        }
                        schedule.HoursSRS = schedule.HoursSum - schedule.HoursClass - schedule.ExamenHours;

                        #endregion




                        practiceRepository.SavePractice(practice);
                        practiceRepository.Save();
                        schedule.PracticeId = practiceRepository.Select(practice).Id;
                        List<Competence> competences = new List<Competence>();
                        foreach (var item in row[5].ToString().Split("\n"))
                        {
                           
                            CompetenceRepository repos = new CompetenceRepository();

                            Competence competence = new Competence();

                            if (item != "" )
                            {


                                
                              
                                if (!repos.Contains(item))
                                {
                                    competence.ThisCompetence = item;
                                    scheduleRepository.SaveCompetence(competence);
                                   
                                    competences.Add(competence);
                                }

                               

                            }
                            
                        }
                        schedule.Competences = competences;
                        scheduleRepository.SaveSchedule(schedule);
                        scheduleRepository.Save();
                    
                        


                    }

                }

            }


        }
    }
}
