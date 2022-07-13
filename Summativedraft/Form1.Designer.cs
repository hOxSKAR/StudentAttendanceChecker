

namespace Summativedraft
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.attendance_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.TimeIn = new System.Windows.Forms.Button();
            this.TimeOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.fname_text = new System.Windows.Forms.TextBox();
            this.lname_text = new System.Windows.Forms.TextBox();
            this.sy_text = new System.Windows.Forms.TextBox();
            this.course_text = new System.Windows.Forms.TextBox();
            this.confirm1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.TextBox();
            this.timeintxt = new System.Windows.Forms.TextBox();
            this.timeouttxt = new System.Windows.Forms.TextBox();
            this.studentid_comb = new System.Windows.Forms.ComboBox();
            this.subjectname = new System.Windows.Forms.ComboBox();
            this.status_lbl = new System.Windows.Forms.Label();
            this.add_student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(451, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "FIRST NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "STUDENT ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // attendance_listView
            // 
            this.attendance_listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.attendance_listView.BackColor = System.Drawing.Color.Teal;
            this.attendance_listView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attendance_listView.BackgroundImage")));
            this.attendance_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.attendance_listView.HoverSelection = true;
            this.attendance_listView.Location = new System.Drawing.Point(363, 139);
            this.attendance_listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendance_listView.Name = "attendance_listView";
            this.attendance_listView.Size = new System.Drawing.Size(717, 453);
            this.attendance_listView.TabIndex = 6;
            this.attendance_listView.UseCompatibleStateImageBehavior = false;
            this.attendance_listView.View = System.Windows.Forms.View.Details;
            this.attendance_listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Student Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time In";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time Out";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Subject Name";
            this.columnHeader6.Width = 100;
            // 
            // TimeIn
            // 
            this.TimeIn.BackColor = System.Drawing.Color.Teal;
            this.TimeIn.ForeColor = System.Drawing.Color.White;
            this.TimeIn.Location = new System.Drawing.Point(13, 553);
            this.TimeIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.Size = new System.Drawing.Size(119, 31);
            this.TimeIn.TabIndex = 7;
            this.TimeIn.Text = "TIME IN";
            this.TimeIn.UseVisualStyleBackColor = false;
            this.TimeIn.Click += new System.EventHandler(this.TimeIn_Click);
            // 
            // TimeOut
            // 
            this.TimeOut.BackColor = System.Drawing.Color.Teal;
            this.TimeOut.ForeColor = System.Drawing.Color.White;
            this.TimeOut.Location = new System.Drawing.Point(13, 592);
            this.TimeOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(119, 31);
            this.TimeOut.TabIndex = 8;
            this.TimeOut.Text = "TIME OUT";
            this.TimeOut.UseVisualStyleBackColor = false;
            this.TimeOut.Click += new System.EventHandler(this.TimeOut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(5, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Student Details";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(8, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Attendance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(13, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Subjects";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "SUBJECT NAME:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "SCHOOL YEAR:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Teal;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(24, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "COURSE:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Teal;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(24, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "LAST NAME:";
            // 
            // fname_text
            // 
            this.fname_text.Enabled = false;
            this.fname_text.Location = new System.Drawing.Point(142, 169);
            this.fname_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fname_text.Name = "fname_text";
            this.fname_text.Size = new System.Drawing.Size(185, 27);
            this.fname_text.TabIndex = 21;
            // 
            // lname_text
            // 
            this.lname_text.Enabled = false;
            this.lname_text.Location = new System.Drawing.Point(142, 208);
            this.lname_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lname_text.Name = "lname_text";
            this.lname_text.Size = new System.Drawing.Size(185, 27);
            this.lname_text.TabIndex = 22;
            // 
            // sy_text
            // 
            this.sy_text.AcceptsReturn = true;
            this.sy_text.Enabled = false;
            this.sy_text.Location = new System.Drawing.Point(142, 247);
            this.sy_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sy_text.Name = "sy_text";
            this.sy_text.Size = new System.Drawing.Size(185, 27);
            this.sy_text.TabIndex = 23;
            // 
            // course_text
            // 
            this.course_text.Enabled = false;
            this.course_text.Location = new System.Drawing.Point(142, 285);
            this.course_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.course_text.Name = "course_text";
            this.course_text.Size = new System.Drawing.Size(185, 27);
            this.course_text.TabIndex = 24;
            // 
            // confirm1
            // 
            this.confirm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm1.BackgroundImage")));
            this.confirm1.Location = new System.Drawing.Point(14, 651);
            this.confirm1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirm1.Name = "confirm1";
            this.confirm1.Size = new System.Drawing.Size(313, 49);
            this.confirm1.TabIndex = 27;
            this.confirm1.Text = "Confirm";
            this.confirm1.UseVisualStyleBackColor = true;
            this.confirm1.Click += new System.EventHandler(this.confirm1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 515);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 31;
            this.button1.Text = "DATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(142, 515);
            this.date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(183, 27);
            this.date.TabIndex = 32;
            // 
            // timeintxt
            // 
            this.timeintxt.Location = new System.Drawing.Point(142, 555);
            this.timeintxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeintxt.Name = "timeintxt";
            this.timeintxt.Size = new System.Drawing.Size(183, 27);
            this.timeintxt.TabIndex = 33;
            // 
            // timeouttxt
            // 
            this.timeouttxt.Location = new System.Drawing.Point(142, 592);
            this.timeouttxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeouttxt.Name = "timeouttxt";
            this.timeouttxt.Size = new System.Drawing.Size(183, 27);
            this.timeouttxt.TabIndex = 34;
            // 
            // studentid_comb
            // 
            this.studentid_comb.DisplayMember = "student_id";
            this.studentid_comb.FormattingEnabled = true;
            this.studentid_comb.Items.AddRange(new object[] {
            "Create New"});
            this.studentid_comb.Location = new System.Drawing.Point(142, 131);
            this.studentid_comb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentid_comb.Name = "studentid_comb";
            this.studentid_comb.Size = new System.Drawing.Size(185, 28);
            this.studentid_comb.TabIndex = 35;
            this.studentid_comb.ValueMember = "student_id";
            this.studentid_comb.SelectedIndexChanged += new System.EventHandler(this.studentid_SelectedIndexChanged);
            // 
            // subjectname
            // 
            this.subjectname.FormattingEnabled = true;
            this.subjectname.Items.AddRange(new object[] {
            "csc",
            "css",
            "cssss"});
            this.subjectname.Location = new System.Drawing.Point(145, 395);
            this.subjectname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(185, 28);
            this.subjectname.TabIndex = 36;
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.status_lbl.Location = new System.Drawing.Point(24, 429);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(0, 20);
            this.status_lbl.TabIndex = 13;
            // 
            // add_student
            // 
            this.add_student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_student.BackgroundImage")));
            this.add_student.Enabled = false;
            this.add_student.Location = new System.Drawing.Point(207, 324);
            this.add_student.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_student.Name = "add_student";
            this.add_student.Size = new System.Drawing.Size(119, 31);
            this.add_student.TabIndex = 31;
            this.add_student.Text = "Add";
            this.add_student.UseVisualStyleBackColor = true;
            this.add_student.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1110, 722);
            this.Controls.Add(this.subjectname);
            this.Controls.Add(this.studentid_comb);
            this.Controls.Add(this.timeouttxt);
            this.Controls.Add(this.timeintxt);
            this.Controls.Add(this.date);
            this.Controls.Add(this.add_student);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirm1);
            this.Controls.Add(this.course_text);
            this.Controls.Add(this.sy_text);
            this.Controls.Add(this.lname_text);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeOut);
            this.Controls.Add(this.TimeIn);
            this.Controls.Add(this.attendance_listView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // SLQ THINGY


        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private ListView attendance_listView;
        private Button TimeIn;
        private Button TimeOut;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox fname_text;
        private TextBox lname_text;
        private TextBox sy_text;
        private TextBox course_text;
        private Button confirm1;
        private Button button1;
        private TextBox date;
        private TextBox timeintxt;
        private TextBox timeouttxt;
        private ComboBox studentid_comb;
        private ComboBox subjectname;
        private Label status_lbl;
        private Button add_student;
    }
}