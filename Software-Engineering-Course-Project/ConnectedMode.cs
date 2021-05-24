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
            AddOrEditUser form = new AddOrEditUser();
            form.Show();
        }

        private void addOrEditCustomerBtn_Click(object sender, EventArgs e)
        {
            AddOrEditCustomer form = new AddOrEditCustomer();
            form.Show();
        }
    }
}
