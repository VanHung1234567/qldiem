﻿namespace qlDiem
{
    partial class MonHoc
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbSearchByID = new System.Windows.Forms.RadioButton();
            this.tbSearchByName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCourseID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCourseCatID = new System.Windows.Forms.ComboBox();
            this.nrPTP = new System.Windows.Forms.NumericUpDown();
            this.nrMAA = new System.Windows.Forms.NumericUpDown();
            this.nrSessions = new System.Windows.Forms.NumericUpDown();
            this.nrCourseCredit = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCourseCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrMAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrCourseCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(687, 383);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(209, 22);
            this.tbSearch.TabIndex = 29;
            // 
            // tbSearchByID
            // 
            this.tbSearchByID.AutoSize = true;
            this.tbSearchByID.Location = new System.Drawing.Point(819, 357);
            this.tbSearchByID.Name = "tbSearchByID";
            this.tbSearchByID.Size = new System.Drawing.Size(105, 20);
            this.tbSearchByID.TabIndex = 28;
            this.tbSearchByID.TabStop = true;
            this.tbSearchByID.Text = "Search by ID";
            this.tbSearchByID.UseVisualStyleBackColor = true;
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.AutoSize = true;
            this.tbSearchByName.Location = new System.Drawing.Point(654, 357);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.Size = new System.Drawing.Size(126, 20);
            this.tbSearchByName.TabIndex = 27;
            this.tbSearchByName.TabStop = true;
            this.tbSearchByName.Text = "Search by name";
            this.tbSearchByName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(922, 383);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 22);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(451, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(286, 365);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 40);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 40);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "COURSE MANAGEMENT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(88, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 236);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CourseCode";
            this.Column1.HeaderText = "Course Code";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CourseName";
            this.Column2.HeaderText = "Course Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CourseCredits";
            this.Column3.HeaderText = "Course Credits";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ClassSessions";
            this.Column4.HeaderText = "Sessions";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaxAllowedAbsences";
            this.Column5.HeaderText = "Max Allowed Absenses";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PointToPass";
            this.Column6.HeaderText = "Point To Pass";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CourseCatID";
            this.Column7.HeaderText = "Course Cat ID";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCourseID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCourseCatID);
            this.groupBox1.Controls.Add(this.nrPTP);
            this.groupBox1.Controls.Add(this.nrMAA);
            this.groupBox1.Controls.Add(this.nrSessions);
            this.groupBox1.Controls.Add(this.nrCourseCredit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCourseName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCourseCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(85, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 228);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Infomation";
            // 
            // tbCourseID
            // 
            this.tbCourseID.Location = new System.Drawing.Point(178, 35);
            this.tbCourseID.Name = "tbCourseID";
            this.tbCourseID.Size = new System.Drawing.Size(209, 22);
            this.tbCourseID.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "CourseID";
            // 
            // cbCourseCatID
            // 
            this.cbCourseCatID.FormattingEnabled = true;
            this.cbCourseCatID.Location = new System.Drawing.Point(684, 160);
            this.cbCourseCatID.Name = "cbCourseCatID";
            this.cbCourseCatID.Size = new System.Drawing.Size(209, 24);
            this.cbCourseCatID.TabIndex = 18;
            // 
            // nrPTP
            // 
            this.nrPTP.Location = new System.Drawing.Point(684, 122);
            this.nrPTP.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nrPTP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrPTP.Name = "nrPTP";
            this.nrPTP.Size = new System.Drawing.Size(209, 22);
            this.nrPTP.TabIndex = 17;
            this.nrPTP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nrMAA
            // 
            this.nrMAA.Location = new System.Drawing.Point(684, 81);
            this.nrMAA.Name = "nrMAA";
            this.nrMAA.Size = new System.Drawing.Size(209, 22);
            this.nrMAA.TabIndex = 16;
            // 
            // nrSessions
            // 
            this.nrSessions.Location = new System.Drawing.Point(178, 166);
            this.nrSessions.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nrSessions.Name = "nrSessions";
            this.nrSessions.Size = new System.Drawing.Size(209, 22);
            this.nrSessions.TabIndex = 15;
            this.nrSessions.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nrCourseCredit
            // 
            this.nrCourseCredit.Location = new System.Drawing.Point(178, 121);
            this.nrCourseCredit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nrCourseCredit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrCourseCredit.Name = "nrCourseCredit";
            this.nrCourseCredit.Size = new System.Drawing.Size(209, 22);
            this.nrCourseCredit.TabIndex = 14;
            this.nrCourseCredit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Class Sessions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Course Categories ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Point To Pass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max Allowed Absenses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course Credits";
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(682, 32);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(209, 22);
            this.tbCourseName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Name";
            // 
            // tbCourseCode
            // 
            this.tbCourseCode.Location = new System.Drawing.Point(178, 80);
            this.tbCourseCode.Name = "tbCourseCode";
            this.tbCourseCode.Size = new System.Drawing.Size(209, 22);
            this.tbCourseCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course Code";
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 717);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbSearchByID);
            this.Controls.Add(this.tbSearchByName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MonHoc";
            this.Text = "MonHoc";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrMAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrCourseCredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.RadioButton tbSearchByID;
        private System.Windows.Forms.RadioButton tbSearchByName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCourseID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCourseCatID;
        private System.Windows.Forms.NumericUpDown nrPTP;
        private System.Windows.Forms.NumericUpDown nrMAA;
        private System.Windows.Forms.NumericUpDown nrSessions;
        private System.Windows.Forms.NumericUpDown nrCourseCredit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCourseCode;
        private System.Windows.Forms.Label label2;
    }
}