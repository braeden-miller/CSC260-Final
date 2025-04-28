namespace Golf_Tournament_Manager
{
    partial class frmEnterScore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnterScore));
            this.tblHoleScores = new System.Windows.Forms.DataGridView();
            this.HoleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolePar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoleScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCourseHandicap = new System.Windows.Forms.Label();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGolferName = new System.Windows.Forms.TextBox();
            this.txtHandicapIndex = new System.Windows.Forms.TextBox();
            this.numHoleScore = new System.Windows.Forms.NumericUpDown();
            this.txtFrontNine = new System.Windows.Forms.TextBox();
            this.txtBackNine = new System.Windows.Forms.TextBox();
            this.txtGrossTotal = new System.Windows.Forms.TextBox();
            this.txtCourseHandicap = new System.Windows.Forms.TextBox();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoleScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoleScore)).BeginInit();
            this.SuspendLayout();
            // 
            // tblHoleScores
            // 
            this.tblHoleScores.AllowUserToAddRows = false;
            this.tblHoleScores.AllowUserToDeleteRows = false;
            this.tblHoleScores.AllowUserToResizeColumns = false;
            this.tblHoleScores.AllowUserToResizeRows = false;
            this.tblHoleScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblHoleScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblHoleScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblHoleScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoleNumber,
            this.HolePar,
            this.HoleScore});
            this.tblHoleScores.Location = new System.Drawing.Point(12, 12);
            this.tblHoleScores.MultiSelect = false;
            this.tblHoleScores.Name = "tblHoleScores";
            this.tblHoleScores.ReadOnly = true;
            this.tblHoleScores.RowHeadersVisible = false;
            this.tblHoleScores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblHoleScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblHoleScores.Size = new System.Drawing.Size(192, 289);
            this.tblHoleScores.TabIndex = 0;
            this.tblHoleScores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblHoleScores_CellClick);
            // 
            // HoleNumber
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoleNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.HoleNumber.HeaderText = "Hole";
            this.HoleNumber.Name = "HoleNumber";
            this.HoleNumber.ReadOnly = true;
            this.HoleNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HoleNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HolePar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolePar.DefaultCellStyle = dataGridViewCellStyle3;
            this.HolePar.HeaderText = "Par";
            this.HolePar.Name = "HolePar";
            this.HolePar.ReadOnly = true;
            this.HolePar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HolePar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HoleScore
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoleScore.DefaultCellStyle = dataGridViewCellStyle4;
            this.HoleScore.HeaderText = "Score";
            this.HoleScore.Name = "HoleScore";
            this.HoleScore.ReadOnly = true;
            this.HoleScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HoleScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Golfer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Handicap:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Front";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Back";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gross";
            // 
            // lblCourseHandicap
            // 
            this.lblCourseHandicap.AutoSize = true;
            this.lblCourseHandicap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseHandicap.Location = new System.Drawing.Point(492, 184);
            this.lblCourseHandicap.Name = "lblCourseHandicap";
            this.lblCourseHandicap.Size = new System.Drawing.Size(107, 20);
            this.lblCourseHandicap.TabIndex = 6;
            this.lblCourseHandicap.Text = "Course HCP";
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetTotal.Location = new System.Drawing.Point(628, 184);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(37, 20);
            this.lblNetTotal.TabIndex = 7;
            this.lblNetTotal.Text = "Net";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(247, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hole Score:";
            // 
            // txtGolferName
            // 
            this.txtGolferName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGolferName.Location = new System.Drawing.Point(356, 25);
            this.txtGolferName.Name = "txtGolferName";
            this.txtGolferName.ReadOnly = true;
            this.txtGolferName.Size = new System.Drawing.Size(309, 26);
            this.txtGolferName.TabIndex = 9;
            // 
            // txtHandicapIndex
            // 
            this.txtHandicapIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHandicapIndex.Location = new System.Drawing.Point(356, 77);
            this.txtHandicapIndex.Name = "txtHandicapIndex";
            this.txtHandicapIndex.ReadOnly = true;
            this.txtHandicapIndex.Size = new System.Drawing.Size(53, 26);
            this.txtHandicapIndex.TabIndex = 10;
            this.txtHandicapIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numHoleScore
            // 
            this.numHoleScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHoleScore.Location = new System.Drawing.Point(356, 129);
            this.numHoleScore.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numHoleScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHoleScore.Name = "numHoleScore";
            this.numHoleScore.Size = new System.Drawing.Size(53, 26);
            this.numHoleScore.TabIndex = 11;
            this.numHoleScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHoleScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHoleScore.ValueChanged += new System.EventHandler(this.numHoleScore_ValueChanged);
            // 
            // txtFrontNine
            // 
            this.txtFrontNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrontNine.Location = new System.Drawing.Point(251, 207);
            this.txtFrontNine.Name = "txtFrontNine";
            this.txtFrontNine.ReadOnly = true;
            this.txtFrontNine.Size = new System.Drawing.Size(48, 26);
            this.txtFrontNine.TabIndex = 12;
            this.txtFrontNine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBackNine
            // 
            this.txtBackNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackNine.Location = new System.Drawing.Point(335, 207);
            this.txtBackNine.Name = "txtBackNine";
            this.txtBackNine.ReadOnly = true;
            this.txtBackNine.Size = new System.Drawing.Size(48, 26);
            this.txtBackNine.TabIndex = 13;
            this.txtBackNine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrossTotal
            // 
            this.txtGrossTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossTotal.Location = new System.Drawing.Point(425, 207);
            this.txtGrossTotal.Name = "txtGrossTotal";
            this.txtGrossTotal.ReadOnly = true;
            this.txtGrossTotal.Size = new System.Drawing.Size(48, 26);
            this.txtGrossTotal.TabIndex = 14;
            this.txtGrossTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCourseHandicap
            // 
            this.txtCourseHandicap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseHandicap.Location = new System.Drawing.Point(524, 207);
            this.txtCourseHandicap.Name = "txtCourseHandicap";
            this.txtCourseHandicap.ReadOnly = true;
            this.txtCourseHandicap.Size = new System.Drawing.Size(48, 26);
            this.txtCourseHandicap.TabIndex = 15;
            this.txtCourseHandicap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetTotal.Location = new System.Drawing.Point(623, 207);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.ReadOnly = true;
            this.txtNetTotal.Size = new System.Drawing.Size(48, 26);
            this.txtNetTotal.TabIndex = 16;
            this.txtNetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(574, 269);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 32);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(437, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 32);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEnterScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 314);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNetTotal);
            this.Controls.Add(this.txtCourseHandicap);
            this.Controls.Add(this.txtGrossTotal);
            this.Controls.Add(this.txtBackNine);
            this.Controls.Add(this.txtFrontNine);
            this.Controls.Add(this.numHoleScore);
            this.Controls.Add(this.txtHandicapIndex);
            this.Controls.Add(this.txtGolferName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNetTotal);
            this.Controls.Add(this.lblCourseHandicap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblHoleScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnterScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Scores";
            this.Load += new System.EventHandler(this.frmEnterScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHoleScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoleScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblHoleScores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCourseHandicap;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGolferName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn HolePar;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoleScore;
        private System.Windows.Forms.TextBox txtHandicapIndex;
        private System.Windows.Forms.NumericUpDown numHoleScore;
        private System.Windows.Forms.TextBox txtFrontNine;
        private System.Windows.Forms.TextBox txtBackNine;
        private System.Windows.Forms.TextBox txtGrossTotal;
        private System.Windows.Forms.TextBox txtCourseHandicap;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}