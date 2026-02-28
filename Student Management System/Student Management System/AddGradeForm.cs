using System;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class AddGradeForm : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        GradeClass grade = new GradeClass();

        public AddGradeForm()
        {
            InitializeComponent();
        }

        private void AddDeleteGradeForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadStudentList();
            LoadGradeList();
        }

        private void LoadStudentList()
        {
            dataGridView_student.DataSource = student.GetStudentList();
        }

        private void LoadCourses()
        {
            comboBox_selectCourse.DataSource = course.getCourse();
            comboBox_selectCourse.DisplayMember = "CourseName";
            comboBox_selectCourse.ValueMember = "CourseId";
        }

        private void LoadGradeList()
        {
            dataGridView_score.DataSource = grade.getList();
        }

        // EKLE BUTONU (Sadeleşti)
        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_stdId.Text == "" || textBox_grade.Text == "")
            {
                MessageBox.Show("Öğrenci ID ve Not bilgisi gerekli.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int stdId = Convert.ToInt32(textBox_stdId.Text);
                int courseId = Convert.ToInt32(comboBox_selectCourse.SelectedValue);
                int score = Convert.ToInt32(textBox_grade.Text);

                if (grade.insertGrade(stdId, courseId, score, ""))
                {
                    LoadGradeList();
                    buttonClear.PerformClick();
                    MessageBox.Show("Not başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_stdId.Clear();
            textBox_grade.Clear();
            if (comboBox_selectCourse.Items.Count > 0) comboBox_selectCourse.SelectedIndex = 0;
        }

        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            if (dataGridView_student.CurrentRow != null)
            {
                textBox_stdId.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void lbl_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}