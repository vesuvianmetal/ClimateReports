namespace ClimateReports
{
    partial class Viento
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
            this.chartvientos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radiomilla = new System.Windows.Forms.RadioButton();
            this.radiokilo = new System.Windows.Forms.RadioButton();
            this.btnenviar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.progressbeau = new System.Windows.Forms.ProgressBar();
            this.txtmed = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartvientos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartvientos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartvientos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartvientos.Legends.Add(legend1);
            this.chartvientos.Location = new System.Drawing.Point(12, 266);
            this.chartvientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartvientos.Name = "chartvientos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Viento";
            this.chartvientos.Series.Add(series1);
            this.chartvientos.Size = new System.Drawing.Size(637, 300);
            this.chartvientos.TabIndex = 8;
            this.chartvientos.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radiomilla
            // 
            this.radiomilla.AutoSize = true;
            this.radiomilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiomilla.ForeColor = System.Drawing.Color.White;
            this.radiomilla.Location = new System.Drawing.Point(465, 113);
            this.radiomilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiomilla.Name = "radiomilla";
            this.radiomilla.Size = new System.Drawing.Size(107, 36);
            this.radiomilla.TabIndex = 40;
            this.radiomilla.TabStop = true;
            this.radiomilla.Text = "ML/H";
            this.radiomilla.UseVisualStyleBackColor = true;
            // 
            // radiokilo
            // 
            this.radiokilo.AutoSize = true;
            this.radiokilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiokilo.ForeColor = System.Drawing.Color.White;
            this.radiokilo.Location = new System.Drawing.Point(464, 70);
            this.radiokilo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiokilo.Name = "radiokilo";
            this.radiokilo.Size = new System.Drawing.Size(110, 36);
            this.radiokilo.TabIndex = 39;
            this.radiokilo.TabStop = true;
            this.radiokilo.Text = "KM/H";
            this.radiokilo.UseVisualStyleBackColor = true;
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(569, 215);
            this.btnenviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 27);
            this.btnenviar.TabIndex = 38;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(465, 215);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 27);
            this.btnimprimir.TabIndex = 37;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 198);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(108, 17);
            this.label.TabIndex = 36;
            this.label.Text = "Escala Beaufort";
            // 
            // progressbeau
            // 
            this.progressbeau.Location = new System.Drawing.Point(17, 219);
            this.progressbeau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressbeau.Name = "progressbeau";
            this.progressbeau.Size = new System.Drawing.Size(237, 23);
            this.progressbeau.TabIndex = 35;
            // 
            // txtmed
            // 
            this.txtmed.Location = new System.Drawing.Point(291, 165);
            this.txtmed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmed.Name = "txtmed";
            this.txtmed.Size = new System.Drawing.Size(100, 22);
            this.txtmed.TabIndex = 34;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(291, 123);
            this.txtmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(100, 22);
            this.txtmin.TabIndex = 33;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(291, 72);
            this.txtmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(100, 22);
            this.txtmax.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Velocidad Media:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "Velocidad Minima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Velocidad Maxima:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Viento";
            // 
            // Viento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(675, 578);
            this.Controls.Add(this.radiomilla);
            this.Controls.Add(this.radiokilo);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.label);
            this.Controls.Add(this.progressbeau);
            this.Controls.Add(this.txtmed);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartvientos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Viento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Viento_FormClosed);
            this.Load += new System.EventHandler(this.Viento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartvientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartvientos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radiomilla;
        private System.Windows.Forms.RadioButton radiokilo;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ProgressBar progressbeau;
        private System.Windows.Forms.TextBox txtmed;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}