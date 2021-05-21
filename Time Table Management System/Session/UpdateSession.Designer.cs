namespace Time_Table_Management_System.Session
{
    partial class UpdateSession
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
            this.title = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.groupBoxStep1 = new System.Windows.Forms.GroupBox();
            this.txtSelectedLec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLec = new System.Windows.Forms.ComboBox();
            this.comboBoxTag = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.groupBoxStep2 = new System.Windows.Forms.GroupBox();
            this.txtNoOfStudents = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            this.groupBoxStep1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.groupBoxStep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(108, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(214, 32);
            this.title.TabIndex = 16;
            this.title.Text = "Update Session";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl.Location = new System.Drawing.Point(31, 73);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(824, 343);
            this.tabControl.TabIndex = 17;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.groupBoxStep1);
            this.tab1.Location = new System.Drawing.Point(4, 32);
            this.tab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1.Size = new System.Drawing.Size(816, 307);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Select Lectures & Tag";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // groupBoxStep1
            // 
            this.groupBoxStep1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStep1.Controls.Add(this.txtSelectedLec);
            this.groupBoxStep1.Controls.Add(this.label3);
            this.groupBoxStep1.Controls.Add(this.comboBoxLec);
            this.groupBoxStep1.Controls.Add(this.comboBoxTag);
            this.groupBoxStep1.Controls.Add(this.label2);
            this.groupBoxStep1.Controls.Add(this.btnNext);
            this.groupBoxStep1.Controls.Add(this.btnClear);
            this.groupBoxStep1.Controls.Add(this.label1);
            this.groupBoxStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxStep1.Location = new System.Drawing.Point(5, 6);
            this.groupBoxStep1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStep1.Name = "groupBoxStep1";
            this.groupBoxStep1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStep1.Size = new System.Drawing.Size(804, 286);
            this.groupBoxStep1.TabIndex = 0;
            this.groupBoxStep1.TabStop = false;
            this.groupBoxStep1.Text = "Step 1";
            // 
            // txtSelectedLec
            // 
            this.txtSelectedLec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSelectedLec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedLec.Location = new System.Drawing.Point(213, 150);
            this.txtSelectedLec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelectedLec.Multiline = true;
            this.txtSelectedLec.Name = "txtSelectedLec";
            this.txtSelectedLec.ReadOnly = true;
            this.txtSelectedLec.Size = new System.Drawing.Size(555, 34);
            this.txtSelectedLec.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(23, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 36);
            this.label3.TabIndex = 32;
            this.label3.Text = "Selected Lecturer(s)";
            // 
            // comboBoxLec
            // 
            this.comboBoxLec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxLec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLec.FormattingEnabled = true;
            this.comboBoxLec.Location = new System.Drawing.Point(213, 78);
            this.comboBoxLec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLec.Name = "comboBoxLec";
            this.comboBoxLec.Size = new System.Drawing.Size(207, 33);
            this.comboBoxLec.TabIndex = 31;
            this.comboBoxLec.SelectedIndexChanged += new System.EventHandler(this.comboBoxLec_SelectedIndexChanged);
            // 
            // comboBoxTag
            // 
            this.comboBoxTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTag.FormattingEnabled = true;
            this.comboBoxTag.Location = new System.Drawing.Point(563, 78);
            this.comboBoxTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(207, 33);
            this.comboBoxTag.TabIndex = 30;
            this.comboBoxTag.SelectedIndexChanged += new System.EventHandler(this.comboBoxTag_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(443, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Select Tag";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Crimson;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Info;
            this.btnNext.Location = new System.Drawing.Point(511, 231);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 39);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClear.Location = new System.Drawing.Point(649, 231);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 39);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Lecturer(s)";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.groupBoxStep2);
            this.tab2.Location = new System.Drawing.Point(4, 32);
            this.tab2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab2.Size = new System.Drawing.Size(816, 307);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Select Group & Subject";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // groupBoxStep2
            // 
            this.groupBoxStep2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStep2.Controls.Add(this.txtNoOfStudents);
            this.groupBoxStep2.Controls.Add(this.txtDuration);
            this.groupBoxStep2.Controls.Add(this.label8);
            this.groupBoxStep2.Controls.Add(this.label7);
            this.groupBoxStep2.Controls.Add(this.comboBoxSubject);
            this.groupBoxStep2.Controls.Add(this.label4);
            this.groupBoxStep2.Controls.Add(this.comboBoxGroup);
            this.groupBoxStep2.Controls.Add(this.label5);
            this.groupBoxStep2.Controls.Add(this.label6);
            this.groupBoxStep2.Controls.Add(this.btnBack);
            this.groupBoxStep2.Controls.Add(this.btnClear2);
            this.groupBoxStep2.Controls.Add(this.btnSubmit);
            this.groupBoxStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxStep2.Location = new System.Drawing.Point(5, 6);
            this.groupBoxStep2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStep2.Name = "groupBoxStep2";
            this.groupBoxStep2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStep2.Size = new System.Drawing.Size(804, 286);
            this.groupBoxStep2.TabIndex = 1;
            this.groupBoxStep2.TabStop = false;
            this.groupBoxStep2.Text = "Step 2";
            // 
            // txtNoOfStudents
            // 
            this.txtNoOfStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoOfStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoOfStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfStudents.Location = new System.Drawing.Point(600, 74);
            this.txtNoOfStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoOfStudents.Name = "txtNoOfStudents";
            this.txtNoOfStudents.Size = new System.Drawing.Size(125, 30);
            this.txtNoOfStudents.TabIndex = 42;
            this.txtNoOfStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDuration
            // 
            this.txtDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(600, 135);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(125, 30);
            this.txtDuration.TabIndex = 41;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(731, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 36);
            this.label8.TabIndex = 40;
            this.label8.Text = "Hrs";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(436, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 36);
            this.label7.TabIndex = 38;
            this.label7.Text = "Duration";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(200, 134);
            this.comboBoxSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(207, 33);
            this.comboBoxSubject.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(37, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 36);
            this.label4.TabIndex = 36;
            this.label4.Text = "Select Subject";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(200, 73);
            this.comboBoxGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(207, 33);
            this.comboBoxGroup.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(436, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 36);
            this.label5.TabIndex = 34;
            this.label5.Text = "No. of Students";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(37, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 36);
            this.label6.TabIndex = 33;
            this.label6.Text = "Select Group";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBack.Location = new System.Drawing.Point(373, 231);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 39);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear2.BackColor = System.Drawing.Color.Crimson;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear2.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClear2.Location = new System.Drawing.Point(649, 231);
            this.btnClear2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(120, 39);
            this.btnClear2.TabIndex = 30;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Crimson;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSubmit.Location = new System.Drawing.Point(511, 231);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 39);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Update";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UpdateSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(881, 442);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateSession";
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.groupBoxStep1.ResumeLayout(false);
            this.groupBoxStep1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.groupBoxStep2.ResumeLayout(false);
            this.groupBoxStep2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.GroupBox groupBoxStep1;
        private System.Windows.Forms.TextBox txtSelectedLec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLec;
        private System.Windows.Forms.ComboBox comboBoxTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.GroupBox groupBoxStep2;
        private System.Windows.Forms.TextBox txtNoOfStudents;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnSubmit;
    }
}