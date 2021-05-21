namespace Time_Table_Management_System
{
    partial class ManageSubjects
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
            this.btnClose = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataGridSubjects = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offeredYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offeredSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuteHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numericEvaluationHours = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericLabHours = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericTuteHours = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericLecHours = new System.Windows.Forms.NumericUpDown();
            this.textBoxSubCode = new System.Windows.Forms.TextBox();
            this.textBoxSubName = new System.Windows.Forms.TextBox();
            this.radioButtonSem2 = new System.Windows.Forms.RadioButton();
            this.radioButtonSem1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOfferdYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorManageSubjects = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEvaluationHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLabHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTuteHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLecHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorManageSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClose.Location = new System.Drawing.Point(2, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 20);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(87, 24);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 26);
            this.title.TabIndex = 14;
            this.title.Text = "Manage Subjects";
            // 
            // dataGridSubjects
            // 
            this.dataGridSubjects.AllowUserToAddRows = false;
            this.dataGridSubjects.AllowUserToDeleteRows = false;
            this.dataGridSubjects.AllowUserToResizeColumns = false;
            this.dataGridSubjects.AllowUserToResizeRows = false;
            this.dataGridSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSubjects.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subjectName,
            this.subjectCode,
            this.offeredYear,
            this.offeredSem,
            this.lecHours,
            this.tuteHours,
            this.labHours,
            this.evaluationHours});
            this.dataGridSubjects.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridSubjects.Location = new System.Drawing.Point(23, 67);
            this.dataGridSubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridSubjects.Name = "dataGridSubjects";
            this.dataGridSubjects.ReadOnly = true;
            this.dataGridSubjects.RowHeadersVisible = false;
            this.dataGridSubjects.RowHeadersWidth = 51;
            this.dataGridSubjects.RowTemplate.Height = 24;
            this.dataGridSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSubjects.Size = new System.Drawing.Size(509, 127);
            this.dataGridSubjects.TabIndex = 5;
            this.dataGridSubjects.SelectionChanged += new System.EventHandler(this.dataGrid_Selection);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // subjectName
            // 
            this.subjectName.HeaderText = "Subject Name";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            this.subjectName.Width = 125;
            // 
            // subjectCode
            // 
            this.subjectCode.HeaderText = "Subject Code";
            this.subjectCode.MinimumWidth = 6;
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.ReadOnly = true;
            this.subjectCode.Width = 125;
            // 
            // offeredYear
            // 
            this.offeredYear.HeaderText = "Offered Year";
            this.offeredYear.MinimumWidth = 6;
            this.offeredYear.Name = "offeredYear";
            this.offeredYear.ReadOnly = true;
            this.offeredYear.Width = 125;
            // 
            // offeredSem
            // 
            this.offeredSem.HeaderText = "Offered Sem";
            this.offeredSem.MinimumWidth = 6;
            this.offeredSem.Name = "offeredSem";
            this.offeredSem.ReadOnly = true;
            this.offeredSem.Width = 125;
            // 
            // lecHours
            // 
            this.lecHours.HeaderText = "Lec Hours";
            this.lecHours.MinimumWidth = 6;
            this.lecHours.Name = "lecHours";
            this.lecHours.ReadOnly = true;
            this.lecHours.Visible = false;
            this.lecHours.Width = 125;
            // 
            // tuteHours
            // 
            this.tuteHours.HeaderText = "TuteHours";
            this.tuteHours.MinimumWidth = 6;
            this.tuteHours.Name = "tuteHours";
            this.tuteHours.ReadOnly = true;
            this.tuteHours.Visible = false;
            this.tuteHours.Width = 125;
            // 
            // labHours
            // 
            this.labHours.HeaderText = "LabHours";
            this.labHours.MinimumWidth = 6;
            this.labHours.Name = "labHours";
            this.labHours.ReadOnly = true;
            this.labHours.Visible = false;
            this.labHours.Width = 125;
            // 
            // evaluationHours
            // 
            this.evaluationHours.HeaderText = "EvaluationHours";
            this.evaluationHours.MinimumWidth = 6;
            this.evaluationHours.Name = "evaluationHours";
            this.evaluationHours.ReadOnly = true;
            this.evaluationHours.Visible = false;
            this.evaluationHours.Width = 125;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClear.Location = new System.Drawing.Point(550, 156);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Location = new System.Drawing.Point(550, 111);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Location = new System.Drawing.Point(550, 67);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 32);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numericEvaluationHours
            // 
            this.numericEvaluationHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericEvaluationHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEvaluationHours.Location = new System.Drawing.Point(565, 311);
            this.numericEvaluationHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericEvaluationHours.Name = "numericEvaluationHours";
            this.numericEvaluationHours.Size = new System.Drawing.Size(59, 23);
            this.numericEvaluationHours.TabIndex = 69;
            this.numericEvaluationHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(394, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "Number of Evaluation Hours";
            // 
            // numericLabHours
            // 
            this.numericLabHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericLabHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericLabHours.Location = new System.Drawing.Point(565, 276);
            this.numericLabHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericLabHours.Name = "numericLabHours";
            this.numericLabHours.Size = new System.Drawing.Size(59, 23);
            this.numericLabHours.TabIndex = 67;
            this.numericLabHours.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(394, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Number of Lab Hours";
            // 
            // numericTuteHours
            // 
            this.numericTuteHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericTuteHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTuteHours.Location = new System.Drawing.Point(565, 242);
            this.numericTuteHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericTuteHours.Name = "numericTuteHours";
            this.numericTuteHours.Size = new System.Drawing.Size(59, 23);
            this.numericTuteHours.TabIndex = 65;
            this.numericTuteHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(394, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Number of Tutorial Hours";
            // 
            // numericLecHours
            // 
            this.numericLecHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericLecHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericLecHours.Location = new System.Drawing.Point(566, 209);
            this.numericLecHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericLecHours.Name = "numericLecHours";
            this.numericLecHours.Size = new System.Drawing.Size(59, 23);
            this.numericLecHours.TabIndex = 63;
            this.numericLecHours.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBoxSubCode
            // 
            this.textBoxSubCode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxSubCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubCode.Location = new System.Drawing.Point(149, 311);
            this.textBoxSubCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubCode.Name = "textBoxSubCode";
            this.textBoxSubCode.Size = new System.Drawing.Size(187, 23);
            this.textBoxSubCode.TabIndex = 62;
            // 
            // textBoxSubName
            // 
            this.textBoxSubName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxSubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubName.Location = new System.Drawing.Point(149, 276);
            this.textBoxSubName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubName.Name = "textBoxSubName";
            this.textBoxSubName.Size = new System.Drawing.Size(187, 23);
            this.textBoxSubName.TabIndex = 61;
            // 
            // radioButtonSem2
            // 
            this.radioButtonSem2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonSem2.AutoSize = true;
            this.radioButtonSem2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButtonSem2.Location = new System.Drawing.Point(251, 245);
            this.radioButtonSem2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSem2.Name = "radioButtonSem2";
            this.radioButtonSem2.Size = new System.Drawing.Size(86, 17);
            this.radioButtonSem2.TabIndex = 60;
            this.radioButtonSem2.TabStop = true;
            this.radioButtonSem2.Text = "2st Semester";
            this.radioButtonSem2.UseVisualStyleBackColor = true;
            // 
            // radioButtonSem1
            // 
            this.radioButtonSem1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonSem1.AutoSize = true;
            this.radioButtonSem1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButtonSem1.Location = new System.Drawing.Point(149, 245);
            this.radioButtonSem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSem1.Name = "radioButtonSem1";
            this.radioButtonSem1.Size = new System.Drawing.Size(86, 17);
            this.radioButtonSem1.TabIndex = 59;
            this.radioButtonSem1.TabStop = true;
            this.radioButtonSem1.Text = "1st Semester";
            this.radioButtonSem1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(396, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Number of Lecture Hours";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(36, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Subject Code";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(36, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(36, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Offerd Semester";
            // 
            // comboBoxOfferdYear
            // 
            this.comboBoxOfferdYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxOfferdYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfferdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOfferdYear.FormattingEnabled = true;
            this.comboBoxOfferdYear.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.comboBoxOfferdYear.Location = new System.Drawing.Point(151, 208);
            this.comboBoxOfferdYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxOfferdYear.Name = "comboBoxOfferdYear";
            this.comboBoxOfferdYear.Size = new System.Drawing.Size(187, 25);
            this.comboBoxOfferdYear.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(38, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Offerd Year";
            // 
            // errorManageSubjects
            // 
            this.errorManageSubjects.ContainerControl = this;
            // 
            // ManageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(661, 359);
            this.Controls.Add(this.numericEvaluationHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericLabHours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericTuteHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericLecHours);
            this.Controls.Add(this.textBoxSubCode);
            this.Controls.Add(this.textBoxSubName);
            this.Controls.Add(this.radioButtonSem2);
            this.Controls.Add(this.radioButtonSem1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOfferdYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridSubjects);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageSubjects";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEvaluationHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLabHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTuteHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLecHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorManageSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridSubjects;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numericEvaluationHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericLabHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericTuteHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericLecHours;
        private System.Windows.Forms.TextBox textBoxSubCode;
        private System.Windows.Forms.TextBox textBoxSubName;
        private System.Windows.Forms.RadioButton radioButtonSem2;
        private System.Windows.Forms.RadioButton radioButtonSem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOfferdYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn offeredYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn offeredSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuteHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn labHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationHours;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorManageSubjects;
    }
}