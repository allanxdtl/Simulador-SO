namespace CalculadoraAplicacion
{
    public partial class Form1 : Form
    {
        double fstNum, sndNum;
        string oper;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text=="0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text+"7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            oper = "+";
            txtDisplay.Text = "";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            oper = "-";
            txtDisplay.Text = "";
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            oper = "*";
            txtDisplay.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            oper = "/";
            txtDisplay.Text = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q=Convert.ToDouble(txtDisplay.Text); 
            txtDisplay.Text=Convert.ToString(-1*q);    
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            string f, s;
            f=Convert.ToString(fstNum);
            s=Convert.ToString(sndNum);
            f = "";
            s = "";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length>0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length-1,1);
            }
            if (txtDisplay.Text== "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            sndNum=double.Parse(txtDisplay.Text);
            switch (oper)
            {
                case "+":
                    txtDisplay.Text=(fstNum+sndNum).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (fstNum - sndNum).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (fstNum * sndNum).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (fstNum / sndNum).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = ".";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + ".";
            }
        }
    }
}