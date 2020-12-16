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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewkonyv = new System.Windows.Forms.DataGridView();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szuletesi_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Belepesi_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilepesi_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumgomb1 = new Beadando.datumgomb();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(625, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Keresés";
            // 
            // dataGridViewkonyv
            // 
            this.dataGridViewkonyv.AutoGenerateColumns = false;
            this.dataGridViewkonyv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkonyv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nev,
            this.Szuletesi_datum,
            this.Cim,
            this.Belepesi_datum,
            this.Kilepesi_datum});
            this.dataGridViewkonyv.DataSource = this.bindingSource1;
            this.dataGridViewkonyv.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewkonyv.Name = "dataGridViewkonyv";
            this.dataGridViewkonyv.RowHeadersWidth = 51;
            this.dataGridViewkonyv.RowTemplate.Height = 24;
            this.dataGridViewkonyv.Size = new System.Drawing.Size(599, 426);
            this.dataGridViewkonyv.TabIndex = 31;
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
            // datumgomb1
            // 
            this.datumgomb1._grid = this.dataGridViewkonyv;
            this.datumgomb1.belepes = null;
            this.datumgomb1.Location = new System.Drawing.Point(625, 246);
            this.datumgomb1.Name = "datumgomb1";
            this.datumgomb1.Size = new System.Drawing.Size(162, 88);
            this.datumgomb1.TabIndex = 32;
            this.datumgomb1.Text = "Kiléptetés";
            this.datumgomb1.UseVisualStyleBackColor = true;
            // 
            // tagkilep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datumgomb1);
            this.Controls.Add(this.dataGridViewkonyv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "tagkilep";
            this.Text = "tagkilep";
            this.Load += new System.EventHandler(this.tagkilep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewkonyv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szuletesi_datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Belepesi_datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilepesi_datum;
        public System.Windows.Forms.BindingSource bindingSource1;
        private datumgomb datumgomb1;
    }
}