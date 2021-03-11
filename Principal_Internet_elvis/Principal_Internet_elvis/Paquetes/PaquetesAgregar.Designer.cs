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
            this.gb_codigo = new System.Windows.Forms.GroupBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.gb_c1 = new System.Windows.Forms.GroupBox();
            this.txt_c1 = new System.Windows.Forms.TextBox();
            this.gb_c2 = new System.Windows.Forms.GroupBox();
            this.txt_c2 = new System.Windows.Forms.TextBox();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.bt_servicios = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.cb_inactivos = new System.Windows.Forms.CheckBox();
            this.gb_codigo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_c1.SuspendLayout();
            this.gb_c2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_codigo
            // 
            this.gb_codigo.Controls.Add(this.txt_codigo);
            this.gb_codigo.Location = new System.Drawing.Point(60, 36);
            this.gb_codigo.Name = "gb_codigo";
            this.gb_codigo.Size = new System.Drawing.Size(363, 51);
            this.gb_codigo.TabIndex = 0;
            this.gb_codigo.TabStop = false;
            this.gb_codigo.Text = "CODIGO";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(6, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(351, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_descripcion);
            this.groupBox2.Location = new System.Drawing.Point(60, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 51);
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
            this.txt_descripcion.Size = new System.Drawing.Size(351, 20);
            this.txt_descripcion.TabIndex = 1;
            this.txt_descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_descripcion_KeyDown);
            // 
            // gb_c1
            // 
            this.gb_c1.Controls.Add(this.txt_c1);
            this.gb_c1.Location = new System.Drawing.Point(60, 150);
            this.gb_c1.Name = "gb_c1";
            this.gb_c1.Size = new System.Drawing.Size(363, 51);
            this.gb_c1.TabIndex = 2;
            this.gb_c1.TabStop = false;
            this.gb_c1.Text = "CAMPO1";
            // 
            // txt_c1
            // 
            this.txt_c1.Location = new System.Drawing.Point(6, 19);
            this.txt_c1.MaxLength = 20;
            this.txt_c1.Name = "txt_c1";
            this.txt_c1.Size = new System.Drawing.Size(351, 20);
            this.txt_c1.TabIndex = 1;
            this.txt_c1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_c1_KeyPress);
            // 
            // gb_c2
            // 
            this.gb_c2.Controls.Add(this.txt_c2);
            this.gb_c2.Location = new System.Drawing.Point(60, 207);
            this.gb_c2.Name = "gb_c2";
            this.gb_c2.Size = new System.Drawing.Size(363, 51);
            this.gb_c2.TabIndex = 3;
            this.gb_c2.TabStop = false;
            this.gb_c2.Text = "CAMPO2";
            // 
            // txt_c2
            // 
            this.txt_c2.Location = new System.Drawing.Point(6, 19);
            this.txt_c2.MaxLength = 20;
            this.txt_c2.Name = "txt_c2";
            this.txt_c2.Size = new System.Drawing.Size(351, 20);
            this.txt_c2.TabIndex = 1;
            this.txt_c2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_c2_KeyPress);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Image = global::Principal_Internet_elvis.Properties.Resources.savetheapplication_guardar_2958_1_;
            this.bt_guardar.Location = new System.Drawing.Point(164, 353);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(98, 63);
            this.bt_guardar.TabIndex = 4;
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Image = global::Principal_Internet_elvis.Properties.Resources.emblemunreadable_93487;
            this.bt_salir.Location = new System.Drawing.Point(476, 353);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(98, 63);
            this.bt_salir.TabIndex = 5;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(429, 36);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(577, 293);
            this.dgv_tabla.TabIndex = 6;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            // 
            // bt_servicios
            // 
            this.bt_servicios.Location = new System.Drawing.Point(60, 264);
            this.bt_servicios.Name = "bt_servicios";
            this.bt_servicios.Size = new System.Drawing.Size(363, 65);
            this.bt_servicios.TabIndex = 7;
            this.bt_servicios.Text = "SERVICIOS";
            this.bt_servicios.UseVisualStyleBackColor = true;
            this.bt_servicios.Click += new System.EventHandler(this.bt_servicios_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Image = global::Principal_Internet_elvis.Properties.Resources._9;
            this.bt_eliminar.Location = new System.Drawing.Point(372, 353);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(98, 63);
            this.bt_eliminar.TabIndex = 8;
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.bt_buscar.Location = new System.Drawing.Point(268, 353);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(98, 63);
            this.bt_buscar.TabIndex = 9;
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Image = global::Principal_Internet_elvis.Properties.Resources.rounded_add_button_icon_icons_com_72592;
            this.bt_nuevo.Location = new System.Drawing.Point(60, 353);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(98, 63);
            this.bt_nuevo.TabIndex = 10;
            this.bt_nuevo.UseVisualStyleBackColor = true;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // cb_inactivos
            // 
            this.cb_inactivos.AutoSize = true;
            this.cb_inactivos.Location = new System.Drawing.Point(591, 377);
            this.cb_inactivos.Name = "cb_inactivos";
            this.cb_inactivos.Size = new System.Drawing.Size(87, 17);
            this.cb_inactivos.TabIndex = 18;
            this.cb_inactivos.Text = "Ver inactivos";
            this.cb_inactivos.UseVisualStyleBackColor = true;
            this.cb_inactivos.CheckedChanged += new System.EventHandler(this.cb_inactivos_CheckedChanged);
            // 
            // PaquetesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.cb_inactivos);
            this.Controls.Add(this.bt_nuevo);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_servicios);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_guardar);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button bt_servicios;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.CheckBox cb_inactivos;
    }
}