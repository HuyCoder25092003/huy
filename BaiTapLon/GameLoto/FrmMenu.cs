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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
