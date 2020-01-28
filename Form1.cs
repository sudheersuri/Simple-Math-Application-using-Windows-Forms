using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudheer_week4
{
    public partial class Form1 : Form
    {
        Random rand1 = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Following code initializes defaults
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            AddRadio.Checked = true;
            NumLabel1.Text = rand1.Next(1, 10).ToString();
            NumLabel2.Text = rand1.Next(1, 10).ToString();

        }
        //Following code checks result given by user
        private void AmIRightButton_Click(object sender, EventArgs e)
        {
            //int.TryParse(x,out int result);
            double.TryParse(NumLabel1.Text, out double num1);
            double.TryParse(NumLabel2.Text, out double num2);
            double.TryParse(ResultTextBox.Text, out double result);

            if (ResultTextBox.Text!="")
            {
                if (AddRadio.Checked == true)
                    ResultLabel.Text = (num1 + num2 == result) ? "Correct!" : "Wrong!";
                else if (SubtractRadio.Checked == true)
                    ResultLabel.Text = (num1 - num2 == result) ? "Correct!" : "Wrong!";
                else if (DivideRadio.Checked == true)
                    ResultLabel.Text = (num1 / num2 == result) ? "Correct!" : "Wrong!";
                else if (MultiplyRadio.Checked == true)
                    ResultLabel.Text = (num1 * num2 == result) ? "Correct!" : "Wrong!";
                if (ResultLabel.Text == "Correct!")
                    ResultLabel.ForeColor = Color.Green;
                else
                    ResultLabel.ForeColor = Color.Red;

            }
            else
            {
                ResultLabel.Text = "Please answer";
                ResultLabel.ForeColor = Color.Red;
                ResultTextBox.Focus();
                ResultTextBox.BackColor = Color.Red;
            }

        }
        //Following code decides what application has to do when radio button changed
        private void AddRadio_CheckedChanged(object sender, EventArgs e)
        {
            ResultTextBox.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            NumLabel1.Text = rand1.Next(1, 10).ToString();
            NumLabel2.Text = rand1.Next(1, 10).ToString();
            OpLabel.Text = "+";
        }

        private void SubtractRadio_CheckedChanged(object sender, EventArgs e)
        {
            ResultTextBox.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            NumLabel1.Text = rand1.Next(1, 10).ToString();
            NumLabel2.Text = rand1.Next(1, 10).ToString();
            OpLabel.Text = "-";
        }

        private void DivideRadio_CheckedChanged(object sender, EventArgs e)
        {
            ResultTextBox.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            NumLabel1.Text = rand1.Next(1, 10).ToString();
            NumLabel2.Text = rand1.Next(1, 10).ToString();
            OpLabel.Text = "/";
        }

        private void MultiplyRadio_CheckedChanged(object sender, EventArgs e)
        {
            ResultTextBox.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            NumLabel1.Text = rand1.Next(1, 10).ToString();
            NumLabel2.Text = rand1.Next(1, 10).ToString();
            OpLabel.Text = "*";
        }

        private void NxtQButton_Click(object sender, EventArgs e)
        {
            NumLabel1.Text = rand1.Next(1, 10).ToString();
            NumLabel2.Text = rand1.Next(1, 10).ToString();
            ResultLabel.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
        }

        private void ImDoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {
            ResultTextBox.BackColor = Color.White;
        }
    }
}
