using AdminDashboard.Forms;
using PatientDashboard;
using PatientDashboard.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_Management_System.Forms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            this.Hide();
            loginform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFindDoc findDoc = new FormFindDoc();
            // this.Hide();
            findDoc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAdminProfile AdminInfo = new FormAdminProfile();
            // this.Hide();
            AdminInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAdminProfile AdminInfo = new FormAdminProfile();
            // this.Hide();
            AdminInfo.Show();
        }
    }
}
