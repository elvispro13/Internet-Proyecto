namespace Principal_Internet_elvis.Paquetes
{
    partial class PaquetesTipo
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
            this.bt_paquete = new System.Windows.Forms.Button();
            this.bt_servicio = new System.Windows.Forms.Button();
            this.bt_tipopaquete = new System.Windows.Forms.Button();
            this.bt_promocion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_promocion);
            this.groupBox1.Controls.Add(this.bt_tipopaquete);
            this.groupBox1.Controls.Add(this.bt_servicio);
            this.groupBox1.Controls.Add(this.bt_paquete);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO";
            // 
            // bt_paquete
            // 
            this.bt_paquete.Location = new System.Drawing.Point(6, 19);
            this.bt_paquete.Name = "bt_paquete";
            this.bt_paquete.Size = new System.Drawing.Size(125, 63);
            this.bt_paquete.TabIndex = 0;
            this.bt_paquete.Text = "PAQUETE";
            this.bt_paquete.UseVisualStyleBackColor = true;
            this.bt_paquete.Click += new System.EventHandler(this.bt_paquete_Click);
            // 
            // bt_servicio
            // 
            this.bt_servicio.Location = new System.Drawing.Point(137, 19);
            this.bt_servicio.Name = "bt_servicio";
            this.bt_servicio.Size = new System.Drawing.Size(125, 63);
            this.bt_servicio.TabIndex = 1;
            this.bt_servicio.Text = "SERVICIO";
            this.bt_servicio.UseVisualStyleBackColor = true;
            this.bt_servicio.Click += new System.EventHandler(this.bt_servicio_Click);
            // 
            // bt_tipopaquete
            // 
            this.bt_tipopaquete.Location = new System.Drawing.Point(268, 19);
            this.bt_tipopaquete.Name = "bt_tipopaquete";
            this.bt_tipopaquete.Size = new System.Drawing.Size(125, 63);
            this.bt_tipopaquete.TabIndex = 2;
            this.bt_tipopaquete.Text = "TIPO SERVICIO";
            this.bt_tipopaquete.UseVisualStyleBackColor = true;
            this.bt_tipopaquete.Click += new System.EventHandler(this.bt_tipopaquete_Click);
            // 
            // bt_promocion
            // 
            this.bt_promocion.Location = new System.Drawing.Point(399, 19);
            this.bt_promocion.Name = "bt_promocion";
            this.bt_promocion.Size = new System.Drawing.Size(125, 63);
            this.bt_promocion.TabIndex = 3;
            this.bt_promocion.Text = "PROMOCION";
            this.bt_promocion.UseVisualStyleBackColor = true;
            this.bt_promocion.Click += new System.EventHandler(this.bt_promocion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 46);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(6, 19);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(186, 20);
            this.txt_buscar.TabIndex = 2;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(12, 164);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.Size = new System.Drawing.Size(530, 150);
            this.dgv_tabla.TabIndex = 4;
            // 
            // PaquetesTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaquetesTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaquetesTipo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_paquete;
        private System.Windows.Forms.Button bt_promocion;
        private System.Windows.Forms.Button bt_tipopaquete;
        private System.Windows.Forms.Button bt_servicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_tabla;
    }
}