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
    public partial class Form1 : Form
    {
        private List<string> tableCreationScripts = new List<string>() 
        { "drop table users", 
            "drop table customers",
            @"Create Table Users
                (userID number(8)  primary key, isAdmin varchar2(1), userName varchar2(50), userEmail varchar2(50) unique)",
            @"Create Table Customers
                ( CustomerID number(8)  primary key,  CustomerName varchar2(50),  CustomerEmail varchar2(50) unique,  CustomerPlan varchar2(1))" };

        private List<string> insertDataScripts = new List<string>() 
        { @"insert into Users values
            (1, 'y', 'Mohamed Ahmed', 'mohamed.ahmed34@gmail.com')",
            @"insert into Users values
            (2, 'y', 'Rawan Ahmed', 'rawan.ahmed4@gmail.com')",
            @"insert into Users values
            (3, 'n', 'Kareem Ezzat', 'kareemezzat20@gmail.com')",
            @"insert into Users values
            (4, 'n', 'Mohamed Motaz', 'mohamedmotar87@gmail.com')",
            @"insert into Users values
            (5, 'n', 'Ali Anwar', 'alianwar123@gmail.com')",
            @"Insert into Customers values
            (1,'Kristen Stewart', 'Kristen_Stewart@gmail.com','A')",
            @"Insert into Customers values
            (2,'Robert Pattinson', 'Robert_Pattinson@gmail.com','A')",
            @"Insert into Customers values
            (3,'Taylor Lautner', 'Taylor_Lautner@gmail.com','C')",
            @"Insert into Customers values
            (4,'Rupert Grint', 'Rupert_Grint@gmail.com','C')",
            @"Insert into Customers values
            (5,'Daniel Radcliffe', 'Daniel_Radcliffe@gmail.com','C')",
            @"Insert into Customers values
            (6,'Ralph Fiennes', 'Ralph_Fiennes@gmail.com','B')"
        };

        private string connectionString = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void connectedBtn_Click(object sender, EventArgs e)
        {
            ConnectedMode form = new ConnectedMode();
            form.Show();
        }

        private void disconnectedBtn_Click(object sender, EventArgs e)
        {
            DisconnectedMode form = new DisconnectedMode();
            form.Show();
        }

        private void initializeDataBtn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectionString);
            conn.Open();

            foreach (string command in tableCreationScripts)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = command;
                try
                {
                    cmd.ExecuteNonQuery();
                }catch { }
            }
            foreach (string command in insertDataScripts)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = command;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch { }
            }
            MessageBox.Show("All tables created and all data added succesfully");
            conn.Dispose();
        }
    }
}
