namespace MultiForm_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_name = new TextBox();
            txt_pwd = new TextBox();
            btn_login = new Button();
            btn_clr = new Button();
            label_heading = new Label();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(263, 99);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Enter your Name";
            txt_name.Size = new Size(227, 23);
            txt_name.TabIndex = 0;
            // 
            // txt_pwd
            // 
            txt_pwd.Location = new Point(263, 144);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.PasswordChar = '*';
            txt_pwd.PlaceholderText = "Enter the Password";
            txt_pwd.Size = new Size(227, 23);
            txt_pwd.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(418, 204);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(72, 23);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += Btn_Login_Click;
            // 
            // btn_clr
            // 
            btn_clr.Location = new Point(337, 204);
            btn_clr.Name = "btn_clr";
            btn_clr.Size = new Size(75, 23);
            btn_clr.TabIndex = 3;
            btn_clr.Text = "Clear";
            btn_clr.UseVisualStyleBackColor = true;
            btn_clr.Click += Btn_Clr_Click;
            // 
            // label_heading
            // 
            label_heading.AutoSize = true;
            label_heading.Font = new Font("Segoe UI", 20F);
            label_heading.Location = new Point(307, 35);
            label_heading.Name = "label_heading";
            label_heading.Size = new Size(152, 37);
            label_heading.TabIndex = 4;
            label_heading.Text = "Login Form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(label_heading);
            Controls.Add(btn_clr);
            Controls.Add(btn_login);
            Controls.Add(txt_pwd);
            Controls.Add(txt_name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_pwd;
        private Button btn_login;
        private Button btn_clr;
        private Label label_heading;
    }
}
