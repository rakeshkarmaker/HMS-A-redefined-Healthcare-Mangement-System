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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            WprogressBar.Increment(3);
            if (WprogressBar.Value == 100)
            {
                timer1.Enabled = false;
                HomePage homePage = new HomePage();
                this.Hide();
                homePage.Show();
            }
        }
    }
}
