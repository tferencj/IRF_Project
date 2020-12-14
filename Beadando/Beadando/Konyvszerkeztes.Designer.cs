namespace Beadando
{
    partial class Konyvszerkeztes
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
            this.buttonveglegesit = new System.Windows.Forms.Button();
            this.dataGridViewkonyv = new System.Windows.Forms.DataGridView();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szerzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiadasi_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oldalszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnev = new System.Windows.Forms.TextBox();
            this.textBoxszerzo = new System.Windows.Forms.TextBox();
            this.textBoxdatum = new System.Windows.Forms.TextBox();
            this.textBoxkiado = new System.Windows.Forms.TextBox();
            this.textBoxnyelv = new System.Windows.Forms.TextBox();
            this.textBoxoldalszam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.torolgomb1 = new Beadando.Torolgomb();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonveglegesit
            // 
            this.buttonveglegesit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonveglegesit.Location = new System.Drawing.Point(625, 250);
            this.buttonveglegesit.Name = "buttonveglegesit";
            this.buttonveglegesit.Size = new System.Drawing.Size(163, 91);
            this.buttonveglegesit.TabIndex = 6;
            this.buttonveglegesit.Text = "Véglegesít";
            this.buttonveglegesit.UseVisualStyleBackColor = true;
            this.buttonveglegesit.Click += new System.EventHandler(this.buttonveglegesit_Click);
            // 
            // dataGridViewkonyv
            // 
            this.dataGridViewkonyv.AutoGenerateColumns = false;
            this.dataGridViewkonyv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkonyv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nev,
            this.Szerzo,
            this.Kiadasi_datum,
            this.Kiado,
            this.Nyelv,
            this.Oldalszam});
            this.dataGridViewkonyv.DataSource = this.bindingSource1;
            this.dataGridViewkonyv.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewkonyv.Name = "dataGridViewkonyv";
            this.dataGridViewkonyv.RowHeadersWidth = 51;
            this.dataGridViewkonyv.RowTemplate.Height = 24;
            this.dataGridViewkonyv.Size = new System.Drawing.Size(599, 232);
            this.dataGridViewkonyv.TabIndex = 9;
            this.dataGridViewkonyv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewkonyv_CellContentClick);
            this.dataGridViewkonyv.SelectionChanged += new System.EventHandler(this.dataGridViewkonyv_SelectionChanged);
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
            // Kiadasi_datum
            // 
            this.Kiadasi_datum.DataPropertyName = "Kiadas_datum";
            this.Kiadasi_datum.HeaderText = "Kiadási év";
            this.Kiadasi_datum.MinimumWidth = 6;
            this.Kiadasi_datum.Name = "Kiadasi_datum";
            this.Kiadasi_datum.Width = 125;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(625, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Keresés";
            // 
            // textBoxnev
            // 
            this.textBoxnev.Location = new System.Drawing.Point(12, 284);
            this.textBoxnev.Name = "textBoxnev";
            this.textBoxnev.Size = new System.Drawing.Size(171, 22);
            this.textBoxnev.TabIndex = 12;
            // 
            // textBoxszerzo
            // 
            this.textBoxszerzo.Location = new System.Drawing.Point(226, 284);
            this.textBoxszerzo.Name = "textBoxszerzo";
            this.textBoxszerzo.Size = new System.Drawing.Size(171, 22);
            this.textBoxszerzo.TabIndex = 13;
            // 
            // textBoxdatum
            // 
            this.textBoxdatum.Location = new System.Drawing.Point(440, 284);
            this.textBoxdatum.Name = "textBoxdatum";
            this.textBoxdatum.Size = new System.Drawing.Size(171, 22);
            this.textBoxdatum.TabIndex = 14;
            // 
            // textBoxkiado
            // 
            this.textBoxkiado.Location = new System.Drawing.Point(12, 347);
            this.textBoxkiado.Name = "textBoxkiado";
            this.textBoxkiado.Size = new System.Drawing.Size(171, 22);
            this.textBoxkiado.TabIndex = 15;
            // 
            // textBoxnyelv
            // 
            this.textBoxnyelv.Location = new System.Drawing.Point(226, 347);
            this.textBoxnyelv.Name = "textBoxnyelv";
            this.textBoxnyelv.Size = new System.Drawing.Size(171, 22);
            this.textBoxnyelv.TabIndex = 16;
            // 
            // textBoxoldalszam
            // 
            this.textBoxoldalszam.Location = new System.Drawing.Point(440, 347);
            this.textBoxoldalszam.Name = "textBoxoldalszam";
            this.textBoxoldalszam.Size = new System.Drawing.Size(171, 22);
            this.textBoxoldalszam.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Szerző";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kiadás dátuma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kiadó";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nyelv";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Oldalszám";
            // 
            // torolgomb1
            // 
            this.torolgomb1._grid = this.dataGridViewkonyv;
            this.torolgomb1.Location = new System.Drawing.Point(625, 161);
            this.torolgomb1.Name = "torolgomb1";
            this.torolgomb1.Size = new System.Drawing.Size(162, 82);
            this.torolgomb1.TabIndex = 24;
            this.torolgomb1.Text = "Töröl";
            this.torolgomb1.UseVisualStyleBackColor = true;
            // 
            // Konyvszerkeztes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.torolgomb1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxoldalszam);
            this.Controls.Add(this.textBoxnyelv);
            this.Controls.Add(this.textBoxkiado);
            this.Controls.Add(this.textBoxdatum);
            this.Controls.Add(this.textBoxszerzo);
            this.Controls.Add(this.textBoxnev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewkonyv);
            this.Controls.Add(this.buttonveglegesit);
            this.Name = "Konyvszerkeztes";
            this.Text = "Konyvszerkeztes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonveglegesit;
        private System.Windows.Forms.DataGridView dataGridViewkonyv;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szerzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiadasi_datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oldalszam;
        public System.Windows.Forms.TextBox textBoxnev;
        public System.Windows.Forms.TextBox textBoxszerzo;
        public System.Windows.Forms.TextBox textBoxdatum;
        public System.Windows.Forms.TextBox textBoxkiado;
        public System.Windows.Forms.TextBox textBoxnyelv;
        public System.Windows.Forms.TextBox textBoxoldalszam;
        private Torolgomb torolgomb1;
    }
}