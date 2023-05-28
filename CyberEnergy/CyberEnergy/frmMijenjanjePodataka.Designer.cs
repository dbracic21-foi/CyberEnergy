namespace CyberEnergy
{
    partial class frmMijenjanjePodataka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMijenjanjePodataka));
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMjerna = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVrste = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbZgrade = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cmbOdabir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Odaberite mjernu jedinicu";
            // 
            // cmbMjerna
            // 
            this.cmbMjerna.FormattingEnabled = true;
            this.cmbMjerna.Location = new System.Drawing.Point(583, 219);
            this.cmbMjerna.Name = "cmbMjerna";
            this.cmbMjerna.Size = new System.Drawing.Size(121, 21);
            this.cmbMjerna.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Vrsta energije";
            // 
            // cmbVrste
            // 
            this.cmbVrste.FormattingEnabled = true;
            this.cmbVrste.Location = new System.Drawing.Point(402, 219);
            this.cmbVrste.Name = "cmbVrste";
            this.cmbVrste.Size = new System.Drawing.Size(121, 21);
            this.cmbVrste.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Unesite količinu";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(243, 220);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Odaberite zgradu:";
            // 
            // cmbZgrade
            // 
            this.cmbZgrade.FormattingEnabled = true;
            this.cmbZgrade.Location = new System.Drawing.Point(73, 219);
            this.cmbZgrade.Name = "cmbZgrade";
            this.cmbZgrade.Size = new System.Drawing.Size(121, 21);
            this.cmbZgrade.TabIndex = 20;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(704, 395);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 18;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(583, 395);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 17;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cmbOdabir
            // 
            this.cmbOdabir.FormattingEnabled = true;
            this.cmbOdabir.Location = new System.Drawing.Point(41, 68);
            this.cmbOdabir.Name = "cmbOdabir";
            this.cmbOdabir.Size = new System.Drawing.Size(121, 21);
            this.cmbOdabir.TabIndex = 31;
            this.cmbOdabir.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Odaberite Unos";
            // 
            // frmMijenjanjePodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOdabir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMjerna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbVrste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZgrade);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMijenjanjePodataka";
            this.Text = "frmMijenjanjePodataka";
            this.Load += new System.EventHandler(this.frmMijenjanjePodataka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMjerna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVrste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZgrade;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cmbOdabir;
        private System.Windows.Forms.Label label3;
    }
}