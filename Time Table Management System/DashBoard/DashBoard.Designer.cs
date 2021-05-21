namespace Time_Table_Management_System
{
    partial class DashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLatestSub = new System.Windows.Forms.TextBox();
            this.txtLatestStu = new System.Windows.Forms.TextBox();
            this.txtLatestLec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRegLecs = new System.Windows.Forms.Label();
            this.labelRegStu = new System.Windows.Forms.Label();
            this.labelRegSubs = new System.Windows.Forms.Label();
            this.label1RegRooms = new System.Windows.Forms.Label();
            this.chartLocations = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(2, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 20);
            this.button4.TabIndex = 15;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.txtLatestSub);
            this.groupBox1.Controls.Add(this.txtLatestStu);
            this.groupBox1.Controls.Add(this.txtLatestLec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(369, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 200);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What\'s New?";
            // 
            // txtLatestSub
            // 
            this.txtLatestSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLatestSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatestSub.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatestSub.Location = new System.Drawing.Point(106, 133);
            this.txtLatestSub.Margin = new System.Windows.Forms.Padding(2);
            this.txtLatestSub.Name = "txtLatestSub";
            this.txtLatestSub.ReadOnly = true;
            this.txtLatestSub.Size = new System.Drawing.Size(145, 29);
            this.txtLatestSub.TabIndex = 61;
            this.txtLatestSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLatestStu
            // 
            this.txtLatestStu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLatestStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatestStu.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatestStu.Location = new System.Drawing.Point(106, 92);
            this.txtLatestStu.Margin = new System.Windows.Forms.Padding(2);
            this.txtLatestStu.Name = "txtLatestStu";
            this.txtLatestStu.ReadOnly = true;
            this.txtLatestStu.Size = new System.Drawing.Size(145, 29);
            this.txtLatestStu.TabIndex = 60;
            this.txtLatestStu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLatestLec
            // 
            this.txtLatestLec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLatestLec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatestLec.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatestLec.Location = new System.Drawing.Point(106, 48);
            this.txtLatestLec.Margin = new System.Windows.Forms.Padding(2);
            this.txtLatestLec.Name = "txtLatestLec";
            this.txtLatestLec.ReadOnly = true;
            this.txtLatestLec.Size = new System.Drawing.Size(145, 29);
            this.txtLatestLec.TabIndex = 59;
            this.txtLatestLec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Latest Subject";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Latest Group";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latest lecturer";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(186, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Registered Students";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(349, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Registered Subjects";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(505, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Registered Rooms";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(28, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Registered Lecturers";
            // 
            // labelRegLecs
            // 
            this.labelRegLecs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegLecs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelRegLecs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegLecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegLecs.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegLecs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRegLecs.Location = new System.Drawing.Point(41, 42);
            this.labelRegLecs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegLecs.Name = "labelRegLecs";
            this.labelRegLecs.Size = new System.Drawing.Size(98, 60);
            this.labelRegLecs.TabIndex = 62;
            this.labelRegLecs.Text = "2";
            this.labelRegLecs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegStu
            // 
            this.labelRegStu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegStu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelRegStu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegStu.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegStu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRegStu.Location = new System.Drawing.Point(199, 42);
            this.labelRegStu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegStu.Name = "labelRegStu";
            this.labelRegStu.Size = new System.Drawing.Size(98, 60);
            this.labelRegStu.TabIndex = 63;
            this.labelRegStu.Text = "2";
            this.labelRegStu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegSubs
            // 
            this.labelRegSubs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegSubs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelRegSubs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegSubs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegSubs.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegSubs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRegSubs.Location = new System.Drawing.Point(361, 42);
            this.labelRegSubs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegSubs.Name = "labelRegSubs";
            this.labelRegSubs.Size = new System.Drawing.Size(98, 60);
            this.labelRegSubs.TabIndex = 64;
            this.labelRegSubs.Text = "2";
            this.labelRegSubs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1RegRooms
            // 
            this.label1RegRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1RegRooms.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1RegRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1RegRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1RegRooms.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1RegRooms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1RegRooms.Location = new System.Drawing.Point(512, 42);
            this.label1RegRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1RegRooms.Name = "label1RegRooms";
            this.label1RegRooms.Size = new System.Drawing.Size(98, 60);
            this.label1RegRooms.TabIndex = 65;
            this.label1RegRooms.Text = "2";
            this.label1RegRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartLocations
            // 
            this.chartLocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chartLocations.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLocations.Legends.Add(legend1);
            this.chartLocations.Location = new System.Drawing.Point(31, 162);
            this.chartLocations.Margin = new System.Windows.Forms.Padding(2);
            this.chartLocations.Name = "chartLocations";
            this.chartLocations.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series1.BorderColor = System.Drawing.Color.DarkOrange;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.DarkOrange;
            series1.Legend = "Legend1";
            series1.Name = "Lecture Rooms";
            series1.YValuesPerPoint = 10;
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent05;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Color = System.Drawing.Color.MidnightBlue;
            series2.Legend = "Legend1";
            series2.Name = "Laboratories";
            this.chartLocations.Series.Add(series1);
            this.chartLocations.Series.Add(series2);
            this.chartLocations.Size = new System.Drawing.Size(318, 176);
            this.chartLocations.TabIndex = 66;
            this.chartLocations.Text = "Locations Stats";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(661, 359);
            this.Controls.Add(this.chartLocations);
            this.Controls.Add(this.label1RegRooms);
            this.Controls.Add(this.labelRegSubs);
            this.Controls.Add(this.labelRegStu);
            this.Controls.Add(this.labelRegLecs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLatestSub;
        private System.Windows.Forms.TextBox txtLatestStu;
        private System.Windows.Forms.TextBox txtLatestLec;
        private System.Windows.Forms.Label labelRegLecs;
        private System.Windows.Forms.Label labelRegStu;
        private System.Windows.Forms.Label labelRegSubs;
        private System.Windows.Forms.Label label1RegRooms;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLocations;
    }
}