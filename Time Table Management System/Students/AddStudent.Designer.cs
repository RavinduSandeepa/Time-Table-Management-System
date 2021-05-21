namespace Time_Table_Management_System.Students
{
    partial class AddStudent
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
            this.title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYearSem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProgramme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGroupID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSubGroupID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btngenerateIDs = new System.Windows.Forms.Button();
            this.errorStudent = new System.Windows.Forms.ErrorProvider(this.components);
            this.numericGroupNo = new System.Windows.Forms.NumericUpDown();
            this.numericsubGroup = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGroupNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsubGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(81, 29);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(227, 26);
            this.title.TabIndex = 2;
            this.title.Text = "Add Student Groups";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(2, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(52, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Academic Year & Semester";
            // 
            // textBoxYearSem
            // 
            this.textBoxYearSem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxYearSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxYearSem.Location = new System.Drawing.Point(232, 89);
            this.textBoxYearSem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxYearSem.Name = "textBoxYearSem";
            this.textBoxYearSem.Size = new System.Drawing.Size(193, 24);
            this.textBoxYearSem.TabIndex = 15;
            this.textBoxYearSem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(52, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Programme";
            // 
            // comboBoxProgramme
            // 
            this.comboBoxProgramme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxProgramme.FormattingEnabled = true;
            this.comboBoxProgramme.Items.AddRange(new object[] {
            "IT",
            "CSSE",
            "CSE",
            "DS",
            "CN"});
            this.comboBoxProgramme.Location = new System.Drawing.Point(232, 134);
            this.comboBoxProgramme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProgramme.Name = "comboBoxProgramme";
            this.comboBoxProgramme.Size = new System.Drawing.Size(193, 26);
            this.comboBoxProgramme.TabIndex = 17;
            this.comboBoxProgramme.Tag = "";
            this.comboBoxProgramme.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(52, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Group Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(52, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Group ID";
            // 
            // textBoxGroupID
            // 
            this.textBoxGroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxGroupID.Location = new System.Drawing.Point(232, 260);
            this.textBoxGroupID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGroupID.Name = "textBoxGroupID";
            this.textBoxGroupID.ReadOnly = true;
            this.textBoxGroupID.Size = new System.Drawing.Size(193, 24);
            this.textBoxGroupID.TabIndex = 21;
            this.textBoxGroupID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(52, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sub Group Number";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(52, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sub Group ID";
            // 
            // textBoxSubGroupID
            // 
            this.textBoxSubGroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSubGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSubGroupID.Location = new System.Drawing.Point(232, 300);
            this.textBoxSubGroupID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubGroupID.Name = "textBoxSubGroupID";
            this.textBoxSubGroupID.ReadOnly = true;
            this.textBoxSubGroupID.Size = new System.Drawing.Size(193, 24);
            this.textBoxSubGroupID.TabIndex = 25;
            this.textBoxSubGroupID.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClear.Location = new System.Drawing.Point(498, 234);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 32);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Crimson;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSave.Location = new System.Drawing.Point(498, 177);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 32);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngenerateIDs
            // 
            this.btngenerateIDs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngenerateIDs.BackColor = System.Drawing.Color.Crimson;
            this.btngenerateIDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerateIDs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerateIDs.ForeColor = System.Drawing.SystemColors.Info;
            this.btngenerateIDs.Location = new System.Drawing.Point(498, 121);
            this.btngenerateIDs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btngenerateIDs.Name = "btngenerateIDs";
            this.btngenerateIDs.Size = new System.Drawing.Size(122, 32);
            this.btngenerateIDs.TabIndex = 28;
            this.btngenerateIDs.Text = "Generate IDs";
            this.btngenerateIDs.UseVisualStyleBackColor = false;
            this.btngenerateIDs.Click += new System.EventHandler(this.btnGenerateIDs_Click);
            // 
            // errorStudent
            // 
            this.errorStudent.ContainerControl = this;
            // 
            // numericGroupNo
            // 
            this.numericGroupNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericGroupNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericGroupNo.Location = new System.Drawing.Point(232, 177);
            this.numericGroupNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericGroupNo.Name = "numericGroupNo";
            this.numericGroupNo.Size = new System.Drawing.Size(193, 24);
            this.numericGroupNo.TabIndex = 29;
            // 
            // numericsubGroup
            // 
            this.numericsubGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericsubGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericsubGroup.Location = new System.Drawing.Point(232, 219);
            this.numericsubGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericsubGroup.Name = "numericsubGroup";
            this.numericsubGroup.Size = new System.Drawing.Size(193, 24);
            this.numericsubGroup.TabIndex = 30;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(661, 359);
            this.Controls.Add(this.numericsubGroup);
            this.Controls.Add(this.numericGroupNo);
            this.Controls.Add(this.btngenerateIDs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBoxSubGroupID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGroupID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProgramme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYearSem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.errorStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGroupNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsubGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYearSem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProgramme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGroupID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSubGroupID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btngenerateIDs;
        private System.Windows.Forms.ErrorProvider errorStudent;
        private System.Windows.Forms.NumericUpDown numericsubGroup;
        private System.Windows.Forms.NumericUpDown numericGroupNo;
    }
}