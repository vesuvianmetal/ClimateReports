﻿namespace ClimateReports
{
    partial class Interfaz_Admin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combousuario = new System.Windows.Forms.ComboBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtdelnombre = new System.Windows.Forms.TextBox();
            this.txtdelpat = new System.Windows.Forms.TextBox();
            this.txtdelmat = new System.Windows.Forms.TextBox();
            this.txtdelusuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtconfcon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdelemail = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label16 = new System.Windows.Forms.Label();
            this.txtdelid = new System.Windows.Forms.TextBox();
            this.txtdeltelefono = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combousuario);
            this.groupBox1.Controls.Add(this.txtcontraseña);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txtam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // combousuario
            // 
            this.combousuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combousuario.FormattingEnabled = true;
            this.combousuario.Items.AddRange(new object[] {
            "Administrador",
            "General"});
            this.combousuario.Location = new System.Drawing.Point(5, 354);
            this.combousuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combousuario.Name = "combousuario";
            this.combousuario.Size = new System.Drawing.Size(185, 24);
            this.combousuario.TabIndex = 7;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(3, 409);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcontraseña.MaxLength = 45;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(188, 22);
            this.txtcontraseña.TabIndex = 8;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 388);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Contraseña:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(5, 298);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.MaxLength = 45;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(188, 22);
            this.txtemail.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Tipo De Usuario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Correo Electronico:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(5, 242);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttelefono.MaxLength = 13;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(188, 22);
            this.txttelefono.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Telefono:";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(4, 436);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(187, 49);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtam
            // 
            this.txtam.Location = new System.Drawing.Point(5, 187);
            this.txtam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtam.MaxLength = 20;
            this.txtam.Name = "txtam";
            this.txtam.Size = new System.Drawing.Size(188, 22);
            this.txtam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido Materno:";
            // 
            // txtap
            // 
            this.txtap.Location = new System.Drawing.Point(5, 138);
            this.txtap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtap.MaxLength = 20;
            this.txtap.Name = "txtap";
            this.txtap.Size = new System.Drawing.Size(188, 22);
            this.txtap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Paterno:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(5, 89);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(188, 22);
            this.txtnombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(9, 39);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusuario.MaxLength = 20;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(185, 22);
            this.txtusuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 217);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnlimpiar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Location = new System.Drawing.Point(12, 559);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(200, 137);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(5, 78);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(187, 49);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "Limpiar Campos";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(7, 22);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(187, 49);
            this.btneliminar.TabIndex = 0;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtdelnombre
            // 
            this.txtdelnombre.Location = new System.Drawing.Point(245, 414);
            this.txtdelnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdelnombre.Name = "txtdelnombre";
            this.txtdelnombre.ReadOnly = true;
            this.txtdelnombre.Size = new System.Drawing.Size(141, 22);
            this.txtdelnombre.TabIndex = 4;
            // 
            // txtdelpat
            // 
            this.txtdelpat.Location = new System.Drawing.Point(245, 468);
            this.txtdelpat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdelpat.Name = "txtdelpat";
            this.txtdelpat.ReadOnly = true;
            this.txtdelpat.Size = new System.Drawing.Size(141, 22);
            this.txtdelpat.TabIndex = 5;
            // 
            // txtdelmat
            // 
            this.txtdelmat.Location = new System.Drawing.Point(245, 519);
            this.txtdelmat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdelmat.Name = "txtdelmat";
            this.txtdelmat.ReadOnly = true;
            this.txtdelmat.Size = new System.Drawing.Size(141, 22);
            this.txtdelmat.TabIndex = 6;
            // 
            // txtdelusuario
            // 
            this.txtdelusuario.Location = new System.Drawing.Point(245, 359);
            this.txtdelusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdelusuario.Name = "txtdelusuario";
            this.txtdelusuario.ReadOnly = true;
            this.txtdelusuario.Size = new System.Drawing.Size(141, 22);
            this.txtdelusuario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Apellido Paterno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Apellido Materno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Usuario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Confirmar Contraseña:";
            // 
            // txtconfcon
            // 
            this.txtconfcon.Location = new System.Drawing.Point(452, 393);
            this.txtconfcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtconfcon.Name = "txtconfcon";
            this.txtconfcon.Size = new System.Drawing.Size(141, 22);
            this.txtconfcon.TabIndex = 16;
            this.txtconfcon.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Correo Electronico:";
            // 
            // txtdelemail
            // 
            this.txtdelemail.Location = new System.Drawing.Point(452, 444);
            this.txtdelemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdelemail.Name = "txtdelemail";
            this.txtdelemail.ReadOnly = true;
            this.txtdelemail.Size = new System.Drawing.Size(141, 22);
            this.txtdelemail.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.acercaDeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1105, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem1.Text = "Acerca De";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(245, 293);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "ID:";
            // 
            // txtdelid
            // 
            this.txtdelid.Location = new System.Drawing.Point(248, 315);
            this.txtdelid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdelid.Name = "txtdelid";
            this.txtdelid.ReadOnly = true;
            this.txtdelid.Size = new System.Drawing.Size(141, 22);
            this.txtdelid.TabIndex = 20;
            // 
            // txtdeltelefono
            // 
            this.txtdeltelefono.Location = new System.Drawing.Point(452, 335);
            this.txtdeltelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdeltelefono.Name = "txtdeltelefono";
            this.txtdeltelefono.ReadOnly = true;
            this.txtdeltelefono.Size = new System.Drawing.Size(141, 22);
            this.txtdeltelefono.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(452, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "Telefono";
            // 
            // Interfaz_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 711);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtdeltelefono);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtdelid);
            this.Controls.Add(this.txtdelemail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtconfcon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdelusuario);
            this.Controls.Add(this.txtdelmat);
            this.Controls.Add(this.txtdelpat);
            this.Controls.Add(this.txtdelnombre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Interfaz_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz_Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Interfaz_Admin_FormClosed);
            this.Load += new System.EventHandler(this.Interfaz_Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtdelnombre;
        private System.Windows.Forms.TextBox txtdelpat;
        private System.Windows.Forms.TextBox txtdelmat;
        private System.Windows.Forms.TextBox txtdelusuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtconfcon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdelemail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox combousuario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtdelid;
        private System.Windows.Forms.TextBox txtdeltelefono;
        private System.Windows.Forms.Label label17;
    }
}