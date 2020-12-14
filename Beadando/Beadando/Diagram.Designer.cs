namespace Beadando
{
    partial class Diagram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonnyelv = new System.Windows.Forms.Button();
            this.buttonoldal = new System.Windows.Forms.Button();
            this.buttonkiadas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.bindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 19);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "darab";
            series1.XValueMember = "Nyelv";
            series1.YValueMembers = "db";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(764, 309);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // buttonnyelv
            // 
            this.buttonnyelv.Location = new System.Drawing.Point(31, 349);
            this.buttonnyelv.Name = "buttonnyelv";
            this.buttonnyelv.Size = new System.Drawing.Size(162, 89);
            this.buttonnyelv.TabIndex = 6;
            this.buttonnyelv.Text = "Nyelv";
            this.buttonnyelv.UseVisualStyleBackColor = true;
            this.buttonnyelv.Click += new System.EventHandler(this.buttonnyelv_Click);
            // 
            // buttonoldal
            // 
            this.buttonoldal.Location = new System.Drawing.Point(208, 349);
            this.buttonoldal.Name = "buttonoldal";
            this.buttonoldal.Size = new System.Drawing.Size(162, 89);
            this.buttonoldal.TabIndex = 7;
            this.buttonoldal.Text = "Oldalszám";
            this.buttonoldal.UseVisualStyleBackColor = true;
            this.buttonoldal.Click += new System.EventHandler(this.buttonoldal_Click);
            // 
            // buttonkiadas
            // 
            this.buttonkiadas.Location = new System.Drawing.Point(388, 349);
            this.buttonkiadas.Name = "buttonkiadas";
            this.buttonkiadas.Size = new System.Drawing.Size(162, 89);
            this.buttonkiadas.TabIndex = 8;
            this.buttonkiadas.Text = "Kiadás dátuma";
            this.buttonkiadas.UseVisualStyleBackColor = true;
            this.buttonkiadas.Click += new System.EventHandler(this.buttonkiadas_Click);
            // 
            // Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonkiadas);
            this.Controls.Add(this.buttonoldal);
            this.Controls.Add(this.buttonnyelv);
            this.Controls.Add(this.chart1);
            this.Name = "Diagram";
            this.Text = "Diagram";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonnyelv;
        private System.Windows.Forms.Button buttonoldal;
        private System.Windows.Forms.Button buttonkiadas;
    }
}