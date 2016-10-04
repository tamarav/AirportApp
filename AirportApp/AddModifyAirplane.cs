using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AirportApp.Airplane;

namespace AirportApp
{
    public partial class AddModifyAirplane : Form
    {
        int id = 0;

        public AddModifyAirplane(int id)
        {

            InitializeComponent();
            if (id == 0)
            {
                lbl_title.Text = "Add airplane";
                btn_add.Text = "Add";
            }
            else if (id != 0)
            {
                this.id = id;
                lbl_title.Text = "Modify airplane";
                btn_add.Text = "Save";

            }
            AirplaneDao airplaneDao = new AirplaneDaoImplements();


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddModifyAirplane_Load(object sender, EventArgs e)
        {
            lbl_info.Text = "";
            Airline_company.Airline_companyDao airlinesDao = new Airline_company.Airline_companyDaoImplements();
            List<Airline_company.Airline_company> airlines = airlinesDao.getAllAirlinesData();
            foreach (Airline_company.Airline_company s in airlines)
            {
                this.cb_airlines.Items.Add(new { Text = s.Name, Value = s.Id });
            }
            this.cb_airlines.DisplayMember = "Text";
            this.cb_airlines.ValueMember = "Value";

            if (this.id == 0)
            {
                lbl_title.Text = "Add airplane";
                btn_add.Text = "Add";
            }
            else if (this.id != 0)
            {
                lbl_title.Text = "Modify airplane";
                btn_add.Text = "Save";

                AirplaneDao airplaneDao = new AirplaneDaoImplements();
                Airplane.Airplane airplane = airplaneDao.getAirplane(this.id);

                this.tb_name.Text = airplane.Name;

                Airline_company.Airline_company ac = airlinesDao.getAirlineDataForModification(airplane.Airline_company_id);

                this.tb_numberOfSeats.Text = airplane.Number_of_seats.ToString();
                this.cb_airlines.SelectedItem = new { Text = ac.Name, Value = ac.Id };

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (this.id == 0)
            {
                if (this.tb_name.Text == "" || this.tb_numberOfSeats.Text == "" || this.cb_airlines.Text == "")
                {
                    this.lbl_info.Text = "Missing information.";
                    this.lbl_info.Show();
                    return;
                }
                Airline_company.Airline_companyDao airlineDao = new Airline_company.Airline_companyDaoImplements();

                int airlineId = airlineDao.getAirlineId(this.cb_airlines.Text);
                Airplane.Airplane plane = new Airplane.Airplane(this.tb_name.Text, this.tb_numberOfSeats.Text, airlineId);
                Airplane.AirplaneDao dao = new Airplane.AirplaneDaoImplements();
                dao.addAirplane(plane);
            }
            else if (this.id != 0)
            {
                if (this.tb_name.Text == "" || this.tb_numberOfSeats.Text == "" || this.cb_airlines.Text == "")
                {
                    this.lbl_info.Text = "Missing information.";
                    this.lbl_info.Show();
                    return;
                }
                Airline_company.Airline_companyDao airlineDao = new Airline_company.Airline_companyDaoImplements();

                int airlineId = airlineDao.getAirlineId(this.cb_airlines.Text);
                Airplane.Airplane plane = new Airplane.Airplane(this.id, this.tb_name.Text, Int32.Parse(this.tb_numberOfSeats.Text), airlineId);
                Airplane.AirplaneDao dao = new Airplane.AirplaneDaoImplements();
                dao.editAirplane(plane);
            }
            this.Close();
        }

        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btn_add_Click(sender, e);
            }
        }
    }
}
