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
    public partial class frmCalculScientifique : Form
    {
        public frmCalculScientifique()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCalculScientifique_Load(object sender, EventArgs e)
        {
            btnMR.Enabled = false;
            btnMC.Enabled=false;
        }
        double val;
        char op;
        private void ecrire(string valeur)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = valeur;
                txtrespetit.Text = valeur;
            }
            else
            {
                txtrespetit.Text = txtres.Text+valeur;
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

        private void btn0_Click_1(object sender, EventArgs e)
        {
            ecrire("0");
        }

        private void btnpm_Click(object sender, EventArgs e)
        {
            val=Convert.ToSingle(txtres.Text)*(-1);
            txtrespetit.Text = val.ToString();
            txtres.Text = val.ToString();
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            ecrire("3");

        }

        private void btn4_Click_1(object sender, EventArgs e)
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

        private void btnC_Click(object sender, EventArgs e)
        {
            txtres.Text="0";
            txtrespetit.Text="";
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            if (txtres.Text.Contains(".") == false)
            {
                txtres.Text = txtres.Text + ".";
                txtres.Text = txtrespetit.Text + ".";
            }
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            val = 1/Convert.ToSingle(txtres.Text);
            txtrespetit.Text = "1/("+txtres.Text+")";
            txtres.Text = val.ToString();
        }

        private void btn10x_Click(object sender, EventArgs e)
        {
            val= Math.Pow(10, Convert.ToDouble(txtres.Text));
            txtrespetit.Text = "10^("+ txtres.Text+")";
            txtres.Text = val.ToString();
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            val = Math.Pow(Convert.ToDouble(txtres.Text),2);
            txtrespetit.Text = "sqr("+txtres.Text+")";
            txtres.Text = val.ToString();
        }
        static long Factoriel(long n)
        {
            return n > 1 ? n * Factoriel(n - 1) : 1;
        }
        private void btnfact_Click(object sender, EventArgs e)
        {
            txtrespetit.Text = "fact(" + Convert.ToString(txtres.Text) + ")";
            txtres.Text = Convert.ToString(Factoriel(Convert.ToInt32(txtres.Text)));
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            val= Math.Log(Convert.ToDouble(txtres.Text));
            txtrespetit.Text = "ln(" + txtres.Text + ")";
            txtres.Text= val.ToString();
        }

        private void btnabs_Click(object sender, EventArgs e)
        {
            val=Math.Abs(Convert.ToSingle(txtres.Text));
            txtrespetit.Text = "abs(" + txtres.Text + ")"; 
            txtres.Text=(val.ToString());
        }

        private void btnracine2_Click(object sender, EventArgs e)
        {
            val = Math.Sqrt(Convert.ToDouble(txtres.Text));
            txtrespetit.Text = "√(" + txtres.Text+")";
            txtres.Text = (val.ToString());
        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            txtrespetit.Text = "Π";
            txtres.Text = "3.141592653589793";
        }

        private void btne_Click(object sender, EventArgs e)
        {
            txtres.Text = "2.718281828459045";
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            val = Math.Log10(Convert.ToDouble(txtres.Text));
            txtrespetit.Text="log("+txtres.Text+")";
            txtres.Text = val.ToString();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '+';
            //txtrespetit.Text = txtrespetit.Text+op;
            txtres.Text = "0";
        }

        private void btnegal_Click(object sender, EventArgs e)
        {
            if (op == '+')
            {
                txtrespetit.Text = "=" + txtrespetit.Text+ op + val ;
                val = val + Convert.ToDouble(txtres.Text);
                txtres.Text = val.ToString();
            }
            if (op == '-')
            {
                txtrespetit.Text = "=" + txtrespetit.Text + op + val;
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
                    txtrespetit.Text = "=" + txtrespetit.Text + op + val;
                    val = val / Convert.ToDouble(txtres.Text);
                    txtres.Text = val.ToString();
                }
                
            }
            if (op == '*')
            {
                txtrespetit.Text = "=" + txtrespetit.Text + op + val;
                val = val * Convert.ToDouble(txtres.Text);
                txtres.Text = val.ToString();
            }
            if (op == '%')
            {
                txtrespetit.Text = "=" + txtrespetit.Text + op + val;
                val = val % Convert.ToDouble(txtres.Text);
                txtres.Text = val.ToString();
            }
            if (op == '^')
            {
                txtrespetit.Text = "=" + txtrespetit.Text + op + val;
                val = Math.Pow(val, Convert.ToDouble(txtres.Text));
                txtres.Text = val.ToString();
            }

        }

        private void btnsous_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '-';
            //txtrespetit.Text = txtrespetit.Text + op;
            txtres.Text = "0";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '*';
            //txtrespetit.Text = txtrespetit.Text + op;
            txtres.Text = "0";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '/';
            //txtrespetit.Text = txtrespetit.Text + op;
            txtres.Text = "0";
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '%';
            //txtrespetit.Text = txtrespetit.Text + op;
            txtres.Text = "0";
        }

        private void btnxy_Click(object sender, EventArgs e)
        {
            val = Convert.ToSingle(txtres.Text);
            op = '^';
            //txtrespetit.Text = txtrespetit.Text + op;
            txtres.Text = "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if(txtres.Text.Length > 0)
            {
                txtres.Text = txtres.Text.Remove(txtres.Text.Length - 1, 1);
                txtrespetit.Text = txtres.Text.Remove(txtres.Text.Length - 1, 1);

            }
            if (txtres.Text.Length == 0 ) 
            {
                txtrespetit.Text = "0";
                txtres.Text = "0";
            }
        }

        private void btnexp_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(txtres.Text);
            val = d*Math.Pow(10.0,d);
            txtrespetit.Text="exp("+txtres.Text+")";
            txtres.Text = val.ToString();
        }

        private void txtres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpg_Click(object sender, EventArgs e)
        {
            txtrespetit.Text += "(";
        }

        private void btnpd_Click(object sender, EventArgs e)
        {
            txtrespetit.Text += ")";

        }

        private void btnMR_Click(object sender, EventArgs e)
        {
        }

        private void btnMp_Click(object sender, EventArgs e)
        {
            btnMR.Enabled = btnMC.Enabled = true;

        }

        private void btnMm_Click(object sender, EventArgs e)
        {
            btnMR.Enabled = btnMC.Enabled = true;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            btnMR.Enabled = btnMC.Enabled = true;
        }
    }
}
