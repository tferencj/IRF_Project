namespace Beadando
{
    partial class Kolcsonzes
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
            this.buttonmegse = new System.Windows.Forms.Button();
            this.textBoxkonyv = new System.Windows.Forms.TextBox();
            this.textBoxtag = new System.Windows.Forms.TextBox();
            this.listBoxkonyv = new System.Windows.Forms.ListBox();
            this.listBoxtag = new System.Windows.Forms.ListBox();
            this.buttonhozzaad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Konyv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kivitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.torolgomb1 = new Beadando.Torolgomb();
            this.buttonvissza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonmegse
            // 
            this.buttonmegse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmegse.Location = new System.Drawing.Point(625, 347);
            this.buttonmegse.Name = "buttonmegse";
            this.buttonmegse.Size = new System.Drawing.Size(163, 91);
            this.buttonmegse.TabIndex = 4;
            this.buttonmegse.Text = "Mégse";
            this.buttonmegse.UseVisualStyleBackColor = true;
            this.buttonmegse.Click += new System.EventHandler(this.buttonmegse_Click);
            // 
            // textBoxkonyv
            // 
            this.textBoxkonyv.Location = new System.Drawing.Point(23, 29);
            this.textBoxkonyv.Name = "textBoxkonyv";
            this.textBoxkonyv.Size = new System.Drawing.Size(245, 22);
            this.textBoxkonyv.TabIndex = 5;
            this.textBoxkonyv.TextChanged += new System.EventHandler(this.textBoxkonyv_TextChanged);
            // 
            // textBoxtag
            // 
            this.textBoxtag.Location = new System.Drawing.Point(323, 29);
            this.textBoxtag.Name = "textBoxtag";
            this.textBoxtag.Size = new System.Drawing.Size(245, 22);
            this.textBoxtag.TabIndex = 6;
            this.textBoxtag.TextChanged += new System.EventHandler(this.textBoxtag_TextChanged);
            // 
            // listBoxkonyv
            // 
            this.listBoxkonyv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxkonyv.FormattingEnabled = true;
            this.listBoxkonyv.ItemHeight = 16;
            this.listBoxkonyv.Location = new System.Drawing.Point(23, 61);
            this.listBoxkonyv.Name = "listBoxkonyv";
            this.listBoxkonyv.Size = new System.Drawing.Size(245, 180);
            this.listBoxkonyv.TabIndex = 7;
            this.listBoxkonyv.SelectedIndexChanged += new System.EventHandler(this.listBoxkonyv_SelectedIndexChanged);
            // 
            // listBoxtag
            // 
            this.listBoxtag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxtag.FormattingEnabled = true;
            this.listBoxtag.ItemHeight = 16;
            this.listBoxtag.Location = new System.Drawing.Point(323, 61);
            this.listBoxtag.Name = "listBoxtag";
            this.listBoxtag.Size = new System.Drawing.Size(245, 180);
            this.listBoxtag.TabIndex = 8;
            // 
            // buttonhozzaad
            // 
            this.buttonhozzaad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonhozzaad.Location = new System.Drawing.Point(624, 58);
            this.buttonhozzaad.Name = "buttonhozzaad";
            this.buttonhozzaad.Size = new System.Drawing.Size(163, 91);
            this.buttonhozzaad.TabIndex = 9;
            this.buttonhozzaad.Text = "Hozzáad";
            this.buttonhozzaad.UseVisualStyleBackColor = true;
            this.buttonhozzaad.Click += new System.EventHandler(this.buttonhozzaad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Könyv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tag";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Konyv,
            this.Tag,
            this.Kivitel});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(544, 185);
            this.dataGridView1.TabIndex = 12;
            // 
            // Konyv
            // 
            this.Konyv.DataPropertyName = "Nev";
            this.Konyv.HeaderText = "Könyv";
            this.Konyv.MinimumWidth = 6;
            this.Konyv.Name = "Konyv";
            this.Konyv.Width = 125;
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Tag.Nev";
            this.Tag.HeaderText = "Tag";
            this.Tag.MinimumWidth = 6;
            this.Tag.Name = "Tag";
            this.Tag.Width = 125;
            // 
            // Kivitel
            // 
            this.Kivitel.DataPropertyName = "Kolcsonzes.Kivitel_datum";
            this.Kivitel.HeaderText = "Kivitel";
            this.Kivitel.MinimumWidth = 6;
            this.Kivitel.Name = "Kivitel";
            this.Kivitel.Width = 125;
            // 
            // torolgomb1
            // 
            this.torolgomb1._grid = this.dataGridView1;
            this.torolgomb1.Enabled = false;
            this.torolgomb1.Location = new System.Drawing.Point(625, 252);
            this.torolgomb1.Name = "torolgomb1";
            this.torolgomb1.Size = new System.Drawing.Size(162, 89);
            this.torolgomb1.TabIndex = 13;
            this.torolgomb1.Text = "Töröl";
            this.torolgomb1.UseVisualStyleBackColor = true;
            // 
            // buttonvissza
            // 
            this.buttonvissza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonvissza.Location = new System.Drawing.Point(625, 155);
            this.buttonvissza.Name = "buttonvissza";
            this.buttonvissza.Size = new System.Drawing.Size(163, 91);
            this.buttonvissza.TabIndex = 14;
            this.buttonvissza.Text = "Visszahozás";
            this.buttonvissza.UseVisualStyleBackColor = true;
            this.buttonvissza.Click += new System.EventHandler(this.buttonvissza_Click);
            // 
            // Kolcsonzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonvissza);
            this.Controls.Add(this.torolgomb1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonhozzaad);
            this.Controls.Add(this.listBoxtag);
            this.Controls.Add(this.listBoxkonyv);
            this.Controls.Add(this.textBoxtag);
            this.Controls.Add(this.textBoxkonyv);
            this.Controls.Add(this.buttonmegse);
            this.Name = "Kolcsonzes";
            this.Text = "Kolcsonzes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonmegse;
        private System.Windows.Forms.TextBox textBoxkonyv;
        private System.Windows.Forms.TextBox textBoxtag;
        private System.Windows.Forms.ListBox listBoxkonyv;
        private System.Windows.Forms.ListBox listBoxtag;
        private System.Windows.Forms.Button buttonhozzaad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Torolgomb torolgomb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konyv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kivitel;
        private System.Windows.Forms.Button buttonvissza;
    }
}