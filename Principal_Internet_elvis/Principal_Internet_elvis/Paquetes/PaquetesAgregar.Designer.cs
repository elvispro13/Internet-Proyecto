namespace Principal_Internet_elvis.Paquetes
{
    partial class PaquetesAgregar
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
            this.gb_codigo = new System.Windows.Forms.GroupBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.gb_c1 = new System.Windows.Forms.GroupBox();
            this.txt_c1 = new System.Windows.Forms.TextBox();
            this.gb_c2 = new System.Windows.Forms.GroupBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.txt_c2 = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.cb_inactivos = new System.Windows.Forms.CheckBox();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_burst_time = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_burst_time_2 = new System.Windows.Forms.TextBox();
            this.txt_burst_time_1 = new System.Windows.Forms.TextBox();
            this.gb_burst_threshold = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_burst_threshold_2 = new System.Windows.Forms.TextBox();
            this.txt_burst_threshold_1 = new System.Windows.Forms.TextBox();
            this.gb_burst_limit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_burst_limit_2 = new System.Windows.Forms.TextBox();
            this.txt_burst_limit_1 = new System.Windows.Forms.TextBox();
            this.gb_max_limit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_max_limit_2 = new System.Windows.Forms.TextBox();
            this.txt_max_limit_1 = new System.Windows.Forms.TextBox();
            this.bt_servicios = new System.Windows.Forms.PictureBox();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.tm_inicio = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_codigo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_c1.SuspendLayout();
            this.gb_c2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.gb_datos.SuspendLayout();
            this.gb_burst_time.SuspendLayout();
            this.gb_burst_threshold.SuspendLayout();
            this.gb_burst_limit.SuspendLayout();
            this.gb_max_limit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_servicios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_codigo
            // 
            this.gb_codigo.Controls.Add(this.txt_codigo);
            this.gb_codigo.Location = new System.Drawing.Point(211, 12);
            this.gb_codigo.Name = "gb_codigo";
            this.gb_codigo.Size = new System.Drawing.Size(234, 51);
            this.gb_codigo.TabIndex = 0;
            this.gb_codigo.TabStop = false;
            this.gb_codigo.Text = "CODIGO";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(6, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(221, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_descripcion);
            this.groupBox2.Location = new System.Drawing.Point(211, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DESCRIPCION/BUSCAR";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descripcion.Location = new System.Drawing.Point(6, 19);
            this.txt_descripcion.MaxLength = 255;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(221, 20);
            this.txt_descripcion.TabIndex = 1;
            this.txt_descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_descripcion_KeyDown);
            // 
            // gb_c1
            // 
            this.gb_c1.Controls.Add(this.txt_c1);
            this.gb_c1.Location = new System.Drawing.Point(211, 127);
            this.gb_c1.Name = "gb_c1";
            this.gb_c1.Size = new System.Drawing.Size(234, 51);
            this.gb_c1.TabIndex = 2;
            this.gb_c1.TabStop = false;
            this.gb_c1.Text = "CAMPO1";
            // 
            // txt_c1
            // 
            this.txt_c1.Location = new System.Drawing.Point(6, 19);
            this.txt_c1.MaxLength = 20;
            this.txt_c1.Name = "txt_c1";
            this.txt_c1.Size = new System.Drawing.Size(221, 20);
            this.txt_c1.TabIndex = 1;
            this.txt_c1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_c1_KeyPress);
            // 
            // gb_c2
            // 
            this.gb_c2.Controls.Add(this.bt_calcular);
            this.gb_c2.Controls.Add(this.txt_c2);
            this.gb_c2.Location = new System.Drawing.Point(211, 184);
            this.gb_c2.Name = "gb_c2";
            this.gb_c2.Size = new System.Drawing.Size(234, 51);
            this.gb_c2.TabIndex = 3;
            this.gb_c2.TabStop = false;
            this.gb_c2.Text = "CAMPO2";
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(168, 17);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(60, 23);
            this.bt_calcular.TabIndex = 20;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // txt_c2
            // 
            this.txt_c2.Location = new System.Drawing.Point(6, 19);
            this.txt_c2.MaxLength = 20;
            this.txt_c2.Name = "txt_c2";
            this.txt_c2.ReadOnly = true;
            this.txt_c2.Size = new System.Drawing.Size(156, 20);
            this.txt_c2.TabIndex = 1;
            this.txt_c2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_c2_KeyPress);
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
            this.dgv_tabla.Location = new System.Drawing.Point(451, 12);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(617, 482);
            this.dgv_tabla.TabIndex = 6;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            // 
            // cb_inactivos
            // 
            this.cb_inactivos.AutoSize = true;
            this.cb_inactivos.Location = new System.Drawing.Point(6, 43);
            this.cb_inactivos.Name = "cb_inactivos";
            this.cb_inactivos.Size = new System.Drawing.Size(87, 17);
            this.cb_inactivos.TabIndex = 18;
            this.cb_inactivos.Text = "Ver inactivos";
            this.cb_inactivos.UseVisualStyleBackColor = true;
            this.cb_inactivos.CheckedChanged += new System.EventHandler(this.cb_inactivos_CheckedChanged);
            // 
            // gb_datos
            // 
            this.gb_datos.Controls.Add(this.label6);
            this.gb_datos.Controls.Add(this.label5);
            this.gb_datos.Controls.Add(this.gb_burst_time);
            this.gb_datos.Controls.Add(this.gb_burst_threshold);
            this.gb_datos.Controls.Add(this.gb_burst_limit);
            this.gb_datos.Controls.Add(this.gb_max_limit);
            this.gb_datos.Location = new System.Drawing.Point(12, 12);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(193, 258);
            this.gb_datos.TabIndex = 19;
            this.gb_datos.TabStop = false;
            this.gb_datos.Text = "DATOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Bajada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Subida";
            // 
            // gb_burst_time
            // 
            this.gb_burst_time.Controls.Add(this.label4);
            this.gb_burst_time.Controls.Add(this.txt_burst_time_2);
            this.gb_burst_time.Controls.Add(this.txt_burst_time_1);
            this.gb_burst_time.Location = new System.Drawing.Point(6, 184);
            this.gb_burst_time.Name = "gb_burst_time";
            this.gb_burst_time.Size = new System.Drawing.Size(178, 42);
            this.gb_burst_time.TabIndex = 14;
            this.gb_burst_time.TabStop = false;
            this.gb_burst_time.Text = "BURST-TIME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "/";
            // 
            // txt_burst_time_2
            // 
            this.txt_burst_time_2.Location = new System.Drawing.Point(97, 19);
            this.txt_burst_time_2.Name = "txt_burst_time_2";
            this.txt_burst_time_2.Size = new System.Drawing.Size(71, 20);
            this.txt_burst_time_2.TabIndex = 9;
            // 
            // txt_burst_time_1
            // 
            this.txt_burst_time_1.Location = new System.Drawing.Point(7, 19);
            this.txt_burst_time_1.Name = "txt_burst_time_1";
            this.txt_burst_time_1.Size = new System.Drawing.Size(71, 20);
            this.txt_burst_time_1.TabIndex = 8;
            // 
            // gb_burst_threshold
            // 
            this.gb_burst_threshold.Controls.Add(this.label3);
            this.gb_burst_threshold.Controls.Add(this.txt_burst_threshold_2);
            this.gb_burst_threshold.Controls.Add(this.txt_burst_threshold_1);
            this.gb_burst_threshold.Location = new System.Drawing.Point(6, 135);
            this.gb_burst_threshold.Name = "gb_burst_threshold";
            this.gb_burst_threshold.Size = new System.Drawing.Size(178, 42);
            this.gb_burst_threshold.TabIndex = 13;
            this.gb_burst_threshold.TabStop = false;
            this.gb_burst_threshold.Text = "BURST-THRESHOLD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "/";
            // 
            // txt_burst_threshold_2
            // 
            this.txt_burst_threshold_2.Location = new System.Drawing.Point(97, 19);
            this.txt_burst_threshold_2.Name = "txt_burst_threshold_2";
            this.txt_burst_threshold_2.Size = new System.Drawing.Size(71, 20);
            this.txt_burst_threshold_2.TabIndex = 7;
            // 
            // txt_burst_threshold_1
            // 
            this.txt_burst_threshold_1.Location = new System.Drawing.Point(7, 19);
            this.txt_burst_threshold_1.Name = "txt_burst_threshold_1";
            this.txt_burst_threshold_1.Size = new System.Drawing.Size(71, 20);
            this.txt_burst_threshold_1.TabIndex = 6;
            // 
            // gb_burst_limit
            // 
            this.gb_burst_limit.Controls.Add(this.label2);
            this.gb_burst_limit.Controls.Add(this.txt_burst_limit_2);
            this.gb_burst_limit.Controls.Add(this.txt_burst_limit_1);
            this.gb_burst_limit.Location = new System.Drawing.Point(6, 87);
            this.gb_burst_limit.Name = "gb_burst_limit";
            this.gb_burst_limit.Size = new System.Drawing.Size(178, 42);
            this.gb_burst_limit.TabIndex = 12;
            this.gb_burst_limit.TabStop = false;
            this.gb_burst_limit.Text = "BURST-LIMIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "/";
            // 
            // txt_burst_limit_2
            // 
            this.txt_burst_limit_2.Location = new System.Drawing.Point(97, 19);
            this.txt_burst_limit_2.Name = "txt_burst_limit_2";
            this.txt_burst_limit_2.Size = new System.Drawing.Size(71, 20);
            this.txt_burst_limit_2.TabIndex = 5;
            // 
            // txt_burst_limit_1
            // 
            this.txt_burst_limit_1.Location = new System.Drawing.Point(7, 19);
            this.txt_burst_limit_1.Name = "txt_burst_limit_1";
            this.txt_burst_limit_1.Size = new System.Drawing.Size(71, 20);
            this.txt_burst_limit_1.TabIndex = 4;
            // 
            // gb_max_limit
            // 
            this.gb_max_limit.Controls.Add(this.label1);
            this.gb_max_limit.Controls.Add(this.txt_max_limit_2);
            this.gb_max_limit.Controls.Add(this.txt_max_limit_1);
            this.gb_max_limit.Location = new System.Drawing.Point(6, 39);
            this.gb_max_limit.Name = "gb_max_limit";
            this.gb_max_limit.Size = new System.Drawing.Size(178, 42);
            this.gb_max_limit.TabIndex = 10;
            this.gb_max_limit.TabStop = false;
            this.gb_max_limit.Text = "MAX-LIMIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "/";
            // 
            // txt_max_limit_2
            // 
            this.txt_max_limit_2.Location = new System.Drawing.Point(97, 19);
            this.txt_max_limit_2.Name = "txt_max_limit_2";
            this.txt_max_limit_2.Size = new System.Drawing.Size(71, 20);
            this.txt_max_limit_2.TabIndex = 3;
            // 
            // txt_max_limit_1
            // 
            this.txt_max_limit_1.Location = new System.Drawing.Point(7, 19);
            this.txt_max_limit_1.Name = "txt_max_limit_1";
            this.txt_max_limit_1.Size = new System.Drawing.Size(71, 20);
            this.txt_max_limit_1.TabIndex = 2;
            // 
            // bt_servicios
            // 
            this.bt_servicios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_servicios.Image = global::Principal_Internet_elvis.Properties.Resources.servicios_grande;
            this.bt_servicios.Location = new System.Drawing.Point(181, 506);
            this.bt_servicios.Name = "bt_servicios";
            this.bt_servicios.Size = new System.Drawing.Size(98, 94);
            this.bt_servicios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_servicios.TabIndex = 20;
            this.bt_servicios.TabStop = false;
            this.bt_servicios.Click += new System.EventHandler(this.bt_servicios_Click);
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Image = global::Principal_Internet_elvis.Properties.Resources.rounded_add_button_icon_icons_com_72592;
            this.bt_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_nuevo.Location = new System.Drawing.Point(99, 19);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(130, 63);
            this.bt_nuevo.TabIndex = 10;
            this.bt_nuevo.Text = "CREAR";
            this.bt_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_nuevo.UseVisualStyleBackColor = true;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscar.Location = new System.Drawing.Point(371, 19);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(130, 63);
            this.bt_buscar.TabIndex = 9;
            this.bt_buscar.Text = "BUSCAR";
            this.bt_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Image = global::Principal_Internet_elvis.Properties.Resources._9;
            this.bt_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_eliminar.Location = new System.Drawing.Point(507, 19);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(130, 63);
            this.bt_eliminar.TabIndex = 8;
            this.bt_eliminar.Text = "ESTADO";
            this.bt_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Image = global::Principal_Internet_elvis.Properties.Resources._8;
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(643, 19);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(130, 63);
            this.bt_salir.TabIndex = 5;
            this.bt_salir.Text = "SALIR";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Image = global::Principal_Internet_elvis.Properties.Resources.savetheapplication_guardar_2958_1_;
            this.bt_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_guardar.Location = new System.Drawing.Point(235, 19);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(130, 63);
            this.bt_guardar.TabIndex = 4;
            this.bt_guardar.Text = "GUARDAR";
            this.bt_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // tm_inicio
            // 
            this.tm_inicio.Enabled = true;
            this.tm_inicio.Interval = 500;
            this.tm_inicio.Tick += new System.EventHandler(this.tm_inicio_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bt_nuevo);
            this.groupBox1.Controls.Add(this.cb_inactivos);
            this.groupBox1.Controls.Add(this.bt_guardar);
            this.groupBox1.Controls.Add(this.bt_eliminar);
            this.groupBox1.Controls.Add(this.bt_salir);
            this.groupBox1.Controls.Add(this.bt_buscar);
            this.groupBox1.Location = new System.Drawing.Point(285, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCIONES";
            // 
            // PaquetesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_servicios);
            this.Controls.Add(this.gb_datos);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.gb_c2);
            this.Controls.Add(this.gb_c1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaquetesAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaquetesAgregar";
            this.Load += new System.EventHandler(this.PaquetesAgregar_Load);
            this.gb_codigo.ResumeLayout(false);
            this.gb_codigo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_c1.ResumeLayout(false);
            this.gb_c1.PerformLayout();
            this.gb_c2.ResumeLayout(false);
            this.gb_c2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.gb_datos.ResumeLayout(false);
            this.gb_datos.PerformLayout();
            this.gb_burst_time.ResumeLayout(false);
            this.gb_burst_time.PerformLayout();
            this.gb_burst_threshold.ResumeLayout(false);
            this.gb_burst_threshold.PerformLayout();
            this.gb_burst_limit.ResumeLayout(false);
            this.gb_burst_limit.PerformLayout();
            this.gb_max_limit.ResumeLayout(false);
            this.gb_max_limit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_servicios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.GroupBox gb_c1;
        private System.Windows.Forms.TextBox txt_c1;
        private System.Windows.Forms.GroupBox gb_c2;
        private System.Windows.Forms.TextBox txt_c2;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.CheckBox cb_inactivos;
        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.GroupBox gb_burst_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_burst_time_2;
        private System.Windows.Forms.TextBox txt_burst_time_1;
        private System.Windows.Forms.GroupBox gb_burst_threshold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_burst_threshold_2;
        private System.Windows.Forms.TextBox txt_burst_threshold_1;
        private System.Windows.Forms.GroupBox gb_burst_limit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_burst_limit_2;
        private System.Windows.Forms.TextBox txt_burst_limit_1;
        private System.Windows.Forms.GroupBox gb_max_limit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_max_limit_2;
        private System.Windows.Forms.TextBox txt_max_limit_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.PictureBox bt_servicios;
        private System.Windows.Forms.Timer tm_inicio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}