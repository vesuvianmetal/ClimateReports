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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.respuestatmax = new System.Windows.Forms.TextBox();
            this.radiocel = new System.Windows.Forms.RadioButton();
            this.radiofar = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDetalladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarUnProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesaDeAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proporcionarUnaSugerenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.climateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llenar_grafica = new System.Windows.Forms.Timer(this.components);
            this.llenar_tmax = new System.Windows.Forms.Timer(this.components);
            this.llenar_tmin = new System.Windows.Forms.Timer(this.components);
            this.calcular_tmedia = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.respuestatmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.respuestatmedia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "[ Temperatura ]";
            // 
            // respuestatmax
            // 
            this.respuestatmax.Enabled = false;
            this.respuestatmax.Location = new System.Drawing.Point(219, 64);
            this.respuestatmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.respuestatmax.Multiline = true;
            this.respuestatmax.Name = "respuestatmax";
            this.respuestatmax.ReadOnly = true;
            this.respuestatmax.Size = new System.Drawing.Size(123, 35);
            this.respuestatmax.TabIndex = 7;
            this.respuestatmax.TextChanged += new System.EventHandler(this.txtmax_TextChanged);
            // 
            // radiocel
            // 
            this.radiocel.AutoSize = true;
            this.radiocel.BackColor = System.Drawing.Color.Transparent;
            this.radiocel.Checked = true;
            this.radiocel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiocel.ForeColor = System.Drawing.Color.White;
            this.radiocel.Location = new System.Drawing.Point(175, 18);
            this.radiocel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiocel.Name = "radiocel";
            this.radiocel.Size = new System.Drawing.Size(93, 28);
            this.radiocel.TabIndex = 12;
            this.radiocel.TabStop = true;
            this.radiocel.Text = "Celcius";
            this.radiocel.UseVisualStyleBackColor = false;
            // 
            // radiofar
            // 
            this.radiofar.AutoSize = true;
            this.radiofar.BackColor = System.Drawing.Color.Transparent;
            this.radiofar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiofar.ForeColor = System.Drawing.Color.White;
            this.radiofar.Location = new System.Drawing.Point(21, 18);
            this.radiofar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiofar.Name = "radiofar";
            this.radiofar.Size = new System.Drawing.Size(111, 28);
            this.radiofar.TabIndex = 13;
            this.radiofar.Text = "Farenheit";
            this.radiofar.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderlineColor = System.Drawing.Color.Silver;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            this.chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chart1.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(272, 329);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Temperatura";
            series2.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(713, 234);
            this.chart1.TabIndex = 34;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1004, 28);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDetalladoToolStripMenuItem,
            this.inicioToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // reporteDetalladoToolStripMenuItem
            // 
            this.reporteDetalladoToolStripMenuItem.Name = "reporteDetalladoToolStripMenuItem";
            this.reporteDetalladoToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.reporteDetalladoToolStripMenuItem.Text = "Reporte Detallado";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportarUnProblemaToolStripMenuItem,
            this.mesaDeAyudaToolStripMenuItem,
            this.proporcionarUnaSugerenciaToolStripMenuItem,
            this.soporteTecnicoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // reportarUnProblemaToolStripMenuItem
            // 
            this.reportarUnProblemaToolStripMenuItem.Name = "reportarUnProblemaToolStripMenuItem";
            this.reportarUnProblemaToolStripMenuItem.Size = new System.Drawing.Size(328, 26);
            this.reportarUnProblemaToolStripMenuItem.Text = "Ver la Ayuda";
            // 
            // mesaDeAyudaToolStripMenuItem
            // 
            this.mesaDeAyudaToolStripMenuItem.Name = "mesaDeAyudaToolStripMenuItem";
            this.mesaDeAyudaToolStripMenuItem.Size = new System.Drawing.Size(328, 26);
            this.mesaDeAyudaToolStripMenuItem.Text = "Notificar un Problema";
            // 
            // proporcionarUnaSugerenciaToolStripMenuItem
            // 
            this.proporcionarUnaSugerenciaToolStripMenuItem.Name = "proporcionarUnaSugerenciaToolStripMenuItem";
            this.proporcionarUnaSugerenciaToolStripMenuItem.Size = new System.Drawing.Size(328, 26);
            this.proporcionarUnaSugerenciaToolStripMenuItem.Text = "Proporcionar una Sugerencia";
            // 
            // soporteTecnicoToolStripMenuItem
            // 
            this.soporteTecnicoToolStripMenuItem.Name = "soporteTecnicoToolStripMenuItem";
            this.soporteTecnicoToolStripMenuItem.Size = new System.Drawing.Size(328, 26);
            this.soporteTecnicoToolStripMenuItem.Text = "Soporte Tecnico";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.climateReportsToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // climateReportsToolStripMenuItem
            // 
            this.climateReportsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.climateReportsToolStripMenuItem.Name = "climateReportsToolStripMenuItem";
            this.climateReportsToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.climateReportsToolStripMenuItem.Text = "Climate Reports";
            // 
            // llenar_grafica
            // 
            this.llenar_grafica.Interval = 10000;
            this.llenar_grafica.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // llenar_tmax
            // 
            this.llenar_tmax.Enabled = true;
            this.llenar_tmax.Interval = 10000;
            this.llenar_tmax.Tick += new System.EventHandler(this.llenar_tmax_Tick);
            // 
            // llenar_tmin
            // 
            this.llenar_tmin.Enabled = true;
            this.llenar_tmin.Interval = 10000;
            this.llenar_tmin.Tick += new System.EventHandler(this.llenar_tmin_Tick);
            // 
            // calcular_tmedia
            // 
            this.calcular_tmedia.Enabled = true;
            this.calcular_tmedia.Interval = 11000;
            this.calcular_tmedia.Tick += new System.EventHandler(this.calcular_tmedia_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "Temperatura Maxima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Temperatura Minima";
            // 
            // respuestatmin
            // 
            this.respuestatmin.Enabled = false;
            this.respuestatmin.Location = new System.Drawing.Point(219, 121);
            this.respuestatmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.respuestatmin.Multiline = true;
            this.respuestatmin.Name = "respuestatmin";
            this.respuestatmin.ReadOnly = true;
            this.respuestatmin.Size = new System.Drawing.Size(123, 35);
            this.respuestatmin.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(364, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "Sensación Termica";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(565, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 35);
            this.textBox2.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(364, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Temperatura Media";
            // 
            // respuestatmedia
            // 
            this.respuestatmedia.Enabled = false;
            this.respuestatmedia.Location = new System.Drawing.Point(565, 113);
            this.respuestatmedia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.respuestatmedia.Multiline = true;
            this.respuestatmedia.Name = "respuestatmedia";
            this.respuestatmedia.ReadOnly = true;
            this.respuestatmedia.Size = new System.Drawing.Size(123, 35);
            this.respuestatmedia.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.respuestatmedia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.respuestatmin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radiofar);
            this.panel1.Controls.Add(this.radiocel);
            this.panel1.Controls.Add(this.respuestatmax);
            this.panel1.Location = new System.Drawing.Point(272, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 178);
            this.panel1.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(16, 217);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 53);
            this.panel3.TabIndex = 79;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::ClimateReports.Properties.Resources.impresora_1;
            this.button5.Location = new System.Drawing.Point(4, 4);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 44);
            this.button5.TabIndex = 65;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Imprimir Reporte";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(16, 304);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 53);
            this.panel4.TabIndex = 78;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ClimateReports.Properties.Resources.carta_1;
            this.button3.Location = new System.Drawing.Point(4, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 46);
            this.button3.TabIndex = 67;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(79, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "Enviar por Correo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(16, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 53);
            this.panel2.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(79, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Generar Reporte";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ClimateReports.Properties.Resources.clipboard_1;
            this.button2.Location = new System.Drawing.Point(5, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 48);
            this.button2.TabIndex = 73;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1004, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Temperatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperatura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Temperatura_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Temperatura_FormClosed);
            this.Load += new System.EventHandler(this.Temperatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox respuestatmax;
        private System.Windows.Forms.RadioButton radiocel;
        private System.Windows.Forms.RadioButton radiofar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarUnProblemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesaDeAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proporcionarUnaSugerenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem climateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDetalladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Timer llenar_grafica;
        private System.Windows.Forms.Timer llenar_tmax;
        private System.Windows.Forms.Timer llenar_tmin;
        private System.Windows.Forms.Timer calcular_tmedia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox respuestatmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox respuestatmedia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}