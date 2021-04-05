using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;
using ThesisWork.Repository;

namespace ThesisWork.Parsers
{
    class StudentsParser
    {
        public void ParseStudentsfromExcel(DataRowCollection rows)
        {
            StudentRepository repos = new StudentRepository();
            
            foreach (DataRow row in rows)
            {
                if (row.IsNull(0))
                {
                    break;
                }
                if (row[0].ToString().Contains("Фамилия"))
                {
                    continue;
                }
                Student student = new Student();
                student.Name = row[1].ToString();
                student.Surname = row[0].ToString();
                student.Patronymic = row[2].ToString();
                student.GradeBookNumber = row[3].ToString();
                student.GroupNumber = row[4].ToString();
                student.CourseNumber = int.Parse(row[5].ToString());
                student.Vector = row[7].ToString();
                student.Mentor = false;
                student.Departament = "";
                repos.AddStudent(student);
                Debug.WriteLine(student.Name);
            }
        }
    }
}
