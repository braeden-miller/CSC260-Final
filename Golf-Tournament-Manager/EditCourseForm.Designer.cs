namespace Golf_Tournament_Manager
{
    partial class frmEditCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCourse));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseLocation = new System.Windows.Forms.TextBox();
            this.txtCourseRating = new System.Windows.Forms.TextBox();
            this.numSlopeRating = new System.Windows.Forms.NumericUpDown();
            this.numHolePar = new System.Windows.Forms.NumericUpDown();
            this.dataHolePars = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTees = new System.Windows.Forms.TextBox();
            this.Hole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Par = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numSlopeRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHolePar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHolePars)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Rating:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Slope Rating:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hole Par:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(337, 12);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(341, 38);
            this.txtCourseName.TabIndex = 5;
            // 
            // txtCourseLocation
            // 
            this.txtCourseLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseLocation.Location = new System.Drawing.Point(337, 56);
            this.txtCourseLocation.Name = "txtCourseLocation";
            this.txtCourseLocation.Size = new System.Drawing.Size(341, 38);
            this.txtCourseLocation.TabIndex = 6;
            // 
            // txtCourseRating
            // 
            this.txtCourseRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseRating.Location = new System.Drawing.Point(337, 144);
            this.txtCourseRating.Name = "txtCourseRating";
            this.txtCourseRating.Size = new System.Drawing.Size(92, 38);
            this.txtCourseRating.TabIndex = 7;
            this.txtCourseRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSlopeRating
            // 
            this.numSlopeRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSlopeRating.Location = new System.Drawing.Point(583, 145);
            this.numSlopeRating.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numSlopeRating.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numSlopeRating.Name = "numSlopeRating";
            this.numSlopeRating.Size = new System.Drawing.Size(92, 38);
            this.numSlopeRating.TabIndex = 8;
            this.numSlopeRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSlopeRating.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // numHolePar
            // 
            this.numHolePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHolePar.Location = new System.Drawing.Point(337, 188);
            this.numHolePar.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numHolePar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHolePar.Name = "numHolePar";
            this.numHolePar.Size = new System.Drawing.Size(92, 38);
            this.numHolePar.TabIndex = 9;
            this.numHolePar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numHolePar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHolePar.ValueChanged += new System.EventHandler(this.numHolePar_ValueChanged);
            // 
            // dataHolePars
            // 
            this.dataHolePars.AllowUserToAddRows = false;
            this.dataHolePars.AllowUserToDeleteRows = false;
            this.dataHolePars.AllowUserToResizeColumns = false;
            this.dataHolePars.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHolePars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataHolePars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHolePars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hole,
            this.Par});
            this.dataHolePars.Location = new System.Drawing.Point(12, 12);
            this.dataHolePars.MultiSelect = false;
            this.dataHolePars.Name = "dataHolePars";
            this.dataHolePars.ReadOnly = true;
            this.dataHolePars.RowHeadersVisible = false;
            this.dataHolePars.RowHeadersWidth = 51;
            this.dataHolePars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataHolePars.RowTemplate.Height = 24;
            this.dataHolePars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHolePars.Size = new System.Drawing.Size(135, 296);
            this.dataHolePars.TabIndex = 10;
            this.dataHolePars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHolePars_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(581, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(446, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 37);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tees:";
            // 
            // txtTees
            // 
            this.txtTees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTees.Location = new System.Drawing.Point(337, 100);
            this.txtTees.Name = "txtTees";
            this.txtTees.Size = new System.Drawing.Size(146, 38);
            this.txtTees.TabIndex = 14;
            this.txtTees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hole
            // 
            this.Hole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Hole.DefaultCellStyle = dataGridViewCellStyle2;
            this.Hole.HeaderText = "Hole";
            this.Hole.MinimumWidth = 6;
            this.Hole.Name = "Hole";
            this.Hole.ReadOnly = true;
            this.Hole.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Par
            // 
            this.Par.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Par.DefaultCellStyle = dataGridViewCellStyle3;
            this.Par.HeaderText = "Par";
            this.Par.MinimumWidth = 6;
            this.Par.Name = "Par";
            this.Par.ReadOnly = true;
            // 
            // frmEditCourse
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(690, 320);
            this.Controls.Add(this.txtTees);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataHolePars);
            this.Controls.Add(this.numHolePar);
            this.Controls.Add(this.numSlopeRating);
            this.Controls.Add(this.txtCourseRating);
            this.Controls.Add(this.txtCourseLocation);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Course";
            ((System.ComponentModel.ISupportInitialize)(this.numSlopeRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHolePar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHolePars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseLocation;
        private System.Windows.Forms.TextBox txtCourseRating;
        private System.Windows.Forms.NumericUpDown numSlopeRating;
        private System.Windows.Forms.NumericUpDown numHolePar;
        private System.Windows.Forms.DataGridView dataHolePars;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Par;
    }
}