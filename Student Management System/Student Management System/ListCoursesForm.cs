using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Student_Management_System
{
    public partial class ListCoursesForm : Form
    {
        DBConnect db = new DBConnect();
        DGVPrinter printer = new DGVPrinter();

        public ListCoursesForm()
        {
            InitializeComponent();
        }

        private void listcourses_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            SqlCommand cmd = new SqlCommand(
                @"SELECT c.CourseCode, c.CourseName,
                         t.FirstName + ' ' + t.LastName AS Teacher
                  FROM Courses c
                  LEFT JOIN Teachers t ON c.TeacherId = t.TeacherId",
                db.GetConnection()
            );

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView_course.DataSource = dt;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                @"SELECT CourseCode, CourseName 
                  FROM Courses
                  WHERE CourseCode LIKE @search",
                db.GetConnection()
            );

            cmd.Parameters.AddWithValue("@search", "%" + textBox_search.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView_course.DataSource = dt;
            textBox_search.Clear();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Course List";
            printer.SubTitle = $"Date: {DateTime.Now}";
            printer.PageNumbers = true;
            printer.PrintDataGridView(dataGridView_course);
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
