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

            foreach(User newuser in users)
            {
                ListItem newList = new ListItem();
                newList.Name = newuser.name;
                newList.ID = newuser.id;
                newList.Email = newuser.email;
                newList.Admin = newuser.isAdmin;
                newList.Salary = newuser.salary;

                if (flowLayoutPanel1.Controls.Count < 0)
                    flowLayoutPanel1.Controls.Clear();
                else
                    flowLayoutPanel1.Controls.Add(newList);

            }

        }

        private void ViewAllUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnectedMode form = new ConnectedMode();
            form.ShowDialog();
            this.Close();
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
