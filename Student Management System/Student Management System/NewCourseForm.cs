using System;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class NewCourseForm : Form
    {
        CourseClass course = new CourseClass();

        public NewCourseForm()
        {
            InitializeComponent();
        }

        private void NewCourseForm_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        // DataGridView Listeleme
        private void ShowData()
        {
            DataGridView_course.DataSource = course.getCourse();
        }

        // Ekle Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || textBox_ccode.Text == "")
            {
                MessageBox.Show("Ders bilgilerini doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cName = textBox_Name.Text;
                string cCode = textBox_ccode.Text;
                string cTeacher = textBox_tname.Text;

                if (course.insertCourse(cName, cCode, cTeacher))
                {
                    ShowData();
                    button_clear.PerformClick();
                    MessageBox.Show("Yeni ders eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ders eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Temizle Butonu
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_ccode.Clear();
            textBox_tname.Clear();
        }

        // Çıkış Butonu
        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}