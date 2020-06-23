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
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.bt_servicios = new System.Windows.Forms.Button();
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
            this.gb_codigo.Location = new System.Drawing.Point(12, 12);
            this.gb_codigo.Name = "gb_codigo";
            this.gb_codigo.Size = new System.Drawing.Size(184, 51);
            this.gb_codigo.TabIndex = 0;
            this.gb_codigo.TabStop = false;
            this.gb_codigo.Text = "CODIGO";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(6, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(172, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_descripcion);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 51);
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
            this.txt_descripcion.Size = new System.Drawing.Size(172, 20);
            this.txt_descripcion.TabIndex = 1;
            this.txt_descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_descripcion_KeyDown);
            // 
            // gb_c1
            // 
            this.gb_c1.Controls.Add(this.txt_c1);
            this.gb_c1.Location = new System.Drawing.Point(12, 126);
            this.gb_c1.Name = "gb_c1";
            this.gb_c1.Size = new System.Drawing.Size(184, 51);
            this.gb_c1.TabIndex = 2;
            this.gb_c1.TabStop = false;
            this.gb_c1.Text = "CAMPO1";
            // 
            // txt_c1
            // 
            this.txt_c1.Location = new System.Drawing.Point(6, 19);
            this.txt_c1.MaxLength = 20;
            this.txt_c1.Name = "txt_c1";
            this.txt_c1.Size = new System.Drawing.Size(172, 20);
            this.txt_c1.TabIndex = 1;
            this.txt_c1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_c1_KeyPress);
            // 
            // gb_c2
            // 
            this.gb_c2.Controls.Add(this.txt_c2);
            this.gb_c2.Location = new System.Drawing.Point(12, 183);
            this.gb_c2.Name = "gb_c2";
            this.gb_c2.Size = new System.Drawing.Size(184, 51);
            this.gb_c2.TabIndex = 3;
            this.gb_c2.TabStop = false;
            this.gb_c2.Text = "CAMPO2";
            // 
            // txt_c2
            // 
            this.txt_c2.Location = new System.Drawing.Point(6, 19);
            this.txt_c2.MaxLength = 20;
            this.txt_c2.Name = "txt_c2";
            this.txt_c2.Size = new System.Drawing.Size(172, 20);
            this.txt_c2.TabIndex = 1;
            this.txt_c2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_c2_KeyPress);
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(382, 188);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(111, 39);
            this.bt_aceptar.TabIndex = 4;
            this.bt_aceptar.Text = "ACEPTAR";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(499, 188);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(111, 39);
            this.bt_salir.TabIndex = 5;
            this.bt_salir.Text = "SALIR";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(202, 12);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(408, 165);
            this.dgv_tabla.TabIndex = 6;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellContentClick);
            // 
            // bt_servicios
            // 
            this.bt_servicios.Location = new System.Drawing.Point(265, 188);
            this.bt_servicios.Name = "bt_servicios";
            this.bt_servicios.Size = new System.Drawing.Size(111, 39);
            this.bt_servicios.TabIndex = 7;
            this.bt_servicios.Text = "SERVICIOS";
            this.bt_servicios.UseVisualStyleBackColor = true;
            this.bt_servicios.Click += new System.EventHandler(this.bt_servicios_Click);
            // 
            // PaquetesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 239);
            this.Controls.Add(this.bt_servicios);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.gb_c2);
            this.Controls.Add(this.gb_c1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_codigo);
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
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button bt_servicios;
    }
}