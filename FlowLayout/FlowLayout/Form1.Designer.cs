namespace FlowLayout
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
            FLP = new FlowLayoutPanel();
            btn_add = new Button();
            SuspendLayout();
            // 
            // FLP
            // 
            FLP.AutoScroll = true;
            FLP.BackColor = SystemColors.ControlDarkDark;
            FLP.Location = new Point(271, 94);
            FLP.Name = "FLP";
            FLP.Size = new Size(208, 158);
            FLP.TabIndex = 0;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(427, 269);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(52, 39);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add);
            Controls.Add(FLP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FLP;
        private Button btn_add;
    }
}
