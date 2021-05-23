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
        public static void ParseScheduleFromExcel(DataTableCollection data, PracticeRepository practiceRepository, ScheduleRepository scheduleRepository, CompetenceRepository competenceRepository, int auditorehours)
        {


            foreach (DataTable table in data)
            {

                string practiceName = "";
                string practiceSemestr = "";
                string educationYear = "";
                int NullCount = 0;

                foreach (DataRow row in table.Rows)
                {
                    Debug.WriteLine(NullCount);
                    PracticeSchedule schedule = new PracticeSchedule();
                    Practice practice = new Practice();
                    if (row[5].ToString().ToLower().Contains("год"))
                    {
                        educationYear = row[5].ToString().ToLower().Split("уч")[0].Replace(" ", "").Replace("/", "-");
                    }
                    if (NullCount > 10)
                    {
                        break;
                    }
                    if (row[0].ToString().Replace(" ", "") == "")
                    {
                        NullCount++;
                        continue;
                    }
                    else
                    {
                        NullCount = 0;
                    }


                    if (row[0].ToString().ToLower().Contains("практика") || row[0].ToString().ToLower().Contains("семестр"))
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


                        schedule.EducationYear = educationYear.Replace("/", "-");
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


                        schedule.StartDate = DateTime.ParseExact(row[4].ToString().ToLower().Split("с")[1].Replace(" ", "").Split("по")[0] + "." + year, "d.M.yyyy", null);

                        schedule.EndDate = DateTime.ParseExact(row[4].ToString().ToLower().Split("по")[1].Replace(" ", "").Split("г")[0], "d.M.yyyy", null);


                        #region Hours
                        schedule.StudentsNumber = studentsViewModel.GetStudentsCount(schedule);

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

                        
                        foreach  (var item in practiceRepository.GetStudentsByGroup(schedule.GroupNumber,schedule.EducationYear).ToList())
                        {
                            PracticeBase practiceBase = new PracticeBase();
                            scheduleRepository.AttachStudent(item);
                            practiceBase.CompanyName = "Казанский национальный исследовательский технический университет им. А. Н. Туполева-КАИ";
                            practiceBase.Index = "420111";
                            practiceBase.Area = "РТ";
                            practiceBase.City = "Казань";
                            practiceBase.Street = "Большая Красная";
                            practiceBase.Building = "55";
                            practiceBase.DocumentNumber = "000000";
                            practiceBase.DirectorFCs = "Гильмутдинов А.Х.";
                            practiceBase.DirectorPos = "Ректор";
                            practiceBase.ResponsibleFCs = "Кожевников О.Ю.";
                            practiceBase.ResponsiblePost = "зав. лабораторией";
                            practiceBase.Group = schedule.GroupNumber;
                            practiceBase.PracticeSchedule = schedule;
                            practiceBase.EducationYear = schedule.EducationYear;
                            practiceBase.Student = item;
                            scheduleRepository.SavePracticeBase(practiceBase);
                        }
                        practiceRepository.AddVector(schedule.Vector,schedule.EducationYear);
                        practiceRepository.SavePractice(practice);

                        practiceRepository.Save();
                        schedule.PracticeId = practiceRepository.Select(practice).Id;
                        List<Competence> competences = new List<Competence>();
                        foreach (var item in row[5].ToString().Split("\n"))
                        {

                            CompetenceRepository repos = new CompetenceRepository();

                            Competence competence = new Competence();

                            if (item != ""&& item!=" ")
                            {


                                competence.ThisCompetence = item;

                                if (!scheduleRepository.ContainsCompetence(item))
                                {
                                   
                                    scheduleRepository.SaveCompetence(competence);

                                  
                                }
                                else
                                {
                                    competence = scheduleRepository.SelectCompetence(competence);
                                }

                                competences.Add(competence);

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