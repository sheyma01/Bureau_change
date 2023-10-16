using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjcalculBureauChange
{
    public partial class frmCalculStandard : Form
    {
        public frmCalculStandard()
        {
            InitializeComponent();
        }
        double val;
        char op;
        private void frmCalculStandard_Load(object sender, EventArgs e)
        {

        }
        private void ecrire(string valeur)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = valeur;
            }
            else
            {
                txtres.Text = txtres.Text + valeur;

            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ecrire("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ecrire("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ecrire("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ecrire("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ecrire("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ecrire("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ecrire("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ecrire("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ecrire("9");
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '+';
            txtres.Text = "0";
        }

        private void btnsous_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '-';
            txtres.Text = "0";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '*';
            txtres.Text = "0";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '/';
            txtres.Text = "0";
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '%';
            txtres.Text = "0";
        }

        private void btnracine2_Click(object sender, EventArgs e)
        {
            val = Math.Sqrt(Convert.ToDouble(txtres.Text));
            txtres.Text = (val.ToString());

        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            val = Math.Pow(Convert.ToDouble(txtres.Text), 2);
            txtres.Text = val.ToString();
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            val = 1 / Convert.ToSingle(txtres.Text);
            txtres.Text = val.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtres.Text = "0";

        }

        private void egal_Click(object sender, EventArgs e)
        {
            if (op == '+')
            {
                val = val + Convert.ToDouble(txtres.Text);
                txtres.Text = val.ToString();
            }
            if (op == '-')
            {
                val = val - Convert.ToDouble(txtres.Text);
                txtres.Text = val.ToString();
            }
            if (op == '/')
            {
                if (txtres.Text == "0")
                {
                    txtres.Text = "impossible de diviser par Zéro";
                }
                else
                {
                    val = val / Convert.ToDouble(txtres.Text);
                    txtres.Text = val.ToString();
                }

            }
            if (op == '*')
            {
                val = val * Convert.ToDouble(txtres.Text);
                txtres.Text = val.ToString();
            }
            if (op == '%')
            {
                val = val % Convert.ToDouble(txtres.Text);
                txtres.Text = val.ToString();
            }
            if (op == '^')
            {
                val = Math.Pow(val, Convert.ToDouble(txtres.Text));
                txtres.Text = val.ToString();
            }
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            if (txtres.Text.Contains(".") == false)
            {
                txtres.Text = txtres.Text + ".";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ecrire("0");
        }

        private void btnpm_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text) * (-1);
            txtres.Text = val.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtres.Text = "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if (txtres.Text.Length > 0)
            {
                txtres.Text = txtres.Text.Remove(txtres.Text.Length - 1, 1);

            }
            if (txtres.Text.Length == 0)
            {
                txtres.Text = "0";
            }

        }
    }
}
