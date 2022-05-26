using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace May_Tinh_Cam_Tay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double data1, data2;
        string phep ="null";

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"../../thach.jpg");
            Bitmap objBitmap = new Bitmap(myimage, new Size(350, 450));
            BackgroundImage = objBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Text = "";
            textBox1.Text += button1.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Text = "";
            textBox1.Text += button2.Text;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Text = "";
            textBox1.Text += button3.Text;
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Text = "";
            textBox1.Text += button4.Text;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Text = "";
            textBox1.Text += button5.Text;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Text = "";
            textBox1.Text += button6.Text;
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Text = "";
            textBox1.Text += button7.Text;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Text = "";
            textBox1.Text += button8.Text;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Text = "";
            textBox1.Text += button9.Text;
            

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.Text = "";
            textBox1.Text += button0.Text;
           
        }

        private void sum_Click(object sender, EventArgs e)
        {
            if (textBox2.Text =="")
                data1 = Convert.ToDouble(textBox1.Text);
            else
                data1 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = sum.Text;
            phep = "sum";
            textBox1.Text = "";

        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                data1 = Convert.ToDouble(textBox1.Text);
            else
                data1 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = sub.Text;
            phep = "sub";
            textBox1.Text = "";

        }
        /*ket qua*/
        private void equal_Click(object sender, EventArgs e)
        {
            data2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            if (phep == "sum")
                textBox2.Text = Convert.ToString(data1 + data2);
            else if (phep =="sub")
                textBox2.Text = Convert.ToString(data1 - data2);
            else if (phep == "mul")
                textBox2.Text = Convert.ToString(data1 * data2);
            else if (phep == "div")
                textBox2.Text = Convert.ToString(data1 / data2);
            phep = "null";
            textBox3.Text = "";
           
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                data1 = Convert.ToDouble(textBox1.Text);
            else
                data1 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = mul.Text;
            phep = "mul";
            textBox1.Text = "";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void div_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                data1 = Convert.ToDouble(textBox1.Text);
            else
                data1 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = div.Text;
            phep = "div";
            textBox1.Text = "";
        }
    }
}
