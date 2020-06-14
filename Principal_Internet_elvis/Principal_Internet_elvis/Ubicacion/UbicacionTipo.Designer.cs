namespace Principal_Internet_elvis.Ubicacion
{
    partial class UbicacionTipo
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
            this.bt_lugar = new System.Windows.Forms.Button();
            this.bt_barrio = new System.Windows.Forms.Button();
            this.bt_sector = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_sector);
            this.groupBox1.Controls.Add(this.bt_barrio);
            this.groupBox1.Controls.Add(this.bt_lugar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // bt_lugar
            // 
            this.bt_lugar.Location = new System.Drawing.Point(6, 19);
            this.bt_lugar.Name = "bt_lugar";
            this.bt_lugar.Size = new System.Drawing.Size(139, 51);
            this.bt_lugar.TabIndex = 1;
            this.bt_lugar.Text = "LUGAR";
            this.bt_lugar.UseVisualStyleBackColor = true;
            // 
            // bt_barrio
            // 
            this.bt_barrio.Location = new System.Drawing.Point(6, 76);
            this.bt_barrio.Name = "bt_barrio";
            this.bt_barrio.Size = new System.Drawing.Size(139, 51);
            this.bt_barrio.TabIndex = 2;
            this.bt_barrio.Text = "BARRIO";
            this.bt_barrio.UseVisualStyleBackColor = true;
            // 
            // bt_sector
            // 
            this.bt_sector.Location = new System.Drawing.Point(6, 133);
            this.bt_sector.Name = "bt_sector";
            this.bt_sector.Size = new System.Drawing.Size(139, 51);
            this.bt_sector.TabIndex = 3;
            this.bt_sector.Text = "SECTOR";
            this.bt_sector.UseVisualStyleBackColor = true;
            // 
            // UbicacionTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 215);
            this.Controls.Add(this.groupBox1);
            this.Name = "UbicacionTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubicacion Tipo";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_lugar;
        private System.Windows.Forms.Button bt_sector;
        private System.Windows.Forms.Button bt_barrio;
    }
}