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
            this.BTN_Analyze = new System.Windows.Forms.Button();
            this.textBoxAnalyze = new System.Windows.Forms.TextBox();
            this.LBL_TEXT_TO_ANALIZE = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCorrectInput = new System.Windows.Forms.Label();
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
            this.openRule.Location = new System.Drawing.Point(13, 413);
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
            this.saveRule.Location = new System.Drawing.Point(292, 411);
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
            this.SaveAs.Location = new System.Drawing.Point(585, 409);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(178, 62);
            this.SaveAs.TabIndex = 3;
            this.SaveAs.Text = "Save As";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // BTN_Analyze
            // 
            this.BTN_Analyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_Analyze.Location = new System.Drawing.Point(839, 111);
            this.BTN_Analyze.Name = "BTN_Analyze";
            this.BTN_Analyze.Size = new System.Drawing.Size(151, 52);
            this.BTN_Analyze.TabIndex = 6;
            this.BTN_Analyze.Text = "Analyze";
            this.BTN_Analyze.UseVisualStyleBackColor = true;
            this.BTN_Analyze.Click += new System.EventHandler(this.BTN_Analyze_Click);
            // 
            // textBoxAnalyze
            // 
            this.textBoxAnalyze.Location = new System.Drawing.Point(824, 71);
            this.textBoxAnalyze.Name = "textBoxAnalyze";
            this.textBoxAnalyze.Size = new System.Drawing.Size(186, 20);
            this.textBoxAnalyze.TabIndex = 7;
            // 
            // LBL_TEXT_TO_ANALIZE
            // 
            this.LBL_TEXT_TO_ANALIZE.AutoSize = true;
            this.LBL_TEXT_TO_ANALIZE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_TEXT_TO_ANALIZE.Location = new System.Drawing.Point(848, 39);
            this.LBL_TEXT_TO_ANALIZE.Name = "LBL_TEXT_TO_ANALIZE";
            this.LBL_TEXT_TO_ANALIZE.Size = new System.Drawing.Size(132, 20);
            this.LBL_TEXT_TO_ANALIZE.TabIndex = 8;
            this.LBL_TEXT_TO_ANALIZE.Text = "Text to Analyze";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.Location = new System.Drawing.Point(326, 503);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 9;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOutput.Location = new System.Drawing.Point(801, 224);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 16);
            this.labelOutput.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(773, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Correct Input :";
            // 
            // labelCorrectInput
            // 
            this.labelCorrectInput.AutoSize = true;
            this.labelCorrectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCorrectInput.Location = new System.Drawing.Point(876, 184);
            this.labelCorrectInput.Name = "labelCorrectInput";
            this.labelCorrectInput.Size = new System.Drawing.Size(0, 18);
            this.labelCorrectInput.TabIndex = 12;
            // 
            // CompilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1065, 691);
            this.Controls.Add(this.labelCorrectInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.LBL_TEXT_TO_ANALIZE);
            this.Controls.Add(this.textBoxAnalyze);
            this.Controls.Add(this.BTN_Analyze);
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
        private System.Windows.Forms.Button openRule;
        private System.Windows.Forms.Button saveRule;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.Button BTN_Analyze;
        private System.Windows.Forms.TextBox textBoxAnalyze;
        private System.Windows.Forms.Label LBL_TEXT_TO_ANALIZE;
        private System.Windows.Forms.Label labelResult;
        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCorrectInput;
    }
}