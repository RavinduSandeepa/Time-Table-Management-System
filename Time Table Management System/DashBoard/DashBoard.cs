using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System
{
    public partial class DashBoard : Form
    {
        private IDashBoardService iDashBoardService;
        public DashBoard()
        {
            InitializeComponent();
            loadChartLocations();
            getData();
        }

        public void getData()
        {
            iDashBoardService = new DashBoardService();
            labelRegLecs.Text = iDashBoardService.getLecturersCount().ToString();
            labelRegStu.Text = iDashBoardService.getStudentsCount().ToString();
            labelRegSubs.Text = iDashBoardService.getSubjectsCount().ToString();
            label1RegRooms.Text = iDashBoardService.getLocationsCount().ToString();
            txtLatestLec.Text = iDashBoardService.getLatestLecturer();
            txtLatestStu.Text = iDashBoardService.getLatestGroupName();
            txtLatestSub.Text = iDashBoardService.getLatestSubject();
        }

        public void loadChartLocations()
        {
            iDashBoardService = new DashBoardService();
            this.chartLocations.Series["Lecture Rooms"].Points.AddXY("Locations", iDashBoardService.getLecCount());
            this.chartLocations.Series["Laboratories"].Points.AddXY("Locations", iDashBoardService.getLabCount());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
