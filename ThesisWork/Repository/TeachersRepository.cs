using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;

namespace ThesisWork.Repository
{
    class TeachersRepository
    {
        private static readonly ApplicationContext DataBase = new ApplicationContext();

        public IEnumerable<Teacher> GetAll() => DataBase.Teachers.Select(x => x);
        public bool UpdateTable(IEnumerable<Teacher>teachers)
        {
            try
            {
                DataBase.Teachers.UpdateRange(teachers);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
