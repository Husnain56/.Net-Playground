namespace MultiForm_App
{
    partial class Form2
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
            label_wc = new Label();
            Btn_Exit = new Button();
            SuspendLayout();
            // 
            // label_wc
            // 
            label_wc.AutoSize = true;
            label_wc.Font = new Font("Segoe UI", 20F);
            label_wc.Location = new Point(221, 70);
            label_wc.Name = "label_wc";
            label_wc.Size = new Size(0, 37);
            label_wc.TabIndex = 0;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Location = new Point(292, 237);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(156, 53);
            Btn_Exit.TabIndex = 1;
            Btn_Exit.Text = "Exit";
            Btn_Exit.UseVisualStyleBackColor = true;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Exit);
            Controls.Add(label_wc);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_wc;
        private Button Btn_Exit;
    }
}