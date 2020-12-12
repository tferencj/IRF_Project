namespace Beadando
{
    partial class Tagszerkeztes
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
            this.Szuletesi_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Belepesi_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilepesi_datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxnev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxszuletes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxcim = new System.Windows.Forms.TextBox();
            this.textBoxbelepes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttontorol = new System.Windows.Forms.Button();
            this.buttonkilep = new System.Windows.Forms.Button();
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
            this.buttonveglegesit.TabIndex = 5;
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
            this.Szuletesi_datum,
            this.Cim,
            this.Belepesi_datum,
            this.Kilepesi_datum});
            this.dataGridViewkonyv.DataSource = this.bindingSource1;
            this.dataGridViewkonyv.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewkonyv.Name = "dataGridViewkonyv";
            this.dataGridViewkonyv.RowHeadersWidth = 51;
            this.dataGridViewkonyv.RowTemplate.Height = 24;
            this.dataGridViewkonyv.Size = new System.Drawing.Size(599, 232);
            this.dataGridViewkonyv.TabIndex = 10;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Keresés";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(625, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxnev
            // 
            this.textBoxnev.Location = new System.Drawing.Point(12, 284);
            this.textBoxnev.Name = "textBoxnev";
            this.textBoxnev.Size = new System.Drawing.Size(171, 22);
            this.textBoxnev.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Név";
            // 
            // textBoxszuletes
            // 
            this.textBoxszuletes.Location = new System.Drawing.Point(314, 284);
            this.textBoxszuletes.Name = "textBoxszuletes";
            this.textBoxszuletes.Size = new System.Drawing.Size(171, 22);
            this.textBoxszuletes.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Születési dátum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cím";
            // 
            // textBoxcim
            // 
            this.textBoxcim.Location = new System.Drawing.Point(12, 353);
            this.textBoxcim.Name = "textBoxcim";
            this.textBoxcim.Size = new System.Drawing.Size(171, 22);
            this.textBoxcim.TabIndex = 23;
            // 
            // textBoxbelepes
            // 
            this.textBoxbelepes.Location = new System.Drawing.Point(314, 353);
            this.textBoxbelepes.Name = "textBoxbelepes";
            this.textBoxbelepes.Size = new System.Drawing.Size(171, 22);
            this.textBoxbelepes.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Belépési dátum";
            // 
            // buttontorol
            // 
            this.buttontorol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttontorol.Location = new System.Drawing.Point(625, 153);
            this.buttontorol.Name = "buttontorol";
            this.buttontorol.Size = new System.Drawing.Size(163, 91);
            this.buttontorol.TabIndex = 28;
            this.buttontorol.Text = "Töröl";
            this.buttontorol.UseVisualStyleBackColor = true;
            this.buttontorol.Click += new System.EventHandler(this.buttontorol_Click);
            // 
            // buttonkilep
            // 
            this.buttonkilep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonkilep.Location = new System.Drawing.Point(625, 56);
            this.buttonkilep.Name = "buttonkilep";
            this.buttonkilep.Size = new System.Drawing.Size(163, 91);
            this.buttonkilep.TabIndex = 29;
            this.buttonkilep.Text = "Kiléptetés";
            this.buttonkilep.UseVisualStyleBackColor = true;
            this.buttonkilep.Click += new System.EventHandler(this.buttonkilep_Click);
            // 
            // Tagszerkeztes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonkilep);
            this.Controls.Add(this.buttontorol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxbelepes);
            this.Controls.Add(this.textBoxcim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxszuletes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxnev);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewkonyv);
            this.Controls.Add(this.buttonveglegesit);
            this.Name = "Tagszerkeztes";
            this.Text = "Tagszerkeztes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonveglegesit;
        private System.Windows.Forms.DataGridView dataGridViewkonyv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxnev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxszuletes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxcim;
        private System.Windows.Forms.TextBox textBoxbelepes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttontorol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szuletesi_datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Belepesi_datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilepesi_datum;
        private System.Windows.Forms.Button buttonkilep;
    }
}