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

namespace AirportApp
{
    public partial class Add_ModifyAirline : Form
    {
        private int id = 0;

        public Add_ModifyAirline(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Add_ModifyAirline_Load(object sender, EventArgs e)
        {
            lbl_info.Text = "";
            if (this.id == 0)
            {
                this.lb_title.Text = "Add airline";
                this.btn_add.Text = "Add";
            }
            else if (this.id != 0)
            {
                this.lb_title.Text = "Modify airline";
                this.btn_add.Text = "Save";
                Airline_companyDao airlineDao = new Airline_companyDaoImplements();
                Airline_company.Airline_company airline = airlineDao.getAirlineDataForModification(this.id);
                this.tb_name.Text = airline.Name;
                this.tb_country.Text = airline.Country;
                this.tb_address.Text = airline.Address;
                this.tb_email.Text = airline.Email;
                this.tb_telephone.Text = airline.Telephone;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (this.id == 0)
            {
                lbl_info.Text = "";

                if (this.tb_name.Text == "" || this.tb_country.Text == "" || this.tb_address.Text == "")
                {
                    this.lbl_info.Text = "Missing information.";
                    this.lbl_info.Show();
                    return;
                }
                else
                {
                    Airline_company.Airline_companyDao dao = new Airline_company.Airline_companyDaoImplements();
                    string name = this.tb_name.Text;
                    string country = this.tb_country.Text;
                    string address = this.tb_address.Text;
                    string telephone = null;
                    string email = null;
                    if (this.tb_telephone.Text != "")
                    {
                        telephone = this.tb_telephone.Text;
                    }
                    if (this.tb_email.Text != "")
                    {
                        email = this.tb_email.Text;
                    }
                    Airline_company.Airline_company airline = new Airline_company.Airline_company(name, country, address, telephone, email);
                    dao.addAirline(airline);
                }
            }
            else if (this.id != 0)
            {
                lbl_info.Text = "";

                if (this.tb_name.Text == "" || this.tb_country.Text == "" || this.tb_address.Text == "")
                {
                    this.lbl_info.Text = "Missing information.";
                    this.lbl_info.Show();
                    return;
                }
                else
                {
                    Airline_company.Airline_companyDao dao = new Airline_company.Airline_companyDaoImplements();
                    string name = this.tb_name.Text;
                    string country = this.tb_country.Text;
                    string address = this.tb_address.Text;
                    string telephone = null;
                    string email = null;
                    if (this.tb_telephone.Text != "")
                    {
                        telephone = this.tb_telephone.Text;
                    }
                    if (this.tb_email.Text != "")
                    {
                        email = this.tb_email.Text;
                    }
                    
                    Airline_company.Airline_company airline = new Airline_company.Airline_company(name, country, address, telephone, email, this.id);
                    dao.editAirline(airline);
                }
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
