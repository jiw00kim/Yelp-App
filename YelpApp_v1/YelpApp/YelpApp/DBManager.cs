using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace YelpApp
{
    public sealed class DBManager
    {
        private static DBManager? instance = null;
        private static readonly object padlock = new object();

        DBManager()
        {
        }

        public static DBManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DBManager();
                    }
                    return instance;
                }
            }
        }

        private NpgsqlConnection con;

        public void Connect()
        {
            // TODO: set your PW 
            var cs = "Host=localhost;Username=postgres;Password=011643030;Database=tempyelp";

            con = new NpgsqlConnection(cs);
            con.Open();

            //var sql = "SELECT version()";

            //var cmd = new NpgsqlCommand(sql, con);
            //var version = cmd.ExecuteScalar().ToString();
            //return $"PostgreSQL version: {version}";
        }

        public List<string> GetAllStates()
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT DISTINCT state FROM business", con);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<string> states = new List<string>();
            while (reader.Read())
            {
                states.Add(String.Format("{0}", reader[0]));
            }
            reader.Close();
            return states;
        }

        public List<NumTipsModel> GetAllTips()
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT tipdate, tip.user_id, tip.likes, tiptext from tip, business where tip.user_id = business.business_id", con);
            NpgsqlDataReader reader = command.ExecuteReader();

           
            List<NumTipsModel> tips = new List<NumTipsModel>();

            while(reader.Read())
            {
                NumTipsModel numTips = new NumTipsModel();
                numTips.date = String.Format("{0}", reader["tipdate"]);
                numTips.userName = String.Format("{0}", reader["user_id"]);
                numTips.likes = String.Format("{0}", reader["likes"]);
                numTips.text = String.Format("{0}", reader["tiptext"]);

                tips.Add(numTips);

            }

            reader.Close();

            return tips;

        }

        public List<string> GetAllCities(string state)
        {
            string cmd = string.Format("SELECT DISTINCT city FROM business WHERE state = '{0}'", state);
            NpgsqlCommand command = new NpgsqlCommand(cmd, con);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<string> cities = new List<string>();
            while (reader.Read())
            {
                cities.Add(String.Format("{0}", reader[0]));
            }
            reader.Close();
            return cities;
        }

        public List<string> GetAllZipcodes(string state, string city)
        {
            string cmd = string.Format("SELECT DISTINCT zipcode FROM BUSINESS WHERE state = '{0}' AND city = '{1}'", state, city);
            NpgsqlCommand command = new NpgsqlCommand(cmd, con);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<string> zipcodes = new List<string>();
            while (reader.Read())
            {
                zipcodes.Add(String.Format("{0}", reader[0]));
            }
            reader.Close();
            return zipcodes;
        }

        public List<string> GetAllCategories(string state, string city, string zipcode)
        {
            string cmd = string.Format("SELECT DISTINCT business_id FROM business WHERE state = '{0}' AND city = '{1}' AND zipcode = '{2}'", state, city, zipcode);
            NpgsqlCommand command = new NpgsqlCommand(cmd, con);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<string> businesses = new List<string>();
            while (reader.Read())
            {
                businesses.Add(String.Format("{0}", reader[0]));
            }
            reader.Close();

            StringBuilder sb = new StringBuilder("SELECT DISTINCT category_name FROM categories WHERE");
            for (int i = 0; i < businesses.Count; i++)
            {
                if (i > 0)
                {
                    sb.Append(String.Format(" OR"));
                }
                sb.Append(String.Format(" business_id = '{0}'", businesses[i]));
            }

            cmd = sb.ToString();
            command = new NpgsqlCommand(cmd, con);
            reader = command.ExecuteReader();
            List<string> categories = new List<string>();
            while (reader.Read())
            {
                categories.Add(String.Format("{0}", reader[0]));
            }
            reader.Close();

            return categories;
        }

        public List<BusinessModel> GetBusinesses(string state, string city, string zipcode, string userId, List<string> categories = null)
        {
            StringBuilder sb = new StringBuilder(string.Format("SELECT business.name, business.address, business.city, business.state,"
                    + " asin("
                    + "   sqrt("
                    + "     sin(radians(business.latitude - users.lat) / 2) ^ 2 +"
                    + "     sin(radians(business.longitude - users.long) / 2) ^ 2 *"
                    + "     cos(radians(users.lat)) *"
                    + "     cos(radians(business.latitude))"
                    + "   )"
                    + " ) * 7926.3352 AS distance,"
                    + " stars,"
                    + " numtips,"
                    + " numcheckins"
                    + " FROM business, users"
                    + " WHERE users.user_id = '{0}'"
                    + " AND business.state = '{1}'"
                    + " AND business.city = '{2}'"
                    + " AND business.zipcode = '{3}'", userId, state, city, zipcode));
            string cmd = sb.ToString();
            NpgsqlCommand command = new NpgsqlCommand(cmd, con);
            NpgsqlDataReader reader = command.ExecuteReader();
            List<BusinessModel> businesses = new List<BusinessModel>();
            int i = 0;
            while (reader.Read())
            {
                BusinessModel business = new BusinessModel();
                business.name = String.Format("{0}", reader["name"]);
                business.address = String.Format("{0}", reader["address"]);
                business.city = String.Format("{0}", reader["city"]);
                business.state = String.Format("{0}", reader["state"]);
                business.distance = String.Format("{0}", reader["distance"]);
                business.stars = String.Format("{0}", reader["stars"]);
                business.numtips = String.Format("{0}", reader["numtips"]);
                business.numcheckins = String.Format("{0}", reader["numcheckins"]);
                businesses.Add(business);
                i++;
            }
            reader.Close();

            return businesses;
        }
    }
}
