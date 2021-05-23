using Microsoft.EntityFrameworkCore;
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
        public IEnumerable<PracticeSchedule> ScheduleInfo(string directorFcs)
        {
            string correctFcs = directorFcs.Split(" ")[0] +" "+ directorFcs.Split(" ")[1][0] + "." + directorFcs.Split(" ")[2][0] + ".";
            return DataBase.PracticeSchedule.Select(x => x).Where(x => x.HeadFcs.ToLower() == correctFcs.ToLower());
        }
        public void SavePracticeBase(PracticeBase practiceBase)
        {
            if (!DataBase.PracticeBases.Any(x => x.Student == practiceBase.Student))
            {
                DataBase.PracticeBases.Add(practiceBase);
            }


        }
        public void AttachStudent(Student student)
        {
            DataBase.Students.Attach(student);
        }
        public IEnumerable<PracticeSchedule> SelectAll() => DataBase.PracticeSchedule.Select(x => x);
        public void SaveSchedule(PracticeSchedule schedule)
        {
            if (!DataBase.PracticeSchedule.Any(x => x == schedule))
            {
                DataBase.PracticeSchedule.Add(schedule);
            }
            else
            {
                DataBase.PracticeSchedule.Update(schedule);
            }


        }
        public void UpdateRange(IEnumerable<PracticeSchedule> practiceSchedules)
        {
            DataBase.PracticeSchedule.UpdateRange(practiceSchedules);
            Save();
        }
        public PracticeSchedule Select(PracticeSchedule schedule)
        {

            return DataBase.PracticeSchedule.FirstOrDefault(x => x == schedule);
        }
        public bool Save()
        {

            int count = DataBase.SaveChanges();

            return count > 0;
        }
        public void SaveCompetence(Competence competence)
        {

            if (!DataBase.Competences.Any(x => x.ThisCompetence == competence.ThisCompetence))
            {
                DataBase.Competences.Add(competence);
            }


        }
        public Competence SelectCompetence(Competence competence) => DataBase.Competences.FirstOrDefault(x => x.ThisCompetence == competence.ThisCompetence);
        public void AttachCompetence(Competence competence)
        {
            DataBase.Attach(competence);
        }
        public bool ContainsCompetence(string name) => DataBase.Competences.Any(x => x.ThisCompetence == name);
    }
}
