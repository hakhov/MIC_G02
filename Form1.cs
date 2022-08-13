namespace MyCalc
{
    public partial class Form1 : Form
    {
        double numberOne;
        double numberTwo;
        string operation;
        bool btpoint = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btOne_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txResult.Text == "0" || txResult.Text == "Error")
            {
                txResult.Clear();
            }
            txResult.Text += button.Text;
        }

        private void btPluse_Click(object sender, EventArgs e)
        {
            numberOne = double.Parse(txResult.Text);
            txResult.Text = "0";

            Button button = (Button)sender;
            operation = button.Text;
            btpoint = false;
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            numberTwo = double.Parse(txResult.Text); //3

            switch (operation)
            {
                case "+":
                    txResult.Text = (numberOne + numberTwo).ToString();
                    break;
                case "-":
                    txResult.Text = (numberOne - numberTwo).ToString();
                    break;
                case "*":
                    txResult.Text = (numberOne * numberTwo).ToString();
                    break;
                case "/":
                    if (numberTwo == 0)
                        txResult.Text = "Error";
                    else
                        txResult.Text = (numberOne / numberTwo).ToString();
                    break;
            }
        }

        private void btPoint_Click(object sender, EventArgs e)
        {
            if (btpoint) return;
                        txResult.Text += btPoint.Text;
            btpoint = true;

        }

        private void btDoubleZero_Click(object sender, EventArgs e)
        {
            if (txResult.Text == "0" || txResult.Text == "Error") return;
            txResult.Text += btDoubleZero.Text;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (txResult.Text.Length != 1)
            {

                txResult.Text = txResult.Text.Remove(txResult.Text.Length - 1, 1);
            }
            else
            {
                txResult.Text = "0";
            }
        }

        private void btPlusMinus_Click(object sender, EventArgs e)
        {

            //if (txResult.Text.StartsWith("-"))
            //{
            //    txResult.Text.Remove(0, 1);
            //}
            //else
            //{
            //    txResult.Text.Replace("-", "");
            //}
            txResult.Text = (int.Parse(txResult.Text) * (-1)).ToString();
        }
    }
}