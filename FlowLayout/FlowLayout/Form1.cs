namespace FlowLayout
{
    public partial class Form1 : Form
    {
        private int _i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int r = rand.Next(0, 256);
            int g = rand.Next(0, 256);
            int b = rand.Next(0, 256);

            TextBox txt = new TextBox();
            txt.BackColor = Color.FromArgb(r, g, b);
            MyButton btn = new MyButton(txt);
            btn.Text = "Button " + _i++;

            btn.Click += new System.EventHandler(this.btnTemp_Click);

            FLP.Controls.Add(txt);
            FLP.Controls.Add(btn);
        }

        private void btnTemp_Click(object sender,EventArgs e)
        {
            MyButton btn = sender as MyButton;
            MessageBox.Show(btn.MyText.BackColor + " has been clicked");
        }
    }
}
