namespace Student_Management_System
{
    partial class main_menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.lbl_uni = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.button_logIn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lbl_exit);
            this.panel1.Controls.Add(this.lbl_name1);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(366, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 563);
            this.panel1.TabIndex = 0;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_exit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_exit.Location = new System.Drawing.Point(476, 9);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(40, 38);
            this.lbl_exit.TabIndex = 4;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_name1
            // 
            this.lbl_name1.AutoSize = true;
            this.lbl_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_name1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_name1.Location = new System.Drawing.Point(176, 203);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(153, 38);
            this.lbl_name1.TabIndex = 3;
            this.lbl_name1.Text = " System ";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_name.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_name.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_name.Location = new System.Drawing.Point(84, 163);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(326, 38);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Student Managment";
            // 
            // lbl_uni
            // 
            this.lbl_uni.AutoSize = true;
            this.lbl_uni.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uni.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_uni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_uni.Location = new System.Drawing.Point(2, 110);
            this.lbl_uni.Name = "lbl_uni";
            this.lbl_uni.Size = new System.Drawing.Size(322, 38);
            this.lbl_uni.TabIndex = 1;
            this.lbl_uni.Text = "Lightning University";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_username.Location = new System.Drawing.Point(23, 203);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(189, 32);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Tag = "";
            this.lbl_username.Text = "User Name : ";
            // 
            // txb_username
            // 
            this.txb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_username.Location = new System.Drawing.Point(28, 252);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(231, 30);
            this.txb_username.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_password.Location = new System.Drawing.Point(24, 299);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(171, 32);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password : ";
            // 
            // txb_password
            // 
            this.txb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_password.Location = new System.Drawing.Point(28, 340);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(231, 30);
            this.txb_password.TabIndex = 5;
            this.txb_password.UseSystemPasswordChar = true;
            // 
            // button_logIn
            // 
            this.button_logIn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_logIn.ForeColor = System.Drawing.Color.White;
            this.button_logIn.Location = new System.Drawing.Point(28, 404);
            this.button_logIn.Name = "button_logIn";
            this.button_logIn.Size = new System.Drawing.Size(113, 44);
            this.button_logIn.TabIndex = 6;
            this.button_logIn.Text = "LOGIN";
            this.button_logIn.UseVisualStyleBackColor = false;
            this.button_logIn.Click += new System.EventHandler(this.button_logIn_Click);
            // 
            // main_menu
            // 
            this.AcceptButton = this.button_logIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 563);
            this.Controls.Add(this.lbl_uni);
            this.Controls.Add(this.button_logIn);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_uni;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Button button_logIn;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label lbl_name1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

