namespace Beadando
{
    partial class tagkilep
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
            this.dataGridViewkonyv = new System.Windows.Forms.DataGridView();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szuletesi_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Belepesi_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilepesi_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewkonyv
            // 
            this.dataGridViewkonyv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkonyv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nev,
            this.Szuletesi_datum,
            this.Cim,
            this.Belepesi_datum,
            this.Kilepesi_datum});
            this.dataGridViewkonyv.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewkonyv.Name = "dataGridViewkonyv";
            this.dataGridViewkonyv.RowHeadersWidth = 51;
            this.dataGridViewkonyv.RowTemplate.Height = 24;
            this.dataGridViewkonyv.Size = new System.Drawing.Size(599, 232);
            this.dataGridViewkonyv.TabIndex = 11;
            // 
            // Nev
            // 
            this.Nev.DataPropertyName = "Nev";
            this.Nev.HeaderText = "Név";
            this.Nev.MinimumWidth = 6;
            this.Nev.Name = "Nev";
            this.Nev.Width = 125;
            // 
            // Szuletesi_datum
            // 
            this.Szuletesi_datum.DataPropertyName = "Szuletesi_datum";
            this.Szuletesi_datum.HeaderText = "Születési év";
            this.Szuletesi_datum.MinimumWidth = 6;
            this.Szuletesi_datum.Name = "Szuletesi_datum";
            this.Szuletesi_datum.Width = 125;
            // 
            // Cim
            // 
            this.Cim.DataPropertyName = "Cim";
            this.Cim.HeaderText = "Cím";
            this.Cim.MinimumWidth = 6;
            this.Cim.Name = "Cim";
            this.Cim.Width = 125;
            // 
            // Belepesi_datum
            // 
            this.Belepesi_datum.DataPropertyName = "Belepesi_datum";
            this.Belepesi_datum.HeaderText = "Belépési dátum";
            this.Belepesi_datum.MinimumWidth = 6;
            this.Belepesi_datum.Name = "Belepesi_datum";
            this.Belepesi_datum.Width = 125;
            // 
            // Kilepesi_datum
            // 
            this.Kilepesi_datum.DataPropertyName = "Kilepesi_datum";
            this.Kilepesi_datum.HeaderText = "Kilépési dátum";
            this.Kilepesi_datum.MinimumWidth = 6;
            this.Kilepesi_datum.Name = "Kilepesi_datum";
            this.Kilepesi_datum.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(620, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Keresés";
            // 
            // tagkilep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewkonyv);
            this.Name = "tagkilep";
            this.Text = "tagkilep";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewkonyv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szuletesi_datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Belepesi_datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilepesi_datum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}