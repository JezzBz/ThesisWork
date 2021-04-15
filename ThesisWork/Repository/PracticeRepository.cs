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
        public bool Save()
        {
            int count = DataBase.SaveChanges();

            return count > 0;
        }
    }
}
