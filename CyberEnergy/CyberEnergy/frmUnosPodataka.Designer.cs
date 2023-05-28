namespace CyberEnergy
{
    partial class frmUnosPodataka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnosPodataka));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZgrade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVrste = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMjerna = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(36, 167);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(735, 156);
            this.textBox1.TabIndex = 0;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(595, 405);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(716, 405);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Napomena";
            // 
            // cmbZgrade
            // 
            this.cmbZgrade.FormattingEnabled = true;
            this.cmbZgrade.Location = new System.Drawing.Point(106, 58);
            this.cmbZgrade.Name = "cmbZgrade";
            this.cmbZgrade.Size = new System.Drawing.Size(121, 21);
            this.cmbZgrade.TabIndex = 4;
            this.cmbZgrade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odaberite zgradu:";
            // 
            // txtKolicine
            // 
            this.txtKolicine.Location = new System.Drawing.Point(276, 59);
            this.txtKolicine.Name = "txtKolicine";
            this.txtKolicine.Size = new System.Drawing.Size(100, 20);
            this.txtKolicine.TabIndex = 10;
            this.txtKolicine.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unesite količinu";
            // 
            // cmbVrste
            // 
            this.cmbVrste.FormattingEnabled = true;
            this.cmbVrste.Location = new System.Drawing.Point(435, 58);
            this.cmbVrste.Name = "cmbVrste";
            this.cmbVrste.Size = new System.Drawing.Size(121, 21);
            this.cmbVrste.TabIndex = 12;
            this.cmbVrste.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vrsta energije";
            // 
            // cmbMjerna
            // 
            this.cmbMjerna.FormattingEnabled = true;
            this.cmbMjerna.Location = new System.Drawing.Point(616, 58);
            this.cmbMjerna.Name = "cmbMjerna";
            this.cmbMjerna.Size = new System.Drawing.Size(121, 21);
            this.cmbMjerna.TabIndex = 14;
            this.cmbMjerna.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Odaberite mjernu jedinicu";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // frmUnosPodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMjerna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbVrste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKolicine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZgrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUnosPodataka";
            this.Text = "UnosPodataka";
            this.Load += new System.EventHandler(this.UnosPodataka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZgrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVrste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMjerna;
        private System.Windows.Forms.Label label7;
    }
}