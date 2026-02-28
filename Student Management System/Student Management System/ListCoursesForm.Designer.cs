namespace Student_Management_System
{
    partial class ListCoursesForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Label();
            this.dataGridView_course = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_print = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.lbl_exit);
            this.panel3.Controls.Add(this.Registration);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 59);
            this.panel3.TabIndex = 14;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_exit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_exit.Location = new System.Drawing.Point(908, 2);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(39, 39);
            this.lbl_exit.TabIndex = 12;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Registration.Location = new System.Drawing.Point(389, 9);
            this.Registration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(170, 34);
            this.Registration.TabIndex = 11;
            this.Registration.Text = "List Courses";
            // 
            // dataGridView_course
            // 
            this.dataGridView_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_course.Location = new System.Drawing.Point(163, 190);
            this.dataGridView_course.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_course.Name = "dataGridView_course";
            this.dataGridView_course.RowHeadersWidth = 51;
            this.dataGridView_course.RowTemplate.Height = 24;
            this.dataGridView_course.Size = new System.Drawing.Size(605, 267);
            this.dataGridView_course.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(106, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Class : ";
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_search.Location = new System.Drawing.Point(297, 80);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(236, 36);
            this.textBox_search.TabIndex = 18;
            // 
            // button_print
            // 
            this.button_print.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_print.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_print.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_print.Location = new System.Drawing.Point(758, 512);
            this.button_print.Margin = new System.Windows.Forms.Padding(2);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(128, 49);
            this.button_print.TabIndex = 20;
            this.button_print.Text = "PRINT";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 619);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 59);
            this.panel2.TabIndex = 23;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_search.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_search.Location = new System.Drawing.Point(580, 76);
            this.button_search.Margin = new System.Windows.Forms.Padding(2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(146, 41);
            this.button_search.TabIndex = 24;
            this.button_search.Text = "SEACRH";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // listcourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(947, 678);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_course);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listcourses";
            this.Text = "ListCourses";
            this.Load += new System.EventHandler(this.listcourses_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.DataGridView dataGridView_course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_search;
    }
}