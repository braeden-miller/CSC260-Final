﻿namespace Golf_Tournament_Manager
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tblLeaderboard = new System.Windows.Forms.DataGridView();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetToPar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditTournament = new System.Windows.Forms.Button();
            this.txtEventRounds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTeesPlayed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCourseRating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCourseLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.txtCoursePar = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddGolfer = new System.Windows.Forms.Button();
            this.cmbGolferList = new System.Windows.Forms.ComboBox();
            this.btnEditGolfer = new System.Windows.Forms.Button();
            this.btnDeleteGolfer = new System.Windows.Forms.Button();
            this.btnCreateScorecard = new System.Windows.Forms.Button();
            this.cmbRoundList = new System.Windows.Forms.ComboBox();
            this.btnEditScorecard = new System.Windows.Forms.Button();
            this.btnDeleteScorecard = new System.Windows.Forms.Button();
            this.btnPlayerStats = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblLeaderboard)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLeaderboard
            // 
            this.tblLeaderboard.AllowUserToAddRows = false;
            this.tblLeaderboard.AllowUserToDeleteRows = false;
            this.tblLeaderboard.AllowUserToResizeColumns = false;
            this.tblLeaderboard.AllowUserToResizeRows = false;
            this.tblLeaderboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblLeaderboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLeaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.PlayerName,
            this.NetToPar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblLeaderboard.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblLeaderboard.Location = new System.Drawing.Point(639, 70);
            this.tblLeaderboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblLeaderboard.Name = "tblLeaderboard";
            this.tblLeaderboard.ReadOnly = true;
            this.tblLeaderboard.RowHeadersVisible = false;
            this.tblLeaderboard.RowHeadersWidth = 51;
            this.tblLeaderboard.RowTemplate.Height = 24;
            this.tblLeaderboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblLeaderboard.Size = new System.Drawing.Size(405, 632);
            this.tblLeaderboard.TabIndex = 0;
            // 
            // Place
            // 
            this.Place.FillWeight = 75F;
            this.Place.HeaderText = "Place";
            this.Place.MinimumWidth = 6;
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Place.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PlayerName
            // 
            this.PlayerName.FillWeight = 200F;
            this.PlayerName.HeaderText = "Player";
            this.PlayerName.MinimumWidth = 6;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PlayerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NetToPar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NetToPar.DefaultCellStyle = dataGridViewCellStyle2;
            this.NetToPar.FillWeight = 75F;
            this.NetToPar.HeaderText = "Net +/-";
            this.NetToPar.MinimumWidth = 6;
            this.NetToPar.Name = "NetToPar";
            this.NetToPar.ReadOnly = true;
            this.NetToPar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NetToPar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditTournament);
            this.groupBox1.Controls.Add(this.txtEventRounds);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEventDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEventName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(611, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tournament Information";
            // 
            // btnEditTournament
            // 
            this.btnEditTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTournament.Location = new System.Drawing.Point(376, 182);
            this.btnEditTournament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditTournament.Name = "btnEditTournament";
            this.btnEditTournament.Size = new System.Drawing.Size(228, 32);
            this.btnEditTournament.TabIndex = 6;
            this.btnEditTournament.Text = "Edit Tournament Information";
            this.btnEditTournament.UseVisualStyleBackColor = true;
            this.btnEditTournament.Click += new System.EventHandler(this.btnEditTournament_Click);
            // 
            // txtEventRounds
            // 
            this.txtEventRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventRounds.Location = new System.Drawing.Point(485, 118);
            this.txtEventRounds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEventRounds.Name = "txtEventRounds";
            this.txtEventRounds.ReadOnly = true;
            this.txtEventRounds.Size = new System.Drawing.Size(39, 38);
            this.txtEventRounds.TabIndex = 5;
            this.txtEventRounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rounds";
            // 
            // txtEventDate
            // 
            this.txtEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDate.Location = new System.Drawing.Point(5, 118);
            this.txtEventDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.ReadOnly = true;
            this.txtEventDate.Size = new System.Drawing.Size(359, 38);
            this.txtEventDate.TabIndex = 3;
            this.txtEventDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dates";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(148, 30);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(436, 38);
            this.txtEventName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTeesPlayed);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCourseRating);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCourseLocation);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnEditCourse);
            this.groupBox2.Controls.Add(this.txtCoursePar);
            this.groupBox2.Controls.Add(this.txtCourseName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(611, 220);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(217, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tees:";
            // 
            // txtTeesPlayed
            // 
            this.txtTeesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeesPlayed.Location = new System.Drawing.Point(291, 123);
            this.txtTeesPlayed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTeesPlayed.Name = "txtTeesPlayed";
            this.txtTeesPlayed.ReadOnly = true;
            this.txtTeesPlayed.Size = new System.Drawing.Size(87, 30);
            this.txtTeesPlayed.TabIndex = 12;
            this.txtTeesPlayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rating:";
            // 
            // txtCourseRating
            // 
            this.txtCourseRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseRating.Location = new System.Drawing.Point(469, 123);
            this.txtCourseRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCourseRating.Name = "txtCourseRating";
            this.txtCourseRating.ReadOnly = true;
            this.txtCourseRating.Size = new System.Drawing.Size(115, 30);
            this.txtCourseRating.TabIndex = 10;
            this.txtCourseRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Par:";
            // 
            // txtCourseLocation
            // 
            this.txtCourseLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseLocation.Location = new System.Drawing.Point(163, 73);
            this.txtCourseLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCourseLocation.Name = "txtCourseLocation";
            this.txtCourseLocation.ReadOnly = true;
            this.txtCourseLocation.Size = new System.Drawing.Size(421, 38);
            this.txtCourseLocation.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Location:";
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCourse.Location = new System.Drawing.Point(376, 182);
            this.btnEditCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(228, 32);
            this.btnEditCourse.TabIndex = 6;
            this.btnEditCourse.Text = "Edit Course Information";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // txtCoursePar
            // 
            this.txtCoursePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoursePar.Location = new System.Drawing.Point(163, 123);
            this.txtCoursePar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCoursePar.Name = "txtCoursePar";
            this.txtCoursePar.ReadOnly = true;
            this.txtCoursePar.Size = new System.Drawing.Size(48, 30);
            this.txtCoursePar.TabIndex = 5;
            this.txtCoursePar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(163, 30);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(421, 38);
            this.txtCourseName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Course Name:";
            // 
            // btnAddGolfer
            // 
            this.btnAddGolfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGolfer.Location = new System.Drawing.Point(321, 88);
            this.btnAddGolfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddGolfer.Name = "btnAddGolfer";
            this.btnAddGolfer.Size = new System.Drawing.Size(228, 32);
            this.btnAddGolfer.TabIndex = 14;
            this.btnAddGolfer.Text = "Add Golfer";
            this.btnAddGolfer.UseVisualStyleBackColor = true;
            this.btnAddGolfer.Click += new System.EventHandler(this.btnAddGolfer_Click);
            // 
            // cmbGolferList
            // 
            this.cmbGolferList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGolferList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGolferList.FormattingEnabled = true;
            this.cmbGolferList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbGolferList.Location = new System.Drawing.Point(321, 49);
            this.cmbGolferList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGolferList.MaxDropDownItems = 100;
            this.cmbGolferList.Name = "cmbGolferList";
            this.cmbGolferList.Size = new System.Drawing.Size(225, 33);
            this.cmbGolferList.Sorted = true;
            this.cmbGolferList.TabIndex = 15;
            this.cmbGolferList.SelectedIndexChanged += new System.EventHandler(this.cmbGolferList_SelectedIndexChanged);
            // 
            // btnEditGolfer
            // 
            this.btnEditGolfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGolfer.Location = new System.Drawing.Point(321, 125);
            this.btnEditGolfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditGolfer.Name = "btnEditGolfer";
            this.btnEditGolfer.Size = new System.Drawing.Size(228, 32);
            this.btnEditGolfer.TabIndex = 16;
            this.btnEditGolfer.Text = "Edit Golfer";
            this.btnEditGolfer.UseVisualStyleBackColor = true;
            this.btnEditGolfer.Click += new System.EventHandler(this.btnEditGolfer_Click);
            // 
            // btnDeleteGolfer
            // 
            this.btnDeleteGolfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGolfer.Location = new System.Drawing.Point(321, 162);
            this.btnDeleteGolfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteGolfer.Name = "btnDeleteGolfer";
            this.btnDeleteGolfer.Size = new System.Drawing.Size(228, 32);
            this.btnDeleteGolfer.TabIndex = 17;
            this.btnDeleteGolfer.Text = "Delete Golfer";
            this.btnDeleteGolfer.UseVisualStyleBackColor = true;
            this.btnDeleteGolfer.Click += new System.EventHandler(this.btnDeleteGolfer_Click);
            // 
            // btnCreateScorecard
            // 
            this.btnCreateScorecard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateScorecard.Location = new System.Drawing.Point(57, 88);
            this.btnCreateScorecard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateScorecard.Name = "btnCreateScorecard";
            this.btnCreateScorecard.Size = new System.Drawing.Size(228, 32);
            this.btnCreateScorecard.TabIndex = 18;
            this.btnCreateScorecard.Text = "Create Scorecard";
            this.btnCreateScorecard.UseVisualStyleBackColor = true;
            this.btnCreateScorecard.Click += new System.EventHandler(this.btnCreateScorecard_Click);
            // 
            // cmbRoundList
            // 
            this.cmbRoundList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoundList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoundList.FormattingEnabled = true;
            this.cmbRoundList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbRoundList.Location = new System.Drawing.Point(60, 49);
            this.cmbRoundList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoundList.MaxDropDownItems = 100;
            this.cmbRoundList.Name = "cmbRoundList";
            this.cmbRoundList.Size = new System.Drawing.Size(225, 33);
            this.cmbRoundList.Sorted = true;
            this.cmbRoundList.TabIndex = 19;
            // 
            // btnEditScorecard
            // 
            this.btnEditScorecard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditScorecard.Location = new System.Drawing.Point(57, 125);
            this.btnEditScorecard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditScorecard.Name = "btnEditScorecard";
            this.btnEditScorecard.Size = new System.Drawing.Size(228, 32);
            this.btnEditScorecard.TabIndex = 20;
            this.btnEditScorecard.Text = "Edit Scorecard";
            this.btnEditScorecard.UseVisualStyleBackColor = true;
            this.btnEditScorecard.Click += new System.EventHandler(this.btnEditScorecard_Click);
            // 
            // btnDeleteScorecard
            // 
            this.btnDeleteScorecard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteScorecard.Location = new System.Drawing.Point(57, 162);
            this.btnDeleteScorecard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteScorecard.Name = "btnDeleteScorecard";
            this.btnDeleteScorecard.Size = new System.Drawing.Size(228, 32);
            this.btnDeleteScorecard.TabIndex = 21;
            this.btnDeleteScorecard.Text = "Delete Scorecard";
            this.btnDeleteScorecard.UseVisualStyleBackColor = true;
            this.btnDeleteScorecard.Click += new System.EventHandler(this.btnDeleteScorecard_Click);
            // 
            // btnPlayerStats
            // 
            this.btnPlayerStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerStats.Location = new System.Drawing.Point(728, 24);
            this.btnPlayerStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayerStats.Name = "btnPlayerStats";
            this.btnPlayerStats.Size = new System.Drawing.Size(228, 32);
            this.btnPlayerStats.TabIndex = 22;
            this.btnPlayerStats.Text = "View Statistics";
            this.btnPlayerStats.UseVisualStyleBackColor = true;
            this.btnPlayerStats.Click += new System.EventHandler(this.btnPlayerStats_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditScorecard);
            this.groupBox3.Controls.Add(this.btnDeleteScorecard);
            this.groupBox3.Controls.Add(this.cmbRoundList);
            this.groupBox3.Controls.Add(this.btnAddGolfer);
            this.groupBox3.Controls.Add(this.btnCreateScorecard);
            this.groupBox3.Controls.Add(this.btnEditGolfer);
            this.groupBox3.Controls.Add(this.cmbGolferList);
            this.groupBox3.Controls.Add(this.btnDeleteGolfer);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 530);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(611, 220);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manage Golfers and Scores";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(728, 716);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 32);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 808);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPlayerStats);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblLeaderboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Golf Tournament Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLeaderboard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblLeaderboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventRounds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditTournament;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.TextBox txtCoursePar;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCourseLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTeesPlayed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCourseRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddGolfer;
        private System.Windows.Forms.ComboBox cmbGolferList;
        private System.Windows.Forms.Button btnEditGolfer;
        private System.Windows.Forms.Button btnDeleteGolfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetToPar;
        private System.Windows.Forms.Button btnCreateScorecard;
        private System.Windows.Forms.ComboBox cmbRoundList;
        private System.Windows.Forms.Button btnEditScorecard;
        private System.Windows.Forms.Button btnDeleteScorecard;
        private System.Windows.Forms.Button btnPlayerStats;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
    }
}

