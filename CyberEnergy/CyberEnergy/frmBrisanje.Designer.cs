namespace CyberEnergy
{
    partial class frmBrisanje
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Odaberite Unos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 63);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(650, 497);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(170, 44);
            this.btnBrisi.TabIndex = 35;
            this.btnBrisi.Text = "Obriši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(880, 497);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(108, 44);
            this.btnOdustani.TabIndex = 34;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Location = new System.Drawing.Point(27, 129);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.RowHeadersWidth = 51;
            this.dgvPrikaz.RowTemplate.Height = 24;
            this.dgvPrikaz.Size = new System.Drawing.Size(1028, 230);
            this.dgvPrikaz.TabIndex = 50;
            this.dgvPrikaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmBrisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnOdustani);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBrisanje";
            this.Text = "frmBrisanje";
            this.Load += new System.EventHandler(this.frmBrisanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dgvPrikaz;
    }
}