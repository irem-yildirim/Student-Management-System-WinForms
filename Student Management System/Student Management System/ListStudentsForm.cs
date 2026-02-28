using System;
using System.Windows.Forms;
using DGVPrinterHelper; // Bu kütüphanenin projenizde olduğunu varsayıyorum

namespace Student_Management_System
{
    public partial class ListStudentsForm : Form
    {
        StudentClass student = new StudentClass();
        DGVPrinter printer = new DGVPrinter();

        public ListStudentsForm()
        {
            InitializeComponent();
        }

        // Form Yüklenirken
        private void TeacListStud_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataGridView_student.DataSource = student.GetStudentList();

            // Eğer resim sütunu (ImageColumn) varsa ve hata veriyorsa,
            // DataGridView ayarlarından RowTemplate.Height değerini 80 yapmayı unutma.
            DataGridView_student.RowTemplate.Height = 80;
        }

        // Yazdır Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            printer.Title = "Student List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = System.Drawing.StringFormatFlags.LineLimit | System.Drawing.StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = System.Drawing.StringAlignment.Near;
            printer.Footer = "Student Management System";
            printer.FooterSpacing = 15;

            // Yazdırma işlemi
            printer.PrintDataGridView(DataGridView_student);
        }

        // Çıkış Butonu
        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}