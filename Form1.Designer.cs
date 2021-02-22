namespace Borderlands3MayhemV2
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.cbModifier1 = new System.Windows.Forms.ComboBox();
            this.cbModifier4 = new System.Windows.Forms.ComboBox();
            this.cbModifier3 = new System.Windows.Forms.ComboBox();
            this.cbModifier2 = new System.Windows.Forms.ComboBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnVeryHard = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.lblModifier4 = new System.Windows.Forms.Label();
            this.lblModifier3 = new System.Windows.Forms.Label();
            this.lblModifier2 = new System.Windows.Forms.Label();
            this.lblModifier1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudWait = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbResolution = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWait)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(249, 865);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(238, 58);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start Reroll";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(9, 865);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(238, 58);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOutput.Location = new System.Drawing.Point(9, 433);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.Size = new System.Drawing.Size(478, 422);
            this.rtxtOutput.TabIndex = 12;
            this.rtxtOutput.Text = "";
            // 
            // cbModifier1
            // 
            this.cbModifier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModifier1.FormattingEnabled = true;
            this.cbModifier1.Location = new System.Drawing.Point(136, 112);
            this.cbModifier1.Name = "cbModifier1";
            this.cbModifier1.Size = new System.Drawing.Size(310, 37);
            this.cbModifier1.TabIndex = 2;
            this.cbModifier1.SelectedIndexChanged += new System.EventHandler(this.cbModifier1_SelectedIndexChanged);
            // 
            // cbModifier4
            // 
            this.cbModifier4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModifier4.FormattingEnabled = true;
            this.cbModifier4.Location = new System.Drawing.Point(136, 242);
            this.cbModifier4.Name = "cbModifier4";
            this.cbModifier4.Size = new System.Drawing.Size(310, 37);
            this.cbModifier4.TabIndex = 8;
            this.cbModifier4.SelectedIndexChanged += new System.EventHandler(this.cbModifier4_SelectedIndexChanged);
            // 
            // cbModifier3
            // 
            this.cbModifier3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModifier3.FormattingEnabled = true;
            this.cbModifier3.Location = new System.Drawing.Point(136, 199);
            this.cbModifier3.Name = "cbModifier3";
            this.cbModifier3.Size = new System.Drawing.Size(310, 37);
            this.cbModifier3.TabIndex = 6;
            this.cbModifier3.SelectedIndexChanged += new System.EventHandler(this.cbModifier3_SelectedIndexChanged);
            // 
            // cbModifier2
            // 
            this.cbModifier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModifier2.FormattingEnabled = true;
            this.cbModifier2.Location = new System.Drawing.Point(136, 156);
            this.cbModifier2.Name = "cbModifier2";
            this.cbModifier2.Size = new System.Drawing.Size(310, 37);
            this.cbModifier2.TabIndex = 3;
            this.cbModifier2.SelectedIndexChanged += new System.EventHandler(this.cbModifier2_SelectedIndexChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(12, 401);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(475, 29);
            this.lblOutput.TabIndex = 99;
            this.lblOutput.Text = "Instructions";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(475, 38);
            this.label6.TabIndex = 99;
            this.label6.Text = "Mayhem Modifiers";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEasy
            // 
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(452, 112);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(40, 40);
            this.btnEasy.TabIndex = 3;
            this.btnEasy.Text = "/";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnVeryHard
            // 
            this.btnVeryHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeryHard.Location = new System.Drawing.Point(452, 241);
            this.btnVeryHard.Name = "btnVeryHard";
            this.btnVeryHard.Size = new System.Drawing.Size(40, 40);
            this.btnVeryHard.TabIndex = 9;
            this.btnVeryHard.Text = "/";
            this.btnVeryHard.UseVisualStyleBackColor = true;
            this.btnVeryHard.Click += new System.EventHandler(this.btnVeryHard_Click);
            // 
            // btnHard
            // 
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(452, 198);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(40, 40);
            this.btnHard.TabIndex = 7;
            this.btnHard.Text = "/";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(452, 155);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(40, 40);
            this.btnMedium.TabIndex = 5;
            this.btnMedium.Text = "/";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // lblModifier4
            // 
            this.lblModifier4.AutoSize = true;
            this.lblModifier4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifier4.Location = new System.Drawing.Point(10, 245);
            this.lblModifier4.Name = "lblModifier4";
            this.lblModifier4.Size = new System.Drawing.Size(119, 29);
            this.lblModifier4.TabIndex = 99;
            this.lblModifier4.Text = "Very Hard";
            // 
            // lblModifier3
            // 
            this.lblModifier3.AutoSize = true;
            this.lblModifier3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifier3.Location = new System.Drawing.Point(12, 202);
            this.lblModifier3.Name = "lblModifier3";
            this.lblModifier3.Size = new System.Drawing.Size(65, 29);
            this.lblModifier3.TabIndex = 99;
            this.lblModifier3.Text = "Hard";
            // 
            // lblModifier2
            // 
            this.lblModifier2.AutoSize = true;
            this.lblModifier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifier2.Location = new System.Drawing.Point(12, 159);
            this.lblModifier2.Name = "lblModifier2";
            this.lblModifier2.Size = new System.Drawing.Size(100, 29);
            this.lblModifier2.TabIndex = 99;
            this.lblModifier2.Text = "Medium";
            // 
            // lblModifier1
            // 
            this.lblModifier1.AutoSize = true;
            this.lblModifier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifier1.Location = new System.Drawing.Point(12, 116);
            this.lblModifier1.Name = "lblModifier1";
            this.lblModifier1.Size = new System.Drawing.Size(65, 29);
            this.lblModifier1.TabIndex = 99;
            this.lblModifier1.Text = "Easy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 99;
            this.label1.Text = "Mayhem Level";
            // 
            // nudLevel
            // 
            this.nudLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.Location = new System.Drawing.Point(186, 64);
            this.nudLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(61, 35);
            this.nudLevel.TabIndex = 1;
            this.nudLevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLevel.ValueChanged += new System.EventHandler(this.nudLevel_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 29);
            this.label3.TabIndex = 99;
            this.label3.Text = "Wait after start (seconds)";
            // 
            // nudWait
            // 
            this.nudWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWait.Location = new System.Drawing.Point(426, 299);
            this.nudWait.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudWait.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWait.Name = "nudWait";
            this.nudWait.Size = new System.Drawing.Size(61, 35);
            this.nudWait.TabIndex = 10;
            this.nudWait.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWait.ValueChanged += new System.EventHandler(this.nudWait_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 99;
            this.label4.Text = "Resolution";
            // 
            // cbResolution
            // 
            this.cbResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResolution.FormattingEnabled = true;
            this.cbResolution.Location = new System.Drawing.Point(326, 340);
            this.cbResolution.Name = "cbResolution";
            this.cbResolution.Size = new System.Drawing.Size(161, 37);
            this.cbResolution.TabIndex = 11;
            this.cbResolution.SelectedIndexChanged += new System.EventHandler(this.cbResolution_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 937);
            this.Controls.Add(this.cbResolution);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudWait);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnVeryHard);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblModifier2);
            this.Controls.Add(this.lblModifier3);
            this.Controls.Add(this.lblModifier4);
            this.Controls.Add(this.lblModifier1);
            this.Controls.Add(this.cbModifier2);
            this.Controls.Add(this.cbModifier3);
            this.Controls.Add(this.cbModifier4);
            this.Controls.Add(this.cbModifier1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtxtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Borderlands Modifiers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox rtxtOutput;
        private System.Windows.Forms.ComboBox cbModifier1;
        private System.Windows.Forms.ComboBox cbModifier4;
        private System.Windows.Forms.ComboBox cbModifier3;
        private System.Windows.Forms.ComboBox cbModifier2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnVeryHard;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Label lblModifier4;
        private System.Windows.Forms.Label lblModifier3;
        private System.Windows.Forms.Label lblModifier2;
        private System.Windows.Forms.Label lblModifier1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWait;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbResolution;
    }
}

