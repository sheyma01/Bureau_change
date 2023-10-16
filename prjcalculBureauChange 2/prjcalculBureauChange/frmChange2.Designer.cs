namespace prjcalculBureauChange
{
    partial class frmChange2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChange2));
            this.label1 = new System.Windows.Forms.Label();
            this.lblconversion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbocountries1 = new System.Windows.Forms.ComboBox();
            this.cbocountries2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmontant1 = new System.Windows.Forms.TextBox();
            this.txtmontant2 = new System.Windows.Forms.TextBox();
            this.btncalculer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.btnMiseajour = new System.Windows.Forms.Button();
            this.btnfermer = new System.Windows.Forms.Button();
            this.lblavertissement = new System.Windows.Forms.Label();
            this.grpInformations = new System.Windows.Forms.GroupBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnswitch = new System.Windows.Forms.Button();
            this.grpInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Name = "label1";
            // 
            // lblconversion
            // 
            resources.ApplyResources(this.lblconversion, "lblconversion");
            this.lblconversion.Name = "lblconversion";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbocountries1
            // 
            resources.ApplyResources(this.cbocountries1, "cbocountries1");
            this.cbocountries1.FormattingEnabled = true;
            this.cbocountries1.Name = "cbocountries1";
            this.cbocountries1.SelectedIndexChanged += new System.EventHandler(this.cbocountries1_SelectedIndexChanged);
            // 
            // cbocountries2
            // 
            resources.ApplyResources(this.cbocountries2, "cbocountries2");
            this.cbocountries2.FormattingEnabled = true;
            this.cbocountries2.Name = "cbocountries2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtmontant1
            // 
            resources.ApplyResources(this.txtmontant1, "txtmontant1");
            this.txtmontant1.Name = "txtmontant1";
            this.txtmontant1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontant1_KeyPress);
            // 
            // txtmontant2
            // 
            resources.ApplyResources(this.txtmontant2, "txtmontant2");
            this.txtmontant2.Name = "txtmontant2";
            // 
            // btncalculer
            // 
            resources.ApplyResources(this.btncalculer, "btncalculer");
            this.btncalculer.Name = "btncalculer";
            this.btncalculer.UseVisualStyleBackColor = true;
            this.btncalculer.Click += new System.EventHandler(this.btncalculer_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Name = "label6";
            // 
            // btnimprimer
            // 
            resources.ApplyResources(this.btnimprimer, "btnimprimer");
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.UseVisualStyleBackColor = true;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
            // 
            // btnMiseajour
            // 
            resources.ApplyResources(this.btnMiseajour, "btnMiseajour");
            this.btnMiseajour.Name = "btnMiseajour";
            this.btnMiseajour.UseVisualStyleBackColor = true;
            this.btnMiseajour.Click += new System.EventHandler(this.btnMiseajour_Click);
            // 
            // btnfermer
            // 
            resources.ApplyResources(this.btnfermer, "btnfermer");
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.UseVisualStyleBackColor = true;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // lblavertissement
            // 
            this.lblavertissement.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.lblavertissement, "lblavertissement");
            this.lblavertissement.Name = "lblavertissement";
            // 
            // grpInformations
            // 
            this.grpInformations.Controls.Add(this.lblinfo);
            resources.ApplyResources(this.grpInformations, "grpInformations");
            this.grpInformations.Name = "grpInformations";
            this.grpInformations.TabStop = false;
            // 
            // lblinfo
            // 
            resources.ApplyResources(this.lblinfo, "lblinfo");
            this.lblinfo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblinfo.Name = "lblinfo";
            // 
            // btnswitch
            // 
            this.btnswitch.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnswitch, "btnswitch");
            this.btnswitch.Image = global::prjcalculBureauChange.Properties.Resources.Remove_background__3_;
            this.btnswitch.Name = "btnswitch";
            this.btnswitch.UseVisualStyleBackColor = false;
            this.btnswitch.Click += new System.EventHandler(this.btnswitch_Click);
            // 
            // frmChange2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInformations);
            this.Controls.Add(this.lblavertissement);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.btnMiseajour);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncalculer);
            this.Controls.Add(this.txtmontant2);
            this.Controls.Add(this.txtmontant1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbocountries2);
            this.Controls.Add(this.btnswitch);
            this.Controls.Add(this.cbocountries1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblconversion);
            this.Controls.Add(this.label1);
            this.Name = "frmChange2";
            this.Load += new System.EventHandler(this.frmChange2_Load);
            this.grpInformations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblconversion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbocountries1;
        private System.Windows.Forms.Button btnswitch;
        private System.Windows.Forms.ComboBox cbocountries2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmontant1;
        private System.Windows.Forms.TextBox txtmontant2;
        private System.Windows.Forms.Button btncalculer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.Button btnMiseajour;
        private System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.Label lblavertissement;
        private System.Windows.Forms.GroupBox grpInformations;
        private System.Windows.Forms.Label lblinfo;
    }
}