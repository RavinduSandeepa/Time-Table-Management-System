using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System.Generate
{
    public partial class GenerateTimeTable : Form
    {
        private WorkingDaysHours workingDaysHours = new WorkingDaysHours();
        private IWorkingDaysHoursService workingDaysHoursService = new WorkingDaysHoursService();
        private ISessionService sessionService = new SessionService();

        private List<String> timeSlotsList = new List<String>();


        public GenerateTimeTable()
        {
            InitializeComponent();
            loadDataIntoDrop();
            if (checkExistData())
            {
                createTable();
            }
            else
            {
                //ErrorMessage em = new ErrorMessage("Please set Working Days and Hours to Proceed");
                //em.Show();
                MessageBox.Show("Please set Working Days and Hours to Proceed");
            }
        }

        private Boolean checkExistData()
        {
            return workingDaysHoursService.getExistWorkingDaysHours();
        }

        private void createTable()
        {
            workingDaysHours = workingDaysHoursService.getWorkingDaysHours();
            timeSlotsList.Add("08.30-09.30");
            timeSlotsList.Add("09.30-10.30");
            timeSlotsList.Add("10.30-11.30");
            timeSlotsList.Add("11.30-12.30");
            timeSlotsList.Add("12.30-13.00");
            timeSlotsList.Add("13.00-14.00");
            timeSlotsList.Add("14.00-15.00");
            timeSlotsList.Add("15.00-16.00");
            timeSlotsList.Add("16.00-17.00");
        }

        private void loadDataIntoDrop()
        {
            // add Lecturers
            ILecturerService lecturerService = new LecturerService();
            List<Lecturer> lecList = new List<Lecturer>();
            List<String> lecNameList = new List<String>();
            lecList = lecturerService.getAllLecturers();

            foreach (Lecturer lec in lecList)
            {
                lecNameList.Add(lec.Name);
            }
            comboBoxLecList.Items.AddRange(lecNameList.ToArray());

            // add group
            IStudentService studentService = new StudentService();
            List<Student> stuList = new List<Student>();
            List<String> stuNameList = new List<String>();
            stuList = studentService.getAllStudents();

            foreach (Student stu in stuList)
            {
                stuNameList.Add(stu.GroupId);
            }
            comboBoxGroups.Items.AddRange(stuNameList.ToArray());

            // add rooms
            ILocationService locationService = new LocationService();
            List<Location> locationList = new List<Location>();
            List<String> roomNameList = new List<String>();
            locationList = locationService.getAllLocations();

            foreach (Location l in locationList)
            {
                roomNameList.Add(l.RoomName);
            }
            comboBoxLocationList.Items.AddRange(roomNameList.ToArray());
        }

        private void btnGenerateLec_Click(object sender, EventArgs e)
        {
            if(comboBoxLecList.Text == String.Empty)
            {
                //ErrorMessage em = new ErrorMessage("Please Select Lecturer");
                //em.Show();
                MessageBox.Show("Please Select Lecturer");
            }
            else
            {
                try
                {
                    SessionDTO[,] lec2DArray = new SessionDTO[8, workingDaysHours.NoOfWorkingDays];// 8, 5  indexes:0-7, 0-4
                    List<SessionDTO> sessionsArray = sessionService.getAllSessions();
                    dataGridLec.Rows.Clear();

                    // set session slots
                    foreach (SessionDTO session in sessionsArray)
                    {
                        if (session.Lec1_name == comboBoxLecList.Text || session.Lec2_name == comboBoxLecList.Text)
                        {
                            if (session.Duration == 2)
                            {
                                int colNum = getRandom(0, workingDaysHours.NoOfWorkingDays); // 0 1 2 3 4
                                int rawNum = getRandom(0, 7); // 0 1 2 3 4 5 6
                                
                                session.Duration = 1;
                                while (lec2DArray[rawNum, colNum] != null || lec2DArray[rawNum, colNum + 1] != null || rawNum == 3)
                                {
                                    colNum = getRandom(0, workingDaysHours.NoOfWorkingDays);
                                    rawNum = getRandom(0, 7);
                                }
                                //set Session
                                lec2DArray[rawNum, colNum] = session;
                                lec2DArray[rawNum + 1, colNum] = session;
                            }
                            else //session.Duration == 1
                            {
                                int colNum = getRandom(0, workingDaysHours.NoOfWorkingDays); // 0 1 2 3 4 
                                int rawNum = getRandom(0, 8); // 0 1 2 3 4 5 6 7
                                while (lec2DArray[rawNum, colNum] != null)
                                {
                                    colNum = getRandom(0, workingDaysHours.NoOfWorkingDays);
                                    rawNum = getRandom(0, 8);
                                }
                                //set Session
                                lec2DArray[rawNum, colNum] = session;
                            }
                        }
                    }

                    MessageBox.Show("Time Table Generated Successfully", "Info");
                    //display
                    int raw = 0;
                    foreach (String time in timeSlotsList)
                    {
                        if (time == "12.30-13.00")
                        {
                            dataGridLec.Rows.Add(time, "xxxxx", "xxxxx", "xxxxx", "xxxxx", "xxxxx");
                        }
                        else
                        {
                            String[] rowString = new String[5];
                            for (int col = 0; col < 5; col++)
                            {
                                if (lec2DArray[raw, col] == null)
                                {
                                    rowString[col] = ("---");
                                }
                                else
                                {
                                    rowString[col] = (getStringSession(lec2DArray[raw, col].Lec1_name, lec2DArray[raw, col].Lec2_name,
                                        lec2DArray[raw, col].Subject_name, lec2DArray[raw, col].Subject_code, lec2DArray[raw, col].Tag,
                                        lec2DArray[raw, col].Group_code, lec2DArray[raw, col].Student_count.ToString(),
                                        lec2DArray[raw, col].Duration.ToString(), lec2DArray[raw, col].Room));

                                    dataGridLec.RowTemplate.Height = 75;
                                }
                            }
                            dataGridLec.Rows.Add(time,rowString[0],rowString[1],rowString[2],rowString[3],rowString[4]);   
                            raw++;
                        }
                    }

                }catch(Exception exas)
                {
                    MessageBox.Show("Conflict has Occured ! ," + exas.Message, "Error");
                }
            }
        }

        public int getRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min,max);
        }

        public String getStringSession(String lec1, String lec2, String subjectName, String subjectCode, String tag, String group, String stuCount, String duration, String room)
        {
            String file = null;
            if (lec2 == String.Empty || lec2 == null)
            {
                file = lec1 + Environment.NewLine +
                       subjectName + "(" + subjectCode + "), " + tag + Environment.NewLine +
                       group + ", " + stuCount + "(" + duration + "), " + room;
            }
            else
            {
                file = lec1 + ", " + lec2 + Environment.NewLine +
                       subjectName + "(" + subjectCode + "), " + tag + Environment.NewLine +
                       group + ", " + stuCount + "(" + duration + "), " + room ;
            }
            return file;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridLec.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "timeTable_"+comboBoxLecList.Text+".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridLec.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridLec.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridLec.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnGenerateStudent_Click(object sender, EventArgs e)
        {
            if (comboBoxGroups.Text == String.Empty)
            {
                //ErrorMessage em = new ErrorMessage("Please Select Group");
                //em.Show();
                MessageBox.Show("Please Select Group");
            }
            else
            {
                try
                {
                    SessionDTO[,] lec2DArray = new SessionDTO[8, workingDaysHours.NoOfWorkingDays];// 8, 5  indexes:0-7, 0-4
                    List<SessionDTO> sessionsArray = sessionService.getAllSessions();
                    dataGridGroup.Rows.Clear();

                    // set session slots
                    foreach (SessionDTO session in sessionsArray)
                    {
                        if (session.Group_code == comboBoxGroups.Text || session.Group_code == comboBoxGroups.Text+".1" || session.Group_code == comboBoxGroups.Text + ".2")
                        {
                            if (session.Duration == 2)
                            {
                                int colNum = getRandom(0, workingDaysHours.NoOfWorkingDays); // 0 1 2 3 4
                                int rawNum = getRandom(0, 7); // 0 1 2 3 4 5 6

                                session.Duration = 1;
                                while (lec2DArray[rawNum, colNum] != null || lec2DArray[rawNum, colNum + 1] != null || rawNum == 3)
                                {
                                    colNum = getRandom(0, workingDaysHours.NoOfWorkingDays);
                                    rawNum = getRandom(0, 7);
                                }
                                //set Session
                                lec2DArray[rawNum, colNum] = session;
                                lec2DArray[rawNum + 1, colNum] = session;
                            }
                            else if (session.Duration == 1) //session.Duration == 1
                            {
                                int colNum = getRandom(0, workingDaysHours.NoOfWorkingDays); // 0 1 2 3 4 
                                int rawNum = getRandom(0, 8); // 0 1 2 3 4 5 6 7
                                MessageBox.Show(colNum + "," + rawNum);

                                while (lec2DArray[rawNum, colNum] != null)
                                {
                                    colNum = getRandom(0, workingDaysHours.NoOfWorkingDays);
                                    rawNum = getRandom(0, 8);
                                }
                                //set Session
                                lec2DArray[rawNum, colNum] = session;
                            }
                        }
                    }

                    MessageBox.Show("Time Table Generated Successfully", "Info");
                    //display
                    int raw = 0;
                    foreach (String time in timeSlotsList)
                    {
                        if (time == "12.30-13.00")
                        {
                            dataGridGroup.Rows.Add(time, "xxxxx", "xxxxx", "xxxxx", "xxxxx", "xxxxx");
                        }
                        else
                        {
                            String[] rowString = new String[5];
                            for (int col = 0; col < 5; col++)
                            {
                                if (lec2DArray[raw, col] == null)
                                {
                                    rowString[col] = ("---");
                                }
                                else
                                {
                                    rowString[col] = (getStringSession(lec2DArray[raw, col].Lec1_name, lec2DArray[raw, col].Lec2_name,
                                        lec2DArray[raw, col].Subject_name, lec2DArray[raw, col].Subject_code, lec2DArray[raw, col].Tag,
                                        lec2DArray[raw, col].Group_code, lec2DArray[raw, col].Student_count.ToString(),
                                        lec2DArray[raw, col].Duration.ToString(), lec2DArray[raw,col].Room));

                                    dataGridGroup.RowTemplate.Height = 75;
                                }
                            }
                            dataGridGroup.Rows.Add(time, rowString[0], rowString[1], rowString[2], rowString[3], rowString[4]);
                            raw++;
                        }
                    }

                }
                catch (Exception exas)
                {
                    MessageBox.Show("Conflict has Occured ! ," + exas.Message, "Error");
                }
            }
        }

        private void btnPrintLocation_Click(object sender, EventArgs e)
        {
            if (dataGridLocation.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "timeTable_" + comboBoxLocationList.Text + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridLocation.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridLocation.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridLocation.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnPrintStudent_Click(object sender, EventArgs e)
        {
            if (dataGridGroup.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "timeTable_" + comboBoxGroups.Text + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridGroup.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridGroup.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridGroup.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnGenerateLocation_Click(object sender, EventArgs e)
        {
            if (comboBoxLocationList.Text == String.Empty)
            {
                //ErrorMessage em = new ErrorMessage("Please Select Room");
                //em.Show();
                MessageBox.Show("Please Select Room");
            }
            else
            {
                try
                {
                    SessionDTO[,] lec2DArray = new SessionDTO[8, workingDaysHours.NoOfWorkingDays];// 8, 5  indexes:0-7, 0-4
                    List<SessionDTO> sessionsArray = sessionService.getAllSessions();
                    dataGridLec.Rows.Clear();

                    // set session slots
                    foreach (SessionDTO session in sessionsArray)
                    {
                        if (session.Room == comboBoxLocationList.Text)
                        {
                            if (session.Duration == 2)
                            {
                                int colNum = getRandom(0, workingDaysHours.NoOfWorkingDays); // 0 1 2 3 4
                                int rawNum = getRandom(0, 7); // 0 1 2 3 4 5 6

                                session.Duration = 1;
                                while (lec2DArray[rawNum, colNum] != null || lec2DArray[rawNum, colNum + 1] != null || rawNum == 3)
                                {
                                    colNum = getRandom(0, workingDaysHours.NoOfWorkingDays);
                                    rawNum = getRandom(0, 7);
                                }
                                //set Session
                                lec2DArray[rawNum, colNum] = session;
                                lec2DArray[rawNum + 1, colNum] = session;
                            }
                            else //session.Duration == 1
                            {
                                int colNum = getRandom(0, workingDaysHours.NoOfWorkingDays); // 0 1 2 3 4 
                                int rawNum = getRandom(0, 8); // 0 1 2 3 4 5 6 7
                                while (lec2DArray[rawNum, colNum] != null)
                                {
                                    colNum = getRandom(0, workingDaysHours.NoOfWorkingDays);
                                    rawNum = getRandom(0, 8);
                                }
                                //set Session
                                lec2DArray[rawNum, colNum] = session;
                            }
                        }
                    }

                    MessageBox.Show("Time Table Generated Successfully", "Info");
                    //display
                    int raw = 0;
                    foreach (String time in timeSlotsList)
                    {
                        if (time == "12.30-13.00")
                        {
                            dataGridLocation.Rows.Add(time, "xxxxx", "xxxxx", "xxxxx", "xxxxx", "xxxxx");
                        }
                        else
                        {
                            String[] rowString = new String[5];
                            for (int col = 0; col < 5; col++)
                            {
                                if (lec2DArray[raw, col] == null)
                                {
                                    rowString[col] = ("---");
                                }
                                else
                                {
                                    rowString[col] = (getStringSession(lec2DArray[raw, col].Lec1_name, lec2DArray[raw, col].Lec2_name,
                                        lec2DArray[raw, col].Subject_name, lec2DArray[raw, col].Subject_code, lec2DArray[raw, col].Tag,
                                        lec2DArray[raw, col].Group_code, lec2DArray[raw, col].Student_count.ToString(),
                                        lec2DArray[raw, col].Duration.ToString(), lec2DArray[raw, col].Room));

                                    dataGridLocation.RowTemplate.Height = 75;
                                }
                            }
                            dataGridLocation.Rows.Add(time, rowString[0], rowString[1], rowString[2], rowString[3], rowString[4]);
                            raw++;
                        }
                    }

                }
                catch (Exception exas)
                {
                    MessageBox.Show("Conflict has Occured ! ," + exas.Message, "Error");
                }
            }
        }
    }
}
