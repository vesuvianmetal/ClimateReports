namespace ClimateReports
{
    partial class Reporte_General
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtporhumedad = new System.Windows.Forms.TextBox();
            this.txtsensor = new System.Windows.Forms.TextBox();
            this.txtviento = new System.Windows.Forms.TextBox();
            this.txtpresion = new System.Windows.Forms.TextBox();
            this.txttemperatura = new System.Windows.Forms.TextBox();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btncomentario = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnenviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte General";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(969, 246);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sensor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "% Humedad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Viento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Presion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Temperatura:";
            // 
            // txtporhumedad
            // 
            this.txtporhumedad.Location = new System.Drawing.Point(149, 349);
            this.txtporhumedad.Name = "txtporhumedad";
            this.txtporhumedad.Size = new System.Drawing.Size(100, 22);
            this.txtporhumedad.TabIndex = 7;
            // 
            // txtsensor
            // 
            this.txtsensor.Location = new System.Drawing.Point(149, 323);
            this.txtsensor.Name = "txtsensor";
            this.txtsensor.Size = new System.Drawing.Size(100, 22);
            this.txtsensor.TabIndex = 8;
            // 
            // txtviento
            // 
            this.txtviento.Location = new System.Drawing.Point(149, 379);
            this.txtviento.Name = "txtviento";
            this.txtviento.Size = new System.Drawing.Size(100, 22);
            this.txtviento.TabIndex = 9;
            // 
            // txtpresion
            // 
            this.txtpresion.Location = new System.Drawing.Point(149, 409);
            this.txtpresion.Name = "txtpresion";
            this.txtpresion.Size = new System.Drawing.Size(100, 22);
            this.txtpresion.TabIndex = 10;
            // 
            // txttemperatura
            // 
            this.txttemperatura.Location = new System.Drawing.Point(149, 438);
            this.txttemperatura.Name = "txttemperatura";
            this.txttemperatura.Size = new System.Drawing.Size(100, 22);
            this.txttemperatura.TabIndex = 11;
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(383, 343);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(394, 134);
            this.txtcomentario.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Comentario";
            // 
            // btncomentario
            // 
            this.btncomentario.Location = new System.Drawing.Point(383, 483);
            this.btncomentario.Name = "btncomentario";
            this.btncomentario.Size = new System.Drawing.Size(75, 23);
            this.btncomentario.TabIndex = 14;
            this.btncomentario.Text = "Enviar";
            this.btncomentario.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(801, 531);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 15;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(901, 531);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 16;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            // 
            // Reporte_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 587);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btncomentario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.txttemperatura);
            this.Controls.Add(this.txtpresion);
            this.Controls.Add(this.txtviento);
            this.Controls.Add(this.txtsensor);
            this.Controls.Add(this.txtporhumedad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Reporte_General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte General";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtporhumedad;
        private System.Windows.Forms.TextBox txtsensor;
        private System.Windows.Forms.TextBox txtviento;
        private System.Windows.Forms.TextBox txtpresion;
        private System.Windows.Forms.TextBox txttemperatura;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncomentario;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnenviar;
    }
}