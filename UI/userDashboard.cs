using billing_system.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_system
{
    public partial class userDashboard : Form
    {
        public userDashboard()
        {
            InitializeComponent();
        }

        private void userDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void userDashboard_Load(object sender, EventArgs e)
        {
            labelLoggedInUsername.Text = formLogin.loggedInUsername;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            formLogin login = new formLogin();
            login.ShowDialog();
        }
    }
}
