using gnosis.Controllers.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Views.Server
{
    public partial class ViewAdminConnection : Form
    {
        public ViewAdminConnection(int origen)
        {
            InitializeComponent();
            ControllerAdminConnection objConnection = new ControllerAdminConnection(this, origen);
        }
    }
}
