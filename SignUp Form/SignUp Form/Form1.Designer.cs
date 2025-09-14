namespace SignUp_Form
{
    partial class SignUpForm
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
            username_textbox = new TextBox();
            password_textbox = new TextBox();
            label1 = new Label();
            Password_Label = new Label();
            Headinglabel = new Label();
            btn_signin = new Button();
            clr_btn = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // username_textbox
            // 
            username_textbox.Font = new Font("Segoe UI", 11F);
            username_textbox.Location = new Point(370, 192);
            username_textbox.Margin = new Padding(4);
            username_textbox.Name = "username_textbox";
            username_textbox.PlaceholderText = "Enter your Username";
            username_textbox.Size = new Size(306, 27);
            username_textbox.TabIndex = 0;
            // 
            // password_textbox
            // 
            password_textbox.Font = new Font("Segoe UI", 11F);
            password_textbox.Location = new Point(370, 264);
            password_textbox.Margin = new Padding(4);
            password_textbox.Name = "password_textbox";
            password_textbox.PasswordChar = '*';
            password_textbox.PlaceholderText = "Enter your Password";
            password_textbox.Size = new Size(306, 27);
            password_textbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(266, 196);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Location = new Point(266, 267);
            Password_Label.Margin = new Padding(4, 0, 4, 0);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(76, 20);
            Password_Label.TabIndex = 3;
            Password_Label.Text = "Password";
            // 
            // Headinglabel
            // 
            Headinglabel.AutoSize = true;
            Headinglabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Headinglabel.Location = new Point(370, 93);
            Headinglabel.Name = "Headinglabel";
            Headinglabel.Size = new Size(243, 37);
            Headinglabel.TabIndex = 4;
            Headinglabel.Text = "User Sign in Form";
            // 
            // btn_signin
            // 
            btn_signin.Location = new Point(601, 335);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(75, 35);
            btn_signin.TabIndex = 5;
            btn_signin.Text = "Sign in";
            btn_signin.UseVisualStyleBackColor = true;
            btn_signin.Click += btn_signin_Click;
            // 
            // clr_btn
            // 
            clr_btn.Location = new Point(520, 335);
            clr_btn.Name = "clr_btn";
            clr_btn.Size = new Size(75, 35);
            clr_btn.TabIndex = 6;
            clr_btn.Text = "Clear";
            clr_btn.UseVisualStyleBackColor = true;
            clr_btn.Click += clr_btn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(439, 341);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Admin";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 600);
            Controls.Add(checkBox1);
            Controls.Add(clr_btn);
            Controls.Add(btn_signin);
            Controls.Add(Headinglabel);
            Controls.Add(Password_Label);
            Controls.Add(label1);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_textbox;
        private TextBox password_textbox;
        private Label label1;
        private Label Password_Label;
        private Label Headinglabel;
        private Button btn_signin;
        private Button clr_btn;
        private CheckBox checkBox1;
    }
}
