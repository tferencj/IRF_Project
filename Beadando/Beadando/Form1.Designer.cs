namespace Beadando
{
    partial class Form1
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
            this.buttonkonyv = new System.Windows.Forms.Button();
            this.buttontag = new System.Windows.Forms.Button();
            this.Buttonbezar = new System.Windows.Forms.Button();
            this.buttonkolcsonzes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonkonyv
            // 
            this.buttonkonyv.Location = new System.Drawing.Point(29, 35);
            this.buttonkonyv.Name = "buttonkonyv";
            this.buttonkonyv.Size = new System.Drawing.Size(163, 91);
            this.buttonkonyv.TabIndex = 0;
            this.buttonkonyv.Text = "Könyvek";
            this.buttonkonyv.UseVisualStyleBackColor = true;
            this.buttonkonyv.Click += new System.EventHandler(this.buttonkonyv_Click);
            // 
            // buttontag
            // 
            this.buttontag.Location = new System.Drawing.Point(224, 35);
            this.buttontag.Name = "buttontag";
            this.buttontag.Size = new System.Drawing.Size(163, 91);
            this.buttontag.TabIndex = 1;
            this.buttontag.Text = "Tagok";
            this.buttontag.UseVisualStyleBackColor = true;
            this.buttontag.Click += new System.EventHandler(this.buttontag_Click);
            // 
            // Buttonbezar
            // 
            this.Buttonbezar.Location = new System.Drawing.Point(224, 155);
            this.Buttonbezar.Name = "Buttonbezar";
            this.Buttonbezar.Size = new System.Drawing.Size(163, 91);
            this.Buttonbezar.TabIndex = 2;
            this.Buttonbezar.Text = "Bezár";
            this.Buttonbezar.UseVisualStyleBackColor = true;
            this.Buttonbezar.Click += new System.EventHandler(this.Buttonbezar_Click);
            // 
            // buttonkolcsonzes
            // 
            this.buttonkolcsonzes.Location = new System.Drawing.Point(29, 155);
            this.buttonkolcsonzes.Name = "buttonkolcsonzes";
            this.buttonkolcsonzes.Size = new System.Drawing.Size(163, 91);
            this.buttonkolcsonzes.TabIndex = 3;
            this.buttonkolcsonzes.Text = "Kölcsönzés";
            this.buttonkolcsonzes.UseVisualStyleBackColor = true;
            this.buttonkolcsonzes.Click += new System.EventHandler(this.buttonkolcsonzes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 295);
            this.Controls.Add(this.buttonkolcsonzes);
            this.Controls.Add(this.Buttonbezar);
            this.Controls.Add(this.buttontag);
            this.Controls.Add(this.buttonkonyv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonkonyv;
        private System.Windows.Forms.Button buttontag;
        private System.Windows.Forms.Button Buttonbezar;
        private System.Windows.Forms.Button buttonkolcsonzes;
    }
}

