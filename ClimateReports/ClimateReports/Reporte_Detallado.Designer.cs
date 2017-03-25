namespace ClimateReports
{
    partial class Reporte_Detallado
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempraturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesaDeAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttemperatura = new System.Windows.Forms.TextBox();
            this.txtpresion = new System.Windows.Forms.TextBox();
            this.txtviento = new System.Windows.Forms.TextBox();
            this.txtsensor = new System.Windows.Forms.TextBox();
            this.txtporhumedad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncomentario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempraturaToolStripMenuItem,
            this.vientoToolStripMenuItem,
            this.humedadToolStripMenuItem,
            this.presionToolStripMenuItem});
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.modulosToolStripMenuItem.Text = "Modulos";
            // 
            // tempraturaToolStripMenuItem
            // 
            this.tempraturaToolStripMenuItem.Name = "tempraturaToolStripMenuItem";
            this.tempraturaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.tempraturaToolStripMenuItem.Text = "Tempratura";
            this.tempraturaToolStripMenuItem.Click += new System.EventHandler(this.tempraturaToolStripMenuItem_Click);
            // 
            // vientoToolStripMenuItem
            // 
            this.vientoToolStripMenuItem.Name = "vientoToolStripMenuItem";
            this.vientoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.vientoToolStripMenuItem.Text = "Viento";
            // 
            // humedadToolStripMenuItem
            // 
            this.humedadToolStripMenuItem.Name = "humedadToolStripMenuItem";
            this.humedadToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.humedadToolStripMenuItem.Text = "Humedad";
            // 
            // presionToolStripMenuItem
            // 
            this.presionToolStripMenuItem.Name = "presionToolStripMenuItem";
            this.presionToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.presionToolStripMenuItem.Text = "Presion";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesaDeAyudaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // mesaDeAyudaToolStripMenuItem
            // 
            this.mesaDeAyudaToolStripMenuItem.Name = "mesaDeAyudaToolStripMenuItem";
            this.mesaDeAyudaToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.mesaDeAyudaToolStripMenuItem.Text = "Mesa De Ayuda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 282);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte Detallado";
            // 
            // txttemperatura
            // 
            this.txttemperatura.Location = new System.Drawing.Point(144, 486);
            this.txttemperatura.Name = "txttemperatura";
            this.txttemperatura.Size = new System.Drawing.Size(100, 22);
            this.txttemperatura.TabIndex = 21;
            // 
            // txtpresion
            // 
            this.txtpresion.Location = new System.Drawing.Point(144, 457);
            this.txtpresion.Name = "txtpresion";
            this.txtpresion.Size = new System.Drawing.Size(100, 22);
            this.txtpresion.TabIndex = 20;
            // 
            // txtviento
            // 
            this.txtviento.Location = new System.Drawing.Point(144, 427);
            this.txtviento.Name = "txtviento";
            this.txtviento.Size = new System.Drawing.Size(100, 22);
            this.txtviento.TabIndex = 19;
            // 
            // txtsensor
            // 
            this.txtsensor.Location = new System.Drawing.Point(144, 371);
            this.txtsensor.Name = "txtsensor";
            this.txtsensor.Size = new System.Drawing.Size(100, 22);
            this.txtsensor.TabIndex = 18;
            // 
            // txtporhumedad
            // 
            this.txtporhumedad.Location = new System.Drawing.Point(144, 397);
            this.txtporhumedad.Name = "txtporhumedad";
            this.txtporhumedad.Size = new System.Drawing.Size(100, 22);
            this.txtporhumedad.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Temperatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Presion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Viento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "% Humedad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sensor:";
            // 
            // btncomentario
            // 
            this.btncomentario.Location = new System.Drawing.Point(351, 534);
            this.btncomentario.Name = "btncomentario";
            this.btncomentario.Size = new System.Drawing.Size(75, 23);
            this.btncomentario.TabIndex = 24;
            this.btncomentario.Text = "Enviar";
            this.btncomentario.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Comentario";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(351, 394);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(394, 134);
            this.txtcomentario.TabIndex = 22;
            // 
            // Reporte_Detallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 578);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reporte_Detallado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Detallado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempraturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humedadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesaDeAyudaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttemperatura;
        private System.Windows.Forms.TextBox txtpresion;
        private System.Windows.Forms.TextBox txtviento;
        private System.Windows.Forms.TextBox txtsensor;
        private System.Windows.Forms.TextBox txtporhumedad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncomentario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcomentario;
    }
}