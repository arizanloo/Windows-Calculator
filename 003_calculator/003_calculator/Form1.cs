using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _003_calculator
{
    public partial class Form1 : Form
    {
        double x, y, z; // Variables
        string op; // Operators
        Boolean flag;
        Boolean pow = false;
        public Form1()
        {
            InitializeComponent();
        }
        //Get The Numbers 
        private void Numbers(object sender, EventArgs e)
        {
            if (flag == true)
            {
                txtresult.Text = "";
                flag = false;
            }
            txtresult.Text += ((Button)sender).Text;
        }
        //Get The Operators
        private void Operators(object sender, EventArgs e)
        {
            if (txtresult.Text == "" || txtresult.Text == ".")
                return;
        
            x = Convert.ToDouble(txtresult.Text);
            op = ((Button)sender).Text;
            flag = true;
        }
        // Calculate 
        private void btnequal_Click(object sender, EventArgs e)
        {
            int i=0;
            if (txtresult.Text == "")
                return;
            y = Convert.ToDouble(txtresult.Text);

            switch (op)
            {
                case "+":
                    z = x + y;
                    break;
                case "-":
                    z = x - y;
                    break;
                case "*":
                    z = x * y;
                    break;
                case "/":
                    z = x / y;
                    break;
            }
            txtoperators.Text = Convert.ToString(x) +" " + Convert.ToString(op) + " " +Convert.ToString(y) + " = ";
            txtresult.Text = Convert.ToString(z);

        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {
            btnpoint.Enabled = !txtresult.Text.Contains("."); // if "." already exist, disable "." Button
            btnspace.Enabled = Convert.ToBoolean(txtresult.Text.Length);// if txtresult.Text is equal to null, disable txtresult
        }
        //Backspace
        private void btnspace_Click(object sender, EventArgs e)
        {
            if (txtresult.TextLength > 0)
                txtresult.Text = txtresult.Text.Substring(0, txtresult.Text.Length-1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtresult_TextChanged(null, null);
        }
        //Clear Text Boxes
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
            txtoperators.Text = "";
        }
        //Keyboard Buttons
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Button x in panel1.Controls)
                if (x.Text == e.KeyChar.ToString())
                    x.Focus();
            Button temp= new Button();
            temp.Text= e.KeyChar.ToString();
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                Numbers(temp, null);
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                Operators(temp, null);
            else if (e.KeyChar == '=')
                btnequal_Click(null, null);
            else if (e.KeyChar == '.' && txtresult.Text.Contains(".") == false)
                Numbers(temp, null);
            else if (e.KeyChar == '\b')
                btnspace_Click(null, null);
        }
        //Exit Button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Disable Panel1 and work with keyboard
        //You can also disable KeyPreview while Panel1 is Enabled by uncommenting "this.KeyPreview" lines
        private void btnonoff_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;
            if (btnonoff.Text == "ON")
            {
                btnonoff.Text = "OFF";
                //this.KeyPreview = true;
            }
            else if (btnonoff.Text == "OFF")
            {
                btnonoff.Text = "ON";
                //this.KeyPreview = false;
            }
        }

        private void btn_PI_Click(object sender, EventArgs e)
        {
            txtresult.Text = Convert.ToString(Math.PI);
        }
        //Power 2 of x
        private void btnpow2_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "")
                return;
            x = Convert.ToDouble(txtresult.Text);
            z = x * x;
            txtoperators.Text = Convert.ToString(x) + "^(2)";
            txtresult.Text = Convert.ToString(z);
        }
        //Power y of x
        private void btnpow_Click(object sender, EventArgs e)
        {  
            if (txtresult.Text == "")
                return;
            if (pow == false)
            {
                x = Convert.ToDouble(txtresult.Text);
                txtoperators.Text = x + "^(";
                txtresult.Text = "";
                pow = true;
            }
            else
            {
                y = Convert.ToDouble(txtresult.Text);
                Power(x, y);
                pow = false;
            }       
        }
        void Power(double Base, double Pow)
        {
            double pow = Math.Pow(Base, Pow);
            txtoperators.Text = Base + "^(" + Pow + ")";
            txtresult.Text = Convert.ToString(pow);
        }
        //x Cosine
        private void btncos_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "")
                return;
            x = Convert.ToDouble(txtresult.Text);
            double cosangle = (x * (Math.PI)) / 180;
            z = Math.Cos(cosangle);
            txtoperators.Text = "cosd(" + x + ")";
            txtresult.Text = Convert.ToString(z);
        }
        //x Sine
        private void btnsin_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "")
                return;
            x = Convert.ToDouble(txtresult.Text);
            double sinangle = (x * (Math.PI)) / 180;
            z = Math.Sin(sinangle);
            txtoperators.Text = "sind(" + x + ")";
            txtresult.Text = Convert.ToString(z);
        }
        //x Tangent
        private void btntan_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "")
                return;
            x = Convert.ToDouble(txtresult.Text);
            double tanangle = x * (Math.PI / 180);
            z = Math.Tan(tanangle);
            txtoperators.Text = "tand(" + x + ")";
            txtresult.Text = Convert.ToString(z);
        }
    }
}
