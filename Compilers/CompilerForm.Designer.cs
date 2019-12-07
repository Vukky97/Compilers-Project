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
            this.openRule = new System.Windows.Forms.Button();
            this.saveRule = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV.Location = new System.Drawing.Point(13, 13);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(750, 350);
            this.DGV.TabIndex = 0;
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
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 412);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(764, 20);
            this.textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Preview n Edit";
            // 
            // CompilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1107, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.saveRule);
            this.Controls.Add(this.openRule);
            this.Controls.Add(this.DGV);
            this.Name = "CompilerForm";
            this.Text = "CompilerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button openRule;
        private System.Windows.Forms.Button saveRule;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
    }
}