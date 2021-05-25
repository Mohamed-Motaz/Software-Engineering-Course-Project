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
    public partial class AddOrEditUser : Form
    {
        OracleConnection conn;
        private string connectionString = "data source=orcl; user id=hr; password=hr;";
        public AddOrEditUser()
        {
            InitializeComponent();
            conn = new OracleConnection(connectionString);
            conn.Open();
        }

        private void AddOrEditUser_Load(object sender, EventArgs e)
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

        private void AddOrEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
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
                if (dr["isAdmin"].ToString() == "y")
                    yesRadioBtn.Checked = true;
                else
                    noRadioBtn.Checked = true;
                salaryTxtBox.Text = dr["salary"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            if (!IsIdPresent())
            {
                addUser();
                return;
            }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update users set username=:username, useremail=:useremail, isAdmin=:isAdmin, salary=:salary where userid=:userid";
            cmd.Parameters.Add("username", userNameTxtBox.Text);
            cmd.Parameters.Add("useremail", userEmailTxtBox.Text);
            cmd.Parameters.Add("isAdmin", yesRadioBtn.Checked ? "y" : "n");
            cmd.Parameters.Add("salary", salaryTxtBox.Text);       
            cmd.Parameters.Add("userid", textVersionComboBox.Text);


            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("User successfully updated");
        }
        private bool IsIdPresent()
        {
            bool present = false;
            foreach( var item in textVersionComboBox.Items)
            {
                if (item.ToString() == textVersionComboBox.Text)
                {
                    present = true;
                    break;
                }
            }
            return present;
        }
        private void addUser()
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into users values (:userid, :isAdmin,:username, :useremail, :salary)";
            cmd.Parameters.Add("userid", textVersionComboBox.Text);           
            cmd.Parameters.Add("isAdmin", yesRadioBtn.Checked ? "y" : "n");

            cmd.Parameters.Add("username", userNameTxtBox.Text);
            cmd.Parameters.Add("useremail", userEmailTxtBox.Text);
            cmd.Parameters.Add("salary", salaryTxtBox.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
                MessageBox.Show("User successfully created");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from users where userid =:id";
            cmd.Parameters.Add("id", textVersionComboBox.SelectedItem.ToString());

            if ((cmd.ExecuteNonQuery()) != -1)
            {
                textVersionComboBox.Items.RemoveAt(textVersionComboBox.SelectedIndex);
                textVersionComboBox.Text = "";
                userNameTxtBox.Text = "";
                userEmailTxtBox.Text = "";
                salaryTxtBox.Text = "";
                MessageBox.Show("User is deleted");
            }
            else { MessageBox.Show("Select User to delete"); }
        }
    }
}
