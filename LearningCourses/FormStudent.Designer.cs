namespace LearningCourses
{
    partial class FormStudent
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.numUpDownNum = new System.Windows.Forms.NumericUpDown();
            this.numUpDownSerial = new System.Windows.Forms.NumericUpDown();
            this.txtBoxDadname = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learningCoursesZyabchukDataSet = new LearningCourses.LearningCoursesZyabchukDataSet();
            this.studentTableAdapter = new LearningCourses.LearningCoursesZyabchukDataSetTableAdapters.StudentTableAdapter();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSerial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningCoursesZyabchukDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(782, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(782, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Номер";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(782, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Серия";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Фамилия";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BirthDatePicker.Location = new System.Drawing.Point(878, 301);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(209, 20);
            this.BirthDatePicker.TabIndex = 45;
            // 
            // numUpDownNum
            // 
            this.numUpDownNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numUpDownNum.Location = new System.Drawing.Point(878, 252);
            this.numUpDownNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUpDownNum.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownNum.Name = "numUpDownNum";
            this.numUpDownNum.Size = new System.Drawing.Size(209, 20);
            this.numUpDownNum.TabIndex = 44;
            this.numUpDownNum.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // numUpDownSerial
            // 
            this.numUpDownSerial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numUpDownSerial.Location = new System.Drawing.Point(878, 198);
            this.numUpDownSerial.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDownSerial.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownSerial.Name = "numUpDownSerial";
            this.numUpDownSerial.Size = new System.Drawing.Size(209, 20);
            this.numUpDownSerial.TabIndex = 43;
            this.numUpDownSerial.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtBoxDadname
            // 
            this.txtBoxDadname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxDadname.Location = new System.Drawing.Point(878, 152);
            this.txtBoxDadname.MaxLength = 50;
            this.txtBoxDadname.Name = "txtBoxDadname";
            this.txtBoxDadname.Size = new System.Drawing.Size(209, 20);
            this.txtBoxDadname.TabIndex = 42;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxName.Location = new System.Drawing.Point(878, 103);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(209, 20);
            this.txtBoxName.TabIndex = 41;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxSurname.Location = new System.Drawing.Point(878, 53);
            this.txtBoxSurname.MaxLength = 50;
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(209, 20);
            this.txtBoxSurname.TabIndex = 40;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.Location = new System.Drawing.Point(1011, 376);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Location = new System.Drawing.Point(899, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInsert.Location = new System.Drawing.Point(785, 376);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 37;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStudent.AutoGenerateColumns = false;
            this.dataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dadnameDataGridViewTextBoxColumn,
            this.serialDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn});
            this.dataGridStudent.DataSource = this.studentBindingSource;
            this.dataGridStudent.Location = new System.Drawing.Point(12, 53);
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.RowHeadersVisible = false;
            this.dataGridStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStudent.Size = new System.Drawing.Size(764, 346);
            this.dataGridStudent.TabIndex = 36;
            this.dataGridStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudent_CellClick);
            this.dataGridStudent.SelectionChanged += new System.EventHandler(this.dataGridStudent_SelectionChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.learningCoursesZyabchukDataSet;
            // 
            // learningCoursesZyabchukDataSet
            // 
            this.learningCoursesZyabchukDataSet.DataSetName = "LearningCoursesZyabchukDataSet";
            this.learningCoursesZyabchukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "Id_Student";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "Id_Student";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            this.idStudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStudentDataGridViewTextBoxColumn.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dadnameDataGridViewTextBoxColumn
            // 
            this.dadnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dadnameDataGridViewTextBoxColumn.DataPropertyName = "Dadname";
            this.dadnameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.dadnameDataGridViewTextBoxColumn.Name = "dadnameDataGridViewTextBoxColumn";
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Серия";
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.numUpDownNum);
            this.Controls.Add(this.numUpDownSerial);
            this.Controls.Add(this.txtBoxDadname);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridStudent);
            this.Name = "FormStudent";
            this.Text = "Обучающиеся";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStudent_FormClosed);
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSerial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningCoursesZyabchukDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.NumericUpDown numUpDownNum;
        private System.Windows.Forms.NumericUpDown numUpDownSerial;
        private System.Windows.Forms.TextBox txtBoxDadname;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridStudent;
        private LearningCoursesZyabchukDataSet learningCoursesZyabchukDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private LearningCoursesZyabchukDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
    }
}