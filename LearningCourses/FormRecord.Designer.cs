namespace LearningCourses
{
    partial class FormRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridRecord = new System.Windows.Forms.DataGridView();
            this.Id_Record = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learningCoursesZyabchukDataSet = new LearningCourses.LearningCoursesZyabchukDataSet();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.studentTableAdapter = new LearningCourses.LearningCoursesZyabchukDataSetTableAdapters.StudentTableAdapter();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new LearningCourses.LearningCoursesZyabchukDataSetTableAdapters.CourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningCoursesZyabchukDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRecord
            // 
            this.dataGridRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Record,
            this.Id_Student,
            this.StudName,
            this.NameCourse});
            this.dataGridRecord.Location = new System.Drawing.Point(12, 21);
            this.dataGridRecord.Name = "dataGridRecord";
            this.dataGridRecord.RowHeadersVisible = false;
            this.dataGridRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRecord.Size = new System.Drawing.Size(544, 316);
            this.dataGridRecord.TabIndex = 28;
            this.dataGridRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRecord_CellClick);
            // 
            // Id_Record
            // 
            this.Id_Record.DataPropertyName = "Id_Record";
            this.Id_Record.HeaderText = "Id_Record";
            this.Id_Record.Name = "Id_Record";
            this.Id_Record.ReadOnly = true;
            this.Id_Record.Visible = false;
            // 
            // Id_Student
            // 
            this.Id_Student.DataPropertyName = "Id_Student";
            this.Id_Student.HeaderText = "Id_Student";
            this.Id_Student.Name = "Id_Student";
            this.Id_Student.ReadOnly = true;
            this.Id_Student.Visible = false;
            // 
            // StudName
            // 
            this.StudName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudName.DataPropertyName = "StudName";
            this.StudName.HeaderText = "Обучающийся";
            this.StudName.Name = "StudName";
            this.StudName.ReadOnly = true;
            // 
            // NameCourse
            // 
            this.NameCourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCourse.DataPropertyName = "NameCourse";
            this.NameCourse.HeaderText = "Курс";
            this.NameCourse.Name = "NameCourse";
            this.NameCourse.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Курс";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Студент";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCourse.DataSource = this.courseBindingSource;
            this.comboBoxCourse.DisplayMember = "Name";
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(633, 82);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(213, 21);
            this.comboBoxCourse.TabIndex = 25;
            this.comboBoxCourse.ValueMember = "Id_Course";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.learningCoursesZyabchukDataSet;
            // 
            // learningCoursesZyabchukDataSet
            // 
            this.learningCoursesZyabchukDataSet.DataSetName = "LearningCoursesZyabchukDataSet";
            this.learningCoursesZyabchukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStudent.DataSource = this.studentBindingSource;
            this.comboBoxStudent.DisplayMember = "Surname";
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(633, 20);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(213, 21);
            this.comboBoxStudent.TabIndex = 24;
            this.comboBoxStudent.ValueMember = "Id_Student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.learningCoursesZyabchukDataSet;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(581, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(265, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(581, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(265, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(581, 143);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(265, 23);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataMember = "Record";
            this.recordBindingSource.DataSource = this.learningCoursesZyabchukDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // FormRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 359);
            this.Controls.Add(this.dataGridRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Name = "FormRecord";
            this.Text = "Записи на курсы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRecord_FormClosed);
            this.Load += new System.EventHandler(this.FormRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningCoursesZyabchukDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private LearningCoursesZyabchukDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private LearningCoursesZyabchukDataSet learningCoursesZyabchukDataSet;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private LearningCoursesZyabchukDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Record;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCourse;
    }
}