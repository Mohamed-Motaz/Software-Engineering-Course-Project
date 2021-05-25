using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Software_Engineering_Course_Project
{
    public partial class ViewAllUsers : Form
    {
        OracleConnection conn;
        private string connectionString = "data source=orcl; user id=hr; password=hr;";
        List<User> users;

        public ViewAllUsers()
        {
            InitializeComponent();
            conn = new OracleConnection(connectionString);
            conn.Open();
        }
        private void ViewAllUsers_Load(object sender, EventArgs e)
        {
            users = new List<User>();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users";

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                users.Add(new User() { email = dr["useremail"].ToString(),
                id = dr["userid"].ToString(), isAdmin = dr["isAdmin"].ToString(),
                name = dr["username"].ToString(), salary= dr["salary"].ToString()});
            }
            dr.Close();
        }

        private void ViewAllUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
    class User
    {
        public string id;
        public string name;
        public string email;
        public string isAdmin;
        public string salary;
    }
}
