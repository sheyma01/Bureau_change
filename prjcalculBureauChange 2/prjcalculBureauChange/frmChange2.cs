using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace prjcalculBureauChange
{
    public partial class frmChange2 : Form
    {
        public frmChange2()
        {
            InitializeComponent();
        }
        public struct devise
        {
            public string CurrencyName;
            public string rate;

        }
        devise[] tabcurrencies;
        
        private void frmChange2_Load(object sender, EventArgs e)
        {
            cbocountries1.Items.Add("Select the country");
            cbocountries1.SelectedIndex = 0;
            cbocountries2.Items.Add("Select the country");
            cbocountries2.SelectedIndex = 0;
            tabcurrencies = new devise[150];
            XmlDocument file = new XmlDocument();
            XmlNodeList nodes = file.SelectNodes("/*/*/*/*");
            file.Load(@"https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            for (int i = 0; i < nodes.Count; i++)
            {
                tabcurrencies[i].CurrencyName = nodes[i].Attributes[0].Value;
                cbocountries1.Items.Add(  nodes[i].Attributes[0].Value );
                cbocountries2.Items.Add( nodes[i].Attributes[0].Value );

                tabcurrencies[i].rate = nodes[i].Attributes[1].Value;
                
            }
            lblinfo.Text = "Bienvenu au programme de taux d'échange!" + "\n" + DateTime.Now.ToString();
            txtmontant1.Text = "1";

        }

        private void btnswitch_Click(object sender, EventArgs e)
        {
            //c'est pour permuter les pays
           ( cbocountries1.SelectedItem , cbocountries2.SelectedItem)= (cbocountries2.SelectedItem, cbocountries1.SelectedItem);
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            string msg = "Êtes vous sûr de vouloir fermer cette application ?";
            string tit = "Fermeture de l'application ";

            if (MessageBox.Show(msg, tit, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMiseajour_Click(object sender, EventArgs e)
        {
            lblinfo.Text = "Bienvenu au programme de taux d'échange!" + "\n"+DateTime.Now.ToString();
            XmlDocument file = new XmlDocument();
            XmlNodeList nodes = file.SelectNodes("/*/*/*/*");
            file.Load(@"https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");

        }

        private void cbocountries1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncalculer_Click(object sender, EventArgs e)
        {
             //cbocountries1.selectedItem
            Int32 montantentre = Convert.ToInt32(txtmontant1.Text);
            Single montant1=1,montant2=1,total;
            String titre1 = cbocountries1.SelectedItem.ToString();
            String titre2 = cbocountries2.SelectedItem.ToString();

            
           
            for (int j = 0; j < tabcurrencies.Length; j++) 
            { 
                if (titre2==(tabcurrencies[j].CurrencyName))
                {
                    montant1 = (montantentre * Convert.ToSingle(tabcurrencies[j].rate)) ;
                }
                
            }
            for (int j = 0; j < tabcurrencies.Length; j++)
            {
                if (titre1==(tabcurrencies[j].CurrencyName))
                {
                    montant2 =  Convert.ToSingle(tabcurrencies[j].rate);
                }

            }

            total = montant1/ montant2;
            txtmontant2.Text = total.ToString();
                
            
            
        }

        private void txtmontant1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            frmReçu fc = new frmReçu();
            fc.MdiParent = MdiParent;
            fc.Show();
        }
    }
}
