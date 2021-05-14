using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;

namespace ThesisWork.Repository
{
    class CompetenceRepository
    {
        private static readonly ApplicationContext DataBase = new ApplicationContext();
        public void SaveCompetence(Competence competence)
        {
            if (!DataBase.Competences.Any(x=>x.ThisCompetence==competence.ThisCompetence))
            {
                DataBase.Competences.Add(competence);
            }
            
        }
        public IEnumerable<Competence> GetCompetences() => DataBase.Competences.Select(x => x);
        
      
        public bool Save()
        {
            int count = DataBase.SaveChanges();

            return count > 0;
        }
        public bool UpdateTable(IEnumerable<Competence> competence)
        {
            try
            {
                DataBase.Competences.UpdateRange(competence);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }
        public Competence SelectCompetence(Competence competence) => DataBase.Competences.FirstOrDefault(x=>x.ThisCompetence==competence.ThisCompetence);
    }
}
