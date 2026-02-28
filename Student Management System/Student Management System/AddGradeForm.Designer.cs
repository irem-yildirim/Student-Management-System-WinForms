namespace Student_Management_System
{
    partial class AddGradeForm
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
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox_stdId = new System.Windows.Forms.TextBox();
            this.textBox_grade = new System.Windows.Forms.TextBox();
            this.comboBox_selectCourse = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_score = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_score)).BeginInit();
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
            this.panel3.TabIndex = 11;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_exit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_exit.Location = new System.Drawing.Point(905, 4);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(39, 39);
            this.lbl_exit.TabIndex = 12;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click_1);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Registration.Location = new System.Drawing.Point(392, 11);
            this.Registration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(167, 34);
            this.Registration.TabIndex = 11;
            this.Registration.Text = "Add Grade";
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_student.Location = new System.Drawing.Point(50, 113);
            this.dataGridView_student.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.RowHeadersWidth = 51;
            this.dataGridView_student.RowTemplate.Height = 24;
            this.dataGridView_student.Size = new System.Drawing.Size(417, 254);
            this.dataGridView_student.TabIndex = 12;
            this.dataGridView_student.Click += new System.EventHandler(this.dataGridView_student_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(432, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 34);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select Course : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(68, 455);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Grade : ";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_add.ForeColor = System.Drawing.Color.DarkCyan;
            this.button_add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_add.Location = new System.Drawing.Point(282, 572);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(128, 43);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClear.ForeColor = System.Drawing.Color.DarkCyan;
            this.buttonClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClear.Location = new System.Drawing.Point(431, 572);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(128, 43);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox_stdId
            // 
            this.textBox_stdId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_stdId.Location = new System.Drawing.Point(194, 390);
            this.textBox_stdId.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_stdId.Name = "textBox_stdId";
            this.textBox_stdId.Size = new System.Drawing.Size(219, 32);
            this.textBox_stdId.TabIndex = 15;
            // 
            // textBox_grade
            // 
            this.textBox_grade.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_grade.Location = new System.Drawing.Point(191, 459);
            this.textBox_grade.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_grade.Name = "textBox_grade";
            this.textBox_grade.Size = new System.Drawing.Size(222, 32);
            this.textBox_grade.TabIndex = 15;
            // 
            // comboBox_selectCourse
            // 
            this.comboBox_selectCourse.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_selectCourse.FormattingEnabled = true;
            this.comboBox_selectCourse.Location = new System.Drawing.Point(438, 439);
            this.comboBox_selectCourse.Name = "comboBox_selectCourse";
            this.comboBox_selectCourse.Size = new System.Drawing.Size(465, 29);
            this.comboBox_selectCourse.TabIndex = 19;
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
            // dataGridView_score
            // 
            this.dataGridView_score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_score.Location = new System.Drawing.Point(500, 113);
            this.dataGridView_score.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_score.Name = "dataGridView_score";
            this.dataGridView_score.RowHeadersWidth = 51;
            this.dataGridView_score.RowTemplate.Height = 24;
            this.dataGridView_score.Size = new System.Drawing.Size(417, 254);
            this.dataGridView_score.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(174, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "Student List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(635, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 34);
            this.label5.TabIndex = 26;
            this.label5.Text = "Grade List";
            // 
            // AddDeleteGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(947, 678);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_score);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox_selectCourse);
            this.Controls.Add(this.textBox_grade);
            this.Controls.Add(this.textBox_stdId);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_student);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDeleteGradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDeleteGradeForm";
            this.Load += new System.EventHandler(this.AddDeleteGradeForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox_stdId;
        private System.Windows.Forms.TextBox textBox_grade;
        private System.Windows.Forms.ComboBox comboBox_selectCourse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}