using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double ResultValue = 0;
        String OperationPerformed = "";
        bool isOperationPerformed=false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if((textBox_Result.Text=="0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed= false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }else
                textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ResultValue != 0)
            {
                button18.PerformClick();
                OperationPerformed = button.Text;
                labelCurr_Op.Text = ResultValue + " " + OperationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                OperationPerformed = button.Text;
                ResultValue = Double.Parse(textBox_Result.Text);
                labelCurr_Op.Text = ResultValue + " " + OperationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            ResultValue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (OperationPerformed)
            {
                case "+":
                    textBox_Result.Text = (ResultValue+Double.Parse(textBox_Result.Text)).ToString(); 
                    break;
                case "-":
                    textBox_Result.Text = (ResultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (ResultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (ResultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                    default:
                    break;
            }
            ResultValue= Double.Parse(textBox_Result.Text);
            labelCurr_Op.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
