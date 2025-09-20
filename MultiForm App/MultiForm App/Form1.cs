namespace MultiForm_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Clr_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_pwd.Clear();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_pwd.Text != "")
            {
                LoginDetails NewLogin = new LoginDetails(txt_name.Text, txt_pwd.Text);
                Form2 newForm = new Form2(NewLogin);
                newForm.Show(this);
                return;
            }
            MessageBox.Show("Please fill both Username and Password");
        }
    }
}
