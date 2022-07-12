using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
namespace Summativedraft
{
    public partial class Form1 : Form
    {

        public SqlCommand command;
        public SqlConnection connection;
        public Form1()
        {

            initializeConnection();
            InitializeComponent();
            LoadStudents();
            LoadSubjects();
            LoadAttendance();
        }
        private void initializeConnection()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\johnd\\source\\repos\\StudentAttendanceChecker\\Summativedraft\\AttendanceSchema.mdf;Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(connectionString);
        }
        private void LoadStudents()
        {
            studentid_comb.Items.Clear();
            studentid_comb.Items.Add("Create New");
            string students_query = "SELECT student_id FROM Students";
            command = new SqlCommand(students_query, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                studentid_comb.Items.Add(reader["student_id"].ToString());
            }            
            connection.Close();
        }
        private void LoadAttendance()
        {
            attendance_listView.Items.Clear();
            string students_query = "SELECT Students.student_id, CONCAT(Students.first_name,' ', Students.last_name) AS student_name, Attendance.date_attendance, Attendance.time_in, Attendance.time_out, Subjects.name FROM Attendance JOIN Students ON Attendance.st_id = Students.student_id JOIN Subjects ON Attendance.sb_id = Subjects.Id";
            command = new SqlCommand(students_query, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Student_ID", typeof(string));
            dt.Columns.Add("Student_Name", typeof(string));
            dt.Columns.Add("Date_Attendance", typeof(string));
            dt.Columns.Add("Time_In", typeof(string));
            dt.Columns.Add("Time_Out", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Load(reader);

            

           for(int i= 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr["Student_ID"].ToString());
                item.SubItems.Add(dr["Student_Name"].ToString());
                item.SubItems.Add(dr["Date_Attendance"].ToString());
                item.SubItems.Add(dr["Time_In"].ToString());
                item.SubItems.Add(dr["Time_Out"].ToString());
                item.SubItems.Add(dr["Name"].ToString());
                attendance_listView.Items.Add(item);
            }
            connection.Close();
        }
        private void LoadSubjects()
        {
            subjectname.Items.Clear();
            string subjects_query = "SELECT * FROM Subjects";
            command = new SqlCommand(subjects_query, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("name", typeof(string));
            dt.Load(reader);
            subjectname.ValueMember = "Id";
            subjectname.DisplayMember = "name";

            subjectname.DataSource = dt;

            connection.Close();
        }


        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void confirm1_Click(object sender, EventArgs e)
        {
            int increment = attendance_listView.Items.Count;  
            if (string.IsNullOrEmpty(studentid_comb.Text) || string.IsNullOrEmpty(fname_text.Text) || string.IsNullOrEmpty(date.Text) || string.IsNullOrEmpty(timeintxt.Text) || string.IsNullOrEmpty(timeouttxt.Text) || string.IsNullOrEmpty(subjectname.Text))
                return;
                string createNewTime = "INSERT INTO Attendance (Id, st_id, sb_id, date_attendance, time_in, time_out) VALUES (@id, @student_id, @subject_id, @date, @time_in, @time_out);";
                command = new SqlCommand(createNewTime, connection);
                command.Parameters.AddWithValue("id", increment + 2);
                command.Parameters.AddWithValue("@student_id", int.Parse(studentid_comb.SelectedItem.ToString()));
                command.Parameters.AddWithValue("@subject_id", int.Parse(subjectname.SelectedValue.ToString()));
            
                command.Parameters.AddWithValue("@date", DateTime.Parse(date.Text).ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@time_in", DateTime.Parse(timeintxt.Text).ToString("HH:mm"));
                command.Parameters.AddWithValue("@time_out", DateTime.Parse(timeouttxt.Text).ToString("HH:mm"));
            try
            {
                connection.Open();

                command.ExecuteNonQuery();


                status_lbl.ForeColor = Color.Green;
                status_lbl.Text = "Successfully Added";

            }
            catch (SqlException ex)
            {
                status_lbl.ForeColor = Color.Red;
                status_lbl.Text = ex.Message;
            }
            finally
            {
                connection.Close();
                LoadAttendance();

            }
            
            
            date.Clear();
            timeintxt.Clear();
            timeouttxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            date.Text = DateTime.Now.ToShortDateString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            int increment = studentid_comb.Items.Count;
            if (string.IsNullOrEmpty(studentid_comb.Text) || string.IsNullOrEmpty(fname_text.Text) || string.IsNullOrEmpty(course_text.Text) || string.IsNullOrEmpty(subjectname.Text))
                return;
            string createNewTime = "INSERT INTO Students (student_id, first_name, last_name, course, school_year) VALUES (@student_id, @first_name, @last_name, @course, @school_year);";
            command = new SqlCommand(createNewTime, connection);
            
            command.Parameters.AddWithValue("@student_id", increment);
            command.Parameters.AddWithValue("@first_name", fname_text.Text);

            command.Parameters.AddWithValue("@last_name", lname_text.Text);
            command.Parameters.AddWithValue("@course", course_text.Text);
            command.Parameters.AddWithValue("@school_year", sy_text.Text);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                status_lbl.ForeColor = Color.Green;
                status_lbl.Text = "Successfully Added";

            }
            catch (SqlException ex)
            {
                status_lbl.ForeColor = Color.Red;
                status_lbl.Text = ex.Message;
            }
            finally
            {
                add_student.Enabled = false;
                fname_text.Enabled = false;
                lname_text.Enabled = false;
                course_text.Enabled = false;
                sy_text.Enabled = false;
                connection.Close();
                LoadStudents();
            }
        }

        private void TimeIn_Click(object sender, EventArgs e)
        {
            timeintxt.Text = DateTime.Now.ToShortTimeString();
        }

        private void TimeOut_Click(object sender, EventArgs e)
        {
            timeouttxt.Text = DateTime.Now.ToShortTimeString();
        }

        private void studentid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentid_comb.SelectedItem.ToString() == "Create New")
            {
                fname_text.Text = "";
                lname_text.Text = "";
                sy_text.Text = "";
                course_text.Text = "";

                add_student.Enabled = true;

                fname_text.Enabled = true;
                lname_text.Enabled = true;
                sy_text.Enabled = true;
                course_text.Enabled = true;

            }
            else
            {
                fname_text.Enabled = false;
                lname_text.Enabled = false;
                sy_text.Enabled = false;
                course_text.Enabled = false;

                string student_selected_query = "SELECT first_name, last_name,course, school_year FROM Students WHERE student_id=" + studentid_comb.SelectedItem;
                command = new SqlCommand(student_selected_query, connection);
                connection.Open();
                using SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {

                    fname_text.Text = rd["first_name"].ToString();
                    lname_text.Text = rd["last_name"].ToString();
                    sy_text.Text = rd["school_year"].ToString();
                    course_text.Text = rd["course"].ToString();
                }

                connection.Close();
            }



        }
    }
}