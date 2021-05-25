using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Course_Project
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }
        [Category("Custom Props")]
        private String _name;
        public String Name
        {
            get { return _name; }
            set { _name = value; nameLabel.Text = value; }
        }
        [Category("Custom Props")]
        private String _id;
        public String ID
        {
            get { return _id; }
            set { _id = value; idLabel.Text = value; }
        }
        [Category("Custom Props")]
        private String _email;
        public String Email
        {
            get { return _email; }
            set { _email = value;  email_label.Text = value; }
        }
        [Category("Custom Props")]
        private String _admin;
        public String Admin
        {
            get { return _admin; }
            set { _admin = value; admin_label.Text = value; }
        }

        [Category("Custom Props")]
        private String _salary;
        public String Salary
        {
            get { return _salary; }
            set { _salary = value; salaryLabel.Text = value; }
        }
        private void ListItem_Load(object sender, EventArgs e)
        {

        }

        private void ListItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
