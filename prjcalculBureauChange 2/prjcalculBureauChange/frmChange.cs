using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// pour streamwriter et steamreader


namespace prjcalculBureauChange
{
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
        }
        struct Infopays
        {
            public string Nompays;
            public string Devise;
            public Single Taux;
        }

        Infopays[] tabpays;
        int nbpays;
        private void frmChange_Load(object sender, EventArgs e)
        {
            //raddeus.Checked = true;
            tabpays = new Infopays[150];

            StreamReader myfile = new StreamReader("infopays.txt");
            int i = 0;
            cbocountries.Items.Add("Select the country");
            cbocountries.SelectedIndex = 0;
            while (myfile.EndOfStream==false)
            {
                tabpays[i].Nompays = myfile.ReadLine();
                tabpays[i].Devise = myfile.ReadLine();
                tabpays[i].Taux = Convert.ToSingle(myfile.ReadLine());
                i++;
            }


            nbpays = i;
            myfile.Close();
            for (int j = 0; j < nbpays; j++)
            {
                cbocountries.Items.Add(tabpays[j].Nompays);
            }
            txtmontant.Text = "1";
          
        }

        private void cbocountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void lbldeus_Click(object sender, EventArgs e)
        {
           
        }

       

        private void btnconvertir_Click(object sender, EventArgs e)
        {
           

            
        }

        private void raddeus_CheckedChanged(object sender, EventArgs e)
        {

        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void lblaus_Click(object sender, EventArgs e)
        {
            
        }

        private void radaus_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btneffacer_Click(object sender, EventArgs e)
        {
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            

        }

        private void btnquitter_Click_1(object sender, EventArgs e)
        {
            string msg = "Êtes vous sûr de vouloir fermer cette application ?";
            string tit = "Fermeture de l'application ";

            if (MessageBox.Show(msg, tit, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblus1_Click(object sender, EventArgs e)
        {

        }

        private void raddeus_CheckedChanged_1(object sender, EventArgs e)
        {
            lbldevise.Text = "USD";
        }

        private void radaus_CheckedChanged_1(object sender, EventArgs e)
        {
            for (int k = 0; k < nbpays; k++)
            {
                if (tabpays[k].Nompays == cbocountries.SelectedItem.ToString())
                {
                    
                    lbldevise.Text = tabpays[k].Devise;

                    
                }
            }
        }

        private void cbocountries_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectpays = cbocountries.SelectedItem.ToString();

            for (int i = 0; i < nbpays; i++)
            {
                if (tabpays[i].Nompays == selectpays)
                {
                    radaus.Checked = raddeus.Checked = false;
                    lbldevise.Text = "";
                    lbldeus.Text = " USD to " + tabpays[i].Devise;
                    lblaus.Text = tabpays[i].Devise + " to USD";
                    lblus1.Text = "1 USD = " + tabpays[i].Taux + " " + tabpays[i].Devise.ToString();
                    lblus2.Text = "1 " + tabpays[i].Devise.ToString() + " = " + Math.Round(1 / Convert.ToSingle(tabpays[i].Taux), 5) + " USD ";


                }


            }
        }

        private void btnconvertir_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < nbpays; i++)
            {
                if (cbocountries.SelectedItem.ToString() == tabpays[i].Nompays)
                {
                    Single montant;
                    montant = Convert.ToSingle(txtmontant.Text);

                    Single taux = tabpays[i].Taux;


                    if (lbldevise.Text == "USD")
                    {
                        lblresultat.Text = (montant * taux) + " " + tabpays[i].Devise;

                    }
                    else
                    {
                        lblresultat.Text = (montant / taux) + " $";

                    }

                }
            }
        }

        private void btneffacer_Click_1(object sender, EventArgs e)
        {
            txtmontant.Text = "";

        }

        private void txtmontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
