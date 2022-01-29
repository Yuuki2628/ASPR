namespace ASPR
{
    partial class FrmTop10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDone = new System.Windows.Forms.Button();
            this.dgwTop = new System.Windows.Forms.DataGridView();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStrength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(260, 256);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(71, 21);
            this.btnDone.TabIndex = 6;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // dgwTop
            // 
            this.dgwTop.AllowUserToAddRows = false;
            this.dgwTop.AllowUserToDeleteRows = false;
            this.dgwTop.AllowUserToResizeColumns = false;
            this.dgwTop.AllowUserToResizeRows = false;
            this.dgwTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPosition,
            this.clmName,
            this.clmStrength});
            this.dgwTop.Location = new System.Drawing.Point(12, 12);
            this.dgwTop.Name = "dgwTop";
            this.dgwTop.ReadOnly = true;
            this.dgwTop.Size = new System.Drawing.Size(242, 265);
            this.dgwTop.TabIndex = 7;
            // 
            // clmPosition
            // 
            this.clmPosition.HeaderText = "#";
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmStrength
            // 
            this.clmStrength.HeaderText = "Strength";
            this.clmStrength.Name = "clmStrength";
            this.clmStrength.ReadOnly = true;
            this.clmStrength.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStrength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmTop10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 286);
            this.Controls.Add(this.dgwTop);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmTop10";
            this.ShowIcon = false;
            this.Text = "Top 10 strongest enemies";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgwTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridView dgwTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStrength;
    }
}