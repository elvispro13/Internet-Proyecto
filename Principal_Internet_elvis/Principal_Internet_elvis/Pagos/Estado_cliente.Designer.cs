﻿namespace Principal_Internet_elvis.Configuraciones
{
    partial class Estado_cliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.bt_estado = new System.Windows.Forms.Button();
            this.bt_ping = new System.Windows.Forms.Button();
            this.bt_antena = new System.Windows.Forms.Button();
            this.tm_inicio = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgv_tabla);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTADO DEL CONTRATO";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txt_buscar);
            this.groupBox4.Controls.Add(this.bt_buscar);
            this.groupBox4.Location = new System.Drawing.Point(617, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 62);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BUSCADOR";
            // 
            // txt_buscar
            // 
            this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_buscar.Location = new System.Drawing.Point(6, 20);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(277, 21);
            this.txt_buscar.TabIndex = 3;
            this.txt_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyDown);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_buscar.Location = new System.Drawing.Point(289, 9);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(120, 44);
            this.bt_buscar.TabIndex = 4;
            this.bt_buscar.Text = "BUSCAR";
            this.bt_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_estado);
            this.groupBox3.Location = new System.Drawing.Point(12, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 53);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ESTADO DEL PAQUETE DEL CLIENTE";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "PENDIENTE INSTALACION",
            "SERVICIO ACTIVO",
            "CORTE DE SERVICIO"});
            this.cb_estado.Location = new System.Drawing.Point(6, 20);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(324, 23);
            this.cb_estado.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_descripcion);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 49);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOTA DE CAMBIO DE ESTADO";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descripcion.Location = new System.Drawing.Point(6, 20);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(503, 21);
            this.txt_descripcion.TabIndex = 0;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(6, 131);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(1028, 363);
            this.dgv_tabla.TabIndex = 1;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Principal_Internet_elvis.Properties.Resources._8;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(932, 518);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 66);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bt_estado
            // 
            this.bt_estado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_estado.Image = global::Principal_Internet_elvis.Properties.Resources._9;
            this.bt_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_estado.Location = new System.Drawing.Point(728, 518);
            this.bt_estado.Name = "bt_estado";
            this.bt_estado.Size = new System.Drawing.Size(198, 66);
            this.bt_estado.TabIndex = 3;
            this.bt_estado.Text = "CAMBIAR ESTADO";
            this.bt_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_estado.UseVisualStyleBackColor = true;
            this.bt_estado.Click += new System.EventHandler(this.bt_estado_Click);
            // 
            // bt_ping
            // 
            this.bt_ping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ping.Location = new System.Drawing.Point(559, 518);
            this.bt_ping.Name = "bt_ping";
            this.bt_ping.Size = new System.Drawing.Size(163, 66);
            this.bt_ping.TabIndex = 4;
            this.bt_ping.Text = "HACER PING";
            this.bt_ping.UseVisualStyleBackColor = true;
            this.bt_ping.Click += new System.EventHandler(this.bt_ping_Click);
            // 
            // bt_antena
            // 
            this.bt_antena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_antena.Location = new System.Drawing.Point(390, 518);
            this.bt_antena.Name = "bt_antena";
            this.bt_antena.Size = new System.Drawing.Size(163, 66);
            this.bt_antena.TabIndex = 5;
            this.bt_antena.Text = "ABRIR ANTENA";
            this.bt_antena.UseVisualStyleBackColor = true;
            this.bt_antena.Click += new System.EventHandler(this.bt_antena_Click);
            // 
            // tm_inicio
            // 
            this.tm_inicio.Enabled = true;
            this.tm_inicio.Interval = 500;
            this.tm_inicio.Tick += new System.EventHandler(this.tm_inicio_Tick);
            // 
            // Estado_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1064, 596);
            this.ControlBox = false;
            this.Controls.Add(this.bt_antena);
            this.Controls.Add(this.bt_ping);
            this.Controls.Add(this.bt_estado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Estado_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Estado_cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Button bt_estado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_ping;
        private System.Windows.Forms.Button bt_antena;
        private System.Windows.Forms.Timer tm_inicio;
    }
}