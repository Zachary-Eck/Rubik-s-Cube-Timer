namespace Rubik_s_Cube_Timer
{
    partial class FrmRubiksCubeTimer
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
            this.LblTimer = new System.Windows.Forms.Label();
            this.BtnStartStop = new System.Windows.Forms.Button();
            this.LstBoxHistory = new System.Windows.Forms.ListBox();
            this.LblHistoryListBox = new System.Windows.Forms.Label();
            this.BtnDeleteSelected = new System.Windows.Forms.Button();
            this.LblScrambleAlg = new System.Windows.Forms.Label();
            this.LblAverage = new System.Windows.Forms.Label();
            this.LblScrambler = new System.Windows.Forms.Label();
            this.BtnNewScramble = new System.Windows.Forms.Button();
            this.BtnLockScramble = new System.Windows.Forms.Button();
            this.NudScrambleLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NudScrambleLength)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTimer
            // 
            this.LblTimer.Font = new System.Drawing.Font("MS Gothic", 128.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimer.Location = new System.Drawing.Point(300, 50);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(800, 200);
            this.LblTimer.TabIndex = 0;
            this.LblTimer.Text = "00:00.00";
            this.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnStartStop
            // 
            this.BtnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartStop.Location = new System.Drawing.Point(300, 256);
            this.BtnStartStop.Name = "BtnStartStop";
            this.BtnStartStop.Size = new System.Drawing.Size(800, 68);
            this.BtnStartStop.TabIndex = 1;
            this.BtnStartStop.Text = "Start/Stop";
            this.BtnStartStop.UseVisualStyleBackColor = true;
            this.BtnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // LstBoxHistory
            // 
            this.LstBoxHistory.FormattingEnabled = true;
            this.LstBoxHistory.Items.AddRange(new object[] {
            "(none)"});
            this.LstBoxHistory.Location = new System.Drawing.Point(12, 51);
            this.LstBoxHistory.Name = "LstBoxHistory";
            this.LstBoxHistory.ScrollAlwaysVisible = true;
            this.LstBoxHistory.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstBoxHistory.Size = new System.Drawing.Size(275, 199);
            this.LstBoxHistory.TabIndex = 2;
            // 
            // LblHistoryListBox
            // 
            this.LblHistoryListBox.AutoSize = true;
            this.LblHistoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHistoryListBox.Location = new System.Drawing.Point(13, 13);
            this.LblHistoryListBox.Name = "LblHistoryListBox";
            this.LblHistoryListBox.Size = new System.Drawing.Size(160, 25);
            this.LblHistoryListBox.TabIndex = 3;
            this.LblHistoryListBox.Text = "Previous Times";
            // 
            // BtnDeleteSelected
            // 
            this.BtnDeleteSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteSelected.Location = new System.Drawing.Point(12, 256);
            this.BtnDeleteSelected.Name = "BtnDeleteSelected";
            this.BtnDeleteSelected.Size = new System.Drawing.Size(130, 30);
            this.BtnDeleteSelected.TabIndex = 5;
            this.BtnDeleteSelected.Text = "Delete Selected";
            this.BtnDeleteSelected.UseVisualStyleBackColor = true;
            this.BtnDeleteSelected.Click += new System.EventHandler(this.BtnDeleteSelected_Click);
            // 
            // LblScrambleAlg
            // 
            this.LblScrambleAlg.AutoSize = true;
            this.LblScrambleAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScrambleAlg.Location = new System.Drawing.Point(1106, 13);
            this.LblScrambleAlg.Name = "LblScrambleAlg";
            this.LblScrambleAlg.Size = new System.Drawing.Size(198, 25);
            this.LblScrambleAlg.TabIndex = 6;
            this.LblScrambleAlg.Text = "Scramble Algorithm";
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAverage.Location = new System.Drawing.Point(12, 299);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(176, 25);
            this.LblAverage.TabIndex = 7;
            this.LblAverage.Text = "Average: 0:00.00";
            // 
            // LblScrambler
            // 
            this.LblScrambler.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScrambler.Location = new System.Drawing.Point(1106, 50);
            this.LblScrambler.Name = "LblScrambler";
            this.LblScrambler.Size = new System.Drawing.Size(265, 199);
            this.LblScrambler.TabIndex = 8;
            // 
            // BtnNewScramble
            // 
            this.BtnNewScramble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewScramble.Location = new System.Drawing.Point(1110, 256);
            this.BtnNewScramble.Name = "BtnNewScramble";
            this.BtnNewScramble.Size = new System.Drawing.Size(125, 30);
            this.BtnNewScramble.TabIndex = 9;
            this.BtnNewScramble.Text = "New Scramble";
            this.BtnNewScramble.UseVisualStyleBackColor = true;
            this.BtnNewScramble.Click += new System.EventHandler(this.BtnNewScramble_Click);
            // 
            // BtnLockScramble
            // 
            this.BtnLockScramble.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnLockScramble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLockScramble.Location = new System.Drawing.Point(1246, 256);
            this.BtnLockScramble.Name = "BtnLockScramble";
            this.BtnLockScramble.Size = new System.Drawing.Size(125, 30);
            this.BtnLockScramble.TabIndex = 10;
            this.BtnLockScramble.Text = "Lock";
            this.BtnLockScramble.UseVisualStyleBackColor = true;
            this.BtnLockScramble.Click += new System.EventHandler(this.BtnLockScramble_Click);
            // 
            // NudScrambleLength
            // 
            this.NudScrambleLength.Location = new System.Drawing.Point(1310, 18);
            this.NudScrambleLength.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.NudScrambleLength.Name = "NudScrambleLength";
            this.NudScrambleLength.Size = new System.Drawing.Size(62, 20);
            this.NudScrambleLength.TabIndex = 12;
            this.NudScrambleLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudScrambleLength.ValueChanged += new System.EventHandler(this.NudScrambleLength_ValueChanged);
            // 
            // FrmRubiksCubeTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 336);
            this.Controls.Add(this.NudScrambleLength);
            this.Controls.Add(this.BtnLockScramble);
            this.Controls.Add(this.BtnNewScramble);
            this.Controls.Add(this.LblScrambler);
            this.Controls.Add(this.LblAverage);
            this.Controls.Add(this.LblScrambleAlg);
            this.Controls.Add(this.BtnDeleteSelected);
            this.Controls.Add(this.LblHistoryListBox);
            this.Controls.Add(this.LstBoxHistory);
            this.Controls.Add(this.BtnStartStop);
            this.Controls.Add(this.LblTimer);
            this.Name = "FrmRubiksCubeTimer";
            this.Text = "Rubik\'s Cube Timer";
            ((System.ComponentModel.ISupportInitialize)(this.NudScrambleLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Button BtnStartStop;
        private System.Windows.Forms.ListBox LstBoxHistory;
        private System.Windows.Forms.Label LblHistoryListBox;
        private System.Windows.Forms.Button BtnDeleteSelected;
        private System.Windows.Forms.Label LblScrambleAlg;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.Label LblScrambler;
        private System.Windows.Forms.Button BtnNewScramble;
        private System.Windows.Forms.Button BtnLockScramble;
        private System.Windows.Forms.NumericUpDown NudScrambleLength;
    }
}

