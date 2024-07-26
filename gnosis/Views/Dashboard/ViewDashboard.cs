using System.Windows.Forms;
using gnosis.Controllers.Dashboard;

namespace gnosis.Views.Dashboard
{
    public partial class ViewDashboard : Form
    {
        public ViewDashboard(string username)
        {
            InitializeComponent();
            ControllerDashboard objDash = new ControllerDashboard(this, username);
        }
    }
}
