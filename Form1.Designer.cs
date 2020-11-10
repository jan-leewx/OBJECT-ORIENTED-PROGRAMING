namespace Snake
{
    partial class Form1
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
            this.boardPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.levelLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.pauseBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.modeLBL = new System.Windows.Forms.Label();
            this.timerLBL = new System.Windows.Forms.Label();
            this.upBTN = new System.Windows.Forms.Button();
            this.leftBTN = new System.Windows.Forms.Button();
            this.downBTN = new System.Windows.Forms.Button();
            this.rightBTN = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.BackgroundImage = global::Snake.Properties.Resources.background_scene___nyan_cat_background;
            this.boardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boardPanel.Location = new System.Drawing.Point(0, 1);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(312, 173);
            this.boardPanel.TabIndex = 19;
            this.boardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPanel_Paint);
            // 
            // controlPanel
            // 
            this.controlPanel.BackgroundImage = global::Snake.Properties.Resources._3016000000107020_large;
            this.controlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.controlPanel.Controls.Add(this.Exitbtn);
            this.controlPanel.Controls.Add(this.button4);
            this.controlPanel.Controls.Add(this.button3);
            this.controlPanel.Controls.Add(this.button2);
            this.controlPanel.Controls.Add(this.button1);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.levelLBL);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.scoreLBL);
            this.controlPanel.Controls.Add(this.pauseBTN);
            this.controlPanel.Controls.Add(this.startBTN);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.modeLBL);
            this.controlPanel.Controls.Add(this.timerLBL);
            this.controlPanel.Controls.Add(this.upBTN);
            this.controlPanel.Controls.Add(this.leftBTN);
            this.controlPanel.Controls.Add(this.downBTN);
            this.controlPanel.Controls.Add(this.rightBTN);
            this.controlPanel.Location = new System.Drawing.Point(11, 376);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(708, 171);
            this.controlPanel.TabIndex = 18;
            this.controlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.controlPanel_Paint);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exitbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exitbtn.Location = new System.Drawing.Point(607, 104);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 32;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(344, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 26);
            this.button4.TabIndex = 31;
            this.button4.Text = "◢";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(236, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 26);
            this.button3.TabIndex = 30;
            this.button3.Text = "◣";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(236, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 26);
            this.button2.TabIndex = 29;
            this.button2.Text = "◤";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(343, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 26);
            this.button1.TabIndex = 28;
            this.button1.Text = "◥";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Level :";
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.BackColor = System.Drawing.Color.Transparent;
            this.levelLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelLBL.Location = new System.Drawing.Point(72, 12);
            this.levelLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(17, 18);
            this.levelLBL.TabIndex = 26;
            this.levelLBL.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Score :";
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.BackColor = System.Drawing.Color.Transparent;
            this.scoreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreLBL.Location = new System.Drawing.Point(72, 35);
            this.scoreLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(17, 18);
            this.scoreLBL.TabIndex = 24;
            this.scoreLBL.Text = "0";
            // 
            // pauseBTN
            // 
            this.pauseBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pauseBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.pauseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pauseBTN.Location = new System.Drawing.Point(607, 76);
            this.pauseBTN.Name = "pauseBTN";
            this.pauseBTN.Size = new System.Drawing.Size(75, 23);
            this.pauseBTN.TabIndex = 23;
            this.pauseBTN.Text = "Pause";
            this.pauseBTN.UseVisualStyleBackColor = false;
            this.pauseBTN.Click += new System.EventHandler(this.pauseBTN_Click);
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startBTN.Location = new System.Drawing.Point(607, 47);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(75, 23);
            this.startBTN.TabIndex = 22;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Timer :";
            // 
            // modeLBL
            // 
            this.modeLBL.AutoSize = true;
            this.modeLBL.BackColor = System.Drawing.Color.Transparent;
            this.modeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.modeLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modeLBL.Location = new System.Drawing.Point(266, 86);
            this.modeLBL.Name = "modeLBL";
            this.modeLBL.Size = new System.Drawing.Size(59, 13);
            this.modeLBL.TabIndex = 6;
            this.modeLBL.Text = "modeLBL";
            this.modeLBL.Click += new System.EventHandler(this.modeLBL_Click);
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.BackColor = System.Drawing.Color.Transparent;
            this.timerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timerLBL.Location = new System.Drawing.Point(72, 129);
            this.timerLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(17, 18);
            this.timerLBL.TabIndex = 20;
            this.timerLBL.Text = "0";
            // 
            // upBTN
            // 
            this.upBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.upBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.upBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.upBTN.Location = new System.Drawing.Point(290, 42);
            this.upBTN.Margin = new System.Windows.Forms.Padding(2);
            this.upBTN.Name = "upBTN";
            this.upBTN.Size = new System.Drawing.Size(26, 25);
            this.upBTN.TabIndex = 4;
            this.upBTN.Text = "▲";
            this.upBTN.UseVisualStyleBackColor = false;
            this.upBTN.Click += new System.EventHandler(this.upBTN_Click);
            // 
            // leftBTN
            // 
            this.leftBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.leftBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.leftBTN.Location = new System.Drawing.Point(235, 78);
            this.leftBTN.Margin = new System.Windows.Forms.Padding(2);
            this.leftBTN.Name = "leftBTN";
            this.leftBTN.Size = new System.Drawing.Size(26, 26);
            this.leftBTN.TabIndex = 1;
            this.leftBTN.Text = "◀";
            this.leftBTN.UseVisualStyleBackColor = false;
            this.leftBTN.Click += new System.EventHandler(this.leftBTN_Click);
            // 
            // downBTN
            // 
            this.downBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.downBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.downBTN.Location = new System.Drawing.Point(290, 112);
            this.downBTN.Margin = new System.Windows.Forms.Padding(2);
            this.downBTN.Name = "downBTN";
            this.downBTN.Size = new System.Drawing.Size(26, 26);
            this.downBTN.TabIndex = 3;
            this.downBTN.Text = "▼";
            this.downBTN.UseVisualStyleBackColor = false;
            this.downBTN.Click += new System.EventHandler(this.downBTN_Click);
            // 
            // rightBTN
            // 
            this.rightBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rightBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rightBTN.Location = new System.Drawing.Point(343, 78);
            this.rightBTN.Margin = new System.Windows.Forms.Padding(2);
            this.rightBTN.Name = "rightBTN";
            this.rightBTN.Size = new System.Drawing.Size(26, 26);
            this.rightBTN.TabIndex = 5;
            this.rightBTN.Text = "▶";
            this.rightBTN.UseVisualStyleBackColor = false;
            this.rightBTN.Click += new System.EventHandler(this.rightBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.background_scene___nyan_cat_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 545);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.controlPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button leftBTN;
        private System.Windows.Forms.Button downBTN;
        private System.Windows.Forms.Button upBTN;
        private System.Windows.Forms.Button rightBTN;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label modeLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Button pauseBTN;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exitbtn;
    }
}

