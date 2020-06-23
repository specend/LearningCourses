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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FormStudent f = new FormStudent();
            f.Show();
            this.Hide();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            FormCourse f = new FormCourse();
            f.Show();
            this.Hide();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            FormRecord f = new FormRecord();
            f.Show();
            this.Hide();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQuery f = new FormQuery();
            f.Show();
            this.Hide();
        }
    }
}
