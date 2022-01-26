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
            this.lblPersonality = new System.Windows.Forms.Label();
            this.cmbPersonality = new System.Windows.Forms.ComboBox();
            this.cmbMonster = new System.Windows.Forms.ComboBox();
            this.lblMonster = new System.Windows.Forms.Label();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnFullReload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonality
            // 
            this.lblPersonality.AutoSize = true;
            this.lblPersonality.Location = new System.Drawing.Point(12, 36);
            this.lblPersonality.Name = "lblPersonality";
            this.lblPersonality.Size = new System.Drawing.Size(61, 13);
            this.lblPersonality.TabIndex = 0;
            this.lblPersonality.Text = "Personality:";
            // 
            // cmbPersonality
            // 
            this.cmbPersonality.FormattingEnabled = true;
            this.cmbPersonality.Location = new System.Drawing.Point(79, 33);
            this.cmbPersonality.Name = "cmbPersonality";
            this.cmbPersonality.Size = new System.Drawing.Size(175, 21);
            this.cmbPersonality.TabIndex = 1;
            // 
            // cmbMonster
            // 
            this.cmbMonster.FormattingEnabled = true;
            this.cmbMonster.Location = new System.Drawing.Point(79, 6);
            this.cmbMonster.Name = "cmbMonster";
            this.cmbMonster.Size = new System.Drawing.Size(175, 21);
            this.cmbMonster.TabIndex = 3;
            // 
            // lblMonster
            // 
            this.lblMonster.AutoSize = true;
            this.lblMonster.Location = new System.Drawing.Point(12, 9);
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
            this.btnReload.Location = new System.Drawing.Point(260, 6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(71, 21);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnFullReload
            // 
            this.btnFullReload.Location = new System.Drawing.Point(260, 33);
            this.btnFullReload.Name = "btnFullReload";
            this.btnFullReload.Size = new System.Drawing.Size(71, 21);
            this.btnFullReload.TabIndex = 6;
            this.btnFullReload.Text = "Full Reload";
            this.btnFullReload.UseVisualStyleBackColor = true;
            this.btnFullReload.Click += new System.EventHandler(this.btnFullReload_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 335);
            this.Controls.Add(this.button1);
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
            this.Text = "ASPR [v1.0]";
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
        private System.Windows.Forms.Button button1;
    }
}

