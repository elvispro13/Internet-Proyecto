namespace Principal_Internet_elvis.Ubicacion
{
    partial class UbicacionElegir
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(219, 12);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(577, 263);
            this.dgv_tabla.TabIndex = 10;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(219, 281);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(104, 47);
            this.bt_aceptar.TabIndex = 1;
            this.bt_aceptar.Text = "ACEPTAR";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(329, 281);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(104, 47);
            this.bt_cancelar.TabIndex = 2;
            this.bt_cancelar.Text = "CANCELAR";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Location = new System.Drawing.Point(439, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 47);
            this.groupBox1.TabIndex = 5;
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
            // UbicacionElegir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.dgv_tabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UbicacionElegir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UbicacionElegir";
            this.Load += new System.EventHandler(this.UbicacionElegir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}