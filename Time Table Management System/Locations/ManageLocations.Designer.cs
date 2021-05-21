namespace Time_Table_Management_System.Locations
{
    partial class ManageLocations
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
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataGridLocations = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuildName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonLectureHall = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.radioButtonLaboratory = new System.Windows.Forms.RadioButton();
            this.errorLocation = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 20);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(87, 24);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(225, 29);
            this.title.TabIndex = 15;
            this.title.Text = "Manage Locations";
            // 
            // dataGridLocations
            // 
            this.dataGridLocations.AllowUserToAddRows = false;
            this.dataGridLocations.AllowUserToDeleteRows = false;
            this.dataGridLocations.AllowUserToResizeColumns = false;
            this.dataGridLocations.AllowUserToResizeRows = false;
            this.dataGridLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLocations.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridLocations.Location = new System.Drawing.Point(38, 80);
            this.dataGridLocations.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridLocations.MultiSelect = false;
            this.dataGridLocations.Name = "dataGridLocations";
            this.dataGridLocations.RowHeadersVisible = false;
            this.dataGridLocations.RowHeadersWidth = 51;
            this.dataGridLocations.RowTemplate.Height = 24;
            this.dataGridLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLocations.Size = new System.Drawing.Size(476, 125);
            this.dataGridLocations.TabIndex = 16;
            this.dataGridLocations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLocations_CellContentClick);
            this.dataGridLocations.SelectionChanged += new System.EventHandler(this.dataGrid_Selection);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Building";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Room Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Capacity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Location = new System.Drawing.Point(536, 80);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 32);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Location = new System.Drawing.Point(536, 125);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClear.Location = new System.Drawing.Point(536, 173);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(17, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Building Name";
            // 
            // textBoxBuildName
            // 
            this.textBoxBuildName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBuildName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxBuildName.Location = new System.Drawing.Point(131, 245);
            this.textBoxBuildName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuildName.Name = "textBoxBuildName";
            this.textBoxBuildName.Size = new System.Drawing.Size(187, 24);
            this.textBoxBuildName.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(17, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Room Name";
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxRoomName.Location = new System.Drawing.Point(131, 282);
            this.textBoxRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(187, 24);
            this.textBoxRoomName.TabIndex = 57;
            this.textBoxRoomName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(353, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Room Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioButtonLectureHall
            // 
            this.radioButtonLectureHall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonLectureHall.AutoSize = true;
            this.radioButtonLectureHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLectureHall.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButtonLectureHall.Location = new System.Drawing.Point(454, 246);
            this.radioButtonLectureHall.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLectureHall.Name = "radioButtonLectureHall";
            this.radioButtonLectureHall.Size = new System.Drawing.Size(91, 19);
            this.radioButtonLectureHall.TabIndex = 59;
            this.radioButtonLectureHall.TabStop = true;
            this.radioButtonLectureHall.Text = "Lecture Hall";
            this.radioButtonLectureHall.UseVisualStyleBackColor = true;
            this.radioButtonLectureHall.CheckedChanged += new System.EventHandler(this.radioButtonLectureHall_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(353, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Capacity";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCapacity.Location = new System.Drawing.Point(454, 276);
            this.textBoxCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(187, 24);
            this.textBoxCapacity.TabIndex = 61;
            this.textBoxCapacity.TextChanged += new System.EventHandler(this.textBoxCapacity_TextChanged);
            // 
            // radioButtonLaboratory
            // 
            this.radioButtonLaboratory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonLaboratory.AutoSize = true;
            this.radioButtonLaboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLaboratory.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButtonLaboratory.Location = new System.Drawing.Point(566, 245);
            this.radioButtonLaboratory.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLaboratory.Name = "radioButtonLaboratory";
            this.radioButtonLaboratory.Size = new System.Drawing.Size(83, 19);
            this.radioButtonLaboratory.TabIndex = 62;
            this.radioButtonLaboratory.TabStop = true;
            this.radioButtonLaboratory.Text = "Laboratory";
            this.radioButtonLaboratory.UseVisualStyleBackColor = true;
            this.radioButtonLaboratory.CheckedChanged += new System.EventHandler(this.radioButtonLaboratory_CheckedChanged);
            // 
            // errorLocation
            // 
            this.errorLocation.ContainerControl = this;
            // 
            // ManageLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(661, 359);
            this.Controls.Add(this.radioButtonLaboratory);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonLectureHall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBuildName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridLocations);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button1);
            this.Name = "ManageLocations";
            this.Text = "ManageLocations";
            this.Load += new System.EventHandler(this.ManageLocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridLocations;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuildName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonLectureHall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.RadioButton radioButtonLaboratory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ErrorProvider errorLocation;
    }
}