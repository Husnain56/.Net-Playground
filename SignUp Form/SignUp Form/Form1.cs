namespace SignUp_Form
{
    public partial class SignUpForm : System.Windows.Forms.Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text == "" || password_textbox.Text == "")
            {
                MessageBox.Show("Please Enter both Username and Password");
                username_textbox.Clear();
                password_textbox.Clear();

            }
            else
            {
                if (checkBox1.Checked)
                {
                    MessageBox.Show("Welcome Admin "+ username_textbox.Text);
                    username_textbox.Clear();
                    password_textbox.Clear();
                    checkBox1.Checked = false;

                    return;
                }
                MessageBox.Show("Sign in successful as a User");
                username_textbox.Clear();
                password_textbox.Clear();
                checkBox1.Checked = false; 

            }


        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
         
            username_textbox.Clear();
            password_textbox.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
