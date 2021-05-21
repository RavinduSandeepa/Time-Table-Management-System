using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System.LocationAllocation
{
    public partial class ManageSessionRoom : Form
    {
        private SessionRoom sessionroom = new SessionRoom();
        private ISessionRoomService sessionRoomService = new SessionRoomService();

        private SessionDTO session = new SessionDTO();
        private ISessionService sessionService = new SessionService();
        public ManageSessionRoom()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            // add Sessions
            List<SessionDTO> sessionList = new List<SessionDTO>();
            List<String> sessionNameList = new List<String>();
            sessionList = sessionService.getAllSessions();

            foreach (SessionDTO tag in sessionList)
            {
                
                sessionNameList.Add(tag.Id.ToString());
            }
            comboBoxSessions.Items.AddRange(sessionNameList.ToArray());
        }


        private void comboBoxSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRooms.Items.Clear();
            int sessionID = int.Parse(comboBoxSessions.Text);

            // add rooms
            ILocationService locationService = new LocationService();
            List<Location> locationList = new List<Location>();
            List<String> locationNameList = new List<String>();
            locationList = locationService.getAllLocations();

            if (sessionService.GetSession(sessionID).Tag == "Lecture" || sessionService.GetSession(sessionID).Tag == "Tutorial")
            {
                foreach (Location location in locationList)
                {
                    if( location.RoomType == "Lecture Hall")
                    {
                        locationNameList.Add(location.RoomName);
                    }
                }
                comboBoxRooms.Items.AddRange(locationNameList.ToArray());
            }
            else
            {
                foreach (Location location in locationList)
                {
                    if (location.RoomType == "Laboratory")
                    {
                        locationNameList.Add(location.RoomName);
                    }
                }
                comboBoxRooms.Items.AddRange(locationNameList.ToArray());
            }

            loadData(int.Parse(comboBoxSessions.Text));


        }

        private void loadData(int id)
        {
            SessionDTO selectedSession = new SessionDTO();
            ISessionService sessionService = new SessionService();
            selectedSession = sessionService.GetSession(id);

            if (selectedSession.Lec2_name == null)
            {
                txtSelectedSession.Text = selectedSession.Lec1_name + Environment.NewLine +
                                  selectedSession.Subject_name + "(" + selectedSession.Subject_code + ")" + Environment.NewLine +
                                  selectedSession.Tag + Environment.NewLine +
                                  selectedSession.Group_code + Environment.NewLine +
                                  selectedSession.Student_count.ToString() + "( " + selectedSession.Duration.ToString() + ")";
            }
            else
            {
                txtSelectedSession.Text = selectedSession.Lec1_name + ", " + selectedSession.Lec2_name + Environment.NewLine +
                                  selectedSession.Subject_name + "(" + selectedSession.Subject_code + ")" + Environment.NewLine +
                                  selectedSession.Tag + Environment.NewLine +
                                  selectedSession.Group_code + Environment.NewLine +
                                  selectedSession.Student_count.ToString() + "( " + selectedSession.Duration.ToString() + ")";
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            comboBoxSessions.SelectedIndex = -1;
            comboBoxRooms.SelectedIndex = -1;
            txtSelectedSession.Text = String.Empty;
            
        }

        private void comboBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            ISessionService sessionService = new SessionService();
            List<SessionDTO> sessionList = new List<SessionDTO>();
            List<String> id = new List<String>();
            List<String> sessionNameList = new List<String>();
            sessionList = sessionService.getAllSessions();

            ILocationService locationService = new LocationService();
            List<Location> locationList = new List<Location>();
            List<String> locationNameList = new List<String>();
            locationList = locationService.getAllLocations();

            foreach (SessionDTO session in sessionList)
            {

                //sessionNameList.Add(session.Tag.ToString());
                if(session.Tag == "Lecture")
                {
                    foreach (Location location in locationList)
                    {
                        if (location.RoomType == "Lecture Hall")
                        {
                            locationNameList.Add(location.RoomName);
                            comboBoxRooms.Items.AddRange(locationNameList.ToArray());
                        }

                    }
                }
                else if (session.Tag == "Tutorial")
                {
                    foreach (Location location in locationList)
                    {
                        if (location.RoomType == "Lecture Hall")
                        {
                            locationNameList.Add(location.RoomName);
                            comboBoxRooms.Items.AddRange(locationNameList.ToArray());
                        }
                    }
                }
                else
                {
                    foreach (Location location in locationList)
                    {
                        if (location.RoomType == "Laboratory")
                        {
                            locationNameList.Add(location.RoomName);
                            comboBoxRooms.Items.AddRange(locationNameList.ToArray());
                        }
                    }
                }

            }
            }

        private void txtSelectedSession_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //sessionroom.Session_id = int.Parse(comboBoxSessions.Text);
            sessionroom.Session_id = int.Parse(comboBoxSessions.Text);
            sessionroom.Room = comboBoxRooms.Text;

            //Inser Da
            if (sessionRoomService.addSessionRoom(sessionroom))
            {
                this.Close();
                //SuccessMessage sc = new SuccessMessage("Session Added Successfully !");
                //sc.Show();
                MessageBox.Show("Session Added Successfully !");
            }
            else
            {
                //ErrorMessage ec = new ErrorMessage("Oops, Somthing went wrong!");
                //ec.Show();
                MessageBox.Show("Oops, Somthing went wrong!");
            }
        }
    }          
}
    
   

