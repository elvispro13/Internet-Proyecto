namespace Principal_Internet_elvis.Reportes
{
    partial class ReportesTipo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_mora_hasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_mora_desde = new System.Windows.Forms.DateTimePicker();
            this.bt_mora_buscar = new System.Windows.Forms.Button();
            this.cb_rango = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_rango);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bt_mora_buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTE DE MORA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_mora_hasta);
            this.groupBox3.Location = new System.Drawing.Point(229, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HASTA";
            // 
            // dtp_mora_hasta
            // 
            this.dtp_mora_hasta.Location = new System.Drawing.Point(6, 19);
            this.dtp_mora_hasta.Name = "dtp_mora_hasta";
            this.dtp_mora_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_mora_hasta.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_mora_desde);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DESDE";
            // 
            // dtp_mora_desde
            // 
            this.dtp_mora_desde.Location = new System.Drawing.Point(6, 19);
            this.dtp_mora_desde.Name = "dtp_mora_desde";
            this.dtp_mora_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_mora_desde.TabIndex = 0;
            // 
            // bt_mora_buscar
            // 
            this.bt_mora_buscar.Image = global::Principal_Internet_elvis.Properties.Resources.Print_icon_icons_com_55835;
            this.bt_mora_buscar.Location = new System.Drawing.Point(12, 79);
            this.bt_mora_buscar.Name = "bt_mora_buscar";
            this.bt_mora_buscar.Size = new System.Drawing.Size(103, 42);
            this.bt_mora_buscar.TabIndex = 0;
            this.bt_mora_buscar.UseVisualStyleBackColor = true;
            this.bt_mora_buscar.Click += new System.EventHandler(this.bt_mora_buscar_Click);
            // 
            // cb_rango
            // 
            this.cb_rango.AutoSize = true;
            this.cb_rango.Location = new System.Drawing.Point(132, 93);
            this.cb_rango.Name = "cb_rango";
            this.cb_rango.Size = new System.Drawing.Size(128, 17);
            this.cb_rango.TabIndex = 3;
            this.cb_rango.Text = "RANGO DE FECHAS";
            this.cb_rango.UseVisualStyleBackColor = true;
            // 
            // ReportesTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 463);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportesTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesTipo";
            this.Load += new System.EventHandler(this.ReportesTipo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_mora_buscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_mora_hasta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_mora_desde;
        private System.Windows.Forms.CheckBox cb_rango;
    }
}