using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCourses
{
    public partial class FormQuery : Form
    {
        public FormQuery()
        {
            InitializeComponent();
            
        }

        private void FormQuery_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learningCoursesZyabchukDataSet.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Fill(this.learningCoursesZyabchukDataSet.Course);

        }

        private void btnDurationCourses_Click(object sender, EventArgs e)
        {
            //Курсы больше 6 месяцев
            using (Context db = new Context())
            {
                var duration = from c in db.Courses
                               where c.Duration > 6
                               select new
                               {
                                   Курс = c.Name,
                                   Стоимость = c.Price
                               };
                dataGridQuery.DataSource = duration.ToList();           
            }
            AutoSizeDG();
        }

        private void FormQuery_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }

        private void btnInformaitonCourse_Click(object sender, EventArgs e)
        {
            //информация об определённом курсе
            int id = (int)comboBoxCourse.SelectedValue;
            using (Context db = new Context())
            {
                var infcourse = from c in db.Courses
                                where c.Id_Course == id
                                select new
                                {
                                    Курс = c.Name,
                                    Стоимость = c.Price,
                                    Длительность = c.Duration
                                };
                dataGridQuery.DataSource = infcourse.ToList();
            }
            AutoSizeDG();
        }

        private void btnRecordsCourse_Click(object sender, EventArgs e)
        {
            //записи на курсы
            int id = (int)comboBoxCourse.SelectedValue;
            using (Context db = new Context())
            {
                var records = from r in db.Records
                              join s in db.Students on r.Id_Student equals s.Id_Student
                              join c in db.Courses on r.Id_Course equals c.Id_Course
                              where r.Id_Course == id
                              select new
                              {
                                  ФИО_обучающегося = s.Surname + " " + s.Name + " " + s.Dadname,
                                  Дата_рождения = s.BirthDate,
                                  Название_курса = c.Name,
                                  Стоимость = c.Price,
                                  Длительность = c.Duration
                              };
                dataGridQuery.DataSource = records.ToList();
            }
            AutoSizeDG();
        }
        private void AutoSizeDG()
        {
            foreach (DataGridViewTextBoxColumn column in dataGridQuery.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
