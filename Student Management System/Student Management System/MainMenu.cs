using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_Management_System
{
    public partial class MainMenu : Form
    {
        StudentClass student = new StudentClass();

        string currentUser;
        public MainMenu(string username)
        {
            InitializeComponent();
            customizeDesign();
            currentUser = username;
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //studentCount();
            label6.Text = "Welcome : " + currentUser;
        }

        //create a function to display student count
        private void studentCount()
        {
            label_totalStu.Text = "Total Students : " + student.GetTotalStudentsCount();
            label_fmaleStu.Text = "Female : " + student.GetFemaleStudentsCount();
            label_maleStu.Text = "Male : " + student.GetMaleStudentsCount();
        }
        private void customizeDesign()
        {
            panel_teacStudMenu.Visible = false;
            panel_teacCoursesMenu.Visible = false;
            gradesubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_teacStudMenu.Visible == true)
                panel_teacStudMenu.Visible = false;

            if (panel_teacCoursesMenu.Visible == true)
                panel_teacCoursesMenu.Visible = false; ;
            if (gradesubmenu.Visible == true)
                gradesubmenu.Visible = false;

        }

        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        //To show register form 
        private Form activeForm = null;
        private void openRegForm(Form regForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = regForm;
            regForm.TopLevel = false;
            regForm.FormBorderStyle = FormBorderStyle.None;
            regForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(regForm);
            panel_main.Tag = regForm;
            regForm.BringToFront();
            regForm.Show();
        }


        //To Show Add Delete Grade form 
        private void openAddDeleteGradeForm(Form ADGForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ADGForm;
            ADGForm.TopLevel = false;
            ADGForm.FormBorderStyle = FormBorderStyle.None;
            ADGForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(ADGForm);
            panel_main.Tag = ADGForm;
            ADGForm.BringToFront();
            ADGForm.Show();
        }


        //To show ListStudents form 
        private void openListStudentsForm(Form ListSTUform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ListSTUform;
            ListSTUform.TopLevel = false;
            ListSTUform.FormBorderStyle = FormBorderStyle.None;
            ListSTUform.Dock = DockStyle.Fill;
            panel_main.Controls.Add(ListSTUform);
            panel_main.Tag = ListSTUform;
            ListSTUform.BringToFront();
            ListSTUform.Show();
        }



        //To show NewCourse form
        private void openNewCourseForm(Form NewCourseform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = NewCourseform;
            NewCourseform.TopLevel = false;
            NewCourseform.FormBorderStyle = FormBorderStyle.None;
            NewCourseform.Dock = DockStyle.Fill;
            panel_main.Controls.Add(NewCourseform);
            panel_main.Tag = NewCourseform;
            NewCourseform.BringToFront();
            NewCourseform.Show();
        }



        //To show ManageCourse form
        private void openManageCourseForm(Form ManageCourseform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ManageCourseform;
            ManageCourseform.TopLevel = false;
            ManageCourseform.FormBorderStyle = FormBorderStyle.None;
            ManageCourseform.Dock = DockStyle.Fill;
            panel_main.Controls.Add(ManageCourseform);
            panel_main.Tag = ManageCourseform;
            ManageCourseform.BringToFront();
            ManageCourseform.Show();
        }



        //To show ListCourse form      
        private void openListCourseForm(Form listCourseForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = listCourseForm;
            listCourseForm.TopLevel = false;
            listCourseForm.FormBorderStyle = FormBorderStyle.None;
            listCourseForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(listCourseForm);
            panel_main.Tag = listCourseForm;
            listCourseForm.BringToFront();
            listCourseForm.Show();
        }

        //To show ManageGrade form
        private void openManageGradeForm(Form ManageGrades)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ManageGrades;
            ManageGrades.TopLevel = false;
            ManageGrades.FormBorderStyle = FormBorderStyle.None;
            ManageGrades.Dock = DockStyle.Fill;
            panel_main.Controls.Add(ManageGrades);
            panel_main.Tag = ManageGrades;
            ManageGrades.BringToFront();
            ManageGrades.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button_stud_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_teacStudMenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openRegForm(new RegisterForm());
            hideSubMenu();
        }

        private void btn_listStud_Click(object sender, EventArgs e)
        {
            openListStudentsForm(new ListStudentsForm());
            hideSubMenu();
        }

        private void btn_NewCourse_Click(object sender, EventArgs e)
        {
            openNewCourseForm(new NewCourseForm());
            hideSubMenu();
        }

        private void btn_teacCourse_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_teacCoursesMenu);
        }

        private void btn_manageCourse_Click(object sender, EventArgs e)
        {
            openManageCourseForm(new ManageCourseForm());
            hideSubMenu();
        }

        private void btn_listCourse_Click(object sender, EventArgs e)
        {
            openListCourseForm(new ListCoursesForm());
            hideSubMenu();
        }

        private void btn_TeacCoursePrint_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }


        //exit button...
        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Grade_Click(object sender, EventArgs e)
        {
            ShowSubMenu(gradesubmenu);
        }


        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            studentCount();
        }

        private void button_newGrade_Click(object sender, EventArgs e)
        {
            openAddDeleteGradeForm(new AddGradeForm());
            hideSubMenu();
        }

        private void button_ManageGrade_Click(object sender, EventArgs e)
        {
            openManageGradeForm(new ManageGrades());
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            main_menu login = new main_menu();
            this.Close();
            login.Show();
        }
    }
}
