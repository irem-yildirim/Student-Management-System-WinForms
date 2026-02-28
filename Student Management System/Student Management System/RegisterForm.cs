using System;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class RegisterForm : Form
    {
        StudentClass student = new StudentClass();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        // Öğrenci listesini DataGridView'de göster
        public void ShowTable()
        {

            DataGridView_student.DataSource = student.GetStudentList();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Yeni öğrenci ekle
            string firstName = textBox_Fname.Text;
            string lastName = textBox_Lname.Text;
            string number = textBox_number.Text;
            DateTime birthDate = dateTimePicker_bdate.Value;
            string mail = textBox_mail.Text;
            string gender = radioButton_Female.Checked ? "Female" : "Male";

            // 18-100 yaş kontrolü
            int birthYear = dateTimePicker_bdate.Value.Year;
            int currentYear = DateTime.Now.Year;

            if ((currentYear - birthYear) < 18 || (currentYear - birthYear) > 100)
            {
                MessageBox.Show("Öğrenci yaşı 18 ile 100 arasında olmalıdır.", "Geçersiz Doğum Tarihi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (VerifyFields())
            {
                try
                {
                    if (student.InsertStudent(firstName, lastName, number, birthDate, mail, gender))
                    {
                        ShowTable();
                        MessageBox.Show("Yeni Öğrenci Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button2_Click_1(null, null); // Temizle butonunu tetikle
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Boş alan kontrolü
        bool VerifyFields()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                    (textBox_number.Text == "") || (textBox_mail.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Temizle butonu
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_number.Clear();
            textBox_mail.Clear();
            radioButton_Male.Checked = true;
            dateTimePicker_bdate.Value = DateTime.Now;
        }

        // DataGridView tıklanınca verileri textboxlara doldur
        private void DataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_student.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text = DataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text = DataGridView_student.CurrentRow.Cells[2].Value.ToString();
            textBox_number.Text = DataGridView_student.CurrentRow.Cells[3].Value.ToString();

            // Tarih hatası almamak için kontrol
            try
            {
                dateTimePicker_bdate.Value = (DateTime)DataGridView_student.CurrentRow.Cells[4].Value;
            }
            catch { }

            textBox_mail.Text = DataGridView_student.CurrentRow.Cells[5].Value.ToString();

            if (DataGridView_student.CurrentRow.Cells[6].Value.ToString() == "Female")
                radioButton_Female.Checked = true;
            else
                radioButton_Male.Checked = true;
        }

        // Arama butonu
        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = student.SearchStudent(textBox_search.Text);
        }

        // Güncelleme butonu
        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "") return;

            int id = Convert.ToInt32(textBox_id.Text);
            string firstName = textBox_Fname.Text;
            string lastName = textBox_Lname.Text;
            string number = textBox_number.Text;
            DateTime birthDate = dateTimePicker_bdate.Value;
            string mail = textBox_mail.Text;
            string gender = radioButton_Female.Checked ? "Female" : "Male";

            int birthYear = dateTimePicker_bdate.Value.Year;
            int currentYear = DateTime.Now.Year;

            if ((currentYear - birthYear) < 18 || (currentYear - birthYear) > 100)
            {
                MessageBox.Show("Yaş aralığı uygun değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (VerifyFields())
            {
                try
                {
                    if (student.UpdateStudent(id, firstName, lastName, number, birthDate, mail, gender))
                    {
                        ShowTable();
                        MessageBox.Show("Öğrenci Bilgisi Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button2_Click_1(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Silme butonu
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Silmek için listeden bir öğrenci seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bu öğrenciyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(textBox_id.Text);
                if (student.DeleteStudent(id))
                {
                    ShowTable();
                    MessageBox.Show("Öğrenci Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button2_Click_1(null, null);
                }
                else
                {
                    MessageBox.Show("Öğrenci silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}