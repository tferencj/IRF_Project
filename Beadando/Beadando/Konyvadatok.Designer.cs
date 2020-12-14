namespace Beadando
{
    partial class Konyvadatok
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
            this.buttonkonyv = new System.Windows.Forms.Button();
            this.dataGridViewkonyv = new System.Windows.Forms.DataGridView();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szerzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiadas_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oldalszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttondia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonkonyv
            // 
            this.buttonkonyv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonkonyv.Location = new System.Drawing.Point(625, 250);
            this.buttonkonyv.Name = "buttonkonyv";
            this.buttonkonyv.Size = new System.Drawing.Size(163, 91);
            this.buttonkonyv.TabIndex = 1;
            this.buttonkonyv.Text = "Szerkeztés";
            this.buttonkonyv.UseVisualStyleBackColor = true;
            this.buttonkonyv.Click += new System.EventHandler(this.buttonkonyv_Click);
            // 
            // dataGridViewkonyv
            // 
            this.dataGridViewkonyv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewkonyv.AutoGenerateColumns = false;
            this.dataGridViewkonyv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkonyv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nev,
            this.Szerzo,
            this.Kiadas_datum,
            this.Kiado,
            this.Nyelv,
            this.Oldalszam});
            this.dataGridViewkonyv.DataSource = this.bindingSource1;
            this.dataGridViewkonyv.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewkonyv.Name = "dataGridViewkonyv";
            this.dataGridViewkonyv.RowHeadersWidth = 51;
            this.dataGridViewkonyv.RowTemplate.Height = 24;
            this.dataGridViewkonyv.Size = new System.Drawing.Size(597, 425);
            this.dataGridViewkonyv.TabIndex = 6;
            // 
            // Nev
            // 
            this.Nev.DataPropertyName = "Nev";
            this.Nev.HeaderText = "Név";
            this.Nev.MinimumWidth = 6;
            this.Nev.Name = "Nev";
            this.Nev.Width = 125;
            // 
            // Szerzo
            // 
            this.Szerzo.DataPropertyName = "Szerzo";
            this.Szerzo.HeaderText = "Szerző";
            this.Szerzo.MinimumWidth = 6;
            this.Szerzo.Name = "Szerzo";
            this.Szerzo.Width = 125;
            // 
            // Kiadas_datum
            // 
            this.Kiadas_datum.DataPropertyName = "Kiadas_datum";
            this.Kiadas_datum.HeaderText = "Kiadási év";
            this.Kiadas_datum.MinimumWidth = 6;
            this.Kiadas_datum.Name = "Kiadas_datum";
            this.Kiadas_datum.Width = 125;
            // 
            // Kiado
            // 
            this.Kiado.DataPropertyName = "Kiado";
            this.Kiado.HeaderText = "Kiadó";
            this.Kiado.MinimumWidth = 6;
            this.Kiado.Name = "Kiado";
            this.Kiado.Width = 125;
            // 
            // Nyelv
            // 
            this.Nyelv.DataPropertyName = "Nyelv";
            this.Nyelv.HeaderText = "Nyelv";
            this.Nyelv.MinimumWidth = 6;
            this.Nyelv.Name = "Nyelv";
            this.Nyelv.Width = 125;
            // 
            // Oldalszam
            // 
            this.Oldalszam.DataPropertyName = "Oldalszam";
            this.Oldalszam.HeaderText = "Oldalszám";
            this.Oldalszam.MinimumWidth = 6;
            this.Oldalszam.Name = "Oldalszam";
            this.Oldalszam.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Keresés";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(625, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttondia
            // 
            this.buttondia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttondia.Location = new System.Drawing.Point(625, 153);
            this.buttondia.Name = "buttondia";
            this.buttondia.Size = new System.Drawing.Size(163, 91);
            this.buttondia.TabIndex = 12;
            this.buttondia.Text = "Diagram";
            this.buttondia.UseVisualStyleBackColor = true;
            this.buttondia.Click += new System.EventHandler(this.buttondia_Click);
            // 
            // Konyvadatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttondia);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewkonyv);
            this.Controls.Add(this.buttonkonyv);
            this.Name = "Konyvadatok";
            this.Text = "Konyvadatok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonkonyv;
        private System.Windows.Forms.DataGridView dataGridViewkonyv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szerzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiadas_datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oldalszam;
        private System.Windows.Forms.Button buttondia;
    }
}