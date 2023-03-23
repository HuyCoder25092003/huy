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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            FrmGameMode frmGameMode = new FrmGameMode();
            frmGameMode.ShowDialog();
            InitializeComponent();
            LoadTable();
        }

        void LoadTable()
        {
            Button oldButton = new Button()
            {
                Width = Height = 0,
                Location = new Point(-CONSTANT.MARGIN, 0)
            };

            for (int i = 0; i < CONSTANT.TABLELOTO_HEIGHT; i++)
            {
                for (int j = 0; j < CONSTANT.TABLELOTO_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = CONSTANT.LOTO_WiDTH,
                        Height = CONSTANT.LOTO_HEIGHT
                    };
                    btn.Location = new Point(oldButton.Location.X + oldButton.Width + CONSTANT.MARGIN, oldButton.Location.Y);
                    pnTableLoto.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton = new Button()
                {
                    Width = Height = 0,
                    Location = new Point(-CONSTANT.MARGIN, oldButton.Location.Y + CONSTANT.LOTO_HEIGHT)
                };
            }
        }
    }
}
