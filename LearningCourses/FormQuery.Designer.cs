namespace LearningCourses
{
    partial class FormQuery
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
            this.dataGridQuery = new System.Windows.Forms.DataGridView();
            this.btnDurationCourses = new System.Windows.Forms.Button();
            this.btnInformaitonCourse = new System.Windows.Forms.Button();
            this.btnRecordsCourse = new System.Windows.Forms.Button();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.learningCoursesZyabchukDataSet = new LearningCourses.LearningCoursesZyabchukDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new LearningCourses.LearningCoursesZyabchukDataSetTableAdapters.CourseTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningCoursesZyabchukDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQuery
            // 
            this.dataGridQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuery.Location = new System.Drawing.Point(33, 40);
            this.dataGridQuery.Name = "dataGridQuery";
            this.dataGridQuery.Size = new System.Drawing.Size(508, 257);
            this.dataGridQuery.TabIndex = 0;
            // 
            // btnDurationCourses
            // 
            this.btnDurationCourses.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDurationCourses.Location = new System.Drawing.Point(586, 61);
            this.btnDurationCourses.Name = "btnDurationCourses";
            this.btnDurationCourses.Size = new System.Drawing.Size(202, 23);
            this.btnDurationCourses.TabIndex = 1;
            this.btnDurationCourses.Text = "Курсы больше 6-ти месяцев";
            this.btnDurationCourses.UseVisualStyleBackColor = true;
            this.btnDurationCourses.Click += new System.EventHandler(this.btnDurationCourses_Click);
            // 
            // btnInformaitonCourse
            // 
            this.btnInformaitonCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInformaitonCourse.Location = new System.Drawing.Point(586, 125);
            this.btnInformaitonCourse.Name = "btnInformaitonCourse";
            this.btnInformaitonCourse.Size = new System.Drawing.Size(202, 23);
            this.btnInformaitonCourse.TabIndex = 2;
            this.btnInformaitonCourse.Text = "Информация о курсе";
            this.btnInformaitonCourse.UseVisualStyleBackColor = true;
            this.btnInformaitonCourse.Click += new System.EventHandler(this.btnInformaitonCourse_Click);
            // 
            // btnRecordsCourse
            // 
            this.btnRecordsCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRecordsCourse.Location = new System.Drawing.Point(586, 200);
            this.btnRecordsCourse.Name = "btnRecordsCourse";
            this.btnRecordsCourse.Size = new System.Drawing.Size(202, 22);
            this.btnRecordsCourse.TabIndex = 3;
            this.btnRecordsCourse.Text = "Записи на курсы";
            this.btnRecordsCourse.UseVisualStyleBackColor = true;
            this.btnRecordsCourse.Click += new System.EventHandler(this.btnRecordsCourse_Click);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxCourse.DataSource = this.courseBindingSource;
            this.comboBoxCourse.DisplayMember = "Name";
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(586, 276);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(202, 21);
            this.comboBoxCourse.TabIndex = 4;
            this.comboBoxCourse.ValueMember = "Id_Course";
            // 
            // learningCoursesZyabchukDataSet
            // 
            this.learningCoursesZyabchukDataSet.DataSetName = "LearningCoursesZyabchukDataSet";
            this.learningCoursesZyabchukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.learningCoursesZyabchukDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Курс:";
            // 
            // FormQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.btnRecordsCourse);
            this.Controls.Add(this.btnInformaitonCourse);
            this.Controls.Add(this.btnDurationCourses);
            this.Controls.Add(this.dataGridQuery);
            this.Name = "FormQuery";
            this.Text = "Запросы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuery_FormClosed);
            this.Load += new System.EventHandler(this.FormQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningCoursesZyabchukDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridQuery;
        private System.Windows.Forms.Button btnDurationCourses;
        private System.Windows.Forms.Button btnInformaitonCourse;
        private System.Windows.Forms.Button btnRecordsCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private LearningCoursesZyabchukDataSet learningCoursesZyabchukDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private LearningCoursesZyabchukDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}