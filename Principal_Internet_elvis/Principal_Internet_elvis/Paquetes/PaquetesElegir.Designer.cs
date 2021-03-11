namespace Principal_Internet_elvis.Paquetes
{
    partial class PaquetesElegir
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
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.gb_ip = new System.Windows.Forms.GroupBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.gb_instalacion = new System.Windows.Forms.GroupBox();
            this.txt_intalacion = new System.Windows.Forms.TextBox();
            this.bt_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_ip.SuspendLayout();
            this.gb_instalacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(166, 12);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(710, 358);
            this.dgv_tabla.TabIndex = 0;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellClick);
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Image = global::Principal_Internet_elvis.Properties.Resources.savetheapplication_guardar_2958;
            this.bt_aceptar.Location = new System.Drawing.Point(694, 459);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(74, 60);
            this.bt_aceptar.TabIndex = 1;
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Image = global::Principal_Internet_elvis.Properties.Resources.emblemunreadable_93487;
            this.bt_cancelar.Location = new System.Drawing.Point(774, 459);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(69, 60);
            this.bt_cancelar.TabIndex = 2;
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Location = new System.Drawing.Point(166, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR";
            // 
            // txt_buscar
            // 
            this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_buscar.Location = new System.Drawing.Point(6, 19);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(345, 20);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyDown);
            // 
            // gb_ip
            // 
            this.gb_ip.Controls.Add(this.txt_ip);
            this.gb_ip.Location = new System.Drawing.Point(166, 429);
            this.gb_ip.Name = "gb_ip";
            this.gb_ip.Size = new System.Drawing.Size(239, 42);
            this.gb_ip.TabIndex = 7;
            this.gb_ip.TabStop = false;
            this.gb_ip.Text = "IP";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(6, 19);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(227, 20);
            this.txt_ip.TabIndex = 8;
            // 
            // gb_instalacion
            // 
            this.gb_instalacion.Controls.Add(this.txt_intalacion);
            this.gb_instalacion.Location = new System.Drawing.Point(166, 477);
            this.gb_instalacion.Name = "gb_instalacion";
            this.gb_instalacion.Size = new System.Drawing.Size(239, 42);
            this.gb_instalacion.TabIndex = 9;
            this.gb_instalacion.TabStop = false;
            this.gb_instalacion.Text = "INTALACION";
            // 
            // txt_intalacion
            // 
            this.txt_intalacion.Location = new System.Drawing.Point(6, 19);
            this.txt_intalacion.Name = "txt_intalacion";
            this.txt_intalacion.Size = new System.Drawing.Size(227, 20);
            this.txt_intalacion.TabIndex = 8;
            this.txt_intalacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_intalacion_KeyDown);
            this.txt_intalacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_intalacion_KeyPress);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.bt_actualizar.Location = new System.Drawing.Point(611, 459);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(77, 60);
            this.bt_actualizar.TabIndex = 10;
            this.bt_actualizar.UseVisualStyleBackColor = true;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // PaquetesElegir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.gb_instalacion);
            this.Controls.Add(this.gb_ip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.dgv_tabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaquetesElegir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaquetesElegir";
            this.Load += new System.EventHandler(this.PaquetesElegir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_ip.ResumeLayout(false);
            this.gb_ip.PerformLayout();
            this.gb_instalacion.ResumeLayout(false);
            this.gb_instalacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.GroupBox gb_ip;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.GroupBox gb_instalacion;
        private System.Windows.Forms.TextBox txt_intalacion;
        private System.Windows.Forms.Button bt_actualizar;
    }
}