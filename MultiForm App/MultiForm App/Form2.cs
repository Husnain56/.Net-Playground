using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm_App
{
    public partial class Form2 : Form
    {
        private LoginDetails details;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(LoginDetails Details)
        {
            InitializeComponent();
            this.details = Details;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("What now??");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_wc.Text = "Welcome " + details.Username;
        }
    }
}
