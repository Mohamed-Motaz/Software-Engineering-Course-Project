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
    public partial class ConnectedMode : Form
    {
        OracleConnection conn;
        private string connectionString = "data source=orcl; user id=hr; password=hr;";
        public ConnectedMode()
        {
            InitializeComponent();
            conn = new OracleConnection(connectionString);
            conn.Open();
        }

        private void ConnectedMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void ConnectedMode_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select userid from users";

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textVersionComboBox.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void textVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where userid=:id";
            cmd.Parameters.Add("id", textVersionComboBox.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                userNameTxtBox.Text = dr["username"].ToString();
                userEmailTxtBox.Text = dr["useremail"].ToString();
                isAdminTxtBox.Text = dr["isAdmin"].ToString();
            }
        }
    }
}
