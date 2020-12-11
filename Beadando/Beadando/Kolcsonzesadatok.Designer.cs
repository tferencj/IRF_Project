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
            this.buttondia = new System.Windows.Forms.Button();
            this.dataGridViewkonyv = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttontorol = new System.Windows.Forms.Button();
            this.listBoxkonyv = new System.Windows.Forms.ListBox();
            this.listBoxtag = new System.Windows.Forms.ListBox();
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
            // buttondia
            // 
            this.buttondia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttondia.Location = new System.Drawing.Point(625, 48);
            this.buttondia.Name = "buttondia";
            this.buttondia.Size = new System.Drawing.Size(163, 91);
            this.buttondia.TabIndex = 4;
            this.buttondia.Text = "Diagram";
            this.buttondia.UseVisualStyleBackColor = true;
            // 
            // dataGridViewkonyv
            // 
            this.dataGridViewkonyv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewkonyv.AutoGenerateColumns = false;
            this.dataGridViewkonyv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkonyv.DataSource = this.bindingSource1;
            this.dataGridViewkonyv.Location = new System.Drawing.Point(12, 243);
            this.dataGridViewkonyv.Name = "dataGridViewkonyv";
            this.dataGridViewkonyv.RowHeadersWidth = 51;
            this.dataGridViewkonyv.RowTemplate.Height = 24;
            this.dataGridViewkonyv.Size = new System.Drawing.Size(555, 194);
            this.dataGridViewkonyv.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Keresés a könyvre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Keresés a tagra";
            // 
            // buttontorol
            // 
            this.buttontorol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttontorol.Location = new System.Drawing.Point(625, 242);
            this.buttontorol.Name = "buttontorol";
            this.buttontorol.Size = new System.Drawing.Size(163, 91);
            this.buttontorol.TabIndex = 12;
            this.buttontorol.Text = "Törlés";
            this.buttontorol.UseVisualStyleBackColor = true;
            this.buttontorol.Click += new System.EventHandler(this.buttontorol_Click);
            // 
            // listBoxkonyv
            // 
            this.listBoxkonyv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxkonyv.FormattingEnabled = true;
            this.listBoxkonyv.ItemHeight = 16;
            this.listBoxkonyv.Location = new System.Drawing.Point(12, 57);
            this.listBoxkonyv.Name = "listBoxkonyv";
            this.listBoxkonyv.Size = new System.Drawing.Size(245, 180);
            this.listBoxkonyv.TabIndex = 13;
            // 
            // listBoxtag
            // 
            this.listBoxtag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxtag.FormattingEnabled = true;
            this.listBoxtag.ItemHeight = 16;
            this.listBoxtag.Location = new System.Drawing.Point(322, 57);
            this.listBoxtag.Name = "listBoxtag";
            this.listBoxtag.Size = new System.Drawing.Size(245, 180);
            this.listBoxtag.TabIndex = 14;
            // 
            // Kolcsonzesadatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxtag);
            this.Controls.Add(this.listBoxkonyv);
            this.Controls.Add(this.buttontorol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewkonyv);
            this.Controls.Add(this.buttondia);
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
        private System.Windows.Forms.Button buttondia;
        private System.Windows.Forms.DataGridView dataGridViewkonyv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttontorol;
        private System.Windows.Forms.ListBox listBoxkonyv;
        private System.Windows.Forms.ListBox listBoxtag;
    }
}