using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LearningCourses
{
    public partial class FormCourse : Form
    {
        Regex regexFIO = new Regex(@"^[А-Я][а-я]{0,15}$");
        public FormCourse()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                dataGridCourse.DataSource = db.Courses.ToList();
            }
        }
        private bool Correct()
        {
            string f = txtBoxSurname.Text;
            string i = txtBoxName.Text;
            string o = txtBoxDadname.Text;

            if (!regexFIO.IsMatch(f) || !regexFIO.IsMatch(i) || !regexFIO.IsMatch(o))
            {
                MessageBox.Show("Некорректные ФИО!");
                return false;
            }
            else return true;
        }

        private void reload(Context db)
        {
            try
            {
                db.SaveChanges();
                dataGridCourse.DataSource = db.Courses.ToList();
                dataGridCourse.ClearSelection();
                Clear();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Такой курс уже есть!");
            }
        }
        private void FormCourse_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learningCoursesZyabchukDataSet.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Fill(this.learningCoursesZyabchukDataSet.Course);
            dataGridCourse.ClearSelection();
        }

        private void dataGridCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridCourse.SelectedRows[0].Index;

            txtBoxCourse.Text = dataGridCourse[1, row].Value.ToString();
            txtBoxSurname.Text = dataGridCourse[2, row].Value.ToString();
            txtBoxName.Text = dataGridCourse[3, row].Value.ToString();
            txtBoxDadname.Text = dataGridCourse[4, row].Value.ToString();
            numUpDownPrice.Value = (int)dataGridCourse[5, row].Value;
            numUpDownDuration.Value = (int)dataGridCourse[6, row].Value;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Correct())
            {
                using (Context db = new Context())
                {
                    db.Courses.Add(new Course
                    {
                        Name = txtBoxCourse.Text,
                        Surname_teacher = txtBoxSurname.Text,
                        Name_teacher = txtBoxName.Text,
                        Dadname_teacher = txtBoxDadname.Text,
                        Price = (int)numUpDownPrice.Value,
                        Duration = (int)numUpDownDuration.Value
                    });
                    reload(db);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridCourse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
            else
            {
                if (Correct())
                {
                    using (Context db = new Context())
                    {
                        foreach (DataGridViewRow row in dataGridCourse.SelectedRows)
                        {
                            DialogResult answer;
                            int id = (int)dataGridCourse[0, row.Index].Value;
                            Course delete_c = db.Courses.Where(c => c.Id_Course == id).FirstOrDefault();
                            answer = MessageBox.Show($"Вы хотите удалить курс {delete_c.Name}?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (answer == (DialogResult)6)
                            {
                                db.Courses.Remove(delete_c);
                            }
                        }
                        reload(db);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridCourse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
            else
            {
                if (Correct())
                {
                    int id = (int)dataGridCourse[0, dataGridCourse.CurrentRow.Index].Value;
                    using (Context db = new Context())
                    {
                        Course update_c = db.Courses.Where(c => c.Id_Course == id).FirstOrDefault();
                        update_c.Name = txtBoxCourse.Text;
                        update_c.Surname_teacher = txtBoxSurname.Text;
                        update_c.Name_teacher = txtBoxName.Text;
                        update_c.Dadname_teacher = txtBoxDadname.Text;
                        update_c.Price = (int)numUpDownPrice.Value;
                        update_c.Duration = (int)numUpDownDuration.Value;
                        reload(db);
                    }
                }
            }
        }

        private void FormCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }
        private void Clear()
        {
            txtBoxCourse.Clear();
            txtBoxSurname.Clear();
            txtBoxName.Clear();
            txtBoxDadname.Clear();
            numUpDownPrice.Value = 10000;
            numUpDownDuration.Value = 1;
        }
    }
}
