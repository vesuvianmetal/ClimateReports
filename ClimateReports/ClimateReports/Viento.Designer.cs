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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartvientos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radiomilla = new System.Windows.Forms.RadioButton();
            this.radiokilo = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.progressbeau = new System.Windows.Forms.ProgressBar();
            this.txtmed = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartvientos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartvientos
            // 
            chartArea2.Name = "ChartArea1";
            this.chartvientos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartvientos.Legends.Add(legend2);
            this.chartvientos.Location = new System.Drawing.Point(258, 260);
            this.chartvientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartvientos.Name = "chartvientos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Viento";
            this.chartvientos.Series.Add(series2);
            this.chartvientos.Size = new System.Drawing.Size(405, 173);
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
            this.radiomilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiomilla.ForeColor = System.Drawing.Color.White;
            this.radiomilla.Location = new System.Drawing.Point(406, 21);
            this.radiomilla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiomilla.Name = "radiomilla";
            this.radiomilla.Size = new System.Drawing.Size(62, 22);
            this.radiomilla.TabIndex = 40;
            this.radiomilla.TabStop = true;
            this.radiomilla.Text = "ML/H";
            this.radiomilla.UseVisualStyleBackColor = true;
            // 
            // radiokilo
            // 
            this.radiokilo.AutoSize = true;
            this.radiokilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiokilo.ForeColor = System.Drawing.Color.White;
            this.radiokilo.Location = new System.Drawing.Point(406, 47);
            this.radiokilo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiokilo.Name = "radiokilo";
            this.radiokilo.Size = new System.Drawing.Size(64, 22);
            this.radiokilo.TabIndex = 39;
            this.radiokilo.TabStop = true;
            this.radiokilo.Text = "KM/H";
            this.radiokilo.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(299, 87);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 18);
            this.label.TabIndex = 36;
            this.label.Text = "Escala Beaufort";
            // 
            // progressbeau
            // 
            this.progressbeau.Location = new System.Drawing.Point(302, 113);
            this.progressbeau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressbeau.Name = "progressbeau";
            this.progressbeau.Size = new System.Drawing.Size(178, 19);
            this.progressbeau.TabIndex = 35;
            // 
            // txtmed
            // 
            this.txtmed.Location = new System.Drawing.Point(151, 112);
            this.txtmed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmed.Name = "txtmed";
            this.txtmed.Size = new System.Drawing.Size(109, 20);
            this.txtmed.TabIndex = 34;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(151, 67);
            this.txtmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(109, 20);
            this.txtmin.TabIndex = 33;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(151, 24);
            this.txtmax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(109, 20);
            this.txtmax.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Velocidad Media:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Velocidad Mínima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Velocidad Máxima:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "[ Viento ]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 43);
            this.panel3.TabIndex = 82;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::ClimateReports.Properties.Resources.impresora_1;
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 36);
            this.button5.TabIndex = 65;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Imprimir Reporte";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(12, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 43);
            this.panel4.TabIndex = 81;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ClimateReports.Properties.Resources.carta_1;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 37);
            this.button3.TabIndex = 67;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(59, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 68;
            this.label8.Text = "Enviar por Correo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 43);
            this.panel2.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(59, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Generar Reporte";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ClimateReports.Properties.Resources.clipboard_1;
            this.button2.Location = new System.Drawing.Point(4, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 39);
            this.button2.TabIndex = 73;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.progressbeau);
            this.panel1.Controls.Add(this.radiomilla);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.radiokilo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtmax);
            this.panel1.Controls.Add(this.txtmin);
            this.panel1.Controls.Add(this.txtmed);
            this.panel1.Location = new System.Drawing.Point(204, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 152);
            this.panel1.TabIndex = 83;
            // 
            // Viento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(753, 469);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartvientos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Viento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Viento_FormClosed);
            this.Load += new System.EventHandler(this.Viento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartvientos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartvientos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radiomilla;
        private System.Windows.Forms.RadioButton radiokilo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ProgressBar progressbeau;
        private System.Windows.Forms.TextBox txtmed;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}