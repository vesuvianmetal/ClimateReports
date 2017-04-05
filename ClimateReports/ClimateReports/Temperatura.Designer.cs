namespace ClimateReports
{
    partial class Temperatura
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnenviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtmed = new System.Windows.Forms.TextBox();
            this.txtter = new System.Windows.Forms.TextBox();
            this.charttemperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radiocel = new System.Windows.Forms.RadioButton();
            this.radiofar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.charttemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(431, 44);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(69, 28);
            this.btnimprimir.TabIndex = 1;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(519, 44);
            this.btnenviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(63, 28);
            this.btnenviar.TabIndex = 2;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura Maxima:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Temperatura Minima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Temperatura Media:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sensacion Termica:";
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(167, 50);
            this.txtmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(100, 22);
            this.txtmax.TabIndex = 7;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(167, 87);
            this.txtmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(100, 22);
            this.txtmin.TabIndex = 8;
            // 
            // txtmed
            // 
            this.txtmed.Location = new System.Drawing.Point(167, 124);
            this.txtmed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmed.Name = "txtmed";
            this.txtmed.Size = new System.Drawing.Size(100, 22);
            this.txtmed.TabIndex = 9;
            // 
            // txtter
            // 
            this.txtter.Location = new System.Drawing.Point(167, 162);
            this.txtter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtter.Name = "txtter";
            this.txtter.Size = new System.Drawing.Size(100, 22);
            this.txtter.TabIndex = 10;
            // 
            // charttemperatura
            // 
            chartArea1.Name = "ChartArea1";
            this.charttemperatura.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charttemperatura.Legends.Add(legend1);
            this.charttemperatura.Location = new System.Drawing.Point(12, 212);
            this.charttemperatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charttemperatura.Name = "charttemperatura";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.charttemperatura.Series.Add(series1);
            this.charttemperatura.Size = new System.Drawing.Size(587, 300);
            this.charttemperatura.TabIndex = 11;
            this.charttemperatura.Text = "chart1";
            // 
            // radiocel
            // 
            this.radiocel.AutoSize = true;
            this.radiocel.Location = new System.Drawing.Point(312, 86);
            this.radiocel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiocel.Name = "radiocel";
            this.radiocel.Size = new System.Drawing.Size(74, 21);
            this.radiocel.TabIndex = 12;
            this.radiocel.TabStop = true;
            this.radiocel.Text = "Celcius";
            this.radiocel.UseVisualStyleBackColor = true;
            // 
            // radiofar
            // 
            this.radiofar.AutoSize = true;
            this.radiofar.Location = new System.Drawing.Point(312, 127);
            this.radiofar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiofar.Name = "radiofar";
            this.radiofar.Size = new System.Drawing.Size(89, 21);
            this.radiofar.TabIndex = 13;
            this.radiofar.TabStop = true;
            this.radiofar.Text = "Farenheit";
            this.radiofar.UseVisualStyleBackColor = true;
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 524);
            this.Controls.Add(this.radiofar);
            this.Controls.Add(this.radiocel);
            this.Controls.Add(this.charttemperatura);
            this.Controls.Add(this.txtter);
            this.Controls.Add(this.txtmed);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Temperatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.charttemperatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtmed;
        private System.Windows.Forms.TextBox txtter;
        private System.Windows.Forms.DataVisualization.Charting.Chart charttemperatura;
        private System.Windows.Forms.RadioButton radiocel;
        private System.Windows.Forms.RadioButton radiofar;
    }
}