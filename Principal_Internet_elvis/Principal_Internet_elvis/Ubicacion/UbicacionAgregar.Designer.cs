namespace Principal_Internet_elvis.Ubicacion
{
    partial class UbicacionAgregar
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
            this.gb_codigo2 = new System.Windows.Forms.GroupBox();
            this.bt_codigo2 = new System.Windows.Forms.Button();
            this.txt_codigo2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.gb_codigo.SuspendLayout();
            this.gb_codigo2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_codigo
            // 
            this.gb_codigo.Controls.Add(this.txt_codigo);
            this.gb_codigo.Location = new System.Drawing.Point(12, 12);
            this.gb_codigo.Name = "gb_codigo";
            this.gb_codigo.Size = new System.Drawing.Size(113, 52);
            this.gb_codigo.TabIndex = 0;
            this.gb_codigo.TabStop = false;
            this.gb_codigo.Text = "Codigo";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(6, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // gb_codigo2
            // 
            this.gb_codigo2.Controls.Add(this.bt_codigo2);
            this.gb_codigo2.Controls.Add(this.txt_codigo2);
            this.gb_codigo2.Location = new System.Drawing.Point(508, 12);
            this.gb_codigo2.Name = "gb_codigo2";
            this.gb_codigo2.Size = new System.Drawing.Size(172, 52);
            this.gb_codigo2.TabIndex = 1;
            this.gb_codigo2.TabStop = false;
            this.gb_codigo2.Text = "CodigoR";
            // 
            // bt_codigo2
            // 
            this.bt_codigo2.Location = new System.Drawing.Point(145, 17);
            this.bt_codigo2.Name = "bt_codigo2";
            this.bt_codigo2.Size = new System.Drawing.Size(27, 23);
            this.bt_codigo2.TabIndex = 2;
            this.bt_codigo2.Text = "...";
            this.bt_codigo2.UseVisualStyleBackColor = true;
            this.bt_codigo2.Click += new System.EventHandler(this.bt_codigo2_Click);
            // 
            // txt_codigo2
            // 
            this.txt_codigo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_codigo2.Location = new System.Drawing.Point(6, 19);
            this.txt_codigo2.Name = "txt_codigo2";
            this.txt_codigo2.Size = new System.Drawing.Size(133, 20);
            this.txt_codigo2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_nombre);
            this.groupBox3.Location = new System.Drawing.Point(131, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nombre/Buscar";
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(6, 19);
            this.txt_nombre.MaxLength = 255;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(357, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nombre_KeyDown);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(12, 70);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(668, 263);
            this.dgv_tabla.TabIndex = 3;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellClick);
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Image = global::Principal_Internet_elvis.Properties.Resources.rounded_add_button_icon_icons_com_72592;
            this.bt_nuevo.Location = new System.Drawing.Point(235, 340);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(79, 52);
            this.bt_nuevo.TabIndex = 21;
            this.bt_nuevo.UseVisualStyleBackColor = true;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.bt_buscar.Location = new System.Drawing.Point(431, 340);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(69, 51);
            this.bt_buscar.TabIndex = 20;
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Image = global::Principal_Internet_elvis.Properties.Resources._9;
            this.bt_eliminar.Location = new System.Drawing.Point(521, 339);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(72, 52);
            this.bt_eliminar.TabIndex = 19;
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Image = global::Principal_Internet_elvis.Properties.Resources.savetheapplication_guardar_2958_1_;
            this.bt_guardar.Location = new System.Drawing.Point(333, 340);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(76, 52);
            this.bt_guardar.TabIndex = 18;
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Image = global::Principal_Internet_elvis.Properties.Resources.emblemunreadable_93487;
            this.bt_salir.Location = new System.Drawing.Point(612, 339);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(68, 52);
            this.bt_salir.TabIndex = 17;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click_1);
            // 
            // UbicacionAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 400);
            this.Controls.Add(this.bt_nuevo);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_codigo2);
            this.Controls.Add(this.gb_codigo);
            this.Name = "UbicacionAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UbicacionAgregar";
            this.Load += new System.EventHandler(this.UbicacionAgregar_Load);
            this.gb_codigo.ResumeLayout(false);
            this.gb_codigo.PerformLayout();
            this.gb_codigo2.ResumeLayout(false);
            this.gb_codigo2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.GroupBox gb_codigo2;
        private System.Windows.Forms.TextBox txt_codigo2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button bt_codigo2;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_salir;
    }
}