using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.IO;

namespace AirportApp.DB
{
    class DBConnection
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "airport_db";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again.");
                        break;
                }
                return false;
            }

        }

        private bool CloseConnection()
        {
            try
            {
                connection.Clone();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal User.User getUser(string username)
        {
            string query = "SELECT * FROM USER WHERE username='" + username + "'";

            User.User newUser = null;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    data.Read();
                    newUser = new User.User(data.GetInt32(0), data.GetString(1), data.GetString(2));
                    return newUser;
                }
                data.Close();
                this.CloseConnection();
            }
            return null;
        }

        internal void addUser(User.User user)
        {
            string query = "INSERT INTO USER (username, password) VALUES ('" + user.Username + "', '" + user.Password + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        internal void addFlight(Fly.Fly flight)
        {
            string query = "INSERT INTO FLY (destination, start_point, departure_time, landing_time, airplane_id) VALUES ('" + flight.Destination + "', '" + flight.Start_point + "', '" + flight.Departure_time.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + flight.Landing_time.ToString("yyyy-MM-dd HH:mm:ss") + "', " + flight.Airplane_id + ")";
            Console.WriteLine(query);
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
            Console.WriteLine("db add flight");
        }

        public void removeFlight(int itemId)
        {
            string query = "DELETE FROM FLY WHERE id='" + itemId + "'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        internal void addAirplane(Airplane.Airplane airplane)
        {
            string query = "INSERT INTO AIRPLANE (name, number_of_seats, airline_company_id) VALUES ('" + airplane.Name + "', '" + airplane.Number_of_seats + "', '" + airplane.Airline_company_id + "')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void removeAirplane(int itemId)
        {
            string query = "DELETE FROM AIRPLANE WHERE id='" + itemId + "'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void addAirline(Airline_company.Airline_company airline)
        {
            string query = "INSERT INTO AIRLINE_COMPANY (name, country,  address, telephone, email) VALUES ('" + airline.Name + "', '" + airline.Country + "', '" + airline.Address + "', '" + airline.Telephone + "', '" + airline.Email + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void removeAirline(int itemId)
        {
            string query = "DELETE FROM AIRLINE_COMPANY WHERE id='" + itemId + "'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<Fly.Fly> getAllFlights()
        {
            List<Fly.Fly> listOfFlights = new List<Fly.Fly>();

            string query = "SELECT * FROM FLY";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                Fly.Fly flight;
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        flight = new Fly.Fly(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetDateTime(3), data.GetDateTime(4), data.GetInt32(5));
                        listOfFlights.Add(flight);
                    }
                }
                data.Close();
                this.CloseConnection();
            }
            return listOfFlights;
        }

        public List<string> getAirlines()
        {
            List<string> names = new List<string>();

            string query = "SELECT name FROM AIRLINE_COMPANY";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        names.Add(data.GetString(0));
                        //list.Add(new Flignts(data.GetString(0), data.GetDateTime(0).ToString(), )
                    }
                }
                data.Close();
                this.CloseConnection();
            }
            return names;
        }

        public List<Airline_company.Airline_company> getAirlinesData()
        {
            List<Airline_company.Airline_company> arcList = new List<Airline_company.Airline_company>();

            string query = "SELECT * FROM AIRLINE_COMPANY";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    string telephone, email;
                    while (data.Read())
                    {
                        if (!data.IsDBNull(4))
                        {
                            telephone = data.GetString(4);
                        }
                        else
                        {
                            telephone = "";
                        }
                        if (!data.IsDBNull(5))
                        {
                            email = data.GetString(5);
                        }
                        else
                        {
                            email = "";
                        }

                        arcList.Add(new Airline_company.Airline_company(data.GetString(1), data.GetString(2), data.GetString(3), telephone, email, data.GetInt32(0)));

                    }
                }
                data.Close();
                this.CloseConnection();
            }
            return arcList;
        }

        public Fly.Fly getFlight(string destination)
        {

            string query = "SELECT destination, start_point, departure_time, landing_time, airplane_id FROM FLY WHERE destination='" + destination + "'";

            Fly.Fly flight = null;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    data.Read();
                    flight = new Fly.Fly(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetDateTime(3), data.GetDateTime(4), data.GetInt16(5).ToString());
                    return flight;
                }
                data.Close();
                this.CloseConnection();
            }
            return null;
        }

        public Airplane.Airplane getAirplane(int id)
        {
            string query = "SELECT * FROM AIRPLANE WHERE id='" + id + "'";

            Airplane.Airplane airplane = null;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    data.Read();
                    airplane = new Airplane.Airplane(data.GetInt32(0), data.GetString(1), data.GetInt32(2), data.GetInt32(3));
                    return airplane;
                }
                data.Close();
                this.CloseConnection();
            }
            return null;
        }

        public Airplane.Airplane getAirplaneName(string name)
        {
            string query = "SELECT * FROM AIRPLANE WHERE name='" + name + "'";

            Airplane.Airplane airplane = null;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    data.Read();
                    airplane = new Airplane.Airplane(data.GetInt32(0), data.GetString(1), data.GetInt32(2), data.GetInt32(3));
                    return airplane;
                }
                data.Close();
                this.CloseConnection();
            }
            return null;
        }


        public Fly.Fly getFlight(int id)
        {
            string query = "SELECT * FROM FLY WHERE id='" + id + "'";

            Fly.Fly flight = null;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    data.Read();
                    flight = new Fly.Fly(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetDateTime(3), data.GetDateTime(4), data.GetInt16(5).ToString());
                    return flight;
                }
                data.Close();
                this.CloseConnection();
            }
            return null;
        }


        public List<Airplane.Airplane> getAllAirplanes()
        {
            List<Airplane.Airplane> listOfAirplanes = new List<Airplane.Airplane>();

            string query = "SELECT * FROM airplane";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                Airplane.Airplane airplane;
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        airplane = new Airplane.Airplane(data.GetInt32(0), data.GetString(1), data.GetInt32(2), data.GetInt32(3));
                        listOfAirplanes.Add(airplane);
                    }
                }
                data.Close();
                this.CloseConnection();
            }
            return listOfAirplanes;
        }

        public void editFlight(Fly.Fly flight)
        {

            string query = "UPDATE fly SET destination='" + flight.Destination + "', start_point='" + flight.Start_point + "', departure_time='" + flight.Departure_time.ToString("yyyy-MM-dd HH:mm:ss") + "', landing_time='" + flight.Landing_time.ToString("yyyy-MM-dd HH:mm:ss") + "', airplane_id='" + flight.Airplane_id + "' WHERE id='" + flight.Id + "'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        internal void editAirline(Airline_company.Airline_company airline)
        {
            string query = "UPDATE airline_company SET name='" + airline.Name + "', country='" + airline.Country + "', address='" + airline.Address + "', telephone='" + airline.Telephone + "', email='" + airline.Email + "' WHERE id=" + airline.Id;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        internal void editAirplane(Airplane.Airplane airplane)
        {
            string query = "UPDATE airplane SET name='" + airplane.Name + "', number_of_seats='" + airplane.Number_of_seats + "', airline_company_id='" + airplane.Airline_company_id + "' WHERE id=" + airplane.Id;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public string getAirline(int id)
        {
            string airline = "";

            string query = "SELECT * FROM airline_company  WHERE id=' " + id + "'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        airline = data.GetString(1);
                    }
                }
                data.Close();
                this.CloseConnection();
            }
            return airline;
        }

        public int getAirlineId(string name)
        {
            int airline_id = 0;

            string query = "SELECT * FROM AIRLINE_COMPANY  WHERE name='" + name + "'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        airline_id = data.GetInt32(0);
                    }
                }
                data.Close();
                this.CloseConnection();
            }
            return airline_id;
        }

        public Airline_company.Airline_company getAirlineDataModification(int id)
        {
            string query = "SELECT * FROM AIRLINE_COMPANY WHERE id='" + id + "'";

            Airline_company.Airline_company airline = null;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    data.Read();
                    airline = new Airline_company.Airline_company(data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4), data.GetString(5));
                    return airline;
                }
                data.Close();
                this.CloseConnection();
            }
            return null;
        }
    }
}