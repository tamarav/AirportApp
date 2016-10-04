using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportApp.Airline_company;
using AirportApp.Fly;

namespace AirportApp
{
    public partial class AddFlightForm : Form
    {
        public int id = 0;

        public AddFlightForm(int id)
        {
            InitializeComponent();
            this.dt_pickerDeparture.Format = DateTimePickerFormat.Custom;
            this.dt_pickerDeparture.CustomFormat = "Da't'e: dd. MM. yyyy. Ti'm'e: HH:mm:ss";
            this.dtpicker_Landing.Format = DateTimePickerFormat.Custom;
            this.dtpicker_Landing.CustomFormat = "Da't'e: dd. MM. yyyy. Ti'm'e: HH:mm:ss";
            if (id != 0)
            {
                this.id = id;

                FlyDao flyDao = new FlyDaoImplements();

                Fly.Fly flight = flyDao.getFlight(id);

                this.lb_title.Text = "Modify flight";
                this.tb_destination.Text = flight.Destination;
                this.tb_startPoint.Text = flight.Start_point;
                this.dt_pickerDeparture.Value = flight.Departure_time;
                this.dtpicker_Landing.Value = flight.Landing_time;


            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddFlightForm_Load(object sender, EventArgs e)
        {

            if (this.id == 0)
            {
                this.lb_title.Text = "Add flight";
                this.btn_add.Text = "Add";
            }
            else if (this.id != 0)
            {
                this.lb_title.Text = "Modify flight";
                this.btn_add.Text = "Save";
            }

            Airplane.AirplaneDao airplaneDao = new Airplane.AirplaneDaoImplements();
            List<Airplane.Airplane> airplanes = airplaneDao.getAllAirplanes();
            foreach (Airplane.Airplane s in airplanes)
            {
                this.cb_airline.Items.Add(s.Name);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            lbl_info.Text = "";

            if (this.tb_destination.Text == "" || this.tb_startPoint.Text == "" || this.dt_pickerDeparture.Value.ToString() == "" || this.dtpicker_Landing.Value.ToString() == "" || this.cb_airline.Text == "")
            {
                this.lbl_info.Text = "Missing information.";
                this.lbl_info.Show();
                return;
            }

            if (this.id == 0)
            {
                Airplane.AirplaneDao airplaneDao = new Airplane.AirplaneDaoImplements();
                Airplane.Airplane airplane = airplaneDao.getAirplaneName(this.cb_airline.Text);

                string destination = this.tb_destination.Text;
                string start_point = this.tb_startPoint.Text;

                DateTime departure = this.dt_pickerDeparture.Value;
                DateTime landing = this.dtpicker_Landing.Value;

                Fly.Fly newFlight = new Fly.Fly(destination, start_point, departure, landing, airplane.Id);
                FlyDaoImplements fdi = new FlyDaoImplements();
                fdi.addFlight(newFlight);
            }
            else if (this.id != 0)
            {
                Airplane.AirplaneDao airplaneDao = new Airplane.AirplaneDaoImplements();
                Airplane.Airplane airplane = airplaneDao.getAirplaneName(this.cb_airline.Text);

                string destination = this.tb_destination.Text;
                string start_point = this.tb_startPoint.Text;

                DateTime departure = this.dt_pickerDeparture.Value;
                DateTime landing = this.dtpicker_Landing.Value;

                Fly.Fly newFlight = new Fly.Fly(this.id, destination, start_point, departure, landing, airplane.Id);
                FlyDaoImplements fdi = new FlyDaoImplements();
                fdi.editFlight(newFlight);
            }
            this.Close();
        }

        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.buttonAdd_Click(sender, e);
            }
        }


    }
}
