using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Calkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculator";
        }

        
        double rezult = 0;
        bool isSign = false;
        string path = "MyFile.txt";
        string sign = "";
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (isSign))
                textBox1.Clear();
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
            isSign = false;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (rezult != 0)
            {
                ravBtn.PerformClick();
                sign = button.Text;
                rezLB.Text = rezult + " " + sign;
                isSign = true;
            }
            else
            {
                sign = button.Text;
                rezult = double.Parse(textBox1.Text);
                rezLB.Text = rezult + " " + sign;
                isSign = true;
            }
        }


        private void plminBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }
        private void cBtn_Click(object sender, EventArgs e)
        {            
            rezult = 0;
            textBox1.Clear();
        }
        private void procBtn_Click(object sender, EventArgs e)
        {
            if (sign == "+" || sign == "-")
            {
                textBox1.Text = (rezult / 100 * double.Parse(textBox1.Text)).ToString();
            }
            if (sign == "*" || sign == "/")
            {
                textBox1.Text = (double.Parse(textBox1.Text) / 100).ToString();
            }
        }

        private void ravBtn_Click(object sender, EventArgs e)
        {
            File.AppendAllText(path, $"{rezult} {sign} {textBox1.Text} \n");
            switch (sign)
            {
                case "+":
                    textBox1.Text = (rezult + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (rezult - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (rezult * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (rezult / double.Parse(textBox1.Text)).ToString();
                    break;

                default: break;
            }
            rezult = double.Parse(textBox1.Text);
            rezLB.Text = "";
        }

        private void histBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string[] hist = File.ReadAllLines(path);
                for (int i = 0; i < hist.Length; i++)
                {
                    textBox1.Text = hist[i];                    
                }
            }
            else { textBox1.Text = "No history"; }               
        }

        private void clearHistBtn_Click(object sender, EventArgs e)
        {
            File.Delete(path);
            textBox1.Clear();
        }
    }
}
