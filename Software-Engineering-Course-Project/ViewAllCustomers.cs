using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace Software_Engineering_Course_Project
{
    public partial class ViewAllCustomers : Form
    {
        OracleConnection conn;
        private string connectionString = "data source=orcl; user id=hr; password=hr;";
        List<Customer> customers;
        public ViewAllCustomers()
        {
            InitializeComponent();
            conn = new OracleConnection(connectionString);
            conn.Open();
        }

        private void ViewAllCustomers_Load(object sender, EventArgs e)
        {
            customers = new List<Customer>();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customers";

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                customers.Add(new Customer()
                {
                    email = dr["customeremail"].ToString(),
                    id = dr["customerid"].ToString(),
                    name = dr["customername"].ToString(),
                    plan = dr["customerplan"].ToString()
                });
            }
            dr.Close();
            foreach(Customer newcustomer in customers)
            {
                NewListItem newList = new NewListItem();
                newList.Name = newcustomer.name;
                newList.ID = newcustomer.id;
                newList.Email = newcustomer.email;
                newList.Plan = newcustomer.plan;

                if (flowLayoutPanel1.Controls.Count < 0)
                    flowLayoutPanel1.Controls.Clear();
                else
                    flowLayoutPanel1.Controls.Add(newList);
            }

        }

        private void ViewAllCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
    class Customer
    {
        public string id;
        public string name;
        public string email;
        public string plan;
    }
}
