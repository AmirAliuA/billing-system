using billing_system.UI;
using System.Windows.Forms;

namespace billing_system
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsers user = new formUsers();
            user.Show();

            // Don't allow the formUsers form to open more than once
            if (Application.OpenForms.OfType<formUsers>().Count() == 2)
                Application.OpenForms.OfType<formUsers>().First().Close();
        }
    }
}