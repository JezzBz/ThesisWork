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
        public bool ParseStudentsfromExcel(DataRowCollection rows,string filename)
        {

            StudentRepository repos = new StudentRepository();
            try
            {

                foreach (DataRow row in rows)
                {
                    if (row.IsNull(0))
                    {
                        break;
                    }
                    if (row[0].ToString().Contains("Фамилия")||!row[8].ToString().ToLower().Contains("пми"))
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
                    student.Vector = row[8].ToString();
                    student.Mentor =row[7].ToString().ToLower()=="да"?true:false;
                    student.Departament = row[6].ToString();
                    student.SudtingYear = filename.Split("/")[filename.Split("/").Length-1].Split(".")[0].ToLower().Split("студенты")[1].Replace(" ","");
                    
                    repos.AddStudent(student);
                    Debug.WriteLine(student.Name);
                }
            }
            catch (Exception)
            {

                return false;
            }*/
            return true;
        }
    }
}
