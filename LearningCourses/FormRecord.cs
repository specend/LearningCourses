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

namespace LearningCourses
{
    public partial class FormRecord : Form
    {
        public FormRecord()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                ExecQuery(db);
                comboBoxStudent.DataSource = db.Students.ToList();
                comboBoxCourse.DataSource = db.Courses.ToList();
            }
            dataGridRecord.ClearSelection();
        }
        void reload(Context db)
        {
            try
            {
                db.SaveChanges();
                ExecQuery(db);
                dataGridRecord.ClearSelection();
                Clear();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Данный обучающийся уже записан на этот курс!");
            }
        }
        void ExecQuery(Context db)
        {
            dataGridRecord.DataSource = db.Records.Join(db.Courses, r => r.Id_Course, c => c.Id_Course,
                (r, c) =>
            new
            {
                r.Id_Record,
                c.Name,
                NameCourse = c.Name,
                Id_Student = r.Id_Student
            }
            ).Join(db.Students, rc => rc.Id_Student, s => s.Id_Student,
            (rc, s) =>
            new
            {
                rc.Id_Record,
                rc.Id_Student,
                StudName = s.Surname + " " + s.Name + " " + s.Dadname,
                NameCourse = rc.Name
            }).ToList();
        }
        private void FormRecord_Load(object sender, EventArgs e)
        {
            dataGridRecord.ClearSelection();
            Clear();

        }
        void Clear()
        {
            comboBoxCourse.Text = "";
            comboBoxStudent.Text = "";
        }
        private void FormRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }

        private void dataGridRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridRecord.SelectedRows[0].Index;

            comboBoxStudent.SelectedValue = dataGridRecord[1, row].Value;
            comboBoxStudent.Text = dataGridRecord[2, row].Value.ToString();
            comboBoxCourse.Text = dataGridRecord[3, row].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                db.Records.Add(new Record
                {
                    Id_Student = (int)comboBoxStudent.SelectedValue,
                    Id_Course = (int)comboBoxCourse.SelectedValue
                });
                reload(db);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridRecord.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
            else
            {
                using (Context db = new Context())
                {
                    foreach (DataGridViewRow row in dataGridRecord.SelectedRows)
                    {
                        DialogResult answer;
                        int id = (int)dataGridRecord[0, row.Index].Value;
                        Record delete_r = db.Records.Where(r => r.Id_Record == id).FirstOrDefault();
                        answer = MessageBox.Show($"Вы хотите удалить эту запись обучающегося {comboBoxStudent.Text} на курс {comboBoxCourse.Text}?", 
                            "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (answer == (DialogResult)6)
                        {
                            db.Records.Remove(delete_r);
                        }
                    }
                    reload(db);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridRecord.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для изменения!");
            }
            else
            {
                int id = (int)dataGridRecord[0, dataGridRecord.SelectedRows[0].Index].Value;
                using (Context db = new Context())
                {
                    Record update_r = db.Records.Where(r => r.Id_Record == id).FirstOrDefault();
                    update_r.Id_Student = Convert.ToInt32(comboBoxStudent.SelectedValue);
                    update_r.Id_Course = Convert.ToInt32(comboBoxCourse.SelectedValue);
                    reload(db);
                }
            }
        }
    }
}
