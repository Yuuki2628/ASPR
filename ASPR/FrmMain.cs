using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            cmbMonster.Enabled = false;
            cmbPersonality.Enabled = false;

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

            // Setting up the first column with the identifies of each value
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

            //meme lol
            dgwData.Rows[10].Cells[0].Value = "Don't do drugs...";
            dgwData.Rows[10].Cells[1].Value = "Do Yuuki Instead";

            //setting the background for the separator line and meme line
            dgwData.Rows[6].Cells[0].Style.BackColor = Color.DarkGray;
            dgwData.Rows[6].Cells[1].Style.BackColor = Color.DarkGray;

            dgwData.Rows[10].Cells[0].Style.BackColor = Color.DarkGray;
            dgwData.Rows[10].Cells[1].Style.BackColor = Color.DarkGray;

            //setting the width so nothing is hidden
            dgwData.Columns[0].Width = 110;
            dgwData.Columns[1].Width = 90;

            //loads everything
            FullReload();

            //enables the timer to automatically reload, this way cbosses stats are loaded automatically
            tmrReload.Enabled = true;
            tmrReload.Start();
        }

        /// <summary>
        /// Replaces the s object with a brand new object and reloads everything regarding stats
        /// </summary>
        private void FullReload()
        {
            s = new StatsManager();

            cmbMonster.Enabled = false;
            cmbPersonality.Enabled = false;

            Reload();

            tmrReload.Enabled = true;
            tmrReload.Start();

        }

        /// <summary>
        /// Reloads everything regarding stats
        /// </summary>
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

        /// <summary>
        /// Reload button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        /// <summary>
        /// Full reload button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFullReload_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure about this?", "Fully reload", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                FullReload();
        }

        /// <summary>
        /// Reloads when the timer runs out and disables itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrReload_Tick(object sender, EventArgs e)
        {
            Reload();
            tmrReload.Stop();
            tmrReload.Enabled = false;

            cmbMonster.Enabled = true;
            cmbPersonality.Enabled = true;
        }

        /// <summary>
        /// Updates the stats contained in the results table, used when a personality or monster is changed
        /// </summary>
        private void UpdateStats()
        {
            int indexM = cmbMonster.SelectedIndex;
            string[] enemyStats = new string[] //array with every stat of the monster
            {
                s[indexM, 0, "e"],  //name
                s[indexM, 1, "e"],  //hp
                s[indexM, 2, "e"],  //diplo
                s[indexM, 3, "e"],  //physical res
                s[indexM, 4, "e"],  //magical red
                s[indexM, 5, "e"],  //diplo res
            };

            //fix for a weird bug where it would have an index of -1 and crash
            int indexP;
            if (cmbPersonality.SelectedIndex == -1)
                indexP = 0;
            else
                indexP = cmbPersonality.SelectedIndex;

            string[] enemyPersonality = new string[] // array containing the personality multipliers
            {
                s[indexP, 0, "p"],  //name
                s[indexP, 1, "p"],  //attack res
                s[indexP, 2, "p"],  //talk res
            };

            /* calculates the final stats by multiplying the interested stats
             * finalStab = hp * stab resistance * attack resistance
             * finalMagic = hp * magic resistance * attack resistance
             * finalDiplo = diplo * diplo resistance * talk resistance
             */
            double[] finalStats = new double[] 
            {
                Convert.ToDouble(enemyStats[1].Replace('.', ',')) * Convert.ToDouble(enemyStats[3].Replace('.', ',')) * Convert.ToDouble(enemyPersonality[1].Replace('.', ',')),
                Convert.ToDouble(enemyStats[1].Replace('.', ',')) * Convert.ToDouble(enemyStats[4].Replace('.', ',')) * Convert.ToDouble(enemyPersonality[1].Replace('.', ',')),
                Convert.ToDouble(enemyStats[2].Replace('.', ',')) * Convert.ToDouble(enemyStats[5].Replace('.', ',')) * Convert.ToDouble(enemyPersonality[2].Replace('.', ','))
            };

            //prints out everything on the table
            dgwData.Rows[0].Cells[1].Value = $"{enemyStats[1]}";
            dgwData.Rows[1].Cells[1].Value = $"{enemyStats[2]}";
            dgwData.Rows[2].Cells[1].Value = $"{enemyStats[3]}";
            dgwData.Rows[3].Cells[1].Value = $"{enemyStats[4]}";
            dgwData.Rows[4].Cells[1].Value = $"{enemyPersonality[1]}";
            dgwData.Rows[5].Cells[1].Value = $"{enemyPersonality[2]}";
            dgwData.Rows[7].Cells[1].Value = $"{finalStats[0]}";
            dgwData.Rows[8].Cells[1].Value = $"{finalStats[1]}";
            dgwData.Rows[9].Cells[1].Value = $"{finalStats[2]}";

        }

        private void cmbMonster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMonster.SelectedIndex < s.enemiesN)
                UpdateStats();
        }

        private void cmbPersonality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersonality.SelectedIndex < s.personalitiesN)
                UpdateStats();
        }
    }
}
