using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLoto
{
    public partial class FrmGameMode : Form
    {
        public FrmGameMode()
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();
            InitializeComponent();
        }

        private void btPlayOnline_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
