namespace ASPR
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPersonality = new System.Windows.Forms.Label();
            this.cmbPersonality = new System.Windows.Forms.ComboBox();
            this.cmbMonster = new System.Windows.Forms.ComboBox();
            this.lblMonster = new System.Windows.Forms.Label();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnFullReload = new System.Windows.Forms.Button();
            this.tmrReload = new System.Windows.Forms.Timer(this.components);
            this.btnGetTop = new System.Windows.Forms.Button();
            this.btnChangelog = new System.Windows.Forms.Button();
            this.btnDisplayTop = new System.Windows.Forms.Button();
            this.btnInvisible = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonality
            // 
            this.lblPersonality.AutoSize = true;
            this.lblPersonality.Location = new System.Drawing.Point(12, 10);
            this.lblPersonality.Name = "lblPersonality";
            this.lblPersonality.Size = new System.Drawing.Size(61, 13);
            this.lblPersonality.TabIndex = 0;
            this.lblPersonality.Text = "Personality:";
            // 
            // cmbPersonality
            // 
            this.cmbPersonality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPersonality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPersonality.FormattingEnabled = true;
            this.cmbPersonality.Location = new System.Drawing.Point(79, 6);
            this.cmbPersonality.Name = "cmbPersonality";
            this.cmbPersonality.Size = new System.Drawing.Size(175, 21);
            this.cmbPersonality.TabIndex = 1;
            this.cmbPersonality.SelectedIndexChanged += new System.EventHandler(this.cmbPersonality_SelectedIndexChanged);
            // 
            // cmbMonster
            // 
            this.cmbMonster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMonster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonster.FormattingEnabled = true;
            this.cmbMonster.Location = new System.Drawing.Point(79, 34);
            this.cmbMonster.Name = "cmbMonster";
            this.cmbMonster.Size = new System.Drawing.Size(175, 21);
            this.cmbMonster.TabIndex = 3;
            this.cmbMonster.SelectedIndexChanged += new System.EventHandler(this.cmbMonster_SelectedIndexChanged);
            // 
            // lblMonster
            // 
            this.lblMonster.AutoSize = true;
            this.lblMonster.Location = new System.Drawing.Point(12, 37);
            this.lblMonster.Name = "lblMonster";
            this.lblMonster.Size = new System.Drawing.Size(38, 13);
            this.lblMonster.TabIndex = 2;
            this.lblMonster.Text = "Name:";
            // 
            // dgwData
            // 
            this.dgwData.AllowUserToAddRows = false;
            this.dgwData.AllowUserToDeleteRows = false;
            this.dgwData.AllowUserToResizeColumns = false;
            this.dgwData.AllowUserToResizeRows = false;
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmType,
            this.clmValue});
            this.dgwData.Location = new System.Drawing.Point(12, 60);
            this.dgwData.Name = "dgwData";
            this.dgwData.ReadOnly = true;
            this.dgwData.Size = new System.Drawing.Size(242, 265);
            this.dgwData.TabIndex = 4;
            // 
            // clmType
            // 
            this.clmType.Frozen = true;
            this.clmType.HeaderText = "Type";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            this.clmType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmValue
            // 
            this.clmValue.Frozen = true;
            this.clmValue.HeaderText = "Value";
            this.clmValue.Name = "clmValue";
            this.clmValue.ReadOnly = true;
            this.clmValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(260, 7);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(71, 21);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnFullReload
            // 
            this.btnFullReload.Location = new System.Drawing.Point(260, 34);
            this.btnFullReload.Name = "btnFullReload";
            this.btnFullReload.Size = new System.Drawing.Size(71, 21);
            this.btnFullReload.TabIndex = 6;
            this.btnFullReload.Text = "Full Reload";
            this.btnFullReload.UseVisualStyleBackColor = true;
            this.btnFullReload.Click += new System.EventHandler(this.btnFullReload_Click);
            // 
            // tmrReload
            // 
            this.tmrReload.Interval = 1000;
            this.tmrReload.Tick += new System.EventHandler(this.tmrReload_Tick);
            // 
            // btnGetTop
            // 
            this.btnGetTop.Location = new System.Drawing.Point(260, 61);
            this.btnGetTop.Name = "btnGetTop";
            this.btnGetTop.Size = new System.Drawing.Size(71, 35);
            this.btnGetTop.TabIndex = 7;
            this.btnGetTop.Text = "Get Top";
            this.btnGetTop.UseVisualStyleBackColor = true;
            this.btnGetTop.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangelog
            // 
            this.btnChangelog.Location = new System.Drawing.Point(260, 304);
            this.btnChangelog.Name = "btnChangelog";
            this.btnChangelog.Size = new System.Drawing.Size(71, 21);
            this.btnChangelog.TabIndex = 8;
            this.btnChangelog.Text = "Changelog";
            this.btnChangelog.UseVisualStyleBackColor = true;
            this.btnChangelog.Click += new System.EventHandler(this.btnChangelog_Click);
            // 
            // btnDisplayTop
            // 
            this.btnDisplayTop.Location = new System.Drawing.Point(260, 102);
            this.btnDisplayTop.Name = "btnDisplayTop";
            this.btnDisplayTop.Size = new System.Drawing.Size(71, 21);
            this.btnDisplayTop.TabIndex = 9;
            this.btnDisplayTop.Text = "Display Top";
            this.btnDisplayTop.UseVisualStyleBackColor = true;
            this.btnDisplayTop.Click += new System.EventHandler(this.btnDisplayTop_Click);
            // 
            // btnInvisible
            // 
            this.btnInvisible.Location = new System.Drawing.Point(260, 263);
            this.btnInvisible.Name = "btnInvisible";
            this.btnInvisible.Size = new System.Drawing.Size(71, 35);
            this.btnInvisible.TabIndex = 10;
            this.btnInvisible.UseVisualStyleBackColor = true;
            this.btnInvisible.Click += new System.EventHandler(this.btnInvisible_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 335);
            this.Controls.Add(this.btnInvisible);
            this.Controls.Add(this.btnDisplayTop);
            this.Controls.Add(this.btnChangelog);
            this.Controls.Add(this.btnGetTop);
            this.Controls.Add(this.btnFullReload);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgwData);
            this.Controls.Add(this.cmbMonster);
            this.Controls.Add(this.lblMonster);
            this.Controls.Add(this.cmbPersonality);
            this.Controls.Add(this.lblPersonality);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "ASPR [v2.1] by Yuuki";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPersonality;
        private System.Windows.Forms.ComboBox cmbPersonality;
        private System.Windows.Forms.ComboBox cmbMonster;
        private System.Windows.Forms.Label lblMonster;
        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValue;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnFullReload;
        private System.Windows.Forms.Timer tmrReload;
        private System.Windows.Forms.Button btnGetTop;
        private System.Windows.Forms.Button btnChangelog;
        private System.Windows.Forms.Button btnDisplayTop;
        private System.Windows.Forms.Button btnInvisible;
    }
}

