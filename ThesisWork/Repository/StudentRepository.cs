using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;

namespace ThesisWork.Repository
{
    class StudentRepository
    {
        private static readonly ApplicationContext DataBase = new ApplicationContext();
        public int GetStudentsNumberByGroup(PracticeSchedule practiceSchedule) => DataBase.Students.Count(x => x.GroupNumber == practiceSchedule.GroupNumber && x.SudtingYear == practiceSchedule.EducationYear);
        public IEnumerable<Student> GetAll() => DataBase.Students.Select(x => x);
        public IEnumerable<string> SelectGroups(string Fcs) => DataBase.PracticeSchedule.Where(x => x.HeadFcs == Fcs).Select(x => x.GroupNumber).Distinct();
        public IEnumerable<string> GetYearByHead(string FCs) => DataBase.PracticeSchedule.Where(x => x.HeadFcs == FCs).Select(x=>x.EducationYear).Distinct();
        public void UpdateTable(IEnumerable<Student> students)
        {
            DataBase.Students.UpdateRange(students);
        }
        public void AddStudent(Student student)
        {
            if (!DataBase.Students.Any(x => x == student))
            {
                DataBase.Students.Add(student);
            }
            else
            {
                DataBase.Students.Update(student);
            }


        }
        public bool Save()
        {
            int count = DataBase.SaveChanges();

            return count > 0;
        }
        public IEnumerable<Competence> IncludeScheduleCompetence(PracticeSchedule schedule) => DataBase.Competences.Where(c=>c.PracticesSchedule.Contains(schedule)).Select(x=>x);
        public string GetVectorName(PracticeSchedule schedule) => DataBase.Specialties.FirstOrDefault(x => x.Vector == schedule.Vector).VectorName;
        public PracticeSchedule GetSchedule(string year, string group, string FCs) => DataBase.PracticeSchedule.FirstOrDefault(x=>x.EducationYear==year&&x.GroupNumber==group&&x.HeadFcs==FCs);
        public PracticeBase GetPracticeBase(PracticeSchedule schedule) => DataBase.PracticeBases.Where(x => x.PracticeSchedule == schedule).FirstOrDefault();
        public Practice GetPractice(PracticeSchedule schedule) => DataBase.Practices.FirstOrDefault(x=>x.Id==schedule.PracticeId);
        public Teacher GetTeacher(string fcs) => DataBase.Teachers.FirstOrDefault(x=>x.FCs==fcs);
        public List<string> SelectYears()
        {
            List<string> Years = new List<string>();
            IEnumerable<Student> students = GetAll();
            foreach (var item in students)
            {
                if (!Years.Contains(item.SudtingYear))
                {
                    Years.Add(item.SudtingYear);
                }

            }
            return Years;
        }
        public int GetPracticeShdelueId(string Fcs,string group,string year) => DataBase.PracticeSchedule.FirstOrDefault(x => x.HeadFcs == Fcs&&x.GroupNumber==group&&x.EducationYear==year).Id;
        public void AddStudentInPracticeBase(IEnumerable<PracticeBase> bases)
        {
            DataBase.PracticeBases.AddRange(bases);
        }
        public IEnumerable<Student> GetStudentsByGroup(string group, string year) => DataBase.Students.Where(x => x.GroupNumber == group && x.SudtingYear == year).Select(x=>x);

    }
}
