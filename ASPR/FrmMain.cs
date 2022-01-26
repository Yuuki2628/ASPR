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
    public partial class FrmMain : Form
    {
        StatsManager s;

        public FrmMain()
        {
            InitializeComponent();

            dgwData.RowCount = 11;

            /*
             * HP
             * Diplomacy
             * Physical Defence
             * Magical Defence
             * Persuasion Defence
             * 
             * Personality values
             * 
             * Stab
             * Magic
             * Diplomacy
             */

            dgwData.Rows[0].Cells[0].Value = "HP:";
            dgwData.Rows[1].Cells[0].Value = "Diplomacy:";
            dgwData.Rows[2].Cells[0].Value = "Physical Defence:";
            dgwData.Rows[3].Cells[0].Value = "Magical Defence:";
            dgwData.Rows[4].Cells[0].Value = "Persuasion Defence:";
            dgwData.Rows[5].Cells[0].Value = "Personality Values:";
            dgwData.Rows[6].Cells[0].Value = "Final Results:";
            dgwData.Rows[7].Cells[0].Value = "Stab:";
            dgwData.Rows[8].Cells[0].Value = "Magic:";
            dgwData.Rows[9].Cells[0].Value = "Diplomacy:";

            dgwData.Rows[10].Cells[0].Value = "Don't do drugs...";
            dgwData.Rows[10].Cells[1].Value = "Do Yuuki Instead";

            dgwData.Rows[6].Cells[0].Style.BackColor = Color.DarkGray;
            dgwData.Rows[6].Cells[1].Style.BackColor = Color.DarkGray;

            dgwData.Rows[10].Cells[0].Style.BackColor = Color.DarkGray;
            dgwData.Rows[10].Cells[1].Style.BackColor = Color.DarkGray;


            dgwData.Columns[0].Width = 110;
            dgwData.Columns[1].Width = 90;


            FullReload();
        }

        private void FullReload()
        {
            s = new StatsManager();
            Reload();
        }

        private void Reload()
        {
            cmbPersonality.Items.Clear();
            cmbMonster.Items.Clear();
            for (int i = 0; i < s.enemiesN; i++)
            {
                cmbMonster.Items.Add(s[i, 0, "e"]);
            }
            for (int i = 0; i < s.personalitiesN; i++)
            {
                if (s[i, 0, "p"] != null)
                    cmbPersonality.Items.Add(s[i, 0, "p"]);
            }
            cmbMonster.SelectedIndex = 0;
            cmbPersonality.SelectedIndex = 0;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnFullReload_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure about this?", "Fully reload", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                FullReload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Enemies number: {s.enemiesN}");
        }
    }
}
