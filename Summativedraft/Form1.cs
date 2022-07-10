namespace Summativedraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirm1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentid.Text) || string.IsNullOrEmpty(fname.Text) || string.IsNullOrEmpty(date.Text) || string.IsNullOrEmpty(timeintxt.Text) || string.IsNullOrEmpty(timeouttxt.Text) || string.IsNullOrEmpty(subjectname.Text))
                return;
            ListViewItem item = new ListViewItem(studentid.Text);
            item.SubItems.Add(fname.Text + " " + lname.Text);
            item.SubItems.Add(date.Text);
            item.SubItems.Add(timeintxt.Text);
            item.SubItems.Add(timeouttxt.Text);
            item.SubItems.Add(subjectname.Text);
            listView.Items.Add(item);
            fname.Clear();
            lname.Clear();
            sy.Clear();
            course.Clear();
            date.Clear();
            timeintxt.Clear();
            timeouttxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString();
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

        }
    }
}