using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Util util = new Util();

        public Form1()
        {
            InitializeComponent();
        }

        public void buttonNumPress(string a)
        {
            if (util.Num1 != "" && util.Action == "")
            {

            }
            else
            {
                if (util.Num != "0" && a == "0")
                {
                    util.Num += "0";
                }
                else if (util.Num == "0")
                {
                    util.Num = a;
                }
                else
                {
                    util.Num += a;
                }
            }
            textBox1.Text = util.Num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonNumPress("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonNumPress("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonNumPress("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonNumPress("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonNumPress("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonNumPress("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonNumPress("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonNumPress("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonNumPress("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            buttonNumPress("0");
        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {
            if (util.Num1 == "" && util.Num == "")
            {

            }
            else if (util.Num1 == "" && util.Num != "")
            {
                util.Num1 = util.Num;
                util.Num = "";
                util.Action = "+";
                textBox1.Text = util.Num;
            }
            else if (util.Num == "")
            {
                util.Action = "+";
            }
            else
            {
                util.Result();
                if (Convert.ToInt32(util.Num1) > 999999999 || Convert.ToInt32(util.Num1) < -999999999)
                {
                    util.Action = "";
                    util.Num1 = "";
                    textBox1.Text = "EXCEEDED";
                }
                else
                {
                    textBox1.Text = util.Num;
                }
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (util.Num1 == "" && util.Num == "")
            {

            }
            else if (util.Num1 == "" && util.Num != "")
            {
                util.Num1 = util.Num;
                util.Num = "";
                util.Action = "-";
                textBox1.Text = util.Num;
            }
            else if (util.Num == "")
            {
                util.Action = "-";
            }
            else
            {
                util.Result();
                if (Convert.ToInt32(util.Num1) > 999999999 || Convert.ToInt32(util.Num1) < -999999999)
                {
                    util.Action = "";
                    util.Num1 = "";
                    textBox1.Text = "EXCEEDED";
                }
                else
                {
                    textBox1.Text = util.Num;
                }
            }
        }

        public void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (util.Num1 == "" && util.Num == "")
            {

            }
            else if (util.Num1 == "" && util.Num != "")
            {
                util.Num1 = util.Num;
                util.Num = "";
                util.Action = "*";
                textBox1.Text = util.Num;
            }
            else if (util.Num == "")
            {
                util.Action = "*";
            }
            else
            {
                util.Result();
                if (Convert.ToInt32(util.Num1) > 999999999 || Convert.ToInt32(util.Num1) < -999999999)
                {
                    util.Action = "";
                    util.Num1 = "";
                    textBox1.Text = "EXCEEDED";
                }
                else
                {
                    textBox1.Text = util.Num;
                }
            }
        }

        public void buttonDivide_Click(object sender, EventArgs e)
        {
            if (util.Num1 == "" && util.Num == "")
            {

            }
            else if (util.Num1 == "" && util.Num != "")
            {
                util.Num1 = util.Num;
                util.Num = "";
                util.Action = "/";
                textBox1.Text = util.Num;
            }
            else if (util.Num == "")
            {
                util.Action = "/";
            }
            else
            {
                util.Result();
                if (util.Exception != "")
                {
                    textBox1.Text = util.Exception;
                    util.Exception = "";
                }
                else if (Convert.ToInt32(util.Num1) > 999999999 || Convert.ToInt32(util.Num1) < -999999999)
                {
                    util.Action = "";
                    util.Num1 = "";
                    textBox1.Text = "EXCEEDED";
                }
                else
                {
                    textBox1.Text = util.Num;
                }
            }
        }

        public void buttonClear_Click(object sender, EventArgs e)
        {
            util.Num = "";
            util.Num1 = "";
            util.Action = "";
            textBox1.Text = util.Num;
        }

        public void buttonSign_Click(object sender, EventArgs e)
        {
            if (util.Num != "" && util.Num != "0")
            {
                if (util.Num.Substring(0, 1) == "-")
                {
                    util.Num = util.Num.Substring(1, util.Num.Length - 1);
                }
                else
                {
                    util.Num = util.Num.Insert(0, "-");
                }
            }
            textBox1.Text = util.Num;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (util.Num1 != "" && util.Num != "")
            {
                util.Result();
                if (util.Exception != "")
                {
                    textBox1.Text = util.Exception;
                    util.Exception = "";
                }
                else if (Convert.ToInt32(util.Num1) > 999999999 || Convert.ToInt32(util.Num1) < -999999999)
                {
                    util.Num1 = "";
                    textBox1.Text = "EXCEEDED";
                }
                else
                {
                    textBox1.Text = util.Num1;
                }
            }
        }
    }
}
