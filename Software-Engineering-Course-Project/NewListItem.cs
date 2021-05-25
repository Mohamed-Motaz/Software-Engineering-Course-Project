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
    public partial class NewListItem : UserControl
    {
        public NewListItem()
        {
            InitializeComponent();
        }
        private String _name;
        [Category("Custom Props")]
        public String Name
        {
            get { return _name; }
            set { _name = value; name_label.Text = value;  }
        }
        private String _id;
        [Category("Custom Props")]
        public String ID
        {
            get { return _id; }
            set { _id = value; id_label.Text = value; }
        }
        private String _email;
        [Category("Custom Props")]
        public String Email
        {
            get { return _email; }
            set { _email = value; email_label.Text = value; }
        }
        private String _plan;
        [Category("Custom Props")]
        public String Plan
        {
            get { return _plan; }
            set { _plan = value; plan_label.Text = value; }
        }


        private void NewListItem_Load(object sender, EventArgs e)
        {

        }

        private void NewListItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
        }

        private void NewListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
