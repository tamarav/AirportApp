using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportApp.Fly;
using AirportApp.Airplane;
using AirportApp.Airline_company;
using AirportApp.User;

namespace AirportApp
{
    public partial class MainForm : Form
    {
        int userId;
        string selectedNode = "";
        int id;
        string category = "";

        public MainForm(int id)
        {
            this.userId = id;
            InitializeComponent();
        }

        public MainForm()
        {

            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form2 = new AboutForm();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlightForm form2 = new AddFlightForm(0);
            form2.ShowDialog();
        }

        private void tvMainAfterSelect(object sender, TreeViewEventArgs e)
        {
            this.selectedNode = this.tvTypes.SelectedNode.Text;
        }


        private void ReloadListView()
        {
            if (this.selectedNode == "")
            {
                return;
            }

            this.btn_add.Enabled = false;
            this.btn_remove.Enabled = false;
            this.btn_modify.Enabled = false;

            List<Fly.Fly> listOfFlights = new List<Fly.Fly>();
            ListViewItem lvi = new ListViewItem();
            AirplaneDao airplaneDao = new AirplaneDaoImplements();
            switch (this.selectedNode)
            {
                case "Flights":
                    FlyDao flightsDao = new FlyDaoImplements();
                    List<Fly.Fly> list = flightsDao.getAllFlights();

                    this.btn_add.Enabled = true;
                    this.category = "flights";

                    lv_Main.Columns.Clear();
                    lv_Main.Items.Clear();
                    lv_Main.Columns.Add("id", 0);
                    lv_Main.Columns.Add("Destination", 100);
                    lv_Main.Columns.Add("Start point", 100);
                    lv_Main.Columns.Add("Departure time", 90);
                    lv_Main.Columns.Add("Landing time", 90);
                    lv_Main.Columns.Add("Airplane", 90);

                    foreach (Fly.Fly item in list)
                    {
                        Airplane.Airplane airplane = airplaneDao.getAirplane(item.Airplane_id);
                        lvi = new ListViewItem(new[] { item.Id.ToString(), item.Destination, item.Start_point, Convert.ToString(item.Departure_time), Convert.ToString(item.Landing_time), airplane.Name });
                        lv_Main.Items.Add(lvi);
                    }

                    break;
                case "Airlines":

                    this.btn_add.Enabled = true;
                    this.category = "airlines";

                    Airline_companyDao airlinesDao = new Airline_companyDaoImplements();
                    List<Airline_company.Airline_company> airlines = airlinesDao.getAllAirlinesData();
                    lv_Main.Columns.Clear();
                    lv_Main.Items.Clear();
                    lv_Main.Columns.Add("Name", 90);
                    lv_Main.Columns.Add("Country");
                    lv_Main.Columns.Add("Address");
                    lv_Main.Columns.Add("Telephone", 70);
                    lv_Main.Columns.Add("Email");
                    lv_Main.Columns.Add("id", 0);
                    foreach (Airline_company.Airline_company item in airlines)
                    {
                        lvi = new ListViewItem(new[] { item.Name, item.Country, item.Address, Convert.ToString(item.Telephone), Convert.ToString(item.Email), Convert.ToString(item.Id) });
                        lv_Main.Items.Add(lvi);

                    }

                    break;
                case "Airplanes":

                    this.btn_add.Enabled = true;
                    this.category = "airplanes";

                    lv_Main.Columns.Clear();
                    lv_Main.Items.Clear();
                    lv_Main.Columns.Add("Name", 100);
                    lv_Main.Columns.Add("Number of seats", 100);
                    lv_Main.Columns.Add("Airline", 100);
                    lv_Main.Columns.Add("id", 0);


                    List<Airplane.Airplane> airplanes = airplaneDao.getAllAirplanes();
                    string airlineName = "";
                    Airline_company.Airline_companyDao airline = new Airline_company.Airline_companyDaoImplements();
                    foreach (Airplane.Airplane planes in airplanes)
                    {
                        airlineName = airline.getAirline(planes.Airline_company_id);
                        lvi = new ListViewItem(new[] { planes.Name, planes.Number_of_seats.ToString(), airlineName, planes.Id.ToString() });
                        lv_Main.Items.Add(lvi);
                    }

                    break;

            }

        }

        private void tvTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.selectedNode = this.tvTypes.SelectedNode.Text;
            this.ReloadListView();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFlightForm form2 = new AddFlightForm(0);
            form2.ShowDialog();
            this.ReloadListView();
        }

        private void lv_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lv_Main.SelectedItems.Count > 0)
            {
                this.btn_add.Enabled = false;
                this.btn_remove.Enabled = true;
                this.btn_modify.Enabled = true;
            }
            else
            {
                this.btn_add.Enabled = true;
                this.btn_remove.Enabled = false;
                this.btn_modify.Enabled = false;
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form2 = new Add_ModifyAirline(0);
            form2.ShowDialog();
            this.ReloadListView();
        }


        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Add_ModifyAirline form2 = new Add_ModifyAirline(this.id);
            form2.ShowDialog();
            this.ReloadListView();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddModifyAirplane form2 = new AddModifyAirplane(0);
            form2.ShowDialog();
            this.ReloadListView();
        }

        private void editFlightItem_Click(object sender, EventArgs e)
        {
            AddFlightForm form2 = new AddFlightForm(this.id);
            form2.ShowDialog();
            this.ReloadListView();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            switch (this.category)
            {
                case "flights":
                    AddFlightForm addFlight = new AddFlightForm(0);
                    addFlight.ShowDialog();
                    this.ReloadListView();
                    break;
                case "airplanes":
                    AddModifyAirplane plane = new AddModifyAirplane(0);
                    plane.ShowDialog();
                    this.ReloadListView();
                    break;
                case "airlines":
                    Add_ModifyAirline line = new Add_ModifyAirline(0);
                    line.ShowDialog();
                    this.ReloadListView();
                    break;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int id = 0;
            ListViewItem item = new ListViewItem();
            if (this.lv_Main.SelectedItems.Count > 0)
            {
                item = this.lv_Main.SelectedItems[0];

            }
            switch (this.category)
            {
                case "flights":
                    Fly.FlyDao fly = new Fly.FlyDaoImplements();
                    id = Convert.ToInt32(item.SubItems[0].Text);
                    fly.removeFlight(id);

                    break;
                case "airlines":
                    Airline_company.Airline_companyDao line = new Airline_company.Airline_companyDaoImplements();
                    int idLine = Convert.ToInt32(item.SubItems[5].Text);

                    line.removeAirline(idLine);
                    break;
                case "airplanes":
                    Airplane.AirplaneDao air = new Airplane.AirplaneDaoImplements();
                    int idPlane = Convert.ToInt32(item.SubItems[3].Text);
                    air.removeAirplane(idPlane);
                    break;
            }
            this.ReloadListView();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            if (this.lv_Main.SelectedItems.Count > 0)
            {
                item = this.lv_Main.SelectedItems[0];

            }

            switch (this.category)
            {
                case "flights":
                    AddFlightForm addFlight = new AddFlightForm(Int32.Parse(item.SubItems[0].Text));
                    addFlight.ShowDialog();
                    this.ReloadListView();
                    break;
                case "airplanes":
                    AddModifyAirplane plane = new AddModifyAirplane(Int32.Parse(item.SubItems[3].Text));
                    plane.ShowDialog();
                    this.ReloadListView();
                    break;
                case "airlines":
                    Add_ModifyAirline line = new Add_ModifyAirline(Int32.Parse(item.SubItems[5].Text));
                    line.ShowDialog();
                    this.ReloadListView();
                    break;
            }
        }
    }
}
