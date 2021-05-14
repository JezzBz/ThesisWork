using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;

namespace ThesisWork.Repository
{
    class PracticeRepository
    {
        private static readonly ApplicationContext DataBase = new ApplicationContext();
        public void SavePractice(Practice practice)
        {
            if (!DataBase.Practices.Any(x => x.Name == practice.Name && x.Semestr == practice.Semestr && x.PracticeType == practice.PracticeType && x.PracticeView ==practice.PracticeView))
            {
                DataBase.Practices.Add(practice);
            }
            
        }
        public Practice Select(Practice practice)
        {
            return DataBase.Practices.FirstOrDefault(x => x.Name == practice.Name && x.Semestr == practice.Semestr && x.PracticeType == practice.PracticeType && x.PracticeView == practice.PracticeView);
        }
        public IEnumerable<PracticeBase> GetAll() => DataBase.PracticeBases.Select(x => x);
        public bool UpdatePracticeBaseTable(IEnumerable<PracticeBase>practiceBases)
        {
            try
            {
                DataBase.PracticeBases.UpdateRange(practiceBases);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Save()
        {
            int count = DataBase.SaveChanges();

            return count > 0;
        }
        public void AddToPractiseBase(PracticeBase practiceBase)
        {
            if (!DataBase.PracticeBases.Any(x=>x.Student==practiceBase.Student))
            {
                DataBase.PracticeBases.Add(practiceBase);
            }
            else
            {
                PracticeBase practice=DataBase.PracticeBases.FirstOrDefault(x => x.Student == practiceBase.Student);
                practice = practiceBase;
            }
           
        }
        public void AttachStudent(Student student)
        {
            DataBase.Students.Attach(student);
        }
        
        
    }
}
