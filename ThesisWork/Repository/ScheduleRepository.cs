﻿using Microsoft.EntityFrameworkCore;
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
        public IEnumerable<PracticeSchedule> ScheduleInfo(string directorFcs) => DataBase.PracticeSchedule.Select(x => x).Where(x=>x.HeadFcs == directorFcs);

        public IEnumerable<PracticeSchedule> SelectAll() => DataBase.PracticeSchedule.Select(x => x);
        public void SaveSchedule(PracticeSchedule schedule)
        {
            if (!DataBase.PracticeSchedule.Any(x=>x==schedule))
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

            return DataBase.PracticeSchedule.FirstOrDefault(x => x ==schedule);
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
    }
}
