namespace CyberEnergy
{
    partial class frmIspis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIspis));
            this.dgvTablica = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablica
            // 
            this.dgvTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablica.Location = new System.Drawing.Point(10, 2);
            this.dgvTablica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTablica.Name = "dgvTablica";
            this.dgvTablica.RowHeadersWidth = 50;
            this.dgvTablica.RowTemplate.Height = 24;
            this.dgvTablica.Size = new System.Drawing.Size(231, 180);
            this.dgvTablica.TabIndex = 0;
            this.dgvTablica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(512, 312);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(79, 32);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(321, 41);
            this.txtPretrazivanje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(150, 20);
            this.txtPretrazivanje.TabIndex = 2;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(321, 24);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(77, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Pretraži zgrade";
            // 
            // frmIspis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dgvTablica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmIspis";
            this.Text = "Ispis";
            this.Load += new System.EventHandler(this.Ispis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablica;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label label;
    }
}