namespace CalculatorApp
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
            input_box = new TextBox();
            btn_1 = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_clear = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_res = new Button();
            btn_0 = new Button();
            btn_6 = new Button();
            btn_add = new Button();
            btn_div = new Button();
            btn_mul = new Button();
            btn_sub = new Button();
            SuspendLayout();
            // 
            // input_box
            // 
            input_box.Location = new Point(3, 3);
            input_box.Name = "input_box";
            input_box.ReadOnly = true;
            input_box.Size = new Size(260, 23);
            input_box.TabIndex = 0;
            // 
            // btn_1
            // 
            btn_1.Location = new Point(11, 44);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(55, 32);
            btn_1.TabIndex = 1;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(133, 44);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(55, 32);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(72, 44);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(55, 32);
            btn_2.TabIndex = 3;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_1_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(12, 199);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(55, 32);
            btn_clear.TabIndex = 4;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(133, 146);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(55, 32);
            btn_9.TabIndex = 5;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_1_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(72, 146);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(55, 32);
            btn_8.TabIndex = 6;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_1_Click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(12, 146);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(55, 32);
            btn_7.TabIndex = 7;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_1_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(12, 96);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(55, 32);
            btn_4.TabIndex = 8;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_1_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(73, 96);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(55, 32);
            btn_5.TabIndex = 9;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_1_Click;
            // 
            // btn_res
            // 
            btn_res.Location = new Point(133, 199);
            btn_res.Name = "btn_res";
            btn_res.RightToLeft = RightToLeft.No;
            btn_res.Size = new Size(55, 32);
            btn_res.TabIndex = 11;
            btn_res.Text = "=";
            btn_res.UseVisualStyleBackColor = true;
            btn_res.Click += btn_res_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(73, 199);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(55, 32);
            btn_0.TabIndex = 12;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_1_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(134, 96);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(55, 32);
            btn_6.TabIndex = 13;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_1_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(194, 44);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(69, 32);
            btn_add.TabIndex = 14;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_arith_Click;
            // 
            // btn_div
            // 
            btn_div.Location = new Point(194, 199);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(66, 32);
            btn_div.TabIndex = 15;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_arith_Click;
            // 
            // btn_mul
            // 
            btn_mul.Location = new Point(194, 146);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(66, 32);
            btn_mul.TabIndex = 16;
            btn_mul.Text = "*";
            btn_mul.UseVisualStyleBackColor = true;
            btn_mul.Click += btn_arith_Click;
            // 
            // btn_sub
            // 
            btn_sub.Location = new Point(195, 96);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(68, 32);
            btn_sub.TabIndex = 19;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += btn_arith_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 244);
            Controls.Add(btn_sub);
            Controls.Add(btn_mul);
            Controls.Add(btn_div);
            Controls.Add(btn_add);
            Controls.Add(btn_6);
            Controls.Add(btn_0);
            Controls.Add(btn_res);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_7);
            Controls.Add(btn_8);
            Controls.Add(btn_9);
            Controls.Add(btn_clear);
            Controls.Add(btn_2);
            Controls.Add(btn_3);
            Controls.Add(btn_1);
            Controls.Add(input_box);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input_box;
        private Button btn_1;
        private Button btn_3;
        private Button btn_2;
        private Button btn_clear;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_4;
        private Button btn_5;
        private Button btn_res;
        private Button btn_0;
        private Button btn_6;
        private Button btn_add;
        private Button btn_div;
        private Button btn_mul;
        private Button btn_sub;
    }
}
