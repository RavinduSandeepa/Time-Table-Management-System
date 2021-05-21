namespace Time_Table_Management_System.DaysAndHours
{
    partial class AddTimeSlots
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
            this.dataGridTimeSlots = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericSThours = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddTimeSlot = new System.Windows.Forms.Button();
            this.errorProviderTimeSlot = new System.Windows.Forms.ErrorProvider(this.components);
            this.label = new System.Windows.Forms.Label();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.btnDeleteTimeSlot = new System.Windows.Forms.Button();
            this.comboBoxSTMinutes = new System.Windows.Forms.ComboBox();
            this.btnGenerateRank = new System.Windows.Forms.Button();
            this.ETMinutes = new System.Windows.Forms.TextBox();
            this.ETHours = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimeSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSThours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTimeSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTimeSlots
            // 
            this.dataGridTimeSlots.AllowUserToAddRows = false;
            this.dataGridTimeSlots.AllowUserToDeleteRows = false;
            this.dataGridTimeSlots.AllowUserToResizeColumns = false;
            this.dataGridTimeSlots.AllowUserToResizeRows = false;
            this.dataGridTimeSlots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridTimeSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTimeSlots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StartTime,
            this.EndTime,
            this.Duration});
            this.dataGridTimeSlots.Location = new System.Drawing.Point(65, 228);
            this.dataGridTimeSlots.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridTimeSlots.Name = "dataGridTimeSlots";
            this.dataGridTimeSlots.RowHeadersWidth = 51;
            this.dataGridTimeSlots.RowTemplate.Height = 24;
            this.dataGridTimeSlots.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridTimeSlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTimeSlots.Size = new System.Drawing.Size(550, 111);
            this.dataGridTimeSlots.TabIndex = 19;
            this.dataGridTimeSlots.SelectionChanged += new System.EventHandler(this.dataGrid_Selection);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // StartTime
            // 
            this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            // 
            // EndTime
            // 
            this.EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndTime.HeaderText = "End Time";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.Width = 125;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(87, 24);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(212, 26);
            this.title.TabIndex = 18;
            this.title.Text = "Manage Time Slots";
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
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(62, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Start Time";
            // 
            // numericSThours
            // 
            this.numericSThours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericSThours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSThours.Location = new System.Drawing.Point(190, 94);
            this.numericSThours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericSThours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericSThours.Name = "numericSThours";
            this.numericSThours.Size = new System.Drawing.Size(83, 23);
            this.numericSThours.TabIndex = 43;
            this.numericSThours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(450, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(287, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Hours";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(450, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(287, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Hours";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(62, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "End Time";
            // 
            // btnAddTimeSlot
            // 
            this.btnAddTimeSlot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTimeSlot.BackColor = System.Drawing.Color.Crimson;
            this.btnAddTimeSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTimeSlot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTimeSlot.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddTimeSlot.Location = new System.Drawing.Point(526, 94);
            this.btnAddTimeSlot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTimeSlot.Name = "btnAddTimeSlot";
            this.btnAddTimeSlot.Size = new System.Drawing.Size(90, 35);
            this.btnAddTimeSlot.TabIndex = 50;
            this.btnAddTimeSlot.Text = "Add ";
            this.btnAddTimeSlot.UseVisualStyleBackColor = false;
            this.btnAddTimeSlot.Click += new System.EventHandler(this.btnAddTimeSlot_Click);
            // 
            // errorProviderTimeSlot
            // 
            this.errorProviderTimeSlot.ContainerControl = this;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label.Location = new System.Drawing.Point(62, 133);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(125, 17);
            this.label.TabIndex = 51;
            this.label.Text = "Time Slot Duration";
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDuration.AutoCompleteCustomSource.AddRange(new string[] {
            "30 Minutes",
            "1 Hour",
            "2 Hours"});
            this.comboBoxDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Items.AddRange(new object[] {
            "30 Minutes",
            "1 Hour",
            "2 Hours"});
            this.comboBoxDuration.Location = new System.Drawing.Point(190, 131);
            this.comboBoxDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(84, 25);
            this.comboBoxDuration.TabIndex = 52;
            // 
            // btnDeleteTimeSlot
            // 
            this.btnDeleteTimeSlot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTimeSlot.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteTimeSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTimeSlot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTimeSlot.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDeleteTimeSlot.Location = new System.Drawing.Point(526, 157);
            this.btnDeleteTimeSlot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteTimeSlot.Name = "btnDeleteTimeSlot";
            this.btnDeleteTimeSlot.Size = new System.Drawing.Size(90, 37);
            this.btnDeleteTimeSlot.TabIndex = 53;
            this.btnDeleteTimeSlot.Text = "Delete";
            this.btnDeleteTimeSlot.UseVisualStyleBackColor = false;
            this.btnDeleteTimeSlot.Click += new System.EventHandler(this.btnDeleteTimeSlot_Click);
            // 
            // comboBoxSTMinutes
            // 
            this.comboBoxSTMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSTMinutes.AutoCompleteCustomSource.AddRange(new string[] {
            "30 Minutes",
            "1 Hour",
            "2 Hours"});
            this.comboBoxSTMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSTMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSTMinutes.FormattingEnabled = true;
            this.comboBoxSTMinutes.Items.AddRange(new object[] {
            "00",
            "30"});
            this.comboBoxSTMinutes.Location = new System.Drawing.Point(354, 94);
            this.comboBoxSTMinutes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSTMinutes.Name = "comboBoxSTMinutes";
            this.comboBoxSTMinutes.Size = new System.Drawing.Size(84, 25);
            this.comboBoxSTMinutes.TabIndex = 54;
            // 
            // btnGenerateRank
            // 
            this.btnGenerateRank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerateRank.BackColor = System.Drawing.Color.Snow;
            this.btnGenerateRank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateRank.Image = global::Time_Table_Management_System.Properties.Resources.generate;
            this.btnGenerateRank.Location = new System.Drawing.Point(290, 125);
            this.btnGenerateRank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateRank.Name = "btnGenerateRank";
            this.btnGenerateRank.Size = new System.Drawing.Size(38, 28);
            this.btnGenerateRank.TabIndex = 55;
            this.btnGenerateRank.UseVisualStyleBackColor = false;
            this.btnGenerateRank.Click += new System.EventHandler(this.btnGenerateRank_Click);
            // 
            // ETMinutes
            // 
            this.ETMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ETMinutes.Enabled = false;
            this.ETMinutes.Location = new System.Drawing.Point(354, 177);
            this.ETMinutes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ETMinutes.Name = "ETMinutes";
            this.ETMinutes.ReadOnly = true;
            this.ETMinutes.Size = new System.Drawing.Size(84, 20);
            this.ETMinutes.TabIndex = 57;
            this.ETMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ETHours
            // 
            this.ETHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ETHours.Enabled = false;
            this.ETHours.Location = new System.Drawing.Point(190, 177);
            this.ETHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ETHours.Name = "ETHours";
            this.ETHours.ReadOnly = true;
            this.ETHours.Size = new System.Drawing.Size(84, 20);
            this.ETHours.TabIndex = 58;
            this.ETHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddTimeSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(661, 359);
            this.Controls.Add(this.ETHours);
            this.Controls.Add(this.ETMinutes);
            this.Controls.Add(this.btnGenerateRank);
            this.Controls.Add(this.comboBoxSTMinutes);
            this.Controls.Add(this.btnDeleteTimeSlot);
            this.Controls.Add(this.comboBoxDuration);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnAddTimeSlot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericSThours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridTimeSlots);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTimeSlots";
            this.Text = "AddTimeSlots";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimeSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSThours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTimeSlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTimeSlots;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSThours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddTimeSlot;
        private System.Windows.Forms.ErrorProvider errorProviderTimeSlot;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Button btnDeleteTimeSlot;
        private System.Windows.Forms.ComboBox comboBoxSTMinutes;
        private System.Windows.Forms.Button btnGenerateRank;
        private System.Windows.Forms.TextBox ETMinutes;
        private System.Windows.Forms.TextBox ETHours;
    }
}