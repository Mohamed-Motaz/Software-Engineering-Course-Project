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
    public partial class DisconnectedMode : Form
    {
        OracleDataAdapter oracleDataAdapter;
        OracleCommandBuilder oracleCommandBuilder;
        DataSet ds;

        public DisconnectedMode()
        {
            InitializeComponent();
        }

        private void DisconnectedMode_Load(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            String connectionText = "Data Source=orcl; User Id=hr; Password=hr;";
            String commandText = "";

            if (radioCust.Checked) { commandText = "Select * From customers"; }
            else if (radioUser.Checked) { commandText = "Select * From users"; }

            ds = new DataSet();

            oracleDataAdapter = new OracleDataAdapter(commandText, connectionText);
            oracleDataAdapter.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);
            oracleDataAdapter.Update(ds.Tables[0]);
            MessageBox.Show("Table Updated");
        }

        private void searchIdBtn_Click(object sender, EventArgs e)
        {
            String connectionText = "Data Source=orcl; User Id=hr; Password=hr;";
            String commandText = "Select * From users Where userid = :id";

            if (radioCust.Checked) { commandText = "Select * From customers Where customerid = :id"; }
            else if (radioUser.Checked) { commandText = "Select* From users Where userid = :id"; }

            oracleDataAdapter = new OracleDataAdapter(commandText, connectionText);
            oracleDataAdapter.SelectCommand.Parameters.Add("id", Convert.ToInt32(searchBox.Text));

            ds = new DataSet();
            oracleDataAdapter.Fill(ds);

            dataGridView.DataSource = ds.Tables[0];
        }

    }
}
