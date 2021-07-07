namespace Principal_Internet_elvis.ClientesCarpeta
{
    partial class Clientes
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
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_rtn = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.rb_femenino = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.bt_lugar = new System.Windows.Forms.Button();
            this.txt_lugar = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.cb_inactivos = new System.Windows.Forms.CheckBox();
            this.bt_paquetes = new System.Windows.Forms.PictureBox();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.tm_inicio = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_paquetes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CODIGO";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(6, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(276, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Location = new System.Drawing.Point(306, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOMBRES-APELLIDOS/BUSCAR";
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(6, 19);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(276, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nombre_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txt_rtn);
            this.groupBox3.Location = new System.Drawing.Point(780, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RTN";
            // 
            // txt_rtn
            // 
            this.txt_rtn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_rtn.Location = new System.Drawing.Point(6, 19);
            this.txt_rtn.Name = "txt_rtn";
            this.txt_rtn.Size = new System.Drawing.Size(276, 20);
            this.txt_rtn.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_telefono);
            this.groupBox5.Location = new System.Drawing.Point(12, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 50);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TELEFONO";
            // 
            // txt_telefono
            // 
            this.txt_telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_telefono.Location = new System.Drawing.Point(6, 19);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(276, 20);
            this.txt_telefono.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.rb_masculino);
            this.groupBox6.Controls.Add(this.rb_femenino);
            this.groupBox6.Location = new System.Drawing.Point(780, 128);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(288, 63);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "GENERO";
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Location = new System.Drawing.Point(6, 42);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(88, 17);
            this.rb_masculino.TabIndex = 7;
            this.rb_masculino.Text = "MASCULINO";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // rb_femenino
            // 
            this.rb_femenino.AutoSize = true;
            this.rb_femenino.Checked = true;
            this.rb_femenino.Location = new System.Drawing.Point(6, 19);
            this.rb_femenino.Name = "rb_femenino";
            this.rb_femenino.Size = new System.Drawing.Size(81, 17);
            this.rb_femenino.TabIndex = 6;
            this.rb_femenino.TabStop = true;
            this.rb_femenino.Text = "FEMENINO";
            this.rb_femenino.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txt_correo);
            this.groupBox7.Location = new System.Drawing.Point(306, 68);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(288, 50);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CORREO";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(6, 19);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(276, 20);
            this.txt_correo.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.dtp_fecha);
            this.groupBox8.Location = new System.Drawing.Point(780, 72);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(288, 50);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "FECHA INGRESO";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(6, 19);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(276, 20);
            this.dtp_fecha.TabIndex = 8;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txt_direccion);
            this.groupBox9.Location = new System.Drawing.Point(12, 124);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(288, 50);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "DETALLE DIRECCION";
            // 
            // txt_direccion
            // 
            this.txt_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_direccion.Location = new System.Drawing.Point(6, 19);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(276, 20);
            this.txt_direccion.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.bt_lugar);
            this.groupBox10.Controls.Add(this.txt_lugar);
            this.groupBox10.Location = new System.Drawing.Point(306, 124);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(288, 50);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "LUGAR";
            // 
            // bt_lugar
            // 
            this.bt_lugar.Location = new System.Drawing.Point(255, 17);
            this.bt_lugar.Name = "bt_lugar";
            this.bt_lugar.Size = new System.Drawing.Size(27, 23);
            this.bt_lugar.TabIndex = 10;
            this.bt_lugar.Text = "...";
            this.bt_lugar.UseVisualStyleBackColor = true;
            this.bt_lugar.Click += new System.EventHandler(this.bt_lugar_Click);
            // 
            // txt_lugar
            // 
            this.txt_lugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_lugar.Location = new System.Drawing.Point(6, 19);
            this.txt_lugar.Name = "txt_lugar";
            this.txt_lugar.Size = new System.Drawing.Size(243, 20);
            this.txt_lugar.TabIndex = 1;
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
            this.dgv_tabla.Location = new System.Drawing.Point(12, 197);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(1056, 368);
            this.dgv_tabla.TabIndex = 10;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellClick);
            // 
            // cb_inactivos
            // 
            this.cb_inactivos.AutoSize = true;
            this.cb_inactivos.Location = new System.Drawing.Point(6, 33);
            this.cb_inactivos.Name = "cb_inactivos";
            this.cb_inactivos.Size = new System.Drawing.Size(87, 17);
            this.cb_inactivos.TabIndex = 17;
            this.cb_inactivos.Text = "Ver inactivos";
            this.cb_inactivos.UseVisualStyleBackColor = true;
            this.cb_inactivos.CheckedChanged += new System.EventHandler(this.cb_inactivos_CheckedChanged);
            // 
            // bt_paquetes
            // 
            this.bt_paquetes.Image = global::Principal_Internet_elvis.Properties.Resources.contratos;
            this.bt_paquetes.Location = new System.Drawing.Point(6, 18);
            this.bt_paquetes.Name = "bt_paquetes";
            this.bt_paquetes.Size = new System.Drawing.Size(71, 59);
            this.bt_paquetes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_paquetes.TabIndex = 18;
            this.bt_paquetes.TabStop = false;
            this.bt_paquetes.Click += new System.EventHandler(this.bt_paquetes_Click);
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Image = global::Principal_Internet_elvis.Properties.Resources.rounded_add_button_icon_icons_com_72592;
            this.bt_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_nuevo.Location = new System.Drawing.Point(99, 14);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(120, 60);
            this.bt_nuevo.TabIndex = 16;
            this.bt_nuevo.Text = "CREAR";
            this.bt_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_nuevo.UseVisualStyleBackColor = true;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscar.Location = new System.Drawing.Point(351, 14);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(120, 60);
            this.bt_buscar.TabIndex = 15;
            this.bt_buscar.Text = "BUSCAR";
            this.bt_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Image = global::Principal_Internet_elvis.Properties.Resources._9;
            this.bt_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_eliminar.Location = new System.Drawing.Point(477, 14);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(120, 60);
            this.bt_eliminar.TabIndex = 14;
            this.bt_eliminar.Text = "ESTADO";
            this.bt_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Image = global::Principal_Internet_elvis.Properties.Resources.savetheapplication_guardar_2958_1_;
            this.bt_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_aceptar.Location = new System.Drawing.Point(225, 14);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(120, 60);
            this.bt_aceptar.TabIndex = 12;
            this.bt_aceptar.Text = "GUARDR";
            this.bt_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Image = global::Principal_Internet_elvis.Properties.Resources._8;
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(603, 14);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(120, 60);
            this.bt_salir.TabIndex = 11;
            this.bt_salir.Text = "SALIR";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // tm_inicio
            // 
            this.tm_inicio.Interval = 500;
            this.tm_inicio.Tick += new System.EventHandler(this.tm_inicio_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.bt_paquetes);
            this.groupBox4.Location = new System.Drawing.Point(255, 575);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(83, 83);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PAQUETES";
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.bt_eliminar);
            this.groupBox11.Controls.Add(this.bt_aceptar);
            this.groupBox11.Controls.Add(this.cb_inactivos);
            this.groupBox11.Controls.Add(this.bt_buscar);
            this.groupBox11.Controls.Add(this.bt_salir);
            this.groupBox11.Controls.Add(this.bt_nuevo);
            this.groupBox11.Location = new System.Drawing.Point(338, 579);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(730, 79);
            this.groupBox11.TabIndex = 20;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "ACCIONES";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1080, 666);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_paquetes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_rtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.RadioButton rb_femenino;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txt_lugar;
        private System.Windows.Forms.Button bt_lugar;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.CheckBox cb_inactivos;
        private System.Windows.Forms.PictureBox bt_paquetes;
        private System.Windows.Forms.Timer tm_inicio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox11;
    }
}