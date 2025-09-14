namespace CalculatorApp
{

    public abstract class Operation
    {
        public abstract float Operate(int a, int b);
    }

    public class Addition : Operation
    {
        public override float Operate(int a,int b)
        {
            return a + b;
        }
    }
    public class Subtraction : Operation
    {
        public override float Operate(int a, int b)
        {
            return a - b;
        }
    }
    public class Multiplication : Operation
    {
        public override float Operate(int a, int b)
        {
            return a * b;
        }
    }
    public class Division : Operation
    {
        public override float Operate(int a, int b)
        {
            if (b == 0)
            {
                MessageBox.Show("Division By 0 is not Allowed");
                return 0;
            }
            return a / b;
        }
    }
    public partial class Form1 : Form
    {
        private int _firstNum;
        private int _secondNum;
        private float _result;
        private Operation _op;
        bool _flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input_box.Text += btn.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            input_box.Clear();
            _firstNum = 0;
            _secondNum = 0;
            _result = 0;
        }
        private void btn_arith_Click(object sender, EventArgs e)
        {  
            if(input_box.Text == "")
            {
                return;
            }
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+":
                    _firstNum = Convert.ToInt32(input_box.Text);
                    _op = new Addition();
                    _flag = true;
                    break;
                case "-":
                    _firstNum = Convert.ToInt32(input_box.Text);
                    _op = new Subtraction();
                    _flag = true;
                    break;
                case "*":
                    _firstNum = Convert.ToInt32(input_box.Text);
                    _op = new Multiplication();
                    _flag = true;
                    break;
                case "/":
                    _firstNum = Convert.ToInt32(input_box.Text);
                    _op = new Division();
                    _flag = true;
                    break;                   
                default:
                    break;

            }
            input_box.Clear();
        }
        private void btn_res_Click(object sender, EventArgs e)
        {
            if (_flag)
            {    
                if(input_box.Text=="")
                {
                    return;
                }
                _secondNum = Convert.ToInt32(input_box.Text);
                input_box.Clear();

                _result += _op.Operate(_firstNum, _secondNum);
                input_box.Text = Convert.ToString(_result);

                _firstNum = 0;
                _secondNum = 0;
                _result = 0;
            }
        }
    }
}
