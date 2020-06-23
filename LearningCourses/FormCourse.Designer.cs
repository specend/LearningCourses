namespace LearningCourses
{
    partial class FormCourse
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxCourse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.txtBoxDadname = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridCourse = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learningCoursesZyabchukDataSet = new LearningCourses.LearningCoursesZyabchukDataSet();
            this.courseTableAdapter = new LearningCourses.LearningCoursesZyabchukDataSetTableAdapters.CourseTableAdapter();
            this.idCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameteacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameteacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadnameteacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningCoursesZyabchukDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Курс";
            // 
            // txtBoxCourse
            // 
            this.txtBoxCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCourse.Location = new System.Drawing.Point(850, 60);
            this.txtBoxCourse.MaxLength = 50;
            this.txtBoxCourse.Name = "txtBoxCourse";
            this.txtBoxCourse.Size = new System.Drawing.Size(209, 20);
            this.txtBoxCourse.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Длительность";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(763, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(763, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Фамилия";
            // 
            // numUpDownDuration
            // 
            this.numUpDownDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownDuration.Location = new System.Drawing.Point(850, 313);
            this.numUpDownDuration.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpDownDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownDuration.Name = "numUpDownDuration";
            this.numUpDownDuration.Size = new System.Drawing.Size(209, 20);
            this.numUpDownDuration.TabIndex = 57;
            this.numUpDownDuration.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numUpDownPrice
            // 
            this.numUpDownPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownPrice.Location = new System.Drawing.Point(850, 259);
            this.numUpDownPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownPrice.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownPrice.Name = "numUpDownPrice";
            this.numUpDownPrice.Size = new System.Drawing.Size(209, 20);
            this.numUpDownPrice.TabIndex = 56;
            this.numUpDownPrice.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // txtBoxDadname
            // 
            this.txtBoxDadname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDadname.Location = new System.Drawing.Point(850, 213);
            this.txtBoxDadname.MaxLength = 50;
            this.txtBoxDadname.Name = "txtBoxDadname";
            this.txtBoxDadname.Size = new System.Drawing.Size(209, 20);
            this.txtBoxDadname.TabIndex = 55;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxName.Location = new System.Drawing.Point(850, 164);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(209, 20);
            this.txtBoxName.TabIndex = 54;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSurname.Location = new System.Drawing.Point(850, 114);
            this.txtBoxSurname.MaxLength = 50;
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(209, 20);
            this.txtBoxSurname.TabIndex = 53;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(984, 351);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(872, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(758, 351);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 50;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridCourse
            // 
            this.dataGridCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCourse.AutoGenerateColumns = false;
            this.dataGridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCourseDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameteacherDataGridViewTextBoxColumn,
            this.nameteacherDataGridViewTextBoxColumn,
            this.dadnameteacherDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dataGridCourse.DataSource = this.courseBindingSource;
            this.dataGridCourse.Location = new System.Drawing.Point(12, 46);
            this.dataGridCourse.Name = "dataGridCourse";
            this.dataGridCourse.RowHeadersVisible = false;
            this.dataGridCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCourse.Size = new System.Drawing.Size(709, 346);
            this.dataGridCourse.TabIndex = 49;
            this.dataGridCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCourse_CellClick);
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
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // idCourseDataGridViewTextBoxColumn
            // 
            this.idCourseDataGridViewTextBoxColumn.DataPropertyName = "Id_Course";
            this.idCourseDataGridViewTextBoxColumn.HeaderText = "Id_Course";
            this.idCourseDataGridViewTextBoxColumn.Name = "idCourseDataGridViewTextBoxColumn";
            this.idCourseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCourseDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название_курса";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameteacherDataGridViewTextBoxColumn
            // 
            this.surnameteacherDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameteacherDataGridViewTextBoxColumn.DataPropertyName = "Surname_teacher";
            this.surnameteacherDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameteacherDataGridViewTextBoxColumn.Name = "surnameteacherDataGridViewTextBoxColumn";
            // 
            // nameteacherDataGridViewTextBoxColumn
            // 
            this.nameteacherDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameteacherDataGridViewTextBoxColumn.DataPropertyName = "Name_teacher";
            this.nameteacherDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameteacherDataGridViewTextBoxColumn.Name = "nameteacherDataGridViewTextBoxColumn";
            // 
            // dadnameteacherDataGridViewTextBoxColumn
            // 
            this.dadnameteacherDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dadnameteacherDataGridViewTextBoxColumn.DataPropertyName = "Dadname_teacher";
            this.dadnameteacherDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.dadnameteacherDataGridViewTextBoxColumn.Name = "dadnameteacherDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDownDuration);
            this.Controls.Add(this.numUpDownPrice);
            this.Controls.Add(this.txtBoxDadname);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridCourse);
            this.Name = "FormCourse";
            this.Text = "Курсы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCourse_FormClosed);
            this.Load += new System.EventHandler(this.FormCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningCoursesZyabchukDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDownDuration;
        private System.Windows.Forms.NumericUpDown numUpDownPrice;
        private System.Windows.Forms.TextBox txtBoxDadname;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridCourse;
        private LearningCoursesZyabchukDataSet learningCoursesZyabchukDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private LearningCoursesZyabchukDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadnameteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
    }
}