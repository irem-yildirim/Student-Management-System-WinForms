namespace Student_Management_System
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.DataGridView_student = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_bdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.button_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Lname = new System.Windows.Forms.TextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView_student
            // 
            this.DataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DataGridView_student, "DataGridView_student");
            this.DataGridView_student.Name = "DataGridView_student";
            this.DataGridView_student.RowTemplate.Height = 24;
            this.DataGridView_student.Click += new System.EventHandler(this.DataGridView_student_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Name = "label1";
            // 
            // textBox_Fname
            // 
            resources.ApplyResources(this.textBox_Fname, "textBox_Fname");
            this.textBox_Fname.Name = "textBox_Fname";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Name = "label3";
            // 
            // dateTimePicker_bdate
            // 
            resources.ApplyResources(this.dateTimePicker_bdate, "dateTimePicker_bdate");
            this.dateTimePicker_bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_bdate.Name = "dateTimePicker_bdate";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Name = "label4";
            // 
            // radioButton_Male
            // 
            resources.ApplyResources(this.radioButton_Male, "radioButton_Male");
            this.radioButton_Male.ForeColor = System.Drawing.Color.DarkCyan;
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            resources.ApplyResources(this.radioButton_Female, "radioButton_Female");
            this.radioButton_Female.Checked = true;
            this.radioButton_Female.ForeColor = System.Drawing.Color.DarkCyan;
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            resources.ApplyResources(this.button_add, "button_add");
            this.button_add.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_add.Name = "button_add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.lbl_exit);
            this.panel3.Controls.Add(this.Registration);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lbl_exit
            // 
            resources.ApplyResources(this.lbl_exit, "lbl_exit");
            this.lbl_exit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // Registration
            // 
            resources.ApplyResources(this.Registration, "Registration");
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.Name = "Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DataGridView_student);
            this.panel1.Controls.Add(this.radioButton_Female);
            this.panel1.Controls.Add(this.textBox_Lname);
            this.panel1.Controls.Add(this.textBox_mail);
            this.panel1.Controls.Add(this.textBox_number);
            this.panel1.Controls.Add(this.textBox_Fname);
            this.panel1.Controls.Add(this.radioButton_Male);
            this.panel1.Controls.Add(this.dateTimePicker_bdate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // textBox_search
            // 
            resources.ApplyResources(this.textBox_search, "textBox_search");
            this.textBox_search.Name = "textBox_search";
            // 
            // button_search
            // 
            resources.ApplyResources(this.button_search, "button_search");
            this.button_search.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_search.Name = "button_search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_id
            // 
            resources.ApplyResources(this.textBox_id, "textBox_id");
            this.textBox_id.Name = "textBox_id";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Name = "label6";
            // 
            // button_delete
            // 
            resources.ApplyResources(this.button_delete, "button_delete");
            this.button_delete.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_delete.Name = "button_delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            resources.ApplyResources(this.button_update, "button_update");
            this.button_update.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_update.Name = "button_update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_clear
            // 
            resources.ApplyResources(this.button_clear, "button_clear");
            this.button_clear.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_clear.Name = "button_clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Name = "label5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Name = "label7";
            // 
            // textBox_Lname
            // 
            resources.ApplyResources(this.textBox_Lname, "textBox_Lname");
            this.textBox_Lname.Name = "textBox_Lname";
            // 
            // textBox_mail
            // 
            resources.ApplyResources(this.textBox_mail, "textBox_mail");
            this.textBox_mail.Name = "textBox_mail";
            // 
            // textBox_number
            // 
            resources.ApplyResources(this.textBox_number, "textBox_number");
            this.textBox_number.Name = "textBox_number";
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_bdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.TextBox textBox_Lname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
    }
}