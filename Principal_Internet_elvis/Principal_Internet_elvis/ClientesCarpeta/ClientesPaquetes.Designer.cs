﻿namespace Principal_Internet_elvis.ClientesCarpeta
{
    partial class ClientesPaquetes
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
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_quitar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(12, 12);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(695, 203);
            this.dgv_tabla.TabIndex = 0;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellClick);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Image = global::Principal_Internet_elvis.Properties.Resources.rounded_add_button_icon_icons_com_72592;
            this.bt_agregar.Location = new System.Drawing.Point(12, 221);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(114, 62);
            this.bt_agregar.TabIndex = 1;
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // bt_quitar
            // 
            this.bt_quitar.Image = global::Principal_Internet_elvis.Properties.Resources.emblemunreadable_93487;
            this.bt_quitar.Location = new System.Drawing.Point(132, 221);
            this.bt_quitar.Name = "bt_quitar";
            this.bt_quitar.Size = new System.Drawing.Size(114, 62);
            this.bt_quitar.TabIndex = 2;
            this.bt_quitar.UseVisualStyleBackColor = true;
            this.bt_quitar.Click += new System.EventHandler(this.bt_quitar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Image = global::Principal_Internet_elvis.Properties.Resources._8;
            this.bt_salir.Location = new System.Drawing.Point(593, 221);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(114, 62);
            this.bt_salir.TabIndex = 3;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // ClientesPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 297);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_quitar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dgv_tabla);
            this.Name = "ClientesPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesPaquetes";
            this.Load += new System.EventHandler(this.ClientesPaquetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_quitar;
        private System.Windows.Forms.Button bt_salir;
    }
}