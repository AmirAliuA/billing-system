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
        }
    }
}