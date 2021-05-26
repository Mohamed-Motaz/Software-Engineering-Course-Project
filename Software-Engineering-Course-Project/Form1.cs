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
        {   "drop table users", 
            "drop table customers",
            @"Create Table Users
                (userID number(8)  primary key, isAdmin varchar2(3), userName varchar2(50), userEmail varchar2(50) unique, salary number(6))",
            @"Create Table Customers
                ( CustomerID number(8)  primary key,  CustomerName varchar2(50),  CustomerEmail varchar2(50) unique,  CustomerPlan varchar2(1))" };

        private List<string> insertDataScripts = new List<string>() 
        { @"insert into Users values
            (1, 'Yes', 'Mohamed Ahmed', 'mohamed.ahmed34@gmail.com', 65500)",
            @"insert into Users values
            (2, 'Yes', 'Rawan Ahmed', 'rawan.ahmed4@gmail.com', 6000)",
            @"insert into Users values
            (3, 'No', 'Kareem Ezzat', 'kareemezzat20@gmail.com', 80000)",
            @"insert into Users values
            (4, 'No', 'Mohamed Motaz', 'mohamedmotar87@gmail.com', 7542)",
            @"insert into Users values
            (5, 'No', 'Ali Anwar', 'alianwar123@gmail.com', 4000)",
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

        private string connectionString = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectedBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnectedMode form = new ConnectedMode();
            form.ShowDialog();
            this.Close();
        }

        private void disconnectedBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisconnectedMode form = new DisconnectedMode();
            form.ShowDialog();
            this.Close();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report form = new Report();
            form.ShowDialog();
            this.Close();
        }


        private void summReportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SummReport form = new SummReport();
            form.ShowDialog();
            this.Close();
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
            CreateProcedures();
            
            MessageBox.Show("All tables created and all data added succesfully");
            conn.Dispose();
        }
        private void CreateProcedures()
        {
            List<string> procedures = new List<string>()
            {
                @"create or replace PROCEDURE GetAllCustomers(customers out sys_refcursor)
                    as
                    begin
                    open customers for
                    select *
                    from customers;
                    end;",
                @"create or replace PROCEDURE GetMaxCustomerId(mx out number)
                    as
                    begin
                    select max(customerid)
                    into mx
                    from customers;
                    end;",
                @"create or replace PROCEDURE insertCustomer(id in number, name in varchar2, email in varchar2, plan in VARCHAR2)
                    as
                    begin
                    insert into customers
                    values (id, name, email, plan);
                    end;",
                @"create or replace PROCEDURE updateCustomer(id in number, name in varchar2, email in varchar2, plan in VARCHAR2)
                    as
                    begin
                    update customers
                    set customername = name, customeremail = email, customerplan = plan
                    where customerid = id;
                    end;"

            };
            foreach(string procedure in procedures)
            {
            OracleCommand cmd = new OracleCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = procedure;
            cmd.ExecuteNonQuery();
            }
            
        }
    }
}
