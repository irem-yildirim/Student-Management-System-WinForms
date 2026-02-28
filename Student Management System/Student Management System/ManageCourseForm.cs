using System;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();

        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            dataGridView_course.DataSource = course.getCourse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Name.Clear();
            textBox_ccode.Clear();
            textBox_tname.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || textBox_ccode.Text == "")
            {
                MessageBox.Show("Ders bilgileri eksik.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ID çevrimi
                if (!int.TryParse(textBox_id.Text, out int id)) return;

                string cName = textBox_Name.Text;
                string cCode = textBox_ccode.Text;
                string cTeacher = textBox_tname.Text;

                if (course.updateCourse(id, cName, cCode, cTeacher))
                {
                    showData();
                    button1.PerformClick();
                    MessageBox.Show("Ders güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("ID Gerekli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    if (course.deleteCourse(id))
                    {
                        showData();
                        button1.PerformClick();
                        MessageBox.Show("Ders silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_course_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_course.CurrentRow.Cells[0].Value.ToString();
            textBox_ccode.Text = dataGridView_course.CurrentRow.Cells[1].Value.ToString();
            textBox_Name.Text = dataGridView_course.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView_course.CurrentRow.Cells[3].Value != DBNull.Value)
                textBox_tname.Text = dataGridView_course.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView_course.DataSource = course.searchCourse(textBox_search.Text);
            textBox_search.Clear();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}