using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numsyscal
{
    public partial class Form1 : Form
    {
        public string numericSystem = "Dec";
        public string newNumericSystem = "Dec";
        int numCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void numsysbtn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            newNumericSystem = b.Text;
            if (textBox1.Text != "")
            {
                switch (numericSystem)
                {
                    case "Dec":
                        switch (newNumericSystem)
                        {
                            case "Hex":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 10), 16);
                                break;
                            case "Bin":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 10), 2);
                                break;
                            case "Oct":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 10), 8);
                                break;
                        }
                        break;
                    case "Hex":
                        switch (newNumericSystem)
                        {
                            case "Dec":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 10);
                                break;
                            case "Bin":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 2);
                                break;
                            case "Oct":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 8);
                                break;
                        }

                        break;
                    case "Bin":
                        switch (newNumericSystem)
                        {
                            case "Hex":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 16);
                                break;
                            case "Dec":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 10);
                                break;
                            case "Oct":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 8);
                                break;
                        }
                        break;
                    case "Oct":
                        switch (newNumericSystem)
                        {
                            case "Hex":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 16);
                                break;
                            case "Bin":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 2);
                                break;
                            case "Dec":
                                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 10);
                                break;
                        }

                        break;
                }
            }
            numericSystem = newNumericSystem ;
        }
    }
}
