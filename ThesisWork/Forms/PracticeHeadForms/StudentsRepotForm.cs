using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisWork.Models;
using ThesisWork.Repository;
using ThesisWork.WordOutput;

namespace ThesisWork.Forms.PracticeHeadForms
{
    public partial class StudentsRepotForm : Form
    {
        StudentRepository studentRepository = new StudentRepository();
        string Fcs;
        string FullFCs;
      
        public StudentsRepotForm(string FCs)
        {
            InitializeComponent();
            FullFCs = FCs;
            FCs = FCs.Split(" ")[0]+" "+FCs.Split(" ")[1][0]+"."+ FCs.Split(" ")[2][0]+".";
            Fcs = FCs;
            IEnumerable<string> Years = studentRepository.GetYearByHead(FCs).ToArray();
            comboBox1.Items.AddRange(Years.ToArray());
            comboBox2.Items.AddRange(studentRepository.SelectGroups(FCs).ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WordHelper wordoutput = new WordHelper();
                Dictionary<string, string> items = new Dictionary<string, string>();
                PracticeSchedule schedule = studentRepository.GetSchedule(comboBox1.Text,comboBox2.Text,Fcs);
                
                Practice practice = studentRepository.GetPractice(schedule);
                Teacher teacher = studentRepository.GetTeacher(FullFCs);
                PracticeBase practiceBase = studentRepository.GetPracticeBase(schedule);
                

                items.Add("<Name>",practice.Name);
                items.Add("<VectorName>",studentRepository.GetVectorName(schedule));
                items.Add("<GroupNumber>", schedule.GroupNumber);
                items.Add("<Post>", teacher.Post);
                items.Add("<PracticeHeadFCS>", Fcs);
                items.Add("<EndDate>", schedule.EndDate.ToShortDateString());
                items.Add("<StartDate>", schedule.StartDate.ToShortDateString());
                items.Add("<CurrentYear>", comboBox1.Text);
                items.Add("<HeadFcs>", Fcs);
                items.Add("<CompanyName>", practiceBase.CompanyName);
                items.Add("<ResponsiblePost>", practiceBase.ResponsiblePost);
                items.Add("<ResponsibleFCs>", practiceBase.ResponsibleFCs);
                
                
                items.Add("<PracticeView>", practice.PracticeView);

                List<DataTable> tables = new List<DataTable>();
                DataTable table = new DataTable();
                table.Columns.Add("№ п/п");
                table.Columns.Add("Код компетенции");
                table.Columns.Add("Наименование компетенции");
                table.Columns.Add("Уровень освоения профессиональной компетенции(5 – наивысший балл)");
                int i=1;
                IEnumerable<Competence> competences = studentRepository.IncludeScheduleCompetence(schedule).ToList();
                if (competences!=null)
                {
                    foreach (var item in competences)
                    {
                        if (item!=competences.Last())
                        {
                            items.Add($"<ThisCompetence{i}>", item.ThisCompetence + $"<ThisCompetence{i+1}>"+"\n") ;
                        }
                        else
                        {
                            items.Add($"<ThisCompetence{i}>", item.ThisCompetence );
                        }
                        
                        DataRow row = table.NewRow();
                        string[] array = new string[4];
                        array[0] = i.ToString();
                        array[1] = "";
                        array[2] = item.ThisCompetence;
                        array[3] = "";
                        row.ItemArray = array;
                        table.Rows.Add(row);
                        i++;
                    }
                    tables.Add(table);
                    
                }
                
               
               
                wordoutput.Report(@"C:\Users\vebgh\source\repos\ThesisWork\ThesisWork\Шаблоны для вывода\Шаблон отчёта для студентов.docx", items,sfd.FileName,tables);
                
            }
         
        }
    }
}
