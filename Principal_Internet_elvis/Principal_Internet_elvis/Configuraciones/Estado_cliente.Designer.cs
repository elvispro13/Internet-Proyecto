namespace Principal_Internet_elvis.Configuraciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.bt_estado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_estado);
            this.groupBox1.Controls.Add(this.bt_buscar);
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Controls.Add(this.dgv_tabla);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado del Cliente";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "PENDIENTE INSTALACION",
            "SERVICIO ACTIVO",
            "CORTE DE SERVICIO"});
            this.cb_estado.Location = new System.Drawing.Point(6, 28);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(208, 23);
            this.cb_estado.TabIndex = 5;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_buscar.Location = new System.Drawing.Point(527, 18);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(96, 44);
            this.bt_buscar.TabIndex = 4;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_buscar.Location = new System.Drawing.Point(220, 29);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(301, 21);
            this.txt_buscar.TabIndex = 3;
            this.txt_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyDown);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(6, 68);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(617, 260);
            this.dgv_tabla.TabIndex = 2;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Principal_Internet_elvis.Properties.Resources._8;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 66);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bt_estado
            // 
            this.bt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_estado.Image = global::Principal_Internet_elvis.Properties.Resources._9;
            this.bt_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_estado.Location = new System.Drawing.Point(515, 352);
            this.bt_estado.Name = "bt_estado";
            this.bt_estado.Size = new System.Drawing.Size(120, 66);
            this.bt_estado.TabIndex = 3;
            this.bt_estado.Text = "ESTADO";
            this.bt_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_estado.UseVisualStyleBackColor = true;
            this.bt_estado.Click += new System.EventHandler(this.bt_estado_Click);
            // 
            // Estado_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 430);
            this.ControlBox = false;
            this.Controls.Add(this.bt_estado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Estado_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Estado_cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}