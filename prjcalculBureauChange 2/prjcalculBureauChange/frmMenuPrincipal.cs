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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void quitterProgrammeCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manuelUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmanuelutilisation fc = new frmmanuelutilisation();
            fc.MdiParent = MdiParent;
            fc.Show();

        }



        private void mnuscientifique_Click(object sender, EventArgs e)
        {
            frmCalculScientifique fc = new frmCalculScientifique();
            fc.MdiParent = MdiParent;
            fc.Show();
        }

        private void mnustandard_Click(object sender, EventArgs e)
        {
            frmCalculStandard std = new frmCalculStandard();
            std.MdiParent = MdiParent;
            std.Show();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmapropos std = new frmapropos();
            std.MdiParent = MdiParent;
            std.Show();
        }

        private void quitterProgrammeCtrlXToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string msg = "Êtes vous sûr de vouloir fermer cette application ?";
            string tit = "Fermeture de l'application ";

            if (MessageBox.Show(msg, tit, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void versionLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChange fc = new frmChange();
            fc.MdiParent = MdiParent;
            fc.Show();

        }

        private void mnuversionEnLigne_Click(object sender, EventArgs e)
        {
            frmChange2 fc = new frmChange2();
            fc.MdiParent = MdiParent;
            fc.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCalculStandard std = new frmCalculStandard();
            std.MdiParent = MdiParent;
            std.Show();
        }

        private void ScientificCalculator_Click(object sender, EventArgs e)
        {
            frmCalculScientifique fc = new frmCalculScientifique();
            fc.MdiParent = MdiParent;
            fc.Show();
        }

        private void ExchangeRate_Click(object sender, EventArgs e)
        {
            frmChange fc = new frmChange();
            fc.MdiParent = MdiParent;
            fc.Show();
        }

        private void CurrencyConverter_Click(object sender, EventArgs e)
        {
            frmChange2 fc = new frmChange2();
            fc.MdiParent = MdiParent;
            fc.Show();
        }
    }
}
