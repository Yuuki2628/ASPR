using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        string[,] topTen = new string[10, 2]
        {
            {"","0"},
            {"","0"},
            {"","0"},
            {"","0"},
            {"","0"},
            {"","0"},
            {"","0"},
            {"","0"},
            {"","0"},
            {"","0"}
        };

        public string[,] obtainTopTen
        {
            get { return topTen; }
            private set { }
        }
        public FrmMain()
        {
            InitializeComponent();

            dgwData.RowCount = 11;
            cmbMonster.Enabled = false;
            cmbPersonality.Enabled = false;
            btnChangelog.Enabled = false;
            btnDisplayTop.Enabled = false;
            btnFullReload.Enabled = false;
            btnGetTop.Enabled = false;
            btnReload.Enabled = false;

            /*
             * HP
             * Diplomacy
             * Physical Resistance
             * Magical Resistance
             * Persuasion Resistance
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
            dgwData.Rows[2].Cells[0].Value = "Physical Resistance:";
            dgwData.Rows[3].Cells[0].Value = "Magical Resistance:";
            dgwData.Rows[4].Cells[0].Value = "Persuasion Resistance:";
            dgwData.Rows[5].Cells[0].Value = "Personality Values:";
            dgwData.Rows[6].Cells[0].Value = "Final Results:";
            dgwData.Rows[7].Cells[0].Value = "Stab:";
            dgwData.Rows[8].Cells[0].Value = "Magic:";
            dgwData.Rows[9].Cells[0].Value = "Diplomacy:";

            //meme lol
            dgwData.Rows[10].Cells[0].Value = "This part is useless...";
            dgwData.Rows[10].Cells[1].Value = "Get Top 10 now";

            //setting the background for the separator line and meme line
            dgwData.Rows[6].Cells[0].Style.BackColor = Color.DarkGray;
            dgwData.Rows[6].Cells[1].Style.BackColor = Color.DarkGray;

            dgwData.Rows[10].Cells[0].Style.BackColor = Color.DarkGray;
            dgwData.Rows[10].Cells[1].Style.BackColor = Color.DarkGray;

            /* Hides the first annoying column */
            dgwData.RowHeadersVisible = false;

            //setting the width so everything is visible
            dgwData.Columns[0].Width = 120;
            dgwData.Columns[1].Width = 120;

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

            // empties the top ten list
            topTen = new string[10, 2]
            {
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"}
            };

            //meme lol
            dgwData.Rows[10].Cells[0].Value = "This part is useless...";
            dgwData.Rows[10].Cells[1].Value = "Get Top 10 now";

            btnGetTop.Text = "Get Top";
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
            btnChangelog.Enabled = true;
            btnDisplayTop.Enabled = true;
            btnFullReload.Enabled = true;
            btnGetTop.Enabled = true;
            btnReload.Enabled = true;
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

            // used to 
            NumberFormatInfo numberInfo = CultureInfo.CurrentCulture.NumberFormat;
            /* calculates the final stats by multiplying the interested stats
             * finalStab = hp * stab resistance * attack resistance
             * finalMagic = hp * magic resistance * attack resistance
             * finalDiplo = diplo * diplo resistance * talk resistance
             */
            double[] finalStats = new double[] 
            {
                GetDouble(enemyStats[1]) * GetDouble(enemyStats[3]) * GetDouble(enemyPersonality[1]),
                GetDouble(enemyStats[1]) * GetDouble(enemyStats[4]) * GetDouble(enemyPersonality[1]),
                GetDouble(enemyStats[2]) * GetDouble(enemyStats[5]) * GetDouble(enemyPersonality[2])
            };

            //prints out everything on the table
            dgwData.Rows[0].Cells[1].Value = $"{enemyStats[1]}";
            dgwData.Rows[1].Cells[1].Value = $"{enemyStats[2]}";
            dgwData.Rows[2].Cells[1].Value = $"{enemyStats[3]}";
            dgwData.Rows[3].Cells[1].Value = $"{enemyStats[4]}";
            dgwData.Rows[4].Cells[1].Value = $"{enemyStats[5]}";
            dgwData.Rows[5].Cells[1].Value = $"{enemyPersonality[1]} / {enemyPersonality[2]}";
            dgwData.Rows[7].Cells[1].Value = $"{finalStats[0]}";
            dgwData.Rows[8].Cells[1].Value = $"{finalStats[1]}";
            dgwData.Rows[9].Cells[1].Value = $"{finalStats[2]}";

            if (topTen[0, 0] != "")
            {
                bool gotEm = false;
                for (int i = 0; i < 10 && !gotEm; i++)
                    if (enemyStats[0] == topTen[i, 0])
                    {
                        dgwData.Rows[10].Cells[0].Value = $"This is the top #{i + 1}";
                        dgwData.Rows[10].Cells[1].Value = $"Strenght: {GetDouble(topTen[i, 1])}";
                        gotEm = true;
                    }
                if(!gotEm)
                {
                    /* ((HP * PhysicalResistance) + (Hp * MagicalResistance)) / 2 + (Diplomacy * PersuasionDefence) */
                    double strength = ((finalStats[0] + finalStats[1]) / 2) + (finalStats[2]);

                    dgwData.Rows[10].Cells[0].Value = $"This not a top enemy";
                    dgwData.Rows[10].Cells[1].Value = $"Strenght: {strength}";
                }
            }
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

        /// <summary>
        /// Gets the top 10 strongest enemies in the game
        /// </summary>
        private void getTopTen()
        {
            topTen = new string[10, 2]
            {
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"},
                {"","0"}
            };

            for (int i = 0; i < s.enemiesN; i++)
            {
                string[] enemyStats = new string[] //array with every stat of the monster
                {
                    s[i, 0, "e"],  //name
                    s[i, 1, "e"],  //hp
                    s[i, 2, "e"],  //diplo
                    s[i, 3, "e"],  //physical res
                    s[i, 4, "e"],  //magical red
                    s[i, 5, "e"],  //diplo res
                };

                string[] enemyPersonality = new string[] // array containing the personality multipliers
                {
                    s[12, 0, "p"],  //name
                    s[12, 1, "p"],  //attack res
                    s[12, 2, "p"],  //talk res
                };

                NumberFormatInfo numberInfo = CultureInfo.CurrentCulture.NumberFormat;
                double[] finalStats = new double[]
                {
                    GetDouble(enemyStats[1]) * GetDouble(enemyStats[3]) * GetDouble(enemyPersonality[1]),
                    GetDouble(enemyStats[1]) * GetDouble(enemyStats[4]) * GetDouble(enemyPersonality[1]),
                    GetDouble(enemyStats[2]) * GetDouble(enemyStats[5]) * GetDouble(enemyPersonality[2])
                };

                /* ((HP * PhysicalResistance) + (Hp * MagicalResistance)) / 2 + (Diplomacy * PersuasionDefence) */
                double strength = ((finalStats[0] + finalStats[1]) / 2) + (finalStats[2]);

                for (int j = 0; j < 10; j++)
                {
                    if (strength > GetDouble(topTen[j, 1]))
                    {
                        ShiftTopTen(enemyStats[0], strength, j);
                        break;
                    }
                }

            }
        }

        private double GetDouble(string s) => Double.Parse(s.Replace(',', '.'), CultureInfo.InvariantCulture);

        /// <summary>
        /// Moves the content of the list to the left by one adding the stronger one
        /// </summary>
        /// <param name="name"></param>
        /// <param name="strengh"></param>
        /// <param name="j"></param>
        private void ShiftTopTen(string name, double strengh, int j)
        {
            string[] temp = new string[2]
            {
                topTen[j, 0],
                topTen[j, 1]
            };

            if (name == "Raven" || name == "Orc Peon")
                return;

            topTen[j, 0] = name;
            topTen[j, 1] = strengh.ToString();

            j++;
            try
            {
                if (topTen[j, 0] == null || topTen[j + 1, 0] == null || topTen[j + 1, 0] == "")
                    return;
            }
            catch { return; }

            if (j < 9)
            {
                ShiftTopTen(temp[0], GetDouble(temp[1]), j);
            }
        }

        int nClicks = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (nClicks == 0)
            { 
                btnGetTop.Text = "Are you sure?";
                nClicks++;
            }
            else
            {
                getTopTen();
                btnGetTop.Text = "Got it!";
                nClicks = 0;
            }
        }

        private void btnDisplayTop_Click(object sender, EventArgs e)
        {
            if (topTen[0, 0] == "")
            {
                MessageBox.Show("You haven't gotten the top 10 enemies yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmMain frmMain = this;

            FrmTop10 frmTop10 = new FrmTop10(this);
            frmTop10.ShowDialog();
        }

        private void btnChangelog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "~~~ v1.0 ~~~" +
                "\n- all the code has been rewritten" +
                "\n- performance upgrades" +
                "\n- removed Nega calculator" +
                "\n" +
                "\n ~~~ v1.1 ~~~" +
                "\n- first fix for international double conversions" +
                "\n" +
                "\n ~~~ v2.0 ~~~" +
                "\n- added a button to see the top 10 strongest enemies" +
                "\n- final fix for international double conversions" +
                "\n- added this Changelog button" +
                "\n" +
                "\n ~~~ v2.1 ~~~" +
                "\n- added a Form to view the top 10 strongest enemies" +
                "\n- QOL improvements" +
                "\n- during the loading time now every button will be off"
                , "Changelog", MessageBoxButtons.OK);
        }
    }
}
