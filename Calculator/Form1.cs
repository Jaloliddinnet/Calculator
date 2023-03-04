namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            label2.Text += btn.Text;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
        }

        private void Ammalllar(object sender, EventArgs e)
        {
            var bt = (Button)sender;
            label3.Text = label2.Text + " " + bt.Text;
            label2.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + " " + label2.Text  ;
            string[] text = label3.Text.Split();

            switch (text[1]) 
            {
                case "+":
                    {
                        label2.Text = (double.Parse(text[0]) + double.Parse(text[2])).ToString();
                        break;
                    }
                case "-":
                    {
                        label2.Text = (double.Parse(text[0]) - double.Parse(text[2])).ToString();
                        break;
                    }
                case "x":
                    {
                        label2.Text = (double.Parse(text[0]) * double.Parse(text[2])).ToString();
                        break;
                    }
                case "/":
                    {
                        label2.Text = (double.Parse(text[0]) / double.Parse(text[2])).ToString();
                        break;
                    }
                case "1/x":
                    {
                        label2.Text = ( 1 / double.Parse(text[0])).ToString();
                        break;
                    }
                case "x^2":
                    {
                        label2.Text = (double.Parse(text[0]) * double.Parse(text[0])).ToString();
                        break;
                    }
                case "x^(1/2)":
                    {
                        label2.Text = ((float)Math.Sqrt(double.Parse(text[0]))).ToString();
                        break;
                    }
                case "%":
                    {
                        label2.Text = ((double.Parse(text[2]) * 100 )/ double.Parse(text[0])).ToString();
                        break;
                    }
                case "Q":
                    {
                        label2.Text = (double.Parse(text[0]) % double.Parse(text[2])).ToString();
                        break;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}