namespace prjcalculBureauChange
{
    partial class frmChange
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnquitter = new System.Windows.Forms.Button();
            this.lblresultat = new System.Windows.Forms.Label();
            this.btneffacer = new System.Windows.Forms.Button();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.lbldevise = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblaus = new System.Windows.Forms.Label();
            this.lbldeus = new System.Windows.Forms.Label();
            this.radaus = new System.Windows.Forms.RadioButton();
            this.raddeus = new System.Windows.Forms.RadioButton();
            this.lblus2 = new System.Windows.Forms.Label();
            this.lblus1 = new System.Windows.Forms.Label();
            this.cbocountries = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "BUREAU-XCHANGE";
            // 
            // btnquitter
            // 
            this.btnquitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnquitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitter.Location = new System.Drawing.Point(928, 558);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(145, 58);
            this.btnquitter.TabIndex = 13;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = false;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click_1);
            // 
            // lblresultat
            // 
            this.lblresultat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblresultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresultat.Location = new System.Drawing.Point(60, 599);
            this.lblresultat.Name = "lblresultat";
            this.lblresultat.Size = new System.Drawing.Size(451, 59);
            this.lblresultat.TabIndex = 22;
            // 
            // btneffacer
            // 
            this.btneffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btneffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneffacer.Location = new System.Drawing.Point(928, 479);
            this.btneffacer.Name = "btneffacer";
            this.btneffacer.Size = new System.Drawing.Size(145, 58);
            this.btneffacer.TabIndex = 21;
            this.btneffacer.Text = "Effacer";
            this.btneffacer.UseVisualStyleBackColor = false;
            this.btneffacer.Click += new System.EventHandler(this.btneffacer_Click_1);
            // 
            // btnconvertir
            // 
            this.btnconvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnconvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertir.Location = new System.Drawing.Point(928, 396);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(145, 58);
            this.btnconvertir.TabIndex = 20;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = false;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click_1);
            // 
            // txtmontant
            // 
            this.txtmontant.Location = new System.Drawing.Point(677, 440);
            this.txtmontant.Multiline = true;
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(151, 54);
            this.txtmontant.TabIndex = 19;
            this.txtmontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontant_KeyPress);
            // 
            // lbldevise
            // 
            this.lbldevise.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbldevise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldevise.Location = new System.Drawing.Point(677, 363);
            this.lbldevise.Name = "lbldevise";
            this.lbldevise.Size = new System.Drawing.Size(151, 59);
            this.lbldevise.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblaus);
            this.groupBox1.Controls.Add(this.lbldeus);
            this.groupBox1.Controls.Add(this.radaus);
            this.groupBox1.Controls.Add(this.raddeus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 253);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de conversion";
            // 
            // lblaus
            // 
            this.lblaus.Location = new System.Drawing.Point(69, 163);
            this.lblaus.Name = "lblaus";
            this.lblaus.Size = new System.Drawing.Size(476, 41);
            this.lblaus.TabIndex = 3;
            // 
            // lbldeus
            // 
            this.lbldeus.Location = new System.Drawing.Point(70, 91);
            this.lbldeus.Name = "lbldeus";
            this.lbldeus.Size = new System.Drawing.Size(475, 41);
            this.lbldeus.TabIndex = 2;
            // 
            // radaus
            // 
            this.radaus.AutoSize = true;
            this.radaus.Location = new System.Drawing.Point(21, 164);
            this.radaus.Name = "radaus";
            this.radaus.Size = new System.Drawing.Size(27, 26);
            this.radaus.TabIndex = 1;
            this.radaus.TabStop = true;
            this.radaus.UseVisualStyleBackColor = true;
            this.radaus.CheckedChanged += new System.EventHandler(this.radaus_CheckedChanged_1);
            // 
            // raddeus
            // 
            this.raddeus.AutoSize = true;
            this.raddeus.Location = new System.Drawing.Point(21, 92);
            this.raddeus.Name = "raddeus";
            this.raddeus.Size = new System.Drawing.Size(27, 26);
            this.raddeus.TabIndex = 0;
            this.raddeus.TabStop = true;
            this.raddeus.UseVisualStyleBackColor = true;
            this.raddeus.CheckedChanged += new System.EventHandler(this.raddeus_CheckedChanged_1);
            // 
            // lblus2
            // 
            this.lblus2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblus2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblus2.Location = new System.Drawing.Point(586, 221);
            this.lblus2.Name = "lblus2";
            this.lblus2.Size = new System.Drawing.Size(445, 44);
            this.lblus2.TabIndex = 16;
            // 
            // lblus1
            // 
            this.lblus1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblus1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblus1.Location = new System.Drawing.Point(586, 159);
            this.lblus1.Name = "lblus1";
            this.lblus1.Size = new System.Drawing.Size(445, 44);
            this.lblus1.TabIndex = 15;
            this.lblus1.Click += new System.EventHandler(this.lblus1_Click);
            // 
            // cbocountries
            // 
            this.cbocountries.FormattingEnabled = true;
            this.cbocountries.Location = new System.Drawing.Point(82, 170);
            this.cbocountries.Name = "cbocountries";
            this.cbocountries.Size = new System.Drawing.Size(372, 33);
            this.cbocountries.TabIndex = 14;
            this.cbocountries.SelectedIndexChanged += new System.EventHandler(this.cbocountries_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjcalculBureauChange.Properties.Resources.devises;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1160, 762);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 718);
            this.Controls.Add(this.lblresultat);
            this.Controls.Add(this.btneffacer);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.lbldevise);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblus2);
            this.Controls.Add(this.lblus1);
            this.Controls.Add(this.cbocountries);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmChange";
            this.Text = "frmChange";
            this.Load += new System.EventHandler(this.frmChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Label lblresultat;
        private System.Windows.Forms.Button btneffacer;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.Label lbldevise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblaus;
        private System.Windows.Forms.Label lbldeus;
        private System.Windows.Forms.RadioButton radaus;
        private System.Windows.Forms.RadioButton raddeus;
        private System.Windows.Forms.Label lblus2;
        private System.Windows.Forms.Label lblus1;
        private System.Windows.Forms.ComboBox cbocountries;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}