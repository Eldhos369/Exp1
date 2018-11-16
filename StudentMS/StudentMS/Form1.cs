using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(username.Text=="admin"&&password.Text=="admin")
            {
                admin admin = new admin();
                admin.Show();
                this.Hide();
            }
            else
            {
                Faculty f = new Faculty();
                f.Show(); 
            }
        }
    }
}
