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
        public ConnectedMode()
        {
            InitializeComponent();
        }

        private void ConnectedMode_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ConnectedMode_Load(object sender, EventArgs e)
        {
           
        }

        private void addOrEditUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddOrEditUser form = new AddOrEditUser();
            form.ShowDialog();
            this.Close();
        }

        private void addOrEditCustomerBtn_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            AddOrEditCustomer form = new AddOrEditCustomer();
            form.ShowDialog();
            this.Close();
        }

        private void viewAllUsersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllUsers view = new ViewAllUsers();
            view.ShowDialog();
            this.Close();
        }

        private void viewAllCustomersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllCustomers view = new ViewAllCustomers();
            view.ShowDialog();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
