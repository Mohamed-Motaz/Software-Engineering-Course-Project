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
    public partial class AddOrEditCustomer : Form
    {
        OracleConnection conn;
        private string connectionString = "data source=orcl; user id=hr; password=hr;";
        public AddOrEditCustomer()
        {
            InitializeComponent();
            conn = new OracleConnection(connectionString);
            conn.Open();
        }
        

        private void AddOrEditCustomer_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAllCustomers";
            cmd.Parameters.Add("customers", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textVersionComboBox.Items.Add(dr["customerid"]);
            }
            customerPlanComboBox.Items.Add("A");
            customerPlanComboBox.Items.Add("B");
            customerPlanComboBox.Items.Add("C");

            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsIdPresent() || textVersionComboBox.Text.Length == 0)
            {
                AddCustomer();
                return;
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateCustomer";
            cmd.Parameters.Add("id", textVersionComboBox.Text);
            cmd.Parameters.Add("name", customerNameTxtBox.Text);
            cmd.Parameters.Add("email", customerEmailTxtBox.Text);
            if (customerPlanComboBox.Text != "A" && customerPlanComboBox.Text != "B" && customerPlanComboBox.Text != "C")
            {
                MessageBox.Show("Please choose an appropriate plan");
                return;
            }
            cmd.Parameters.Add("plan", customerPlanComboBox.Text.ToString());

            int r = cmd.ExecuteNonQuery();
             MessageBox.Show("Customer successfully updated");

        }
        private void AddCustomer()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertCustomer";
            
            string id = "";
            if (textVersionComboBox.Text.Length != 0)
                id = textVersionComboBox.Text;
            else
                id = getCustomerId().ToString();
            cmd.Parameters.Add("id", id);
            cmd.Parameters.Add("name", customerNameTxtBox.Text);
            cmd.Parameters.Add("email", customerEmailTxtBox.Text);
            if (customerPlanComboBox.Text != "A" && customerPlanComboBox.Text != "B" && customerPlanComboBox.Text != "C")
            {
                MessageBox.Show("Please choose an appropriate plan");
                return;
            }
            cmd.Parameters.Add("plan", customerPlanComboBox.Text.ToString());
            int r = cmd.ExecuteNonQuery();
            
            textVersionComboBox.Items.Add(id);                
            MessageBox.Show("Customer successfully created");
            textVersionComboBox.SelectedItem = id;
            


        }
        private int getCustomerId()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetMaxCustomerId";
            cmd.Parameters.Add("mx", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                return Convert.ToInt32(cmd.Parameters["mx"].Value.ToString()) + 1;
            }catch
            {
                return 1;
            }
        }

        private void textVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customers where customerid=:id";
            cmd.Parameters.Add("id", textVersionComboBox.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                customerNameTxtBox.Text = dr["customername"].ToString();
                customerEmailTxtBox.Text = dr["customeremail"].ToString();
                customerPlanComboBox.SelectedItem = dr["customerplan"].ToString();
            }
        }
        private bool IsIdPresent()
        {
            bool present = false;
            foreach (var item in textVersionComboBox.Items)
            {
                if (item.ToString() == textVersionComboBox.Text)
                {
                    present = true;
                    break;
                }
            }
            return present;
        }
    }
}
