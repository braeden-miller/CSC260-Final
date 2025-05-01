namespace Golf_Tournament_Manager
{
    partial class frmGolferStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGolferStats));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGolferList = new System.Windows.Forms.ComboBox();
            this.txtStatsDisplay = new System.Windows.Forms.RichTextBox();
            this.lblHandicapIndex = new System.Windows.Forms.Label();
            this.txtHandicapIndex = new System.Windows.Forms.TextBox();
            this.txtCourseHandicap = new System.Windows.Forms.TextBox();
            this.lblCourseHandicap = new System.Windows.Forms.Label();
            this.txtToPar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTournamentStats = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Golfer:";
            // 
            // cmbGolferList
            // 
            this.cmbGolferList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGolferList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGolferList.FormattingEnabled = true;
            this.cmbGolferList.Location = new System.Drawing.Point(95, 6);
            this.cmbGolferList.Name = "cmbGolferList";
            this.cmbGolferList.Size = new System.Drawing.Size(291, 33);
            this.cmbGolferList.Sorted = true;
            this.cmbGolferList.TabIndex = 1;
            this.cmbGolferList.SelectedIndexChanged += new System.EventHandler(this.cmbGolferList_SelectedIndexChanged);
            // 
            // txtStatsDisplay
            // 
            this.txtStatsDisplay.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatsDisplay.Location = new System.Drawing.Point(12, 91);
            this.txtStatsDisplay.Name = "txtStatsDisplay";
            this.txtStatsDisplay.ReadOnly = true;
            this.txtStatsDisplay.Size = new System.Drawing.Size(1273, 219);
            this.txtStatsDisplay.TabIndex = 2;
            this.txtStatsDisplay.Text = "    Hole     1   2   3   4   5   6   7   8   9   Out  10  11  12  13  14  15  16 " +
    " 17  18   In   Gross   Net   To Par";
            // 
            // lblHandicapIndex
            // 
            this.lblHandicapIndex.AutoSize = true;
            this.lblHandicapIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandicapIndex.Location = new System.Drawing.Point(444, 12);
            this.lblHandicapIndex.Name = "lblHandicapIndex";
            this.lblHandicapIndex.Size = new System.Drawing.Size(110, 25);
            this.lblHandicapIndex.TabIndex = 3;
            this.lblHandicapIndex.Text = "Handicap:";
            // 
            // txtHandicapIndex
            // 
            this.txtHandicapIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHandicapIndex.Location = new System.Drawing.Point(560, 9);
            this.txtHandicapIndex.Name = "txtHandicapIndex";
            this.txtHandicapIndex.ReadOnly = true;
            this.txtHandicapIndex.Size = new System.Drawing.Size(85, 30);
            this.txtHandicapIndex.TabIndex = 4;
            this.txtHandicapIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCourseHandicap
            // 
            this.txtCourseHandicap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseHandicap.Location = new System.Drawing.Point(797, 9);
            this.txtCourseHandicap.Name = "txtCourseHandicap";
            this.txtCourseHandicap.ReadOnly = true;
            this.txtCourseHandicap.Size = new System.Drawing.Size(84, 30);
            this.txtCourseHandicap.TabIndex = 6;
            this.txtCourseHandicap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCourseHandicap
            // 
            this.lblCourseHandicap.AutoSize = true;
            this.lblCourseHandicap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseHandicap.Location = new System.Drawing.Point(651, 12);
            this.lblCourseHandicap.Name = "lblCourseHandicap";
            this.lblCourseHandicap.Size = new System.Drawing.Size(140, 25);
            this.lblCourseHandicap.TabIndex = 5;
            this.lblCourseHandicap.Text = "Course HCP:";
            // 
            // txtToPar
            // 
            this.txtToPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToPar.Location = new System.Drawing.Point(977, 9);
            this.txtToPar.Name = "txtToPar";
            this.txtToPar.ReadOnly = true;
            this.txtToPar.Size = new System.Drawing.Size(84, 30);
            this.txtToPar.TabIndex = 8;
            this.txtToPar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(887, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "To Par:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1159, 315);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 32);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "View Tournament Statistics: ";
            // 
            // chkTournamentStats
            // 
            this.chkTournamentStats.AutoSize = true;
            this.chkTournamentStats.Location = new System.Drawing.Point(329, 56);
            this.chkTournamentStats.Name = "chkTournamentStats";
            this.chkTournamentStats.Size = new System.Drawing.Size(18, 17);
            this.chkTournamentStats.TabIndex = 25;
            this.chkTournamentStats.UseVisualStyleBackColor = true;
            this.chkTournamentStats.CheckedChanged += new System.EventHandler(this.chkTournamentStats_CheckedChanged);
            // 
            // frmGolferStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 355);
            this.Controls.Add(this.chkTournamentStats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtToPar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCourseHandicap);
            this.Controls.Add(this.lblCourseHandicap);
            this.Controls.Add(this.txtHandicapIndex);
            this.Controls.Add(this.lblHandicapIndex);
            this.Controls.Add(this.txtStatsDisplay);
            this.Controls.Add(this.cmbGolferList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGolferStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Golfer Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGolferList;
        private System.Windows.Forms.RichTextBox txtStatsDisplay;
        private System.Windows.Forms.Label lblHandicapIndex;
        private System.Windows.Forms.TextBox txtHandicapIndex;
        private System.Windows.Forms.TextBox txtCourseHandicap;
        private System.Windows.Forms.Label lblCourseHandicap;
        private System.Windows.Forms.TextBox txtToPar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTournamentStats;
    }
}