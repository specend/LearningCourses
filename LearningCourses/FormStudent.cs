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
    public partial class FormStudent : Form
    {
        Regex regexFIO = new Regex(@"^[А-Я][а-я]{0,15}$");
        public FormStudent()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                dataGridStudent.DataSource = db.Students.ToList();
            }
        }
        private void reload(Context db)
        {
            try
            {
                db.SaveChanges();
                dataGridStudent.DataSource = db.Students.ToList();
                dataGridStudent.ClearSelection();
                Clear();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Такой обучающийся уже есть!");
            }
        }
        private int Age()
        {
            int age;

            DateTime birth = BirthDatePicker.Value;
            DateTime now = DateTime.Now;

            age = now.Year - birth.Year;
            if (now.Date < birth.Date.AddYears(age))
                age--;
            return age;
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
            else if (Age() < 14)
            {
                MessageBox.Show("Возраст обучающегося должен быть от 14 лет!");
                return false;
            }
            else return true;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Correct())
            {
                using (Context db = new Context())
                {
                    db.Students.Add(new Student
                    {
                        Surname = txtBoxSurname.Text,
                        Name = txtBoxName.Text,
                        Dadname = txtBoxDadname.Text,
                        Serial = (int)numUpDownSerial.Value,
                        Num = (int)numUpDownNum.Value,
                        BirthDate = BirthDatePicker.Value.Date
                    });
                    reload(db);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
            else
            {
                if (Correct())
                {
                    using (Context db = new Context())
                    {
                        foreach (DataGridViewRow row in dataGridStudent.SelectedRows)
                        {
                            DialogResult answer;
                            int id = (int)dataGridStudent[0, row.Index].Value;
                            Student delete_s = db.Students.Where(s => s.Id_Student == id).FirstOrDefault();
                            answer = MessageBox.Show($"Вы хотите удалить обучающегося {delete_s.Fullname}?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (answer == (DialogResult)6)
                            {
                                db.Students.Remove(delete_s);
                            }
                        }
                        reload(db);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
            else
            {
                if (Correct())
                {
                    int id = (int)dataGridStudent[0, dataGridStudent.SelectedRows[0].Index].Value;
                    using (Context db = new Context())
                    {
                        Student update_s = db.Students.Where(s => s.Id_Student == id).FirstOrDefault();
                        update_s.Surname = txtBoxSurname.Text;
                        update_s.Name = txtBoxName.Text;
                        update_s.Dadname = txtBoxDadname.Text;
                        update_s.Serial = (int)numUpDownSerial.Value;
                        update_s.Num = (int)numUpDownNum.Value;
                        update_s.BirthDate = BirthDatePicker.Value.Date;
                        reload(db);
                    }
                }
            }
        }

        private void FormStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }

        private void dataGridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                int row = dataGridStudent.SelectedRows[0].Index;

                txtBoxSurname.Text = dataGridStudent[1, row].Value.ToString();
                txtBoxName.Text = dataGridStudent[2, row].Value.ToString();
                txtBoxDadname.Text = dataGridStudent[3, row].Value.ToString();
                numUpDownSerial.Value = (int)dataGridStudent[4, row].Value;
                numUpDownNum.Value = (int)dataGridStudent[5, row].Value;
                BirthDatePicker.Value = (DateTime)dataGridStudent[6, row].Value;
            
            
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learningCoursesZyabchukDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.learningCoursesZyabchukDataSet.Student);
            dataGridStudent.ClearSelection();

        }

        private void Clear()
        {
            txtBoxSurname.Clear();
            txtBoxName.Clear();
            txtBoxDadname.Clear();
            numUpDownSerial.Value = 1000;
            numUpDownNum.Value = 100000;
            BirthDatePicker.Value = DateTime.Now;
        }
        private void dataGridStudent_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
