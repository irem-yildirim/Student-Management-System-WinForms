using System;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class ManageGrades : Form
    {
        StudentClass student = new StudentClass();
        CourseClass course = new CourseClass();
        GradeClass grade = new GradeClass();

        // Seçilen Notun ID'sini tutmak için değişken
        int selectedGradeId = 0;

        public ManageGrades()
        {
            InitializeComponent();
        }

        private void ManageGrades_Load(object sender, EventArgs e)
        {
            // Dersleri ComboBox'a doldur
            comboBox_selectCourse.DataSource = course.getCourse();
            comboBox_selectCourse.DisplayMember = "CourseName";
            comboBox_selectCourse.ValueMember = "CourseId";

            // Listeleri göster
            ShowScore();
            ShowStudentList();
        }

        // Notları Listele (SQL komutu yok!)
        public void ShowScore()
        {
            dataGridView_score.DataSource = grade.getList();
        }

        // Öğrencileri Listele
        public void ShowStudentList()
        {
            dataGridView_student.DataSource = student.GetStudentList();
        }

        // --- GÜNCELLE BUTONU ---
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_stdId.Text == "" || textBox_grade.Text == "" || selectedGradeId == 0)
            {
                MessageBox.Show("Lütfen listeden güncellenecek notu seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int stdId = Convert.ToInt32(textBox_stdId.Text);
                int courseId = Convert.ToInt32(comboBox_selectCourse.SelectedValue);
                int score = Convert.ToInt32(textBox_grade.Text);

                // GradeClass'a updateGrade fonksiyonunu eklemen gerekecek (Aşağıda verdim)
                // Not: Eski GradeClass'ta updateGrade yoksa eklemelisin.
                if (grade.updateGrade(selectedGradeId, stdId, courseId, score, ""))
                {
                    ShowScore();
                    button_clear.PerformClick();
                    MessageBox.Show("Not başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- SİLME BUTONU ---
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedGradeId == 0)
            {
                MessageBox.Show("Lütfen silinecek notu seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bu notu silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (grade.deleteGrade(selectedGradeId))
                {
                    ShowScore();
                    MessageBox.Show("Not silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
            }
        }

        // --- TEMİZLEME ---
        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_stdId.Clear();
            textBox_grade.Clear();
            selectedGradeId = 0;
            if (comboBox_selectCourse.Items.Count > 0) comboBox_selectCourse.SelectedIndex = 0;
        }

        // --- ÖĞRENCİ SEÇİNCE ID AL ---
        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            if (dataGridView_student.CurrentRow != null)
            {
                textBox_stdId.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();
            }
        }

        // --- NOT SEÇİNCE BİLGİLERİ DOLDUR ---
        private void dataGridView_score_Click(object sender, EventArgs e)
        {
            if (dataGridView_score.CurrentRow != null)
            {
                // GradeId'yi gizli değişkene al (0. sütunda olduğunu varsayıyoruz)
                selectedGradeId = Convert.ToInt32(dataGridView_score.CurrentRow.Cells[0].Value);

                // Öğrenci Adını ID'ye çeviremeyiz ama listeden bulabiliriz.
                // Burada basitçe Score'u alıyoruz.
                textBox_grade.Text = dataGridView_score.CurrentRow.Cells[4].Value.ToString(); // Score sütunu

                // Ders adını ComboBox'ta seçtirmeye çalışıyoruz
                comboBox_selectCourse.Text = dataGridView_score.CurrentRow.Cells[3].Value.ToString(); // CourseName sütunu
            }
        }

        // --- ÇIKIŞ ---
        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}