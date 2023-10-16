namespace prjcalculBureauChange
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustandard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuscientifique = new System.Windows.Forms.ToolStripMenuItem();
            this.bureauxChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuversionLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuversionEnLigne = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterProgrammeCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StandardCalculator = new System.Windows.Forms.ToolStripButton();
            this.ScientificCalculator = new System.Windows.Forms.ToolStripButton();
            this.ExchangeRate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.CurrencyConverter = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1549, 48);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmesToolStripMenuItem
            // 
            this.programmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatricesToolStripMenuItem,
            this.bureauxChangeToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterProgrammeCtrlXToolStripMenuItem});
            this.programmesToolStripMenuItem.Name = "programmesToolStripMenuItem";
            this.programmesToolStripMenuItem.Size = new System.Drawing.Size(168, 40);
            this.programmesToolStripMenuItem.Text = "‎&Programmes";
            // 
            // calculatricesToolStripMenuItem
            // 
            this.calculatricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnustandard,
            this.mnuscientifique});
            this.calculatricesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculatricesToolStripMenuItem.Image")));
            this.calculatricesToolStripMenuItem.Name = "calculatricesToolStripMenuItem";
            this.calculatricesToolStripMenuItem.Size = new System.Drawing.Size(441, 44);
            this.calculatricesToolStripMenuItem.Text = "Calculatrices";
            // 
            // mnustandard
            // 
            this.mnustandard.Name = "mnustandard";
            this.mnustandard.Size = new System.Drawing.Size(359, 44);
            this.mnustandard.Text = "Version Standard";
            this.mnustandard.Click += new System.EventHandler(this.mnustandard_Click);
            // 
            // mnuscientifique
            // 
            this.mnuscientifique.Name = "mnuscientifique";
            this.mnuscientifique.Size = new System.Drawing.Size(359, 44);
            this.mnuscientifique.Text = "Version Scientifique";
            this.mnuscientifique.Click += new System.EventHandler(this.mnuscientifique_Click);
            // 
            // bureauxChangeToolStripMenuItem
            // 
            this.bureauxChangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuversionLocal,
            this.mnuversionEnLigne});
            this.bureauxChangeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bureauxChangeToolStripMenuItem.Image")));
            this.bureauxChangeToolStripMenuItem.Name = "bureauxChangeToolStripMenuItem";
            this.bureauxChangeToolStripMenuItem.Size = new System.Drawing.Size(441, 44);
            this.bureauxChangeToolStripMenuItem.Text = "Bureaux Change";
            // 
            // mnuversionLocal
            // 
            this.mnuversionLocal.Name = "mnuversionLocal";
            this.mnuversionLocal.Size = new System.Drawing.Size(323, 44);
            this.mnuversionLocal.Text = "Version Local";
            this.mnuversionLocal.Click += new System.EventHandler(this.versionLocalToolStripMenuItem_Click);
            // 
            // mnuversionEnLigne
            // 
            this.mnuversionEnLigne.Name = "mnuversionEnLigne";
            this.mnuversionEnLigne.Size = new System.Drawing.Size(323, 44);
            this.mnuversionEnLigne.Text = "Version En Ligne";
            this.mnuversionEnLigne.Click += new System.EventHandler(this.mnuversionEnLigne_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(438, 6);
            // 
            // quitterProgrammeCtrlXToolStripMenuItem
            // 
            this.quitterProgrammeCtrlXToolStripMenuItem.Name = "quitterProgrammeCtrlXToolStripMenuItem";
            this.quitterProgrammeCtrlXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.quitterProgrammeCtrlXToolStripMenuItem.Size = new System.Drawing.Size(441, 44);
            this.quitterProgrammeCtrlXToolStripMenuItem.Text = "Quitter Programme ";
            this.quitterProgrammeCtrlXToolStripMenuItem.Click += new System.EventHandler(this.quitterProgrammeCtrlXToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(85, 40);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // toolbarToolStripMenuItem
            // 
            this.toolbarToolStripMenuItem.Checked = true;
            this.toolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            this.toolbarToolStripMenuItem.Size = new System.Drawing.Size(252, 44);
            this.toolbarToolStripMenuItem.Text = "Toolbar";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(252, 44);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelUtilisateurToolStripMenuItem,
            this.toolStripSeparator1,
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(82, 40);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // manuelUtilisateurToolStripMenuItem
            // 
            this.manuelUtilisateurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manuelUtilisateurToolStripMenuItem.Image")));
            this.manuelUtilisateurToolStripMenuItem.Name = "manuelUtilisateurToolStripMenuItem";
            this.manuelUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(342, 44);
            this.manuelUtilisateurToolStripMenuItem.Text = "&Manuel Utilisateur";
            this.manuelUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.manuelUtilisateurToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(339, 6);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(342, 44);
            this.aProposToolStripMenuItem.Text = "&A propos ... ...";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StandardCalculator,
            this.ScientificCalculator,
            this.ExchangeRate,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.CurrencyConverter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 48);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1549, 50);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StandardCalculator
            // 
            this.StandardCalculator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StandardCalculator.Image = ((System.Drawing.Image)(resources.GetObject("StandardCalculator.Image")));
            this.StandardCalculator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StandardCalculator.Name = "StandardCalculator";
            this.StandardCalculator.Size = new System.Drawing.Size(46, 44);
            this.StandardCalculator.Text = "toolStripButton2";
            this.StandardCalculator.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ScientificCalculator
            // 
            this.ScientificCalculator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ScientificCalculator.Image = ((System.Drawing.Image)(resources.GetObject("ScientificCalculator.Image")));
            this.ScientificCalculator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ScientificCalculator.Name = "ScientificCalculator";
            this.ScientificCalculator.Size = new System.Drawing.Size(46, 44);
            this.ScientificCalculator.Text = "toolStripButton1";
            this.ScientificCalculator.Click += new System.EventHandler(this.ScientificCalculator_Click);
            // 
            // ExchangeRate
            // 
            this.ExchangeRate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExchangeRate.Image = ((System.Drawing.Image)(resources.GetObject("ExchangeRate.Image")));
            this.ExchangeRate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExchangeRate.Name = "ExchangeRate";
            this.ExchangeRate.Size = new System.Drawing.Size(46, 44);
            this.ExchangeRate.Text = "toolStripButton5";
            this.ExchangeRate.Click += new System.EventHandler(this.ExchangeRate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(6, 50);
            // 
            // CurrencyConverter
            // 
            this.CurrencyConverter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurrencyConverter.Image = ((System.Drawing.Image)(resources.GetObject("CurrencyConverter.Image")));
            this.CurrencyConverter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurrencyConverter.Name = "CurrencyConverter";
            this.CurrencyConverter.Size = new System.Drawing.Size(46, 44);
            this.CurrencyConverter.Text = "toolStripButton4";
            this.CurrencyConverter.Click += new System.EventHandler(this.CurrencyConverter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1543, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1549, 873);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenuPrincipal";
            this.Text = "College Institut Teccart";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnustandard;
        private System.Windows.Forms.ToolStripMenuItem mnuscientifique;
        private System.Windows.Forms.ToolStripMenuItem bureauxChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuversionLocal;
        private System.Windows.Forms.ToolStripMenuItem mnuversionEnLigne;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterProgrammeCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StandardCalculator;
        private System.Windows.Forms.ToolStripButton ScientificCalculator;
        private System.Windows.Forms.ToolStripButton ExchangeRate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripButton3;
        private System.Windows.Forms.ToolStripButton CurrencyConverter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}