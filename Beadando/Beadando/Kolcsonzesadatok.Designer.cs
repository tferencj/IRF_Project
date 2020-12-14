namespace Beadando
{
    partial class Kolcsonzesadatok
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
            this.Konyv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konyvnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kivitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxtag = new System.Windows.Forms.ListBox();
            this.torolgomb1 = new Beadando.Torolgomb();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonkonyv
            // 
            this.buttonkonyv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonkonyv.Location = new System.Drawing.Point(625, 145);
            this.buttonkonyv.Name = "buttonkonyv";
            this.buttonkonyv.Size = new System.Drawing.Size(163, 91);
            this.buttonkonyv.TabIndex = 2;
            this.buttonkonyv.Text = "Hozzáadás";
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
            this.Konyv,
            this.Konyvnev,
            this.kivitel});
            this.dataGridViewkonyv.DataSource = this.bindingSource1;
            this.dataGridViewkonyv.Location = new System.Drawing.Point(12, 244);
            this.dataGridViewkonyv.Name = "dataGridViewkonyv";
            this.dataGridViewkonyv.RowHeadersWidth = 51;
            this.dataGridViewkonyv.RowTemplate.Height = 24;
            this.dataGridViewkonyv.Size = new System.Drawing.Size(555, 194);
            this.dataGridViewkonyv.TabIndex = 7;
            // 
            // Konyv
            // 
            this.Konyv.DataPropertyName = "Nev";
            this.Konyv.HeaderText = "Tag";
            this.Konyv.MinimumWidth = 6;
            this.Konyv.Name = "Konyv";
            this.Konyv.Width = 125;
            // 
            // Konyvnev
            // 
            this.Konyvnev.DataPropertyName = "Konyv.Nev";
            this.Konyvnev.HeaderText = "Könyv";
            this.Konyvnev.MinimumWidth = 6;
            this.Konyvnev.Name = "Konyvnev";
            this.Konyvnev.Width = 125;
            // 
            // kivitel
            // 
            this.kivitel.DataPropertyName = "Kolcsonzes.Kivitel_datum";
            this.kivitel.HeaderText = "Kivétel dátuma";
            this.kivitel.MinimumWidth = 6;
            this.kivitel.Name = "kivitel";
            this.kivitel.Width = 125;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Keresés a tagra";
            // 
            // listBoxtag
            // 
            this.listBoxtag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxtag.FormattingEnabled = true;
            this.listBoxtag.ItemHeight = 16;
            this.listBoxtag.Location = new System.Drawing.Point(12, 56);
            this.listBoxtag.Name = "listBoxtag";
            this.listBoxtag.Size = new System.Drawing.Size(555, 180);
            this.listBoxtag.TabIndex = 14;
            this.listBoxtag.SelectedIndexChanged += new System.EventHandler(this.listBoxtag_SelectedIndexChanged);
            // 
            // torolgomb1
            // 
            this.torolgomb1._grid = null;
            this.torolgomb1.Location = new System.Drawing.Point(625, 243);
            this.torolgomb1.Name = "torolgomb1";
            this.torolgomb1.Size = new System.Drawing.Size(163, 91);
            this.torolgomb1.TabIndex = 15;
            this.torolgomb1.Text = "Töröl";
            this.torolgomb1.UseVisualStyleBackColor = true;
            // 
            // Kolcsonzesadatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.torolgomb1);
            this.Controls.Add(this.listBoxtag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridViewkonyv);
            this.Controls.Add(this.buttonkonyv);
            this.Name = "Kolcsonzesadatok";
            this.Text = "Kolcsonzesadatok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkonyv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonkonyv;
        private System.Windows.Forms.DataGridView dataGridViewkonyv;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox listBoxtag;
        private Torolgomb torolgomb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konyv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konyvnev;
        private System.Windows.Forms.DataGridViewTextBoxColumn kivitel;
    }
}