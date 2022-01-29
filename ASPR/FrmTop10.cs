using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASPR
{
    public partial class FrmTop10 : Form
    {
        public FrmTop10(FrmMain frmMain)
        {
            InitializeComponent();

            string[,] top = frmMain.obtainTopTen;

            dgwTop.RowCount = 11;

            /* Hides the first annoying column */
            dgwTop.RowHeadersVisible = false;

            //setting the width so everything is visible
            dgwTop.Columns[0].Width = 20;
            dgwTop.Columns[1].Width = 109;
            dgwTop.Columns[2].Width = 110;

            for (int i = 0; i < 10; i++)
            {
                dgwTop.Rows[i].Cells[0].Value = i + 1;
                dgwTop.Rows[i].Cells[1].Value = top[i, 0];
                dgwTop.Rows[i].Cells[2].Value = top[i, 1];
            }

            //meme lol
            dgwTop.Rows[10].Cells[0].Value = "ထ";
            dgwTop.Rows[10].Cells[1].Value = "Don't do drugs...";
            dgwTop.Rows[10].Cells[2].Value = "Do Yuuki Instead";

            dgwTop.Rows[10].Cells[0].Style.BackColor = Color.DarkGray;
            dgwTop.Rows[10].Cells[1].Style.BackColor = Color.DarkGray;
            dgwTop.Rows[10].Cells[2].Style.BackColor = Color.DarkGray;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
