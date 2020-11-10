namespace Snake
{
    partial class scoreborad
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.submitBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.highscoreDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(89, 11);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score :";
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.BackColor = System.Drawing.Color.Transparent;
            this.scoreLBL.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreLBL.Location = new System.Drawing.Point(85, 35);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(18, 19);
            this.scoreLBL.TabIndex = 3;
            this.scoreLBL.Text = "0";
            // 
            // submitBTN
            // 
            this.submitBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBTN.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitBTN.Location = new System.Drawing.Point(12, 77);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(75, 23);
            this.submitBTN.TabIndex = 4;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = false;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBTN.Location = new System.Drawing.Point(113, 77);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 23);
            this.clearBTN.TabIndex = 5;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // highscoreDGV
            // 
            this.highscoreDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highscoreDGV.Location = new System.Drawing.Point(12, 146);
            this.highscoreDGV.Name = "highscoreDGV";
            this.highscoreDGV.Size = new System.Drawing.Size(438, 216);
            this.highscoreDGV.TabIndex = 6;
            // 
            // scoreborad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.rsz_nyan_cat_wide_672x372;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 383);
            this.Controls.Add(this.highscoreDGV);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.scoreLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Name = "scoreborad";
            this.Text = "scoreborad";
            this.Load += new System.EventHandler(this.scoreborad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.highscoreDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.DataGridView highscoreDGV;
    }
}