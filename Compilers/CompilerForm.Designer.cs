namespace Compilers
{
    partial class CompilerForm
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openRule = new System.Windows.Forms.Button();
            this.saveRule = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DGV.Location = new System.Drawing.Point(13, 13);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(645, 388);
            this.DGV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "+";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "*";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "(";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = ")";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "i";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "#";
            this.Column6.Name = "Column6";
            // 
            // openRule
            // 
            this.openRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openRule.Location = new System.Drawing.Point(817, 57);
            this.openRule.Name = "openRule";
            this.openRule.Size = new System.Drawing.Size(178, 58);
            this.openRule.TabIndex = 1;
            this.openRule.Text = "Open Rule Table";
            this.openRule.UseVisualStyleBackColor = true;
            this.openRule.Click += new System.EventHandler(this.openRule_Click);
            // 
            // saveRule
            // 
            this.saveRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveRule.Location = new System.Drawing.Point(817, 169);
            this.saveRule.Name = "saveRule";
            this.saveRule.Size = new System.Drawing.Size(178, 59);
            this.saveRule.TabIndex = 2;
            this.saveRule.Text = "Save Rule Table";
            this.saveRule.UseVisualStyleBackColor = true;
            this.saveRule.Click += new System.EventHandler(this.saveRule_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveAs.Location = new System.Drawing.Point(817, 273);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(178, 62);
            this.SaveAs.TabIndex = 3;
            this.SaveAs.Text = "Save As";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // CompilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1094, 577);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.saveRule);
            this.Controls.Add(this.openRule);
            this.Controls.Add(this.DGV);
            this.Name = "CompilerForm";
            this.Text = "CompilerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button openRule;
        private System.Windows.Forms.Button saveRule;
        private System.Windows.Forms.Button SaveAs;
    }
}